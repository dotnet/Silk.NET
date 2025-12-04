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
        public Dictionary<string, string> PrefixOverrides { get; init; } = [];

        /// <summary>
        /// Manually renamed native names.
        /// </summary>
        public Dictionary<string, string> NameOverrides { get; init; } = [];

        /// <summary>
        /// The base trimmer version. If null, trimming is disabled.
        /// </summary>
        public Version? TrimmerBaseline { get; init; } = new(3, 0);

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

        // Trim the trimmable names if the trimmer baseline is set
        // Otherwise, we just prettify the trimmable names
        if (cfg.TrimmerBaseline is null)
        {
            // Only prettify the trimmable names
            foreach (var (name, (nonFunctions, functions)) in visitor.TrimmableTypes)
            {
                newNames[name] = new RenamedType(
                    ApplyPrettifyOnlyPipeline(null, name, cfg.NameOverrides, visitor.AffixTypes),
                    nonFunctions.ToDictionary(x => x, x => ApplyPrettifyOnlyPipeline(name, x, cfg.NameOverrides, visitor.AffixTypes)),
                    functions.ToDictionary(x => x.Name, x => ApplyPrettifyOnlyPipeline(name, x.Name, cfg.NameOverrides, visitor.AffixTypes))
                );
            }
        }
        else
        {
            // Trim and prettify the trimmable names

            // Get all the trimmers that are above this baseline. We also sort by the version. Why? Because someone
            // couldn't be bothered to introduce a weight property. It is also unclear what effect this has on 2.17/2.18
            // but to be honest those trimmers aren't used and are only included for posterity and understanding of the
            // old logic.
            var trimmers = trimmerProviders
                .SelectMany(x => x.Get(ctx.JobKey))
                .Append(new NameAffixerEarlyTrimmer(visitor.AffixTypes))
                .Append(new NameAffixerLateTrimmer(visitor.AffixTypes))
                .Append(new PrettifyNamesTrimmer())
                .OrderBy(x => x.Version)
                .ToArray();

            // Create a type name dictionary to trim the type names.
            var typeNames = visitor.TrimmableTypes.ToDictionary(
                x => x.Key,
                x => new CandidateNames(x.Key, [])
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
                var (_, (consts, functions)) = visitor.TrimmableTypes.First(x => x.Key == typeName);

                // Rename the "constants" i.e. all the consts/static readonlys in this type. These are treated
                // individually because everything that isn't a constant or a function is only prettified instead of prettified & trimmed.
                var constNames = consts.ToDictionary(
                    x => x,
                    x => new CandidateNames(x, [])
                );

                // Trim the constants.
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

                // Rename the functions. More often that not functions have different nomenclature to constants, so we
                // treat them separately.
                var functionNames = functions
                    .DistinctBy(x => x.Name)
                    .ToDictionary(x => x.Name, x => new CandidateNames(x.Name, []));

                // Collect the syntax as this is used for conflict resolution in the Trim function.
                var functionSyntax = functionNames.Keys.ToDictionary(
                    x => x,
                    x => functions.Where(y => y.Name == x).Select(y => y.Syntax)
                );

                // Trim the functions.
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

                // Add it to the rewriter's list of names to... rewrite...
                newNames[typeName] = new RenamedType(
                    newTypeName,
                    constNames.ToDictionary(x => x.Key, x => x.Value.Primary),
                    functionNames.ToDictionary(x => x.Key, x => x.Value.Primary)
                );
            }
        }

        // Prettify the prettify only names
        foreach (var (typeName, memberNames) in visitor.PrettifyOnlyTypes)
        {
            if (!newNames.TryGetValue(typeName, out var renamedType))
            {
                renamedType = new RenamedType(ApplyPrettifyOnlyPipeline(null, typeName, cfg.NameOverrides, visitor.AffixTypes), [], []);
            }

            foreach (var memberName in memberNames)
            {
                renamedType.NonFunctions[memberName] = ApplyPrettifyOnlyPipeline(typeName, memberName, cfg.NameOverrides, visitor.AffixTypes);
            }

            newNames[typeName] = renamedType;
        }

        if (logger.IsEnabled(LogLevel.Debug))
        {
            foreach (var (name, (newName, nonFunctions, functions)) in newNames)
            {
                logger.LogDebug("{} = {}", name, newName);
                foreach (var (old, @new) in nonFunctions)
                {
                    logger.LogDebug("{}.{} = {}.{}", name, old, newName, @new);
                }

                foreach (var (old, @new) in functions)
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
                    .Value.NonFunctions.Values.Where(y =>
                        x.Value.Functions.ContainsValue(y)
                    )
                    .ToHashSet();
                return comp.GetSymbolsWithName(x.Key, SymbolFilter.Type, ct)
                    .OfType<ITypeSymbol>()
                    .SelectMany<ITypeSymbol, (ISymbol, string)>(y =>
                        [
                            .. Enumerable.SelectMany(
                                [
                                    .. x.Value.NonFunctions.Select(z =>
                                        nonFunctionConflicts.Contains(z.Value)
                                            ? new KeyValuePair<string, string>(
                                                z.Key,
                                                $"{z.Value}Value"
                                            )
                                            : z
                                    ),
                                    .. x.Value.Functions,
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
                doc is not { FilePath: not null }
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
                    {
                        continue;
                    }

                    var checkDoc = proj.GetDocument(checkDocId);
                    if (checkDoc?.FilePath is null)
                    {
                        continue;
                    }

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

    /// <summary>
    /// Applies the prettify only pipeline.
    /// This currently consists of checking for name overrides first.
    /// Then if no override is found, then the name's affixes are removed,
    /// the name is prettified, and the name's affixes are added back.
    /// </summary>
    private string ApplyPrettifyOnlyPipeline(
        string? container,
        string name,
        Dictionary<string, string> nameOverrides,
        Dictionary<string, TypeAffixData> affixTypes)
    {
        // Check for overrides
        foreach (var (nativeName, overriddenName) in nameOverrides)
        {
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

                var nameToAdd = span[(span.IndexOf('.') + 1)..].ToString();
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

        // Remove affixes, prettify, and add affixes back
        return ApplyAffixes(RemoveAffixes(name, container, name, affixTypes, null), container, name, affixTypes, null).Prettify();
    }

    private void Trim(
        NameTrimmerContext context,
        IEnumerable<INameTrimmer> trimmers,
        Dictionary<string, IEnumerable<MethodDeclarationSyntax>>? functionSyntax = null
    )
    {
        // Ensure the trimmers don't see names that have been manually overridden, as we don't want them to influence
        // automatic prefix determination for example
        var namesToTrim = context.Names;
        foreach (var (nativeName, overriddenName) in context.Configuration.NameOverrides)
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
            context.Names[nameToAdd] = new CandidateNames(
                overriddenName,
                [.. v.Secondary, nameToAdd]
            );
        }

        // Run each trimmer
        foreach (var trimmer in trimmers)
        {
            trimmer.Trim(context with { Names = namesToTrim });
        }

        // Apply changes
        if (namesToTrim != context.Names)
        {
            foreach (var (evalName, result) in namesToTrim)
            {
                context.Names[evalName] = result;
            }
        }

        // Prefer shorter names
        foreach (var (_, (_, secondary)) in context.Names)
        {
            secondary.Sort((a, b) => -a.Length.CompareTo(b.Length));
        }

        // Create a map from primaries to trimming names, to account for multiple overloads with the same primary and
        // same trimming name (i.e. it is a generated/transformed overload) but differing discriminators.
        var primaries = new Dictionary<string, HashSet<string>>();
        foreach (var (trimmingName, (primary, _)) in context.Names)
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
                if (context.Names[trimmingNameToEval].Secondary.Count == 0)
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
                            context.Names[first].Secondary
                            ?? throw new InvalidOperationException("More than one trimming name without secondary names.");
                        var firstNextPrimary = firstSecondary[^1];
                        firstSecondary.RemoveAt(firstSecondary.Count - 1);
                        context.Names[first] = new CandidateNames(firstNextPrimary, firstSecondary);

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
                    context.Names[conflictingTrimmingName].Secondary
                    ?? throw new InvalidOperationException("More than one trimming name without secondary names.");
                var nextPrimary = secondary[^1];
                secondary.RemoveAt(secondary.Count - 1);
                context.Names[conflictingTrimmingName] = new CandidateNames(nextPrimary, secondary);

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

    /// <summary>
    /// Gets affix data for the specified container and original name of the identifier.
    /// </summary>
    /// <param name="container">The container name. Either null or the containing type.</param>
    /// <param name="originalName">The original name of the identifier. Either the type name or the member name.</param>
    /// <param name="affixTypes">The affix data retrieved by the <see cref="Visitor"/>.</param>
    /// <returns>The name affixes for the specified identifier.</returns>
    private static NameAffix[] GetAffixes(string? container, string originalName, Dictionary<string, TypeAffixData> affixTypes)
    {
        TypeAffixData typeAffixData;
        if (container == null)
        {
            if (!affixTypes.TryGetValue(originalName, out typeAffixData))
            {
                return [];
            }

            return typeAffixData.TypeAffixes;
        }

        if (affixTypes.TryGetValue(container, out typeAffixData))
        {
            if (typeAffixData.MemberAffixes?.TryGetValue(originalName, out var affixes) ?? false)
            {
                return affixes;
            }
        }

        return [];
    }

    /// <summary>
    /// Removes affixes from the specified primary name and adds the original specified primary to the secondary list if provided.
    /// </summary>
    /// <remarks>
    /// Designed to be used by either <see cref="ApplyPrettifyOnlyPipeline"/> or <see cref="NameAffixerEarlyTrimmer"/>.
    /// </remarks>
    /// <param name="primary">The current primary name.</param>
    /// <param name="container">The container name. Either null or the containing type.</param>
    /// <param name="originalName">The original name of the identifier. Either the type name or the member name.</param>
    /// <param name="affixTypes">The affix data retrieved by the <see cref="Visitor"/>.</param>
    /// <param name="secondary">The list of secondary names. This should be null if used by <see cref="ApplyPrettifyOnlyPipeline"/>.</param>
    /// <returns>The new primary name.</returns>
    private static string RemoveAffixes(string primary, string? container, string originalName, Dictionary<string, TypeAffixData> affixTypes, List<string>? secondary)
    {
        var affixes = GetAffixes(container, originalName, affixTypes);
        if (affixes.Length == 0)
        {
            return primary;
        }

        var originalPrimary = primary;

        // Sort affixes so that the outer affixes are first
        affixes.Sort(static (a, b) =>
        {
            // Sort by ascending order
            // Higher order means the affix is closer to the inside of the name
            if (a.Order != b.Order)
            {
                return a.Order.CompareTo(b.Order);
            }

            // Then by descending declaration order
            // Lower declaration order means the affix is closer to the inside of the name
            return -a.DeclarationOrder.CompareTo(b.DeclarationOrder);
        });

        var prefixes = affixes.Where(x => x.IsPrefix).ToList();
        var suffixes = affixes.Where(x => !x.IsPrefix).ToList();

        RemoveSide(true, prefixes);
        RemoveSide(false, suffixes);

        if (originalPrimary != primary)
        {
            secondary?.Add(originalPrimary);
        }

        return primary;

        void RemoveSide(bool isPrefix, List<NameAffix> nameAffixes)
        {
            while (nameAffixes.Count > 0)
            {
                var removedAffix = false;
                for (var i = 0; i < nameAffixes.Count; i++)
                {
                    var affix = nameAffixes[i];
                    if (isPrefix ? primary.StartsWith(affix.Affix) : primary.EndsWith(affix.Affix))
                    {
                        primary = isPrefix ? primary[affix.Affix.Length..] : primary[..^affix.Affix.Length];

                        nameAffixes.RemoveAt(i);
                        removedAffix = true;
                        break;
                    }
                }

                if (!removedAffix)
                {
                    break;
                }
            }
        }
    }

    /// <summary>
    /// Applies affixes to the specified primary name and adds fallbacks to the secondary list if provided.
    /// </summary>
    /// <remarks>
    /// Designed to be used by either <see cref="ApplyPrettifyOnlyPipeline"/> or <see cref="NameAffixerLateTrimmer"/>.
    /// </remarks>
    /// <param name="primary">The current primary name.</param>
    /// <param name="container">The container name. Either null or the containing type.</param>
    /// <param name="originalName">The original name of the identifier. Either the type name or the member name.</param>
    /// <param name="affixTypes">The affix data retrieved by the <see cref="Visitor"/>.</param>
    /// <param name="secondary">The list of secondary names. This should be null if used by <see cref="ApplyPrettifyOnlyPipeline"/>.</param>
    /// <returns>The new primary name.</returns>
    private static string ApplyAffixes(string primary, string? container, string originalName, Dictionary<string, TypeAffixData> affixTypes, List<string>? secondary)
    {
        var affixes = GetAffixes(container, originalName, affixTypes);
        if (affixes.Length == 0)
        {
            return primary;
        }

        // Sort affixes by priority
        // Negative priority is first, followed by highest non-negative priority
        // This groups the required affixes at the start and each group of fallback affixes together
        affixes.Sort(static (a, b) =>
        {
            // Negative priority first
            // These are our required affixes
            if (int.Sign(a.Priority) != 1 || int.Sign(b.Priority) != 1)
            {
                return a.Priority.CompareTo(b.Priority);
            }

            // Then sort the remaining by descending priority
            return -a.Priority.CompareTo(b.Priority);
        });

        // This is guaranteed to be non-null when this method returns if there is at least one affix
        string? newPrimary = null;

        var currentPriority = -1;
        for (var affixI = 0; affixI < affixes.Length; affixI++)
        {
            var affix = affixes[affixI];
            if (currentPriority == -1 && affix.Priority < 0)
            {
                continue;
            }

            if (currentPriority == -1 || affix.Priority < currentPriority)
            {
                currentPriority = affix.Priority;
                CreateName(primary, affixes.AsSpan()[..affixI], ref newPrimary, secondary);
                if (secondary == null)
                {
                    return newPrimary!;
                }
            }
        }

        CreateName(primary, affixes, ref newPrimary, secondary);

        return newPrimary!;

        static void CreateName(string name, Span<NameAffix> currentAffixes, ref string? newPrimary, List<string>? secondary)
        {
            // Sort affixes so that the inner affixes are first
            currentAffixes.Sort(static (a, b) =>
            {
                // Sort by descending order
                // Higher order means the affix is closer to the inside of the name
                if (a.Order != b.Order)
                {
                    return -a.Order.CompareTo(b.Order);
                }

                // Then by ascending declaration order
                // Lower declaration order means the affix is closer to the inside of the name
                return a.DeclarationOrder.CompareTo(b.DeclarationOrder);
            });

            foreach (var affix in currentAffixes)
            {
                if (affix.Order >= 0)
                {
                    if (affix.IsPrefix)
                    {
                        name = PreventPrettificationHack(affix.Affix) + name;
                    }
                    else
                    {
                        name += PreventPrettificationHack(affix.Affix);
                    }
                }
            }

            if (newPrimary == null)
            {
                newPrimary = name;
            }
            else
            {
                secondary?.Add(name);
            }
        }

        // This appends a space before every capital and after the entire affix
        // This ensures that capitals are preserved when the name is prettified
        static string PreventPrettificationHack(string affix)
        {
            var result = "";
            foreach (var c in affix)
            {
                if (NameUtils.Uppercase.Contains(c))
                {
                    result += ' ';
                }

                result += c;
            }

            return result + ' ';
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
    private record struct RenamedType(string NewName, Dictionary<string, string> NonFunctions, Dictionary<string, string> Functions);

    private record struct NameAffix(bool IsPrefix, string Affix, int Order, int Priority, int DeclarationOrder);

    private record struct TypeData(List<string> NonFunctions, List<FunctionData> Functions);
    private record struct FunctionData(string Name, MethodDeclarationSyntax Syntax);
    private record struct TypeAffixData(NameAffix[] TypeAffixes, Dictionary<string, NameAffix[]>? MemberAffixes);

    private class Visitor : CSharpSyntaxWalker
    {
        /// <summary>
        /// A mapping from type names to their member names (along with some additional info).
        /// These names are first trimmed, then prettified.
        /// </summary>
        public Dictionary<string, TypeData> TrimmableTypes { get; } = new();

        /// <summary>
        /// A mapping from type names to their member names.
        /// These names do not participate in trimming and are only prettified.
        /// </summary>
        public Dictionary<string, List<string>> PrettifyOnlyTypes { get; } = new();

        /// <summary>
        /// A mapping from type names to the type's affix data, which contains mappings from member names to each member's affix data.
        /// This is used at the start of trimming to remove declared affixes and at the end to restore declared affixes.
        /// Declared affixes are defined by the [NamePrefix] and [NameSuffix] attributes and don't contribute towards the usual trimming processes.
        /// </summary>
        public Dictionary<string, TypeAffixData> AffixTypes { get; } = new();

        /// <summary>
        /// A set of type names marked with the [Transformed] attribute.
        /// </summary>
        /// <remarks>
        /// These are not used for prefix determination since they can contain identifiers that
        /// are not part of the original source code.
        /// </remarks>
        public HashSet<string> NonDeterminant { get; } = new();

        /// <summary>
        /// Tracks the type that we currently are visiting.
        /// </summary>
        private TypeInProgress? _typeInProgress;

        /// <summary>
        /// Tracks the enum that we currently are visiting.
        /// </summary>
        private EnumInProgress? _enumInProgress;

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

        /// <summary>
        /// Returns whether we are currently inside of a type.
        /// </summary>
        /// <remarks>
        /// Note that we currently do not handle nested types.
        /// If we encounter a type while we are already in a type, we ignore that type.
        /// If we encounter a non-type (i.e., a type member), we add the member to the type we are already in.
        /// </remarks>
        private bool IsCurrentlyInType(SyntaxNode node) =>
            _typeInProgress is not null
            || _enumInProgress is not null
            || node.Ancestors().OfType<BaseTypeDeclarationSyntax>().Any();

        private bool TryGetAffixData(SyntaxList<AttributeListSyntax> attributeLists, out NameAffix[] affixes)
        {
            affixes = [];
            var declarationOrder = 0;
            foreach (var list in attributeLists)
            {
                foreach (var attribute in list.Attributes)
                {
                    if (!attribute.IsAttribute("Silk.NET.Core.NameAffix"))
                    {
                        continue;
                    }

                    if (attribute.ArgumentList != null)
                    {
                        var type = (attribute.ArgumentList.Arguments[0].Expression as LiteralExpressionSyntax)?.Token.Value as string;
                        var affix = (attribute.ArgumentList.Arguments[1].Expression as LiteralExpressionSyntax)?.Token.Value as string;
                        var order = (attribute.ArgumentList.Arguments[2].Expression as LiteralExpressionSyntax)?.Token.Value as int? ?? -1;
                        var priority = (attribute.ArgumentList.Arguments[3].Expression as LiteralExpressionSyntax)?.Token.Value as int? ?? -1;

                        if (affix != null)
                        {
                            affixes = [..affixes, new NameAffix(type == "Prefix", affix, order, priority, declarationOrder)];
                            declarationOrder++;
                        }
                    }
                }
            }

            return affixes.Length != 0;
        }

        private void ReportTypeAffixData(string typeIdentifier, SyntaxList<AttributeListSyntax> attributeLists)
        {
            if (!TryGetAffixData(attributeLists, out var affixes))
            {
                return;
            }

            if (!AffixTypes.TryGetValue(typeIdentifier, out var typeAffixData))
            {
                typeAffixData = new TypeAffixData([], null);
            }

            AffixTypes[typeIdentifier] = typeAffixData with
            {
                TypeAffixes = [..typeAffixData.TypeAffixes, ..affixes],
            };
        }

        private void ReportMemberAffixData(string typeIdentifier, string memberIdentifier, SyntaxList<AttributeListSyntax> attributeLists)
        {
            if (!TryGetAffixData(attributeLists, out var affixData))
            {
                return;
            }

            if (!AffixTypes.TryGetValue(typeIdentifier, out var typeAffixData))
            {
                typeAffixData = new TypeAffixData([], null);
            }

            // Note that TryAdd will lead to affixes for later members being silently dropped.
            // This is to handle methods which have the same name and affixes. It is fine to drop the affixes in this case.
            (typeAffixData.MemberAffixes ??= []).TryAdd(memberIdentifier, affixData);
            AffixTypes[typeIdentifier] = typeAffixData;
        }

        // ----- Types -----

        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            if (IsCurrentlyInType(node))
            {
                return;
            }

            var identifier = node.Identifier.ToString();
            if (node.AttributeLists.ContainsAttribute("Silk.NET.Core.Transformed"))
            {
                NonDeterminant.Add(identifier);
            }

            ReportTypeAffixData(identifier, node.AttributeLists);

            // Recurse into members.
            _typeInProgress = new TypeInProgress(node, [], []);
            base.VisitClassDeclaration(node);

            // Merge with existing data in case of partials
            if (!TrimmableTypes.TryGetValue(identifier, out var typeData))
            {
                typeData = new TypeData([], []);
                TrimmableTypes.Add(identifier, typeData);
            }

            typeData.NonFunctions.AddRange(_typeInProgress.Value.NonFunctions.Where(nonFunction => !typeData.NonFunctions.Contains(nonFunction)));
            typeData.Functions.AddRange(_typeInProgress.Value.Functions);

            _typeInProgress = null;
        }

        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            if (IsCurrentlyInType(node))
            {
                return;
            }

            var identifier = node.Identifier.ToString();
            if (node.AttributeLists.ContainsAttribute("Silk.NET.Core.Transformed"))
            {
                NonDeterminant.Add(identifier);
            }

            ReportTypeAffixData(identifier, node.AttributeLists);

            // Recurse into members
            _typeInProgress = new TypeInProgress(node, [], []);
            base.VisitStructDeclaration(node);

            // Merge with existing data in case of partials
            if (!TrimmableTypes.TryGetValue(identifier, out var typeData))
            {
                typeData = new TypeData([], []);
                TrimmableTypes.Add(identifier, typeData);
            }

            typeData.NonFunctions.AddRange(_typeInProgress.Value.NonFunctions.Where(nonFunction => !typeData.NonFunctions.Contains(nonFunction)));
            typeData.Functions.AddRange(_typeInProgress.Value.Functions);

            _typeInProgress = null;
        }

        public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            if (IsCurrentlyInType(node))
            {
                return;
            }

            var identifier = node.Identifier.ToString();
            if (node.AttributeLists.ContainsAttribute("Silk.NET.Core.Transformed"))
            {
                NonDeterminant.Add(identifier);
            }

            ReportTypeAffixData(identifier, node.AttributeLists);

            // Recurse into members
            _enumInProgress = new EnumInProgress(node, []);
            base.VisitEnumDeclaration(node);

            // Merge with existing data in case of partials
            if (!TrimmableTypes.TryGetValue(identifier, out var typeData))
            {
                typeData = new TypeData([], []);
                TrimmableTypes.Add(identifier, typeData);
            }

            typeData.NonFunctions.AddRange(_enumInProgress.Value.EnumMembers);
            _enumInProgress = null;
        }

        public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node)
        {
            var identifier = node.Identifier.ToString();
            if (IsCurrentlyInType(node))
            {
                if (node.Parent == _typeInProgress?.Type)
                {
                    _typeInProgress!.Value.NonFunctions.Add(identifier);
                }

                return;
            }

            if (node.AttributeLists.ContainsAttribute("Silk.NET.Core.Transformed"))
            {
                NonDeterminant.Add(identifier);
            }

            ReportTypeAffixData(identifier, node.AttributeLists);
            TrimmableTypes.Add(identifier, new TypeData([], []));
        }

        // ----- Members -----

        public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
        {
            if (node.Parent == _enumInProgress?.Enum)
            {
                var typeIdentifier = _enumInProgress!.Value.Enum.Identifier.ToString();
                var memberIdentifier = node.Identifier.ToString();
                ReportMemberAffixData(typeIdentifier, memberIdentifier, node.AttributeLists);

                _enumInProgress!.Value.EnumMembers.Add(memberIdentifier);
            }
        }

        public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            // If it's not a constant then we only prettify
            // C constants are globally scoped and typically prefixed, so we trim in addition to prettifying
            var prettifyOnly = !node.Modifiers.Any(SyntaxKind.ConstKeyword) && !node.Modifiers.Any(SyntaxKind.StaticKeyword);

            if (node.Parent == _typeInProgress?.Type)
            {
                var typeIdentifier = _typeInProgress!.Value.Type.Identifier.ToString();
                foreach (var variable in node.Declaration.Variables)
                {
                    var memberIdentifier = variable.Identifier.ToString();
                    ReportMemberAffixData(typeIdentifier, memberIdentifier, node.AttributeLists);

                    if (prettifyOnly)
                    {
                        if (!PrettifyOnlyTypes.TryGetValue(typeIdentifier, out var typeData))
                        {
                            typeData = [];
                            PrettifyOnlyTypes.Add(typeIdentifier, typeData);
                        }

                        typeData.Add(memberIdentifier);
                    }
                    else
                    {
                        _typeInProgress.Value.NonFunctions.Add(memberIdentifier);
                    }
                }
            }
        }

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            if (node.Parent == _typeInProgress?.Type)
            {
                var typeIdentifier = _typeInProgress!.Value.Type.Identifier.ToString();
                var memberIdentifier = node.Identifier.ToString();

                if (_typeInProgress!.Value.Type.IsKind(SyntaxKind.StructDeclaration))
                {
                    // Prettify only
                    // Struct methods are introduced by the generator so they are not prefixed
                    if (!PrettifyOnlyTypes.TryGetValue(typeIdentifier, out var typeData))
                    {
                        typeData = [];
                        PrettifyOnlyTypes.Add(typeIdentifier, typeData);
                    }

                    typeData.Add(memberIdentifier);
                }
                else
                {
                    // Trim + Prettify
                    ReportMemberAffixData(typeIdentifier, memberIdentifier, node.AttributeLists);

                    _typeInProgress!.Value.Functions.Add(new FunctionData(memberIdentifier, node));
                }
            }
        }

        public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            if (node.Parent == _typeInProgress?.Type)
            {
                var typeIdentifier = _typeInProgress!.Value.Type.Identifier.ToString();
                var memberIdentifier = node.Identifier.ToString();
                ReportMemberAffixData(typeIdentifier, memberIdentifier, node.AttributeLists);

                // If it's not a constant then we only prettify.
                var hasSetter = node.AccessorList?.Accessors.Any(a => a.IsKind(SyntaxKind.GetAccessorDeclaration) || a.IsKind(SyntaxKind.InitAccessorDeclaration)) ?? false;
                if (hasSetter)
                {
                    if (!PrettifyOnlyTypes.TryGetValue(typeIdentifier, out var typeData))
                    {
                        typeData = [];
                        PrettifyOnlyTypes.Add(typeIdentifier, typeData);
                    }

                    typeData.Add(memberIdentifier);
                }
                else
                {
                    _typeInProgress!.Value.NonFunctions.Add(memberIdentifier);
                }
            }
        }
    }

    private class RenameSafeAttributeListsRewriter : CSharpSyntaxRewriter
    {
        public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node) =>
            ((MethodDeclarationSyntax)base.VisitMethodDeclaration(node)!)
                .WithRenameSafeAttributeLists();
    }

    private class NameAffixerEarlyTrimmer(Dictionary<string, TypeAffixData> affixTypes) : INameTrimmer
    {
        // TODO: This setup has become insane. Think of a better one.
        /// <summary>
        /// Use high-ish version to ensure this trimmer runs after the global prefix trimmer and before MixKhronosData.
        /// </summary>
        public Version Version => new(21, 21, 21);

        public void Trim(NameTrimmerContext context)
        {
            if (context.Container == null)
            {
                foreach (var (original, (primary, secondary)) in context.Names)
                {
                    var secondaries = secondary;
                    var newPrimary = RemoveAffixes(primary, null, original, affixTypes, secondaries);
                    context.Names[original] = new CandidateNames(newPrimary, secondaries);
                }

                return;
            }

            foreach (var (original, (primary, secondary)) in context.Names)
            {
                var secondaries = secondary;
                var newPrimary = RemoveAffixes(primary, context.Container, original, affixTypes, secondaries);
                context.Names[original] = new CandidateNames(newPrimary, secondaries);
            }
        }
    }

    private class NameAffixerLateTrimmer(Dictionary<string, TypeAffixData> affixTypes) : INameTrimmer
    {
        /// <summary>
        /// Use high version to ensure this trimmer runs second to last.
        /// </summary>
        public Version Version => new(999, 999, 999);

        public void Trim(NameTrimmerContext context)
        {
            if (context.Container == null)
            {
                foreach (var (original, (primary, secondary)) in context.Names)
                {
                    var secondaries = secondary;
                    var newPrimary = ApplyAffixes(primary, null, original, affixTypes, secondaries);
                    context.Names[original] = new CandidateNames(newPrimary, secondaries);
                }

                return;
            }

            foreach (var (original, (primary, secondary)) in context.Names)
            {
                var secondaries = secondary;
                var newPrimary = ApplyAffixes(primary, context.Container, original, affixTypes, secondaries);
                context.Names[original] = new CandidateNames(newPrimary, secondaries);
            }
        }
    }

    private class PrettifyNamesTrimmer : INameTrimmer
    {
        /// <summary>
        /// Use really high version to ensure this trimmer runs last.
        /// </summary>
        public Version Version => new(9999, 9999, 9999);

        public void Trim(NameTrimmerContext context)
        {
            foreach (var (original, (primary, secondary)) in context.Names)
            {
                for (var i = 0; i < secondary.Count; i++)
                {
                    secondary[i] = secondary[i].Prettify();
                }

                context.Names[original] = new CandidateNames(primary.Prettify(), secondary);
            }
        }
    }
}
