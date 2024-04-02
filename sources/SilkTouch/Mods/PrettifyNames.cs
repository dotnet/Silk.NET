using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

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
) : IMod
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
        /// A hint for a "global prefix".
        /// </summary>
        public string? GlobalPrefixHint { get; init; }
    }

    /// <inheritdoc />
    public Task<GeneratedSyntax> AfterScrapeAsync(string key, GeneratedSyntax syntax)
    {
        // First pass to scan the sources and create a dictionary of type/member names.
        var cfg = config.Get(key);
        var visitor = new Visitor { NameOverrides = (cfg.NameOverrides?.ToDictionary() ?? [])! };
        foreach (var (_, node) in syntax.Files.Where(x => x.Key.StartsWith("sources/")))
        {
            visitor.Visit(node);
        }

        var rewriter = new Rewriter();
        var translator = new NameUtils.NameTransformer(cfg.LongAcronymThreshold ?? 3);

        // If we have a trimmer baseline set, that means the user wants to trim the names as well as prettify them.
        if (cfg.TrimmerBaseline is not null)
        {
            // Get all the trimmers that are above this baseline. We also sort by the version. Why? Because someone
            // couldn't be bothered to introduce a weight property. It is also unclear what effect this has on 2.17/2.18
            // but to be honest those trimmers aren't used and are only included for posterity and understanding of the
            // old logic.
            var trimmers = trimmerProviders
                .SelectMany(x => x.Get(key))
                .OrderBy(x => x.Version)
                .ToArray();

            // Create a type name dictionary to trim the type names.
            var typeNames = visitor.Types.ToDictionary(
                x => x.Key,
                x => (x.Key, (List<string>?)null)
            );

            // If we don't have a prefix hint and don't have more than one type, we can't determine a prefix so don't
            // trim.
            if (typeNames.Count > 1 || cfg.GlobalPrefixHint is not null)
            {
                Trim(
                    null,
                    cfg.GlobalPrefixHint,
                    key,
                    typeNames,
                    cfg.PrefixOverrides,
                    trimmers,
                    visitor.NameOverrides,
                    visitor.NonDeterminant
                );
            }

            // Now rename everything within that type.
            foreach (var (typeName, (newTypeName, _)) in typeNames)
            {
                var (_, (consts, functions)) = visitor.Types.First(x => x.Key == typeName);

                // Rename the "constants" i.e. all the consts/static readonlys in this type. These are treated
                // individually because everything that isn't a constant or a function is only prettified instead of prettified & trimmed.
                var constNames = consts?.ToDictionary(
                    x => x,
                    x => (Primary: x, (List<string>?)null)
                );

                // Trim the constants if we have any.
                if (constNames is not null)
                {
                    Trim(
                        typeName,
                        cfg.GlobalPrefixHint,
                        key,
                        constNames,
                        cfg.PrefixOverrides,
                        trimmers,
                        cfg.NameOverrides!,
                        visitor.NonDeterminant
                    );
                }
                else
                {
                    constNames = new Dictionary<string, (string Primary, List<string>?)>();
                }

                // Rename the functions. More often that not functions have different nomenclature to constants, so we
                // treat them separately.
                var functionNames = functions
                    ?.DistinctBy(x => x.Name)
                    .ToDictionary(x => x.Name, x => (Primary: x.Name, (List<string>?)null));

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
                        typeName,
                        cfg.GlobalPrefixHint,
                        key,
                        functionNames,
                        cfg.PrefixOverrides,
                        trimmers,
                        cfg.NameOverrides!,
                        visitor.NonDeterminant,
                        functionSyntax
                    );
                }

                // Add back anything else that isn't a trimming candidate (but should still have a pretty name)
                var prettifiedOnly = visitor.PrettifyOnlyTypes.TryGetValue(typeName, out var val)
                    ? val.Select(x => new KeyValuePair<string, (string Primary, List<string>?)>(
                        x,
                        (x, null)
                    ))
                    : Enumerable.Empty<KeyValuePair<string, (string Primary, List<string>?)>>();

                // Add it to the rewriter's list of names to... rewrite...
                rewriter.Types[typeName] = (
                    newTypeName.Prettify(translator),
                    // TODO deprecate secondaries if they're within the baseline?
                    constNames
                        .Concat(prettifiedOnly)
                        .ToDictionary(x => x.Key, x => x.Value.Primary.Prettify(translator)),
                    functionNames?.ToDictionary(
                        x => x.Key,
                        x => x.Value.Primary.Prettify(translator)
                    )
                );
            }
        }
        else // (there's no trimming baseline)
        {
            // Prettify only if the user has not indicated they want to trim.
            foreach (var (name, (nonFunctions, functions)) in visitor.Types)
            {
                rewriter.Types[name] = (
                    name.Prettify(translator),
                    nonFunctions?.ToDictionary(x => x, x => x.Prettify(translator)),
                    functions?.ToDictionary(x => x.Name, x => x.Name.Prettify(translator))
                );
            }
        }

        if (logger.IsEnabled(LogLevel.Debug))
        {
            foreach (var (name, (newName, nonFunctions, functions)) in rewriter.Types)
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

        return Task.FromResult(
            syntax with
            {
                Files = syntax
                    .Files.Select(x =>
                        (
                            x.Key.EndsWith(".gen.cs")
                            && rewriter.Types.TryGetValue(
                                x.Key[(x.Key.LastIndexOf('/') + 1)..^7], // ^7 to strip the .gen.cs
                                out var info
                            )
                                ? $"{x.Key[..(x.Key.LastIndexOf('/') + 1)]}{info.NewName}.gen.cs"
                                : x.Key,
                            rewriter.Visit(x.Value)
                        )
                    )
                    .ToDictionary(x => x.Item1, x => x.Item2)
            }
        );
    }

    private void Trim(
        string? container,
        string? globalPrefixHint,
        string? key,
        Dictionary<string, (string Primary, List<string>? Secondary)> names,
        Dictionary<string, string>? prefixOverrides,
        IEnumerable<INameTrimmer> trimmers,
        Dictionary<string, string>? nameOverrides,
        HashSet<string> nonDeterminant,
        Dictionary<string, IEnumerable<MethodDeclarationSyntax>>? functionSyntax = null
    )
    {
        // Ensure the trimmers don't see names that have been manually overridden, as we don't want them to influence
        // automatic prefix determination for example
        var namesToTrim = names;
        foreach (
            var (nativeName, overriddenName) in nameOverrides
                ?? Enumerable.Empty<KeyValuePair<string, string>>()
        )
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
                var span = container.AsSpan();
                if (span[..span.IndexOf('.')] == "*" || span[..span.IndexOf('.')] == container)
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
            if (namesToTrim == names)
            {
                namesToTrim = namesToTrim.ToDictionary();
            }

            // Don't let the trimmers see the overridden native name.
            namesToTrim.Remove(nameToAdd);

            // Apply the name override to the dictionary we actually use.
            names[nameToAdd] = (overriddenName, [..v.Secondary, nameToAdd]);
        }

        // Run each trimmer
        string? identifiedPrefix = null;
        foreach (var trimmer in trimmers)
        {
            trimmer.Trim(
                container,
                globalPrefixHint,
                key,
                names,
                prefixOverrides,
                nonDeterminant,
                ref identifiedPrefix
            );
        }

        // Apply changes.
        if (namesToTrim != names)
        {
            foreach (var (evalName, result) in namesToTrim)
            {
                names[evalName] = result;
            }
        }

        // Prefer shorter names
        foreach (var (trimmingName, (primary, secondary)) in names)
        {
            names[trimmingName] = (primary, secondary?.OrderByDescending(x => x.Length).ToList());
        }

        // Create a map from primaries to trimming names, to account for multiple overloads with the same primary and
        // same trimming name (i.e. it is a generated/transformed overload) but differing discriminators.
        var primaries = new Dictionary<string, HashSet<string>>();
        foreach (var (trimmingName, (primary, _)) in names)
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
        var methDiscrims =
            new Dictionary<
                string,
                (string? FirstTrimmingName, List<MethodDeclarationSyntax> Methods)
            >();
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
            var nMethConflicts = 0;
            var nMethods = 0;
            var nNoSecondaries = 0; // <-- at least all but one needs to have a secondary to resolve conflicts
            string? noSecondaryTrimmingName = null;
            foreach (var trimmingNameToEval in trimmingNamesForOldPrimary)
            {
                // Do we even have a secondary to fall back on if there is a conflict?
                if ((names[trimmingNameToEval].Secondary?.Count ?? 0) == 0)
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
                            _ => 0 // No conflict to see here (not yet anyway, call it Schrodinger's Conflict)
                        };

                        if (discrimMatches.Count == 2 && ogTrimmingName is not null)
                        {
                            conflictingTrimmingNames.Add(ogTrimmingName);
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
                            names[first].Secondary
                            ?? throw new InvalidOperationException(
                                "More than one trimming name without secondary names."
                            );
                        var firstNextPrimary = firstSecondary[^1];
                        firstSecondary.RemoveAt(firstSecondary.Count - 1);
                        names[first] = (
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
                    names[conflictingTrimmingName].Secondary
                    ?? throw new InvalidOperationException(
                        "More than one trimming name without secondary names."
                    );
                var nextPrimary = secondary[^1];
                secondary.RemoveAt(secondary.Count - 1);
                names[conflictingTrimmingName] = (
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

    private class Visitor : CSharpSyntaxWalker
    {
        public Dictionary<
            string,
            (
                List<string>? NonFunctions,
                List<(string Name, MethodDeclarationSyntax Syntax)>? Functions
            )
        > Types = new();

        public Dictionary<string, List<string>> PrettifyOnlyTypes = new();
        public required Dictionary<string, string> NameOverrides { get; init; }
        public HashSet<string> NonDeterminant { get; } = [];
        private (
            ClassDeclarationSyntax Class,
            List<string> NonFunctions,
            List<(string Name, MethodDeclarationSyntax Syntax)> Functions
        )? _classInProgress;
        private (EnumDeclarationSyntax Enum, List<string> EnumMembers)? _enumInProgress;
        private FieldDeclarationSyntax? _visitingField = null;
        private bool _prettifyOnly;

        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            if (
                _classInProgress is not null // nesting is ignored for now
                || _enumInProgress is not null // class nested in an enum, wtf?
                || node.Ancestors().OfType<BaseTypeDeclarationSyntax>().Any() // again... nesting is ignored.
            )
            {
                return;
            }

            if (
                node.AttributeLists.Any(x =>
                    x.Attributes.Any(y => y.IsAttribute("Silk.NET.Core.Transformed"))
                )
            )
            {
                NonDeterminant.Add(node.Identifier.ToString());
            }

            _classInProgress = (
                node,
                new List<string>(),
                new List<(string, MethodDeclarationSyntax)>()
            );

            // Recurse into the members.
            base.VisitClassDeclaration(node);
            var id = node.Identifier.ToString();

            // Tolerate partial classes.
            if (!Types.TryGetValue(id, out var inner))
            {
                inner = (new List<string>(), new List<(string, MethodDeclarationSyntax)>());
                Types.Add(id, inner);
            }

            // Merge with the other partials.
            (inner.NonFunctions ??= new List<string>()).AddRange(
                _classInProgress.Value.NonFunctions
            );
            (inner.Functions ??= new List<(string, MethodDeclarationSyntax)>()).AddRange(
                _classInProgress.Value.Functions
            );
            _classInProgress = null;
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
                && (
                    !node.Modifiers.Any(SyntaxKind.StaticKeyword)
                    || !node.Modifiers.Any(SyntaxKind.ReadOnlyKeyword)
                )
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
                    inner = new List<string>();
                    PrettifyOnlyTypes.Add(tiden, inner);
                }

                var iden = node.Identifier.ToString();
                inner.Add(iden);
            }
            else if (_classInProgress is not null && !_prettifyOnly)
            {
                _classInProgress.Value.NonFunctions.Add(node.Identifier.ToString());
            }
        }

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            if (node.Parent == _classInProgress?.Class)
            {
                _classInProgress!.Value.Functions.Add((node.Identifier.ToString(), node));
            }
        }

        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            if (
                _classInProgress is not null
                || _enumInProgress is not null
                || node.Ancestors().OfType<BaseTypeDeclarationSyntax>().Any()
            )
            {
                return;
            }

            if (
                node.AttributeLists.Any(x =>
                    x.Attributes.Any(y => y.IsAttribute("Silk.NET.Core.Transformed"))
                )
            )
            {
                NonDeterminant.Add(node.Identifier.ToString());
            }

            Types[node.Identifier.ToString()] = (null, null);
            base.VisitStructDeclaration(node);
        }

        public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            if (
                _classInProgress is not null
                || _enumInProgress is not null
                || node.Ancestors().OfType<BaseTypeDeclarationSyntax>().Any()
            )
            {
                return;
            }

            if (
                node.AttributeLists.Any(x =>
                    x.Attributes.Any(y => y.IsAttribute("Silk.NET.Core.Transformed"))
                )
            )
            {
                NonDeterminant.Add(node.Identifier.ToString());
            }

            _enumInProgress = (node, new List<string>());
            base.VisitEnumDeclaration(node);
            var id = _enumInProgress.Value.Enum.Identifier.ToString();
            if (!Types.TryGetValue(id, out var inner))
            {
                inner = (new List<string>(), new List<(string, MethodDeclarationSyntax)>());
                Types.Add(id, inner);
            }

            (inner.NonFunctions ??= new List<string>()).AddRange(_enumInProgress.Value.EnumMembers);
            _enumInProgress = null;
        }
    }

    private class Rewriter : CSharpSyntaxRewriter
    {
        public Dictionary<
            string,
            (
                string NewName,
                Dictionary<string, string>? NonFunctions,
                Dictionary<string, string>? Functions
            )
        > Types = new();

        private (
            BaseTypeDeclarationSyntax Type,
            Dictionary<string, string>? NonFunctions,
            Dictionary<string, string>? Functions
        )? _typeInProgress;
        private FieldDeclarationSyntax? _memberInProgress;
        private bool _memberAccess;
        private bool _accessing;
        private bool _member;
        private string? _memberAccessType;
        private readonly List<FieldDeclarationSyntax> _constants = new();

        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            if (
                _typeInProgress is not null
                || !Types.TryGetValue(node.Identifier.ToString(), out var info)
            )
            {
                return base.VisitClassDeclaration(node);
            }

            _typeInProgress = (node, info.NonFunctions, info.Functions);
            var ret = (ClassDeclarationSyntax)base.VisitClassDeclaration(node)!;
            _typeInProgress = null;
            ret = ret.WithIdentifier(Identifier(info.NewName))
                .WithMembers(
                    List(
                        // Constants can be quite prone to conflicting with their functions e.g. consider
                        // GL_PROGRAM_STRING_ARB and glProgramStringARB, as such we relegate the ones that don't
                        // eventually end up in an enum to be in a subclass instead
                        SingletonList<MemberDeclarationSyntax>(
                                ClassDeclaration("Constants")
                                    .WithModifiers(
                                        TokenList(
                                            Token(SyntaxKind.PublicKeyword),
                                            Token(SyntaxKind.StaticKeyword),
                                            Token(SyntaxKind.PartialKeyword)
                                        )
                                    )
                                    .WithMembers(List<MemberDeclarationSyntax>(_constants))
                            )
                            .Concat(ret.Members)
                    )
                );
            _constants.Clear();
            return ret;
        }

        public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            if (
                _typeInProgress?.Functions is not null
                && _typeInProgress.Value.Functions.TryGetValue(
                    node.Identifier.ToString(),
                    out var newName
                )
            )
            {
                return (
                    (MethodDeclarationSyntax)base.VisitMethodDeclaration(node)!
                ).WithIdentifierForImport(Identifier(newName));
            }
            return base.VisitMethodDeclaration(node);
        }

        public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            if (
                _typeInProgress is not null
                || !Types.TryGetValue(node.Identifier.ToString(), out var info)
            )
            {
                return base.VisitEnumDeclaration(node);
            }

            _typeInProgress = (node, info.NonFunctions, info.Functions);
            var ret = base.VisitEnumDeclaration(node);
            _typeInProgress = null;
            return ((EnumDeclarationSyntax)ret!).WithIdentifier(Identifier(info.NewName));
        }

        public override SyntaxNode? VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
        {
            if (
                _typeInProgress is null
                || !(
                    _typeInProgress.Value.NonFunctions?.TryGetValue(
                        node.Identifier.ToString(),
                        out var newName
                    ) ?? false
                )
            )
            {
                return node;
            }
            return node.WithIdentifier(Identifier(newName));
        }

        public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
        {
            if (
                _typeInProgress is not null
                || !Types.TryGetValue(node.Identifier.ToString(), out var info)
            )
            {
                return base.VisitStructDeclaration(node);
            }

            _typeInProgress = (node, info.NonFunctions, info.Functions);
            var ret = ((StructDeclarationSyntax)base.VisitStructDeclaration(node)!).WithIdentifier(
                Identifier(info.NewName)
            );
            _typeInProgress = null;
            return ret;
        }

        public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            if (_typeInProgress is not null && _memberInProgress is null)
            {
                _memberInProgress = node;
            }
            var ret = base.VisitFieldDeclaration(node);
            _memberInProgress = null;
            if (
                !node.Modifiers.Any(SyntaxKind.ConstKeyword)
                || _typeInProgress?.Type is not ClassDeclarationSyntax
            )
            {
                return ret;
            }

            _constants.Add((FieldDeclarationSyntax)ret!);
            return null;
        }

        public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            if (
                _typeInProgress?.NonFunctions is null
                || !_typeInProgress.Value.NonFunctions.TryGetValue(
                    node.Identifier.ToString(),
                    out var newName
                )
            )
            {
                return node;
            }
            return node.WithIdentifier(Identifier(newName));
        }

        public override SyntaxNode? VisitVariableDeclarator(VariableDeclaratorSyntax node)
        {
            if (
                _typeInProgress?.NonFunctions is not null
                && _memberInProgress == node.Parent?.Parent
                && _typeInProgress.Value.NonFunctions.TryGetValue(
                    node.Identifier.ToString(),
                    out var newName
                )
            )
            {
                return node.WithIdentifier(Identifier(newName));
            }

            return node;
        }

        public override SyntaxNode? VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
        {
            _memberAccess = true;
            _accessing = true;
            Visit(node.Expression);
            _accessing = false;
            if (_memberAccessType is null || !Types.TryGetValue(_memberAccessType, out var info))
            {
                _memberAccess = false;
                return node;
            }

            var accessing = (ExpressionSyntax)Visit(node.Expression);
            _member = true;
            var member = (SimpleNameSyntax)Visit(node.Name);
            _member = false;
            var ret = node.Update(accessing, VisitToken(node.OperatorToken), member);
            _memberAccess = false;
            _memberAccessType = null;
            return ret;
        }

        public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
        {
            if (_memberAccess)
            {
                if (_accessing) // getting the last identifier in the thing we're accessing
                {
                    _memberAccessType = node.Identifier.ToString();
                    return node;
                }

                if (_member) // change name of the member we're accessing
                {
                    if (!Types.TryGetValue(_memberAccessType!, out var info))
                    {
                        return base.VisitIdentifierName(node);
                    }

                    if (
                        info.NonFunctions?.TryGetValue(node.Identifier.ToString(), out var cName)
                        ?? false
                    )
                    {
                        return IdentifierName(cName);
                    }

                    if (
                        info.Functions?.TryGetValue(node.Identifier.ToString(), out var fName)
                        ?? false
                    )
                    {
                        return IdentifierName(fName);
                    }
                }
                else // changing name of the thing we're accessing
                {
                    var str = node.Identifier.ToString();
                    if (str == _memberAccessType)
                    {
                        return IdentifierName(Types[str].NewName);
                    }
                }
            }
            else if (
                _typeInProgress?.Functions is not null
                && _typeInProgress.Value.Functions.TryGetValue(
                    node.Identifier.ToString(),
                    out var fName
                )
            )
            {
                return IdentifierName(fName);
            }
            else if (
                _typeInProgress?.NonFunctions is not null
                && _typeInProgress.Value.NonFunctions.TryGetValue(
                    node.Identifier.ToString(),
                    out var cName
                )
            )
            {
                return IdentifierName(cName);
            }
            else if (Types.TryGetValue(node.Identifier.ToString(), out var info))
            {
                return IdentifierName(info.NewName);
            }
            return base.VisitIdentifierName(node);
        }
    }
}
