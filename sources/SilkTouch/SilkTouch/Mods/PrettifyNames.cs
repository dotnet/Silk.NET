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
[ModConfiguration<Configuration>]
public class PrettifyNames(
    ILogger<PrettifyNames> logger,
    IOptionsSnapshot<PrettifyNames.Configuration> config
) : IMod, IResponseFileMod
{
    /// <summary>
    /// The configuration for the <see cref="PrettifyNames"/> mod.
    /// </summary>
    public record Configuration
    {
        /// <summary>
        /// The maximum length of an all capitals string to be treated as a single acronym, rather than as an all
        /// capitals word.
        /// </summary>
        /// <remarks>
        /// The default is 2 to match Microsoft's .NET framework design guidelines:
        /// https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/capitalization-conventions
        /// </remarks>
        public int LongAcronymThreshold { get; init; } = 2;

        /// <summary>
        /// Manually renamed native names.
        /// </summary>
        public Dictionary<string, string> NameOverrides { get; init; } = [];

        /// <summary>
        /// The configuration for each category of name affixes.
        /// The key specifies the category name.
        /// </summary>
        public Dictionary<string, NameAffixConfiguration> Affixes { get; init; } = [];
    }

    /// <summary>
    /// Specifies how a category of name affixes are to be processed by <see cref="PrettifyNames"/>.
    /// </summary>
    public record NameAffixConfiguration
    {
        /// <summary>
        /// Whether the affix should be removed.
        /// </summary>
        public bool Remove { get; init; } = false;

        /// <summary>
        /// The order with which the affix is applied.
        /// <para/>
        /// Does nothing if <see cref="Remove"/> is true.
        /// <para/>
        /// Higher means the affix is applied first, meaning it will be closer to the inside of the name.
        /// Affixes with the same order have ties broken using the order the <see cref="NameAffixAttribute"/>s are declared on the identifier.
        /// First declared are applied first.
        /// </summary>
        public int Order { get; init; } = 0;

        /// <summary>
        /// Whether the affix will be used to create secondary
        /// names that will be used in case of name conflicts.
        /// </summary>
        public bool IsDiscriminator { get; init; } = false;

        /// <summary>
        /// The priority with which the affix will be used to create secondary
        /// names that will be used in case of name conflicts.
        /// <para/>
        /// Does nothing if <see cref="IsDiscriminator"/> is false.
        /// <para/>
        /// Higher means the name created using the affix is tried first.
        /// Affixes with the same priority are applied together as a group.
        /// </summary>
        public int DiscriminatorPriority { get; init; } = 0;
    }

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var cfg = config.Get(ctx.JobKey);
        if (ctx.SourceProject is null)
        {
            return;
        }

        // Scan sources to gather names
        var visitor = new NameDataVisitor();
        foreach (var doc in ctx.SourceProject.Documents)
        {
            visitor.Visit(await doc.GetSyntaxRootAsync(ct));
        }

        // Process the names
        var nameProcessorContext = new NameProcessorContext(visitor);
        {
            var namePrettifier = new NamePrettifier(cfg.LongAcronymThreshold);

            // Define name processors
            var nameProcessors = new INameProcessor[]
            {
                new HandleOverridesProcessor(cfg.NameOverrides),
                new StripAffixesProcessor(visitor),
                new PrettifyProcessor(namePrettifier),
                new ReapplyAffixesProcessor(visitor, cfg.Affixes),
                new PrefixIfStartsWithNumberProcessor(),
                new ResolveConflictsProcessor(visitor, logger),
                new OutputFinalNamesProcessor(),
                new RemoveUnmodifiedFinalNamesProcessor(),
            };

            foreach (var nameProcessor in nameProcessors)
            {
                nameProcessor.ProcessNames(nameProcessorContext);
            }
        }

        var newNames = nameProcessorContext.FinalNames;
        if (logger.IsEnabled(LogLevel.Debug))
        {
            logger.LogDebug("Prettified names by scope:");
            foreach (var (scope, members) in newNames)
            {
                logger.LogDebug("Scope: {}", scope);
                foreach (var (oldMemberName, newMemberName) in members)
                {
                    logger.LogDebug("    {} = {}", oldMemberName, newMemberName);
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
            ?? throw new InvalidOperationException(
                "Failed to obtain compilation for source project!"
            );

        // TODO: Replace this with another visitor. I really don't like LINQ blobs and a visitor might be faster.
        // TODO: Also consider using a symbol visitor instead of a syntax one. It might be faster since we only care about declarations
        await NameUtils.RenameAllAsync(
            ctx,
            newNames.SelectMany(x =>
            {
                var nonFunctionConflicts = x
                    .Value.NonFunctions.Values.Where(y => x.Value.Functions.ContainsValue(y))
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
        var typeNames = newNames.GetValueOrDefault("", []);
        var typeNamesLongestFirst = typeNames.OrderByDescending(x => x.Key.Length).ToArray();

        foreach (var docId in proj.DocumentIds)
        {
            var doc = proj.GetDocument(docId);
            if (doc?.FilePath == null)
            {
                continue;
            }

            var firstMatch = typeNamesLongestFirst.FirstOrDefault(x =>
                doc.FilePath.Contains(x.Key) || doc.Name.Contains(x.Key)
            );
            if (firstMatch is not { Key: { } oldName, Value: { } newName })
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
                logger.LogError(
                    $"{originalName} -> {doc.Name} failed to rename file as a file already exists at {doc.FilePath}"
                );
            }
            else
            {
                proj = doc.Project;
            }
        }

        ctx.SourceProject = proj;
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
    private record struct RenamedType(
        string NewName,
        Dictionary<string, string> NonFunctions,
        Dictionary<string, string> Functions
    );

    /// <summary>
    /// Stores additional data for each scope member.
    /// </summary>
    /// <param name="Name">The name as it exists in source code.</param>
    /// <param name="Affixes">The affixes declared for the name.</param>
    /// <param name="MethodDeclarations">The method declarations, if the name represents a method.</param>
    private record struct MemberData(
        string Name,
        NameAffix[] Affixes,
        List<MethodDeclarationSyntax>? MethodDeclarations
    );

    private class NameDataVisitor : CSharpSyntaxWalker
    {
        /// <summary>
        /// Represents a mapping: ScopeName -> (MemberName -> MemberData).
        /// This data is used by name processors to transform and prettify the names.
        /// </summary>
        public Dictionary<string, Dictionary<string, MemberData>> Scopes { get; } = [];

        private BaseTypeDeclarationSyntax? _scope;

        private void ReportName(
            SyntaxToken memberIdentifier,
            SyntaxList<AttributeListSyntax> memberAttributeLists,
            MethodDeclarationSyntax? memberMethodDeclaration = null
        )
        {
            var scopeName = _scope?.Identifier.ToString() ?? "";
            var memberName = memberIdentifier.ToString();
            var affixes = memberAttributeLists.GetNameAffixes();

            if (!Scopes.TryGetValue(scopeName, out var members))
            {
                Scopes[scopeName] = members = [];
            }

            if (!members.TryGetValue(memberName, out var memberData))
            {
                // Note that we only store affix data for the first encountered version of the name
                // This is fine because if two members have the same name, they should have the same affixes
                memberData = new MemberData(memberName, affixes, null);
            }

            if (memberMethodDeclaration != null)
            {
                // Store method declarations so that we have information on each overload
                // This is used later for overload conflict resolution
                memberData.MethodDeclarations ??= [];
                memberData.MethodDeclarations.Add(memberMethodDeclaration);
            }

            members[memberName] = memberData;
        }

        // ----- Types -----

        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            ReportName(node.Identifier, node.AttributeLists);

            var previousScope = _scope;
            _scope = node;
            foreach (var member in node.Members)
            {
                Visit(member);
            }
            _scope = previousScope;
        }

        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            ReportName(node.Identifier, node.AttributeLists);

            var previousScope = _scope;
            _scope = node;
            foreach (var member in node.Members)
            {
                Visit(member);
            }
            _scope = previousScope;
        }

        public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            ReportName(node.Identifier, node.AttributeLists);

            var previousScope = _scope;
            _scope = node;
            foreach (var member in node.Members)
            {
                Visit(member);
            }
            _scope = previousScope;
        }

        public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node) =>
            ReportName(node.Identifier, node.AttributeLists);

        // ----- Members -----

        public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node) =>
            ReportName(node.Identifier, node.AttributeLists);

        public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            var firstVariable = node.Declaration.Variables.First();
            ReportName(firstVariable.Identifier, node.AttributeLists);
        }

        public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node) =>
            ReportName(node.Identifier, node.AttributeLists);

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node) =>
            ReportName(node.Identifier, node.AttributeLists, node);
    }

    private class RenameSafeAttributeListsRewriter : CSharpSyntaxRewriter
    {
        public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node) =>
            (
                (MethodDeclarationSyntax)base.VisitMethodDeclaration(node)!
            ).WithRenameSafeAttributeLists();
    }

    /// <summary>
    /// Applies name overrides and moves overridden names to the final set of names.
    /// Overridden names are removed from the working set to prevent later processors from directly seeing them.
    /// </summary>
    private class HandleOverridesProcessor(Dictionary<string, string> nameOverrides)
        : INameProcessor
    {
        public void ProcessNames(NameProcessorContext context)
        {
            var overriddenNames = new List<(string Scope, string Member, string OverriddenName)>();
            foreach (var (overrideTargetName, overriddenName) in nameOverrides)
            {
                // Target format can either be "Member" or "Scope.Member"
                // Split into the two parts here
                var overrideTargetScopeEnd = overrideTargetName.IndexOf('.');
                var overrideTargetScope =
                    overrideTargetScopeEnd >= 0
                        ? overrideTargetName[..overrideTargetScopeEnd]
                        : null;
                var overrideTargetMember = overrideTargetName[(overrideTargetScopeEnd + 1)..];

                // Wildcard scope is the same as not specifying a scope
                if (
                    overrideTargetScope != null
                    && overrideTargetScope.Equals("*", StringComparison.Ordinal)
                )
                {
                    overrideTargetScope = null;
                }

                if (overrideTargetScope == null)
                {
                    // Apply unscoped override
                    foreach (var (scope, members) in context.Scopes)
                    {
                        if (members.ContainsKey(overrideTargetMember))
                        {
                            overriddenNames.Add((scope, overrideTargetMember, overriddenName));
                        }
                    }
                }
                else
                {
                    // Apply scoped override
                    if (
                        context.Scopes.TryGetValue(overrideTargetScope, out var members)
                        && members.ContainsKey(overrideTargetMember)
                    )
                    {
                        overriddenNames.Add(
                            (overrideTargetScope, overrideTargetMember, overriddenName)
                        );
                    }
                }
            }

            // Move overridden names to final output
            foreach (var overriddenName in overriddenNames)
            {
                // Remove from working set
                // This is to prevent later processors from modifying overrides
                context.Scopes[overriddenName.Scope].Remove(overriddenName.Member);

                // Add to final names
                if (!context.FinalNames.TryGetValue(overriddenName.Scope, out var members))
                {
                    context.FinalNames[overriddenName.Scope] = members = [];
                }

                members[overriddenName.Member] = overriddenName.OverriddenName;
            }
        }
    }

    /// <summary>
    /// Removes identified affixes so that other name processors can process the base name separately.
    /// These affixes should be reapplied by <see cref="ReapplyAffixesProcessor"/>.
    /// </summary>
    private class StripAffixesProcessor(NameDataVisitor nameData) : INameProcessor
    {
        public void ProcessNames(NameProcessorContext context)
        {
            foreach (var (scope, members) in context.Scopes)
            {
                if (!nameData.Scopes.TryGetValue(scope, out var scopeData))
                {
                    continue;
                }

                foreach (var (original, (primary, secondary)) in members)
                {
                    if (!scopeData.TryGetValue(original, out var memberData))
                    {
                        continue;
                    }

                    var newPrimary = RemoveAffixes(primary, secondary, memberData.Affixes);
                    members[original] = new CandidateNames(newPrimary, secondary);
                }
            }
        }

        /// <summary>
        /// Removes affixes from the specified primary name and adds the original specified primary to the secondary list.
        /// </summary>
        /// <param name="primary">The current primary name.</param>
        /// <param name="secondary">The current secondary names.</param>
        /// <param name="affixes">The affixes declared for the original name.</param>
        /// <returns>The new primary name.</returns>
        private string RemoveAffixes(string primary, List<string> secondary, NameAffix[] affixes)
        {
            if (affixes.Length == 0)
            {
                return primary;
            }

            var stripped = NameAffixer.StripAffixes(primary, affixes);
            if (stripped != primary)
            {
                secondary.Add(primary);
            }

            return stripped;
        }
    }

    /// <summary>
    /// Prettifies the primary and secondary candidate names.
    /// Also see <see cref="NamePrettifier.Prettify"/>.
    /// </summary>
    private class PrettifyProcessor(NamePrettifier namePrettifier) : INameProcessor
    {
        public void ProcessNames(NameProcessorContext context)
        {
            foreach (var (scope, members) in context.Scopes)
            {
                // Be lenient about caps for type names (e.g. GL)
                var allowAllCaps = scope == "";

                foreach (var (original, (primary, secondary)) in members)
                {
                    for (var i = 0; i < secondary.Count; i++)
                    {
                        secondary[i] = namePrettifier.Prettify(secondary[i], allowAllCaps);
                    }

                    members[original] = new CandidateNames(
                        namePrettifier.Prettify(primary, allowAllCaps),
                        secondary
                    );
                }
            }
        }
    }

    /// <summary>
    /// Reapplies and transforms identified affixes based on <see cref="NameAffixConfiguration"/>.
    /// </summary>
    private class ReapplyAffixesProcessor(
        NameDataVisitor nameData,
        Dictionary<string, NameAffixConfiguration> config
    ) : INameProcessor
    {
        private static readonly NameAffixConfiguration _defaultConfig = new();

        public void ProcessNames(NameProcessorContext context)
        {
            // TODO: Proper implementation that builds a dependency graph for the entire project instead of per scope
            foreach (var (scope, members) in context.Scopes)
            {
                if (!nameData.Scopes.TryGetValue(scope, out var scopeData))
                {
                    continue;
                }

                // Calculate processing order using topological sort
                // Name affixes can reference other names
                // We want names that don't reference other names to be processed first
                var processingOrderByKey = new List<string>();
                {
                    var ready = new Queue<string>();
                    var dependencyCountByKey = new Dictionary<string, int>();
                    var notifyDependantByKey = new Dictionary<string, List<string>>();

                    // Build dependency graph
                    foreach (var (member, _) in members)
                    {
                        if (!scopeData.TryGetValue(member, out var memberData))
                        {
                            continue;
                        }

                        var dependencyCount = 0;
                        var affixes = memberData.Affixes;
                        foreach (var affix in affixes)
                        {
                            if (!affix.IsReference)
                            {
                                continue;
                            }

                            // Add as dependency
                            if (!notifyDependantByKey.TryGetValue(affix.Affix, out var dependants))
                            {
                                notifyDependantByKey[affix.Affix] = dependants = [];
                            }

                            dependants.Add(member);
                            dependencyCount++;
                        }

                        if (dependencyCount == 0)
                        {
                            // No dependencies
                            ready.Enqueue(member);
                            continue;
                        }

                        // Store dependency count
                        dependencyCountByKey.Add(member, dependencyCount);
                    }

                    // Output final order
                    while (ready.TryDequeue(out var key))
                    {
                        processingOrderByKey.Add(key);
                        if (notifyDependantByKey.TryGetValue(key, out var dependants))
                        {
                            foreach (var dependant in dependants)
                            {
                                if (
                                    dependencyCountByKey.TryGetValue(
                                        dependant,
                                        out var dependencyCount
                                    )
                                )
                                {
                                    dependencyCount--;
                                    if (dependencyCount == 0)
                                    {
                                        ready.Enqueue(dependant);
                                        dependencyCountByKey.Remove(dependant);
                                        continue;
                                    }

                                    dependencyCountByKey[dependant] = dependencyCount;
                                }
                            }
                        }
                    }

                    // Check for unfulfilled dependencies
                    if (dependencyCountByKey.Count != 0)
                    {
                        // Check for missing dependencies
                        foreach (var key in dependencyCountByKey.Keys)
                        {
                            if (!members.ContainsKey(key))
                            {
                                // This is because we currently can only resolve names that are given by the NameProcessorContext
                                // Please update this message if this limitation changes
                                throw new InvalidOperationException(
                                    $"A name affix for '{key}' references a name that does not exist or is part of a different scope. "
                                        + $"Currently, only references to names directly in the same scope are supported"
                                );
                            }
                        }

                        // Remaining must be a cycle
                        throw new InvalidOperationException(
                            $"Detected cycle in referenced affixes. Names that are part of the cycle: {string.Join(", ", dependencyCountByKey.Keys)}"
                        );
                    }
                }

                foreach (var member in processingOrderByKey)
                {
                    if (!scopeData.TryGetValue(member, out var memberData))
                    {
                        continue;
                    }

                    var (primary, secondary) = members[member];
                    var newPrimary = ApplyAffixes(
                        scope,
                        primary,
                        secondary,
                        memberData.Affixes,
                        context
                    );
                    members[member] = new CandidateNames(newPrimary, secondary);
                }
            }
        }

        /// <summary>
        /// Applies affixes to the specified primary name and adds fallbacks to the secondary list.
        /// </summary>
        /// <param name="scope">The scope of the original name. Used for resolving referenced affixes.</param>
        /// <param name="primary">The current primary name.</param>
        /// <param name="secondary">The current secondary names.</param>
        /// <param name="affixes">The affixes declared for the original name.</param>
        /// <returns>The new primary name.</returns>
        /// <param name="context">The current <see cref="NameProcessorContext"/>. Used for resolving referenced affixes.</param>
        /// <returns>The new primary name.</returns>
        private string ApplyAffixes(
            string scope,
            string primary,
            List<string> secondary,
            NameAffix[] affixes,
            NameProcessorContext context
        )
        {
            if (affixes.Length == 0)
            {
                return primary;
            }

            // Sort affixes by priority
            // Negative priority is first, followed by highest non-negative priority
            // This groups the non-discriminator affixes at the start and each group of discriminator affixes together
            // For example: If we have [..A, ..B, ..C] where A are non-discriminator affixes; B and C are grouped discriminator affixes
            // Processing [..A] will give us our primary name
            // Processing [..A, ..B] will give us the first secondary name
            // Processing [..A, ..B, ..C] will give us the second secondary name
            affixes.Sort(
                (a, b) =>
                {
                    // Sort so that non-discriminator affixes are first
                    if (GetConfiguration(a).IsDiscriminator != GetConfiguration(b).IsDiscriminator)
                    {
                        return GetConfiguration(a)
                            .IsDiscriminator.CompareTo(GetConfiguration(b).IsDiscriminator);
                    }

                    // Then sort the remaining by descending priority
                    return -GetConfiguration(a)
                        .DiscriminatorPriority.CompareTo(GetConfiguration(b).DiscriminatorPriority);
                }
            );

            // This is guaranteed to be non-null when this method returns if there is at least one affix
            string? newPrimary = null;

            // Process each group of affixes
            var hasProcessedNonDiscriminator = false;
            var currentPriority = int.MaxValue;
            for (var affixI = 0; affixI < affixes.Length; affixI++)
            {
                var affix = affixes[affixI];
                if (!GetConfiguration(affix).IsDiscriminator)
                {
                    continue;
                }

                // Process group if we reached the end of the non-discriminator affixes or if the priority changes
                if (
                    !hasProcessedNonDiscriminator
                    || GetConfiguration(affix).DiscriminatorPriority < currentPriority
                )
                {
                    hasProcessedNonDiscriminator = true;
                    currentPriority = GetConfiguration(affix).DiscriminatorPriority;
                    CreateName(primary, affixes.AsSpan()[..affixI]);
                }
            }

            // Process final group since the loop above skips the final group
            CreateName(primary, affixes);

            return newPrimary!;

            void CreateName(string name, Span<NameAffix> currentAffixes)
            {
                // Sort affixes so that the inner affixes are first
                currentAffixes.Sort(
                    (a, b) =>
                    {
                        // Sort by descending order
                        // Higher order means the affix is closer to the inside of the name
                        if (GetConfiguration(a).Order != GetConfiguration(b).Order)
                        {
                            return -GetConfiguration(a).Order.CompareTo(GetConfiguration(b).Order);
                        }

                        // Then by ascending declaration order
                        // Lower declaration order means the affix is closer to the inside of the name
                        return a.DeclarationOrder.CompareTo(b.DeclarationOrder);
                    }
                );

                foreach (var affix in currentAffixes)
                {
                    var affixValue = affix.Affix;
                    if (
                        affix.IsReference
                        && context.Scopes.TryGetValue(scope, out var referencedScopeMembers)
                        && referencedScopeMembers.TryGetValue(
                            affixValue,
                            out var referencedCandidateNames
                        )
                    )
                    {
                        affixValue = referencedCandidateNames.Primary;
                    }

                    if (!GetConfiguration(affix).Remove)
                    {
                        if (affix.Type == NameAffixType.Prefix)
                        {
                            name = affixValue + name;
                        }
                        else
                        {
                            name += affixValue;
                        }
                    }
                }

                if (newPrimary == null)
                {
                    newPrimary = name;
                }
                else
                {
                    secondary.Add(name);
                }
            }
        }

        private NameAffixConfiguration GetConfiguration(NameAffix affix) =>
            GetConfiguration(affix.Category);

        private NameAffixConfiguration GetConfiguration(string category) =>
            config.GetValueOrDefault(category, _defaultConfig);
    }

    /// <summary>
    /// Prefixes candidate names that start with a number.
    /// This is required because C# identifiers cannot start with a number.
    /// </summary>
    private class PrefixIfStartsWithNumberProcessor : INameProcessor
    {
        public void ProcessNames(NameProcessorContext context)
        {
            foreach (var (scope, members) in context.Scopes)
            {
                foreach (var (original, (primary, secondary)) in members)
                {
                    for (var i = 0; i < secondary.Count; i++)
                    {
                        secondary[i] = NameUtils.PrefixIfStartsWithNumber(secondary[i]);
                    }

                    members[original] = new CandidateNames(
                        NameUtils.PrefixIfStartsWithNumber(primary),
                        secondary
                    );
                }
            }
        }
    }

    /// <summary>
    /// Resolves conflicts where multiple names have been transformed into the same output name.
    /// This also considers cases where the methods with the same name are compatible because of method overloading rules.
    /// </summary>
    private class ResolveConflictsProcessor(NameDataVisitor nameData, ILogger logger)
        : INameProcessor
    {
        public void ProcessNames(NameProcessorContext context)
        {
            // foreach (var candidateScope in candidateScopes)
            // {
            //     // TODO: This is a temporary shim. Consider removing/moving
            //     // TODO: Currently this combines both methods and non-methods. This doesn't matter *here* anymore, but IdentifiedSharedPrefixes should consider splitting scopes by methods and non-methods
            //     // TODO: Also, when moving this code ensure that this is done per scope instead of globally for all scopes
            //     var methods = visitor
            //         .Scopes[candidateScope.Key]
            //         .Where(y => y.Value.MethodDeclarations != null)
            //         .ToDictionary(
            //             // Method name
            //             y => y.Key,
            //             // Method declarations
            //             IEnumerable<MethodDeclarationSyntax> (y) => y.Value.MethodDeclarations!
            //         );
            //
            //     if (methods.Count == 0)
            //     {
            //         methods = null;
            //     }
            //
            //     ProcessNames(context, nameProcessors, cfg.NameOverrides, methods);
            // }

            if (namesToProcess != context.Names)
            {
                foreach (var (evalName, result) in namesToProcess)
                {
                    context.Names[evalName] = result;
                }
            }

            // Prefer shorter names
            foreach (var (_, (_, secondary)) in context.Names)
            {
                secondary.Sort((a, b) => -a.Length.CompareTo(b.Length));
            }

            // Create a mapping: Primary name -> Original name
            // Primary name refers to the primary candidate name
            // Original name refers to the original name of the member as seen in source code
            //
            // This is to account for method overloads that have the
            // same primary candidate name and original name, but different discriminators
            //
            // This usually happens with generated/transformed overloads
            var primaries = new Dictionary<string, HashSet<string>>();
            foreach (var (originalName, (primary, _)) in context.Names)
            {
                if (!primaries.TryGetValue(primary, out var originalNamesForPrimary))
                {
                    primaries[primary] = originalNamesForPrimary = [];
                }

                originalNamesForPrimary.Add(originalName);
            }

            // Unwind some names back to their secondary names if the primaries would duplicate
            // We'll use a hash set to determine whether we need to check a primary for conflicts.
            var namesToEval = primaries.Keys.ToHashSet();

            // Keep track of the method discriminators to determine whether we have incompatible overloads that need to be
            // renamed. We keep track of the first original name so that we can add it to conflictingOriginalNames when we
            // do discover a conflict (along with the original name of the actual conflict).
            var methodDiscriminators =
                new Dictionary<
                    string,
                    (string? FirstOriginalName, List<MethodDeclarationSyntax> Methods)
                >();
            var conflictingOriginalNames = new HashSet<string>();
            while (namesToEval.GetEnumerator() is var e && e.MoveNext() && e.Current is var primary)
            {
                // ^-- We can't use a foreach loop because we're mutating below.
                // We're also using GetEnumerator instead of First to avoid allocations.

                // First, let's check whether we have any conflicting discriminators.
                // If we don't, we can mark this as all good right away.
                methodDiscriminators.Clear();
                conflictingOriginalNames.Clear();
                var originalNamesForOldPrimary = primaries[primary];

                // Function-specific logic where some conflicts are okay,
                // so we have to evaluate each signature to see
                // if we can discriminate each one such that there are no conflicts.
                //
                // An example of where this is the case is e.g. alGetBufferf/alGetBufferfv - signatures are identical.
                var nMethodConflicts = 0;
                var nMethods = 0;
                var nNoSecondaries = 0; // <-- at least all but one needs to have a secondary to resolve conflicts
                string? noSecondaryOriginalName = null;
                // TODO: Rewrite this logic to account for the fact that non-methods are also mixed in here now
                foreach (var originalNameToEval in originalNamesForOldPrimary)
                {
                    // Do we even have a secondary to fall back on if there is a conflict?
                    if (context.Names[originalNameToEval].Secondary.Count == 0)
                    {
                        noSecondaryOriginalName ??= originalNameToEval;
                        nNoSecondaries++;
                    }

                    if (
                        methods is not null
                        && methods.TryGetValue(originalNameToEval, out var methodDeclarations)
                    )
                    {
                        foreach (var methodDeclaration in methodDeclarations)
                        {
                            var discriminator = ModUtils.GetMethodDiscriminator(
                                methodDeclaration.Modifiers,
                                methodDeclaration.TypeParameterList,
                                primary,
                                methodDeclaration.ParameterList,
                                returnType: null
                            );

                            if (
                                !methodDiscriminators.TryGetValue(
                                    discriminator,
                                    out var methodDiscriminator
                                )
                            )
                            {
                                methodDiscriminators[discriminator] = methodDiscriminator = (
                                    originalNameToEval,
                                    []
                                );
                            }

                            var (firstOriginalName, discriminatorMatches) = methodDiscriminator;

                            discriminatorMatches.Add(methodDeclaration);
                            nMethods++;

                            // NOTE: The number of conflicts influences how we go about conflict resolution. See the
                            // logic below all of these loops just in case this comment is out of date, but at time of
                            // writing if 50% or more of the methods with this primary name are conflicting then we
                            // rename all of them, otherwise we rename only the conflicting overloads.
                            nMethodConflicts += discriminatorMatches.Count switch
                            {
                                2 => 2, // The original needs to be counted as a conflict in addition to this conflict
                                > 2 => 1, // Just mark this conflict, original is already counted.
                                _ => 0, // No conflict to see here (not yet anyway, call it Schrodinger's Conflict)
                            };

                            if (discriminatorMatches.Count == 2 && firstOriginalName is not null)
                            {
                                conflictingOriginalNames.Add(firstOriginalName);
                            }

                            if (discriminatorMatches.Count > 1)
                            {
                                conflictingOriginalNames.Add(originalNameToEval);
                            }
                        }
                    }
                }

                // If we're checking methods for conflicts and in our travels we've discovered that there are in fact
                // no conflicts, we can bail out early here.
                if (nMethods > 0 && (methodDiscriminators.Count == 0 || nMethodConflicts == 0))
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

                var renameOnlyConflicts = nMethodConflicts <= nMethods / 2.0;

                // We can afford to leave one API alone. If that place isn't already filled by a method without a secondary
                // name then we should fill it with whatever has the shortest original name. The logic being that the more
                // characters (i.e. longer suffix) a name has, the more discriminatory/important that name is ergo the
                // reverse (the shorter the name, the less discriminatory/important it is) is also true.
                string? first = null;
                var primaryClaimed = noSecondaryOriginalName is not null;
                namesToEval.Remove(primary); // <-- just in case the below loop somehow produces the same primary again.
                foreach (
                    var conflictingOriginalName in (
                        renameOnlyConflicts ? conflictingOriginalNames : primaries[primary]
                    ).OrderBy(x => x.Length)
                )
                {
                    // Do not rename if this is the original name that does not have a secondary.
                    if (noSecondaryOriginalName == conflictingOriginalName)
                    {
                        continue;
                    }

                    // If the current primary hasn't been "claimed" by an original name without a secondary, we only want
                    // to let the shortest name claim it (per the logic described in the last comment) if it is actually
                    // the absolute shortest name and not joint-1st for that title. Therefore, the first original name
                    // is saved for the second iteration where we'll make that judgement call and handle both at the
                    // same time.
                    if (first is null)
                    {
                        first = conflictingOriginalName;
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
                        if (first.Length == conflictingOriginalName.Length)
                        {
                            // Update the output name.
                            var firstSecondary =
                                context.Names[first].Secondary
                                ?? throw new InvalidOperationException(
                                    "More than one original member name without secondary names."
                                );
                            var firstNextPrimary = firstSecondary[^1];
                            firstSecondary.RemoveAt(firstSecondary.Count - 1);
                            context.Names[first] = new CandidateNames(
                                firstNextPrimary,
                                firstSecondary
                            );

                            // Update our primary to original name map
                            if (
                                !primaries.TryGetValue(
                                    firstNextPrimary,
                                    out var originalNamesForFirst
                                )
                            )
                            {
                                primaries[firstNextPrimary] = originalNamesForFirst = [];
                            }

                            originalNamesForFirst.Add(first);
                            originalNamesForOldPrimary.Remove(first);
                            if (originalNamesForOldPrimary.Count == 0)
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
                        context.Names[conflictingOriginalName].Secondary
                        ?? throw new InvalidOperationException(
                            "More than one original member name without secondary names."
                        );
                    var nextPrimary = secondary[^1];
                    secondary.RemoveAt(secondary.Count - 1);
                    context.Names[conflictingOriginalName] = new CandidateNames(
                        nextPrimary,
                        secondary
                    );

                    // Update our primary to original name map
                    if (!primaries.TryGetValue(nextPrimary, out var originalNamesForNewPrimary))
                    {
                        primaries[nextPrimary] = originalNamesForNewPrimary = [];
                    }

                    originalNamesForNewPrimary.Add(conflictingOriginalName);
                    originalNamesForOldPrimary.Remove(conflictingOriginalName);
                    if (originalNamesForOldPrimary.Count == 0)
                    {
                        primaries.Remove(primary);
                    }

                    // Make sure we do a pass over the new primary just in case we already have APIs with that primary
                    namesToEval.Add(nextPrimary);
                    if (logger.IsEnabled(LogLevel.Trace)) // <-- prevent needless string.Join
                    {
                        logger.LogTrace(
                            "{}: {} -> {} (remaining secondaries: {})",
                            conflictingOriginalName,
                            primary,
                            nextPrimary,
                            string.Join(", ", secondary)
                        );
                    }
                }
            }
        }
    }

    /// <summary>
    /// Outputs all primary names to the final set of names.
    /// </summary>
    /// <remarks>
    /// This is intentionally implemented in a naive manner.
    /// The working set of names is not cleared and existing data in the final set can be overwritten.
    /// </remarks>
    private class OutputFinalNamesProcessor : INameProcessor
    {
        public void ProcessNames(NameProcessorContext context)
        {
            foreach (var (scope, members) in context.Scopes)
            {
                if (!context.FinalNames.TryGetValue(scope, out var outputScope))
                {
                    context.FinalNames[scope] = outputScope = [];
                }

                foreach (var (member, (primary, _)) in members)
                {
                    outputScope[member] = primary;
                }
            }
        }
    }

    /// <summary>
    /// Removes all unmodified names from the final set of names.
    /// </summary>
    private class RemoveUnmodifiedFinalNamesProcessor : INameProcessor
    {
        public void ProcessNames(NameProcessorContext context)
        {
            var unmodified = new List<string>();

            // Remove unmodified members
            foreach (var (scope, members) in context.FinalNames)
            {
                unmodified.Clear();
                foreach (var (originalName, newName) in members)
                {
                    if (originalName == newName)
                    {
                        unmodified.Add(originalName);
                    }
                }

                foreach (var unmodifiedMember in unmodified)
                {
                    members.Remove(unmodifiedMember);
                }
            }

            // Remove unmodified scopes
            foreach (var (scope, members) in context.FinalNames)
            {
                if (members.Count == 0)
                {
                    unmodified.Add(scope);
                }
            }

            foreach (var unmodifiedScope in unmodified)
            {
                context.FinalNames.Remove(unmodifiedScope);
            }
        }
    }

    /// <summary>
    /// Represents a name processor.
    /// </summary>
    private interface INameProcessor
    {
        /// <summary>
        /// Process and transform the names within the given scope.
        /// </summary>
        public void ProcessNames(NameProcessorContext context);
    }

    /// <summary>
    /// State made available to <see cref="INameProcessor"/> implementations.
    /// </summary>
    private class NameProcessorContext
    {
        /// <summary>
        /// Represents a mapping: ScopeName -> (MemberName -> MemberCandidateNames).
        /// This stores the candidates for the final prettified name for each name organized by scope.
        /// Also known as the working set of names.
        /// </summary>
        public Dictionary<string, Dictionary<string, CandidateNames>> Scopes { get; }

        /// <summary>
        /// Represents a mapping: ScopeName -> (MemberName -> NewMemberName).
        /// This stores the final names for each member.
        /// </summary>
        /// <remarks>
        /// Processors are allowed to modify these, but should have a good reason in doing so.
        /// </remarks>
        public Dictionary<string, Dictionary<string, string>> FinalNames { get; } = [];

        /// <summary>
        /// Creates a new context from the scraped name data.
        /// </summary>
        public NameProcessorContext(NameDataVisitor nameData) =>
            Scopes = nameData.Scopes.ToDictionary(
                // Scope
                x => x.Key,
                x =>
                    x.Value.ToDictionary(
                        // Member name
                        y => y.Key,
                        // Member candidate names
                        y => new CandidateNames(y.Key, [])
                    )
            );
    }

    /// <summary>
    /// Represents the set of primary and secondary candidates for the prettified version of a name.
    /// </summary>
    /// <param name="Primary">The preferred version of the output name.</param>
    /// <param name="Secondary">The fallback versions of the output name. Used in the case the primary causes conflicts.</param>
    private readonly record struct CandidateNames(string Primary, List<string> Secondary)
    {
        public override string ToString() =>
            $"(Primary={Primary}, Secondary=[{string.Join(", ", Secondary)}])";
    }
}
