using System.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// A mod that will convert other naming conventions to the PascalCase nomenclature typically used in C#.
/// </summary>
/// <param name="logger">The logger.</param>
/// <param name="config">Configuration snapshot.</param>
/// <param name="trimmerProviders">Name trimmer providers.</param>
[ModConfiguration<Configuration>]
public class PrettifyNames(
    ILogger<PrettifyNames> logger,
    IOptionsSnapshot<PrettifyNames.Configuration> config,
    IEnumerable<IJobDependency<INameTrimmer>> trimmerProviders
) : IMod, IResponseFileMod
{
    /// <summary>
    /// The configuration for the prettify names mod.
    /// </summary>
    public record Configuration // DON'T USE CONSTRUCTOR-STYLE RECORDS! Needs a default ctor.
    {
        /// <summary>
        /// Corrections to the automatic prefix determination.
        /// </summary>
        public Dictionary<string, string>? PrefixOverrides { get; init; }

        /// <summary>
        /// Manually renamed native names.
        /// </summary>
        public Dictionary<string, string>? NameOverrides { get; init; }

        /// <summary>
        /// The base trimmer version. If null, trimming is disabled.
        /// </summary>
        public Version? TrimmerBaseline { get; init; } = new(3, 0);

        /// <summary>
        /// The maximum length of an all capitals string to be treated as a single acronym, rather than as an all
        /// capitals word.
        /// </summary>
        public int? LongAcronymThreshold { get; init; }

        /// <summary>
        /// Multiple candidate name prefixes that may apply across all of the bindings generated.
        /// </summary>
        public IReadOnlyList<string>? GlobalPrefixHints { get; init; }
    }

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        // First pass to scan the sources and create a dictionary of type/member names.
        var cfg = config.Get(ctx.JobKey);

        // Sort the hints from large to small (longest prefix match)
        var hints = cfg.GlobalPrefixHints?.ToList();
        hints?.Sort((x, y) => -x.Length.CompareTo(y.Length));
        cfg = cfg with { GlobalPrefixHints = hints };

        var visitor = new Visitor();
        if (ctx.SourceProject is null)
        {
            return;
        }

        foreach (var doc in ctx.SourceProject.Documents)
        {
            visitor.Visit(await doc.GetSyntaxRootAsync(ct));
        }

        // The dictionary containing mappings from the original type names to the new names of the type and its members
        var newNames = new Dictionary<string, RenamedType>();

        var nameTransformer = new NameUtils.NameTransformer(cfg.LongAcronymThreshold ?? 3);

        // If we have a trimmer baseline set, that means the user wants to trim the names as well as prettify them.
        if (cfg.TrimmerBaseline is not null)
        {
            // Get all the trimmers that are above this baseline. We also sort by the version. Why? Because someone
            // couldn't be bothered to introduce a weight property. It is also unclear what effect this has on 2.17/2.18
            // but to be honest those trimmers aren't used and are only included for posterity and understanding of the
            // old logic.
            var trimmers = trimmerProviders
                .SelectMany(x => x.Get(ctx.JobKey))
                .OrderBy(x => x.Version)
                .ToArray();

            // Create a type name dictionary to trim the type names.
            var typeNames = visitor.Types.ToDictionary(
                x => x.Key,
                x => new CandidateNames(x.Key, null)
            );

            // If we don't have a prefix hint and don't have more than one type, we can't determine a prefix so don't
            // trim.
            if (typeNames.Count > 1 || cfg.GlobalPrefixHints is not null)
            {
                Trim(
                    new NameTrimmerContext
                    {
                        Container = null,
                        Names = typeNames,
                        Configuration = cfg,
                        JobKey = ctx.JobKey,
                        NonDeterminant = visitor.NonDeterminant,
                    },
                    trimmers
                );
            }

            // Now rename everything within each type.
            foreach (var (typeName, (newTypeName, _)) in typeNames)
            {
                var (_, (consts, functions, isEnum)) = visitor.Types.First(x => x.Key == typeName);

                // Rename the "constants" i.e. all the consts/static readonlys in this type. These are treated
                // individually because everything that isn't a constant or a function is only prettified instead of prettified & trimmed.
                var constNames = consts?.ToDictionary(
                    x => x,
                    x => new CandidateNames(x, null)
                );

                // Trim the constants if we have any.
                if (constNames is not null)
                {
                    Trim(
                        new NameTrimmerContext
                        {
                            Container = typeName,
                            Names = constNames,
                            Configuration = cfg,
                            JobKey = ctx.JobKey,
                            NonDeterminant = visitor.NonDeterminant,
                        },
                        trimmers
                    );
                }
                else
                {
                    constNames = [];
                }

                // Rename the functions. More often that not functions have different nomenclature to constants, so we
                // treat them separately.
                var functionNames = functions
                    ?.DistinctBy(x => x.Name)
                    .ToDictionary(x => x.Name, x => new CandidateNames(x.Name, null));

                // Collect the syntax as this is used for conflict resolution in the Trim function.
                var functionSyntax =
                    functions is null || functionNames is null
                        ? null
                        : functionNames.Keys.ToDictionary(
                            x => x,
                            x => functions.Where(y => y.Name == x).Select(y => y.Syntax)
                        );

                // Now trim if we have any functions.
                if (functionNames is not null)
                {
                    Trim(
                        new NameTrimmerContext
                        {
                            Container = typeName,
                            Names = functionNames,
                            Configuration = cfg,
                            JobKey = ctx.JobKey,
                            NonDeterminant = visitor.NonDeterminant,
                        },
                        trimmers,
                        functionSyntax
                    );
                }

                // Add back anything else that isn't a trimming candidate (but should still have a pretty name)
                var prettifiedOnly = visitor.PrettifyOnlyTypes.TryGetValue(typeName, out var val)
                    ? val.Select(x => new KeyValuePair<string, CandidateNames>(
                        x,
                        new CandidateNames(GetOverriddenName(typeName, x, cfg.NameOverrides!, nameTransformer), null)
                    ))
                    : [];

                // Add it to the rewriter's list of names to... rewrite...
                newNames[typeName] = new RenamedType(
                    newTypeName.Prettify(nameTransformer, allowAllCaps: true), // <-- lenient about caps for type names
                    // TODO deprecate secondaries if they're within the baseline?
                    constNames.Select(x => new KeyValuePair<string, CandidateNames>(x.Key, new CandidateNames(x.Value.Primary.Prettify(nameTransformer), x.Value.Secondary)))
                        .Concat(prettifiedOnly.DistinctBy(kvp => kvp.Key).ToDictionary())
                        .ToDictionary(x => x.Key, x => x.Value.Primary),
                    functionNames?.ToDictionary(
                        x => x.Key,
                        x => x.Value.Primary.Prettify(nameTransformer)
                    ),
                    isEnum
                );
            }
        }
        else // (there's no trimming baseline)
        {
            // Prettify only if the user has not indicated they want to trim.
            foreach (var (name, (nonFunctions, functions, isEnum)) in visitor.Types)
            {
                newNames[name] = new RenamedType(
                    GetOverriddenName(null, name, cfg.NameOverrides!, nameTransformer, true), // <-- lenient about caps for type names (e.g. GL)
                    nonFunctions?.ToDictionary(x => x, x => GetOverriddenName(name, x, cfg.NameOverrides!, nameTransformer)),
                    functions?.ToDictionary(x => x.Name, x => GetOverriddenName(name, x.Name, cfg.NameOverrides!, nameTransformer)),
                    isEnum
                );
            }
        }

        if (logger.IsEnabled(LogLevel.Debug))
        {
            foreach (var (name, (newName, nonFunctions, functions, _)) in newNames)
            {
                logger.LogDebug("{} = {}", name, newName);
                foreach (var (old, @new) in nonFunctions ?? new())
                {
                    logger.LogDebug("{}.{} = {}.{}", name, old, newName, @new);
                }

                foreach (var (old, @new) in functions ?? new())
                {
                    logger.LogDebug("{}.{} = {}.{}", name, old, newName, @new);
                }
            }
        }

        // Before we rename, we should ensure name dependent things are correct
        // e.g. DllImport explicitly specify their EntryPoint
        logger.LogDebug("Fixing up attributes for {} to make them safe for rename...", ctx.JobKey);
        var rewriter = new RenameSafeAttributeListsRewriter();
        var proj = ctx.SourceProject;
        foreach (var docId in proj.DocumentIds)
        {
            var doc = proj.GetDocument(docId);
            if (doc is null)
            {
                continue;
            }

            var root = rewriter.Visit(await doc.GetSyntaxRootAsync(ct));
            if (root is not null)
            {
                proj = doc.WithSyntaxRoot(root).Project;
            }
        }

        // Find symbols and rename their references
        var sw = Stopwatch.StartNew();
        logger.LogDebug("Discovering references to symbols to rename for {}...", ctx.JobKey);
        ctx.SourceProject = proj;

        var comp =
            await proj.GetCompilationAsync(ct)
            ?? throw new InvalidOperationException("Failed to obtain compilation for source project!");

        await NameUtils.RenameAllAsync(
            ctx,
            newNames.SelectMany(x =>
            {
                var nonFunctionConflicts = x
                    .Value.NonFunctions?.Values.Where(y =>
                        x.Value.Functions?.ContainsValue(y) ?? false
                    )
                    .ToHashSet();
                return comp.GetSymbolsWithName(x.Key, SymbolFilter.Type, ct)
                    .OfType<ITypeSymbol>()
                    .SelectMany<ITypeSymbol, (ISymbol, string)>(y =>
                        [
                            .. Enumerable.SelectMany(
                                [
                                    .. x.Value.NonFunctions?.Select(z =>
                                        nonFunctionConflicts?.Contains(z.Value) ?? false
                                            ? new KeyValuePair<string, string>(
                                                z.Key,
                                                $"{z.Value}Value"
                                            )
                                            : z
                                    ) ?? [],
                                    .. x.Value.Functions ?? [],
                                ],
                                z =>
                                {
                                    return y.GetMembers(z.Key).Select(w => (w, z.Value));
                                }
                            ),
                            .. y.GetMembers()
                                .OfType<IMethodSymbol>()
                                .Where(z =>
                                    z.MethodKind is MethodKind.Constructor or MethodKind.Destructor
                                )
                                .Select(z => (z, x.Value.NewName)),
                            (y, x.Value.NewName),
                        ]
                    );
            }),
            logger,
            ct
        );

        logger.LogDebug(
            "Reference renaming took {} seconds for {}.",
            sw.Elapsed.TotalSeconds,
            ctx.JobKey
        );

        // Change the filenames where appropriate.
        proj = ctx.SourceProject;
        foreach (var docId in proj.DocumentIds)
        {
            var doc = proj.GetDocument(docId);
            if (
                doc is not { FilePath: not null, Name: not null }
                || newNames
                    .OrderByDescending(x => x.Key.Length)
                    .FirstOrDefault(x => doc.FilePath.Contains(x.Key) || doc.Name.Contains(x.Key))
                    is not { Key: { } oldName, Value.NewName: { } newName }
            )
            {
                continue;
            }

            var originalName = doc.Name;
            doc = doc.ReplaceNameAndPath(oldName, newName);

            var found = false;
            if (doc.FilePath is not null)
            {
                foreach (var checkDocId in proj.DocumentIds)
                {
                    if (checkDocId == docId)
                        continue;

                    var checkDoc = proj.GetDocument(checkDocId);

                    if (checkDoc is null ||
                        checkDoc.FilePath is null)
                        continue;

                    if (checkDoc.FilePath == doc.FilePath)
                    {
                        found = true;
                        break;
                    }
                }
            }

            if (found)
            {
                logger.LogError($"{originalName} -> {doc.Name} failed to rename file as a file already exists at {doc.FilePath}");
            }
            else
            {
                proj = doc.Project;
            }
        }

        ctx.SourceProject = proj;
    }

    private string GetOverriddenName(
        string? container,
        string name,
        Dictionary<string, string>? nameOverrides,
        NameUtils.NameTransformer nameTransformer,
        bool allowAllCaps = false)
    {
        foreach (var (nativeName, overriddenName) in nameOverrides ?? [])
        {
            var nameToAdd = nativeName;
            if (nativeName.Contains('.'))
            {
                // We're processing a type dictionary, so don't add a member thing.
                if (container is null)
                {
                    continue;
                }

                // Check whether the override is for this type.
                var span = nativeName.AsSpan();
                var containerSpan = span[..span.IndexOf('.')];
                if (!containerSpan.Equals("*", StringComparison.Ordinal) && !containerSpan.Equals(container, StringComparison.Ordinal))
                {
                    continue;
                }

                nameToAdd = span[(span.IndexOf('.') + 1)..].ToString();
                if (nameToAdd == name)
                {
                    return overriddenName;
                }
            }
            else if (nativeName == name)
            {
                return overriddenName;
            }
        }
        return name.Prettify(nameTransformer, allowAllCaps);
    }

    private void Trim(
        NameTrimmerContext context,
        IEnumerable<INameTrimmer> trimmers,
        Dictionary<string, IEnumerable<MethodDeclarationSyntax>>? functionSyntax = null
    )
    {
        // Ensure the trimmers don't see names that have been manually overridden, as we don't want them to influence
        // automatic prefix determination for example
        var namesToTrim = context.Names!;
        foreach (var (nativeName, overriddenName) in context.Configuration.NameOverrides ?? [])
        {
            var nameToAdd = nativeName;
            if (nativeName.Contains('.'))
            {
                // We're processing a type dictionary, so don't add a member thing.
                if (context.Container is null)
                {
                    continue;
                }

                // Check whether the override is for this type.
                var span = nativeName.AsSpan();
                var containerSpan = span[..span.IndexOf('.')];
                if (containerSpan.Equals("*", StringComparison.Ordinal) || containerSpan.Equals(context.Container, StringComparison.Ordinal))
                {
                    nameToAdd = span[(span.IndexOf('.') + 1)..].ToString();
                }
                else
                {
                    continue;
                }
            }

            if (!namesToTrim.TryGetValue(nameToAdd, out var v))
            {
                continue;
            }

            // If we haven't created the differentiated dictionary yet, then do so now. We do want to keep the original
            // dictionary so we can actually apply the renames; if we have created two different branching dictionaries
            // they are recombined following trimming.
            if (namesToTrim == context.Names)
            {
                namesToTrim = namesToTrim.ToDictionary();
            }

            // Don't let the trimmers see the overridden native name.
            namesToTrim.Remove(nameToAdd);

            // Apply the name override to the dictionary we actually use.
            context.Names![nameToAdd] = new CandidateNames(
                overriddenName,
                [.. v.Secondary ?? [], nameToAdd]
            );
        }

        // Run each trimmer
        foreach (var trimmer in trimmers)
        {
            trimmer.Trim(context with { Names = namesToTrim });
        }

        // Apply changes.
        if (namesToTrim != context.Names)
        {
            foreach (var (evalName, result) in namesToTrim)
            {
                context.Names![evalName] = result;
            }
        }

        // Prefer shorter names
        foreach (var (trimmingName, (primary, secondary)) in context.Names!)
        {
            context.Names![trimmingName] = new CandidateNames(
                primary,
                secondary?.OrderByDescending(x => x.Length).ToList()
            );
        }

        // Create a map from primaries to trimming names, to account for multiple overloads with the same primary and
        // same trimming name (i.e. it is a generated/transformed overload) but differing discriminators.
        var primaries = new Dictionary<string, HashSet<string>>();
        foreach (var (trimmingName, (primary, _)) in context.Names!)
        {
            var trimmingNamesForPrimary = primaries.TryGetValue(primary, out var tnfp)
                ? tnfp
                : primaries[primary] = [];
            trimmingNamesForPrimary.Add(trimmingName);
        }

        // Unwind some names back to their secondary names if the primaries would duplicate
        // We'll use a hash set to determine whether or not we need to check a primary for conflicts.
        var namesToEval = primaries.Keys.ToHashSet();

        // Keep track of the method discriminators to determine whether we have incompatible overloads that need to be
        // renamed. We keep track of the first trimming name so that we can add it to conflictingTrimmingNames when we
        // do discover a conflict (along with the trimming name of the actual conflict).
        var methDiscrims = new Dictionary<string, (string? FirstTrimmingName, List<MethodDeclarationSyntax> Methods)>();
        var conflictingTrimmingNames = new HashSet<string>();
        while (namesToEval.GetEnumerator() is var e && e.MoveNext() && e.Current is var primary)
        {
            // ^-- We can't use a foreach loop because we're mutating below. We're also using GetEnumerator instead of
            // First to avoid allocations.

            // First, let's check whether we have any conflicting discriminators. If we don't, we can mark this as all
            // good right away.
            methDiscrims.Clear();
            conflictingTrimmingNames.Clear();
            var trimmingNamesForOldPrimary = primaries[primary];

            // Function-specific logic where some conflicts are okay, so we have to evaluate each signature to see if
            // we can discriminate each one such that there are no conflicts.
            //
            // An example of where this is the case is e.g. alGetBufferf/alGetBufferfv - signatures are identical.
            var nMethConflicts = 0;
            var nMethods = 0;
            var nNoSecondaries = 0; // <-- at least all but one needs to have a secondary to resolve conflicts
            string? noSecondaryTrimmingName = null;
            foreach (var trimmingNameToEval in trimmingNamesForOldPrimary)
            {
                // Do we even have a secondary to fall back on if there is a conflict?
                if ((context.Names![trimmingNameToEval].Secondary?.Count ?? 0) == 0)
                {
                    noSecondaryTrimmingName ??= trimmingNameToEval;
                    nNoSecondaries++;
                }

                if (functionSyntax is not null)
                {
                    foreach (var meth in functionSyntax[trimmingNameToEval])
                    {
                        var discrim = ModUtils.DiscrimStr(
                            meth.Modifiers,
                            meth.TypeParameterList,
                            primary,
                            meth.ParameterList,
                            returnType: null
                        );
                        var (ogTrimmingName, discrimMatches) = methDiscrims.TryGetValue(
                            discrim,
                            out var dte
                        )
                            ? dte
                            : methDiscrims[discrim] = (trimmingNameToEval, []);
                        discrimMatches.Add(meth);
                        nMethods++;

                        // NOTE: The number of conflicts influences how we go about conflict resolution. See the
                        // logic below all of these loops just in case this comment is out of date, but at time of
                        // writing if 50% or more of the methods with this primary name are conflicting then we
                        // rename all of them, otherwise we rename only the conflicting overloads.
                        nMethConflicts += discrimMatches.Count switch
                        {
                            2 => 2, // The original needs to be counted as a conflict in addition to this conflict
                            > 2 => 1, // Just mark this conflict, original is already counted.
                            _ => 0, // No conflict to see here (not yet anyway, call it Schrodinger's Conflict)
                        };

                        if (discrimMatches.Count == 2 && ogTrimmingName is not null)
                        {
                            conflictingTrimmingNames.Add(ogTrimmingName);
                        }

                        if (discrimMatches.Count > 1)
                        {
                            conflictingTrimmingNames.Add(trimmingNameToEval);
                        }
                    }
                }
            }

            // If we're checking methods for conflicts and in our travels we've discovered that there are in fact
            // no conflicts, we can bail out early here.
            if (nMethods > 0 && (methDiscrims.Count == 0 || nMethConflicts == 0))
            {
                namesToEval.Remove(primary);
                continue;
            }

            // We need to determine if we even have alternative names. If one doesn't that's fine because as long
            // as we unwind all the others that one still won't conflict.
            if (nNoSecondaries > 1)
            {
                logger.LogError(
                    "Couldn't resolve conflict for \"{}\" because {} of the APIs with that primary name did not have any secondary names.",
                    primary,
                    nNoSecondaries
                );
                namesToEval.Remove(primary);
                continue;
            }

            var renameOnlyConflicts = nMethConflicts <= nMethods / 2.0;

            // We can afford to leave one API alone. If that place isn't already filled by a method without a secondary
            // name then we should fill it with whatever has the shortest trimming name. The logic being that the more
            // characters (i.e. longer suffix) a name has, the more discriminatory/important that name is ergo the
            // reverse (the shorter the name, the less discriminatory/important it is) is also true.
            string? first = null;
            var primaryClaimed = noSecondaryTrimmingName is not null;
            namesToEval.Remove(primary); // <-- just in case the below loop somehow produces the same primary again.
            foreach (
                var conflictingTrimmingName in (
                    renameOnlyConflicts ? conflictingTrimmingNames : primaries[primary]
                ).OrderBy(x => x.Length)
            )
            {
                // Do not rename if this is the trimming name that does not have a secondary.
                if (noSecondaryTrimmingName == conflictingTrimmingName)
                {
                    continue;
                }

                // If the current primary hasn't been "claimed" by a trimming name without a secondary, we only want
                // to let the shortest name claim it (per the logic described in the last comment) if it is actually
                // the absolute shortest name and not joint-1st for that title. Therefore, the first trimming name
                // is saved for the second iteration where we'll make that judgement call and handle both at the
                // same time.
                if (first is null)
                {
                    first = conflictingTrimmingName;
                    if (!primaryClaimed)
                    {
                        continue;
                    }
                }

                // Now we're going to make the above judgement call. If the first item has the same length as the
                // second item, the first item has no right to claim the primary name therefore both items will be
                // demoted to use their secondary name.
                if (!primaryClaimed)
                {
                    if (first.Length == conflictingTrimmingName.Length)
                    {
                        // Update the output name.
                        var firstSecondary =
                            context.Names![first].Secondary
                            ?? throw new InvalidOperationException("More than one trimming name without secondary names.");
                        var firstNextPrimary = firstSecondary[^1];
                        firstSecondary.RemoveAt(firstSecondary.Count - 1);
                        context.Names![first] = new CandidateNames(
                            firstNextPrimary,
                            firstSecondary.Count == 0 ? null : firstSecondary
                        );

                        // Update our primary to trimming name map
                        var trimmingNamesForFirst = primaries.TryGetValue(
                            firstNextPrimary,
                            out var tnff
                        )
                            ? tnff
                            : primaries[firstNextPrimary] = [];
                        trimmingNamesForFirst.Add(first);
                        trimmingNamesForOldPrimary.Remove(first);
                        if (trimmingNamesForOldPrimary.Count == 0)
                        {
                            primaries.Remove(primary);
                        }

                        // Make sure we do a pass over the new primary just in case we already have APIs with that
                        // primary
                        namesToEval.Add(firstNextPrimary);
                        if (logger.IsEnabled(LogLevel.Trace)) // <-- prevent needless string.Join
                        {
                            logger.LogTrace(
                                "{}: {} -> {} (remaining secondaries: {})",
                                first,
                                primary,
                                firstNextPrimary,
                                string.Join(", ", firstNextPrimary)
                            );
                        }
                    }

                    primaryClaimed = true;
                }

                // Conflict resolution! Update the output name.
                var secondary =
                    context.Names![conflictingTrimmingName].Secondary
                    ?? throw new InvalidOperationException("More than one trimming name without secondary names.");
                var nextPrimary = secondary[^1];
                secondary.RemoveAt(secondary.Count - 1);
                context.Names![conflictingTrimmingName] = new CandidateNames(
                    nextPrimary,
                    secondary.Count == 0 ? null : secondary
                );

                // Update our primary to trimming name map
                var trimmingNamesForNewPrimary = primaries.TryGetValue(nextPrimary, out var tnfp)
                    ? tnfp
                    : primaries[nextPrimary] = [];
                trimmingNamesForNewPrimary.Add(conflictingTrimmingName);
                trimmingNamesForOldPrimary.Remove(conflictingTrimmingName);
                if (trimmingNamesForOldPrimary.Count == 0)
                {
                    primaries.Remove(primary);
                }

                // Make sure we do a pass over the new primary just in case we already have APIs with that primary
                namesToEval.Add(nextPrimary);
                if (logger.IsEnabled(LogLevel.Trace)) // <-- prevent needless string.Join
                {
                    logger.LogTrace(
                        "{}: {} -> {} (remaining secondaries: {})",
                        conflictingTrimmingName,
                        primary,
                        nextPrimary,
                        string.Join(", ", secondary)
                    );
                }
            }
        }
    }

    /// <inheritdoc />
    public Task<List<ResponseFile>> BeforeScrapeAsync(string key, List<ResponseFile> rsps)
    {
        foreach (var responseFile in rsps)
        {
            if (!responseFile.GeneratorConfiguration.DontUseUsingStaticsForEnums)
            {
                logger.LogWarning(
                    "{} (for {}) should use exclude-using-statics-for-enums as PrettifyNames does not resolve "
                    + "conflicts with members of other types.",
                    responseFile.FilePath,
                    key
                );
            }
            if (!responseFile.GeneratorConfiguration.DontUseUsingStaticsForGuidMember)
            {
                logger.LogWarning(
                    "{} (for {}) should use exclude-using-statics-for-guid-members as PrettifyNames does not resolve "
                    + "conflicts with members of other types.",
                    responseFile.FilePath,
                    key
                );
            }
        }

        return Task.FromResult(rsps);
    }

    /// <summary>
    /// Contains the new name of a type and mappings between original names and new names of its members.
    /// </summary>
    /// <param name="NewName">The new name of the type.</param>
    /// <param name="NonFunctions">The mappings from original names to new names of the type's non-function members.</param>
    /// <param name="Functions">The mappings from original names to new names of the type's function members.</param>
    /// <param name="IsEnum">Whether the type is an enum or not.</param>
    private record struct RenamedType(
        string NewName,
        Dictionary<string, string>? NonFunctions,
        Dictionary<string, string>? Functions,
        bool IsEnum
    );

    private record struct TypeData(List<string>? NonFunctions, List<FunctionData>? Functions, bool IsEnum);
    private record struct FunctionData(string Name, MethodDeclarationSyntax Syntax);

    private class Visitor : CSharpSyntaxWalker
    {
        public Dictionary<string, TypeData> Types { get; } = new();
        public Dictionary<string, List<string>> PrettifyOnlyTypes { get; } = new();
        public HashSet<string> NonDeterminant { get; } = new();

        private TypeInProgress? _typeInProgress;
        private EnumInProgress? _enumInProgress;
        private FieldDeclarationSyntax? _visitingField = null;
        private bool _prettifyOnly;

        /// <summary>
        /// While this is called a "type" in progress, this represents either a class or a struct.
        /// </summary>
        /// <param name="Type">The class or struct's declaration syntax node.</param>
        /// <param name="NonFunctions">The names of the non-function members directly contained by the type.</param>
        /// <param name="Functions">The names of the function members directly contained by the type.</param>
        private record struct TypeInProgress(TypeDeclarationSyntax Type, List<string> NonFunctions, List<FunctionData> Functions);

        /// <summary>
        /// Represents an enum.
        /// </summary>
        /// <param name="Enum">The enum's declaration syntax node.</param>
        /// <param name="EnumMembers">The names of the members directly contained by the enum.</param>
        private record struct EnumInProgress(EnumDeclarationSyntax Enum, List<string> EnumMembers);

        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            if (
                _typeInProgress is not null // nesting is ignored for now
                || _enumInProgress is not null // class nested in an enum, wtf?
                || node.Ancestors().OfType<BaseTypeDeclarationSyntax>().Any() // again... nesting is ignored.
            )
            {
                return;
            }

            if (node.AttributeLists.ContainsAttribute("Silk.NET.Core.Transformed"))
            {
                NonDeterminant.Add(node.Identifier.ToString());
            }

            _typeInProgress = new TypeInProgress(node, [], []);

            // Recurse into the members.
            base.VisitClassDeclaration(node);
            var id = node.Identifier.ToString();

            // Tolerate partial classes.
            if (!Types.TryGetValue(id, out var inner))
            {
                inner = new TypeData([], new List<FunctionData>(), false);
                Types.Add(id, inner);
            }

            // Merge with the other partials.
            (inner.NonFunctions ??= []).AddRange(_typeInProgress.Value.NonFunctions.Where(val => !inner.NonFunctions?.Contains(val) ?? true));
            (inner.Functions ??= []).AddRange(_typeInProgress.Value.Functions);
            _typeInProgress = null;
        }

        public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            // Can't have a field within a field or an enum. This is basically a "wtf" check.
            if (_visitingField is not null || _enumInProgress is not null)
            {
                return;
            }

            // If it's not a constant then we only prettify.
            if (
                !node.Modifiers.Any(SyntaxKind.ConstKeyword)
                && !node.Modifiers.Any(SyntaxKind.StaticKeyword)
            )
            {
                _prettifyOnly = true;
            }

            _visitingField = node;
            base.VisitFieldDeclaration(node);
            _prettifyOnly = false;
            _visitingField = null;
        }

        public override void VisitVariableDeclarator(VariableDeclaratorSyntax node)
        {
            if (node.Parent?.Parent != _visitingField)
            {
                return;
            }

            if (
                _prettifyOnly
                && node.Parent?.Parent?.Parent is BaseTypeDeclarationSyntax type
                && type.Parent?.FirstAncestorOrSelf<BaseTypeDeclarationSyntax>() is null
            )
            {
                var tiden = type.Identifier.ToString();
                if (!PrettifyOnlyTypes.TryGetValue(tiden, out var inner))
                {
                    inner = [];
                    PrettifyOnlyTypes.Add(tiden, inner);
                }

                var iden = node.Identifier.ToString();
                inner.Add(iden);
            }
            else if (_typeInProgress is not null && !_prettifyOnly)
            {
                _typeInProgress.Value.NonFunctions.Add(node.Identifier.ToString());
            }
        }

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            if (node.Parent == _typeInProgress?.Type)
            {
                _typeInProgress!.Value.Functions.Add(new FunctionData(node.Identifier.ToString(), node));
            }
        }

        public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            if (node.Parent == _typeInProgress?.Type)
            {
                _typeInProgress!.Value.NonFunctions.Add(node.Identifier.ToString());
            }
        }

        public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node)
        {
            if (
                _typeInProgress is not null
                || _enumInProgress is not null
                || node.Ancestors().OfType<BaseTypeDeclarationSyntax>().Any()
            )
            {
                if (node.Parent == _typeInProgress?.Type)
                {
                    _typeInProgress!.Value.NonFunctions.Add(node.Identifier.ToString());
                }

                return;
            }

            if (node.AttributeLists.ContainsAttribute("Silk.NET.Core.Transformed"))
            {
                NonDeterminant.Add(node.Identifier.ToString());
            }

            Types.Add(node.Identifier.ToString(), new TypeData(null, null, false));
        }

        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            if (
                _typeInProgress is not null
                || _enumInProgress is not null
                || node.Ancestors().OfType<BaseTypeDeclarationSyntax>().Any()
            )
            {
                return;
            }

            if (node.AttributeLists.ContainsAttribute("Silk.NET.Core.Transformed"))
            {
                NonDeterminant.Add(node.Identifier.ToString());
            }

            Types[node.Identifier.ToString()] = new TypeData(null, null, false);
            base.VisitStructDeclaration(node);
        }

        public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
        {
            if (node.Parent == _enumInProgress?.Enum)
            {
                _enumInProgress!.Value.EnumMembers.Add(node.Identifier.ToString());
            }
        }

        public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            if (
                _typeInProgress is not null
                || _enumInProgress is not null
                || node.Ancestors().OfType<BaseTypeDeclarationSyntax>().Any()
            )
            {
                return;
            }

            if (node.AttributeLists.ContainsAttribute("Silk.NET.Core.Transformed"))
            {
                NonDeterminant.Add(node.Identifier.ToString());
            }

            _enumInProgress = new EnumInProgress(node, []);
            base.VisitEnumDeclaration(node);
            var id = _enumInProgress.Value.Enum.Identifier.ToString();
            if (!Types.TryGetValue(id, out var inner))
            {
                inner = new TypeData([], [], true);
                Types.Add(id, inner);
            }

            (inner.NonFunctions ??= []).AddRange(_enumInProgress.Value.EnumMembers);
            _enumInProgress = null;
        }
    }

    private class RenameSafeAttributeListsRewriter : CSharpSyntaxRewriter
    {
        public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node) =>
            (
                (MethodDeclarationSyntax)base.VisitMethodDeclaration(node)!
            ).WithRenameSafeAttributeLists();
    }
}
