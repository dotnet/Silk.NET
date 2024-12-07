using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Mods.Bakery;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Merging the APIs of multiple source sets into a single source set.
/// </summary>
/// <param name="logger">The logger to use.</param>
/// <param name="config">The configuration snapshot.</param>
/// <param name="strategies">
/// The available bake strategies. The actual strategy to use is determined from the configuration.
/// </param>
[ModConfiguration<Configuration>]
public class BakeSourceSets(
    ILogger<BakeSourceSets> logger,
    IOptionsSnapshot<BakeSourceSets.Configuration> config,
    IEnumerable<IJobDependency<IBakeStrategy>> strategies
) : Mod
{
    /// <summary>
    /// The mod configuration.
    /// </summary>
    public record Configuration
    {
        /// <summary>
        /// The <see cref="IBakeStrategy" /> to use.
        /// </summary>
        public string? Strategy { get; init; }

        /// <summary>
        /// The source sets to bake/merge.
        /// </summary>
        public required Dictionary<string, string> SourceSets { get; init; }
    }

    class Rewriter(IBakeStrategy strategy, ILogger<BakeSourceSets> logger) : ModCSharpSyntaxRewriter
    {
        public BakeSet? Baked { get; set; }

        public string? SourceSet { get; set; }

        // Allowable type members for baking (we need to override these):
        // - [x] FieldDeclarationSyntax (VariableDeclarator)
        // - [x] EventFieldDeclarationSyntax
        // - [x] EventDeclarationSyntax
        // - [x] IndexerDeclarationSyntax
        // - [x] PropertyDeclarationSyntax
        // - [x] DelegateDeclarationSyntax
        // - [x] BaseMethodDeclarationSyntax:
        //     - [x] ConstructorDeclarationSyntax
        //     - [x] ConversionOperatorDeclarationSyntax
        //     - [x] DestructorDeclarationSyntax
        //     - [x] MethodDeclarationSyntax
        //     - [x] OperatorDeclarationSyntax
        // - [x] EnumMemberDeclarationSyntax
        //
        // Additional allowed members (done for free by GetOrRegisterTypeBakeSet)
        // - [x] StructDeclarationSyntax
        // - [x] ClassDeclarationSyntax
        // - [x] EnumDeclarationSyntax
        // - [x] RecordDeclarationSyntax
        // - [x] InterfaceDeclarationSyntax

        public override SyntaxNode? VisitDelegateDeclaration(DelegateDeclarationSyntax node) =>
            Visit(
                node,
                node.Identifier
                    + (
                        node is { TypeParameterList.Parameters.Count: > 0 and var cnt }
                            ? $"`{cnt}"
                            : string.Empty
                    ),
                base.VisitDelegateDeclaration
            );

        public override SyntaxNode? VisitEventDeclaration(EventDeclarationSyntax node) =>
            Visit(node, node.Identifier.ToString(), base.VisitEventDeclaration);

        public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node) =>
            Visit(node, node.Identifier.ToString(), base.VisitPropertyDeclaration);

        public override SyntaxNode? VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node) =>
            Visit(node, node.Identifier.ToString(), base.VisitEnumMemberDeclaration);

        public override SyntaxNode? VisitIndexerDeclaration(IndexerDeclarationSyntax node) =>
            Visit(
                node,
                $"this[{string.Join(", ", node.ParameterList.Parameters.Select(ModUtils.DiscrimStr))}]",
                base.VisitIndexerDeclaration
            );

        public override SyntaxNode? VisitVariableDeclarator(VariableDeclaratorSyntax node) =>
            node.FirstAncestorOrSelf<BaseFieldDeclarationSyntax>() is { } baseFld
            && node.FirstAncestorOrSelf<VariableDeclarationSyntax>() is { } varDecl
                ? Visit(
                    // We want to add just this one specific individual standalone field.
                    baseFld.WithDeclaration(varDecl.WithVariables(SingletonSeparatedList(node))),
                    // But we're visiting the inner declarator representing that field.
                    node,
                    node.Identifier.ToString(),
                    // And if for whatever reason we can't continue on with the baking logic, we carry on to the base
                    // inner declarator visitation logic as usual.
                    base.VisitVariableDeclarator
                )
                : base.VisitVariableDeclarator(node);

        public override SyntaxNode? VisitConstructorDeclaration(
            ConstructorDeclarationSyntax node
        ) =>
            Visit(
                node,
                ModUtils.DiscrimStr(node.Modifiers, null, string.Empty, node.ParameterList, null),
                base.VisitConstructorDeclaration
            );

        public override SyntaxNode? VisitDestructorDeclaration(DestructorDeclarationSyntax node) =>
            Visit(node, "~", base.VisitDestructorDeclaration);

        public override SyntaxNode? VisitOperatorDeclaration(OperatorDeclarationSyntax node) =>
            Visit(
                node,
                ModUtils.DiscrimStr(
                    node.Modifiers,
                    null,
                    $"op_{node.OperatorToken.Kind()}",
                    node.ParameterList,
                    node.ReturnType
                ),
                base.VisitOperatorDeclaration
            );

        public override SyntaxNode? VisitConversionOperatorDeclaration(
            ConversionOperatorDeclarationSyntax node
        ) =>
            Visit(
                node,
                ModUtils.DiscrimStr(
                    node.Modifiers,
                    null,
                    $"op_{node.ImplicitOrExplicitKeyword.Kind()}",
                    node.ParameterList,
                    node.Type
                ),
                base.VisitConversionOperatorDeclaration
            );

        public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node) =>
            Visit(
                node,
                ModUtils.DiscrimStr(
                    node.Modifiers,
                    node.TypeParameterList,
                    node.Identifier.ToString(),
                    node.ParameterList,
                    node.ReturnType
                ),
                base.VisitMethodDeclaration
            );

        public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node) =>
            VisitType(node, base.VisitStructDeclaration);

        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node) =>
            VisitType(node, base.VisitClassDeclaration);

        public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node) =>
            VisitType(node, base.VisitEnumDeclaration);

        public override SyntaxNode? VisitRecordDeclaration(RecordDeclarationSyntax node) =>
            VisitType(node, base.VisitRecordDeclaration);

        public override SyntaxNode? VisitInterfaceDeclaration(InterfaceDeclarationSyntax node) =>
            VisitType(node, base.VisitInterfaceDeclaration);

        private SyntaxNode? VisitType<T>(T node, Func<T, SyntaxNode?> @base)
            where T : BaseTypeDeclarationSyntax
        {
            @base(node);

            // Get this type's bake set for some final validation checks.
            // This also registers the bake set if the type had no members.
            GetOrRegisterTypeBakeSet(node);

            return null; // baking erases, but the caller should know that.
        }

        private SyntaxNode? Visit<T>(T node, string discrim, Func<T, SyntaxNode?> @base)
            where T : MemberDeclarationSyntax => Visit(node, node, discrim, @base);

        // This is super convoluted but to deduplicate the member handling code for fields (wherein one field decl may
        // have many declarators of logically independent fields) we separate nodeToAdd vs nodeVisiting. Most of the
        // time these will be the same, but for fields we will be wanting to add a field representing that one
        // individual field whereas we're actually visiting the declarator for that individual field (because if we
        // tried to add the field decl as nodeVisiting directly we'd be adding 3 fields in one)
        private SyntaxNode? Visit<TSeparated, TVisiting>(
            TSeparated nodeToAdd,
            TVisiting nodeVisiting,
            string discrim,
            Func<TVisiting, SyntaxNode?> @base
        )
            where TSeparated : MemberDeclarationSyntax
            where TVisiting : SyntaxNode
        {
            // First, call the base visitor logic.
            var retNode = @base(nodeVisiting);

            logger.LogTrace(
                "Baking item for source set at \"{}\" with discriminator \"{}\": {}",
                SourceSet,
                discrim,
                nodeToAdd
            );

            var parent = GetOrRegisterAncestorBakeSet(nodeVisiting);

            // Update the bake set. This adds if we haven't seen the member before, otherwise we just update the
            // existing declaration by adding our attribute list.
            parent.Children[discrim] = new BakedMember(
                strategy.BakeMember(
                    nodeToAdd,
                    discrim,
                    parent.Children.TryGetValue(discrim, out var baked) ? baked : null
                ),
                null,
                baked.Syntax is null ? parent.Children.Count : baked.Index
            );

            return null; // erase it, but the caller should know to do that anyway.
        }

        private BakeSet GetOrRegisterAncestorBakeSet(SyntaxNode node) =>
            node.Parent is null
                ? Baked ?? throw new InvalidOperationException("BakeSet not set")
                : GetOrRegisterTypeBakeSet(node.Parent);

        private BakeSet GetOrRegisterTypeBakeSet(SyntaxNode node)
        {
            var nsPre = node.NamespaceFromSyntaxNode() is { Length: > 0 } ns
                ? $"{ns}."
                : string.Empty;
            var bakeSet = Baked ?? throw new InvalidOperationException("BakeSet not set");

            // To handle nested types, we go through each ancestor (starting from the top, hence the reverse) and get
            // the bake set (or create if needed), and do this for each ancestor until we finally get to the containing
            // type of the given node.
            foreach (
                var decl in node.AncestorsAndSelf().OfType<BaseTypeDeclarationSyntax>().Reverse()
            )
            {
                var discrim = $"{nsPre}{decl.Identifier}";
                if (
                    decl is TypeDeclarationSyntax
                    {
                        TypeParameterList.Parameters.Count: > 0 and var cnt
                    }
                )
                {
                    discrim += $"`{cnt}";
                }
                nsPre = string.Empty; // only the top-level type shall be prefixed with the namespace
                bakeSet = (
                    bakeSet!.Children[discrim] = new BakedMember(
                        strategy.BakeMember(
                            decl,
                            discrim,
                            bakeSet.Children.TryGetValue(discrim, out var baked) ? baked : null
                        ),
                        baked.Inner ?? new BakeSet(),
                        baked.Syntax is null ? bakeSet.Children.Count : baked.Index
                    )
                ).Inner;
            }

            return bakeSet!;
        }
    }

    /// <summary>
    /// A map of baked roots to deduplicated <see cref="MemberDeclarationSyntax"/>es and their associated discriminants.
    /// </summary>
    private Dictionary<string, BakeSet> _baked = new();

    /// <inheritdoc />
    public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        await base.ExecuteAsync(ctx, ct);
        if (ctx.SourceProject is null)
        {
            return;
        }

        var cfg = config.Get(ctx.JobKey);

        // Locate the bake strategy the user's after.
        var strategy = strategies
            .SelectMany(x => x.Get(ctx.JobKey))
            .FirstOrDefault(x =>
                x.Name == cfg.Strategy
                || (cfg.Strategy is null && x.GetType() == typeof(DefaultBakeStrategy))
            );
        if (strategy is null)
        {
            throw new ConfigurationErrorsException(
                "The strategy referenced in the configuration was not found."
            );
        }

        var rewriter = new Rewriter(strategy, logger);
        var bakery = new Dictionary<string, BakeSet>();
        var baked = new List<string>();
        var aggregatedUsings = new Dictionary<string, UsingDirectiveSyntax>();
        foreach (var docId in ctx.SourceProject.DocumentIds)
        {
            var doc =
                ctx.SourceProject.GetDocument(docId)
                ?? throw new InvalidOperationException("Document missing");
            var path = doc.RelativePath();
            if (path is null)
            {
                continue;
            }

            var tree = await doc.GetSyntaxTreeAsync(ct);
            if (tree is null)
            {
                continue;
            }

            var root = await tree.GetRootAsync(ct);
            var srcSet = cfg
                .SourceSets.Where(x => path.StartsWith(x.Key, StringComparison.OrdinalIgnoreCase))
                .MaxBy(x => x.Key.Length);
            rewriter.SourceSet = srcSet.Key;
            if (rewriter.SourceSet is null)
            {
                continue;
            }

            logger.LogDebug("Identified profile {} for {}", rewriter.SourceSet, path);
            var discrim = srcSet.Value.Trim('/');
            if (!bakery.TryGetValue(discrim, out var bakeSet))
            {
                bakeSet = bakery[discrim] = new BakeSet();
            }

            rewriter.Baked = bakeSet;
            baked.Add(path);

            rewriter.Visit(root);
            foreach (var (k, v) in rewriter.UsingsToAdd)
            {
                aggregatedUsings.TryAdd(k, v);
            }
            rewriter.UsingsToAdd.Clear();
            rewriter.Baked = null;
            rewriter.SourceSet = null;
        }

        var proj = ctx.SourceProject.RemoveDocuments(
            [
                .. ctx
                    .SourceProject.Documents.Where(x =>
                        x.RelativePath() is { } rp && baked.Contains(rp)
                    )
                    .Select(x => x.Id),
            ]
        );
        foreach (
            var (bakedRoot, bakedPath) in GetBaked(bakery, aggregatedUsings)
                .Select(x => (x.Value, path: x.Key))
        )
        {
            proj = proj.AddDocument(
                Path.GetFileName(bakedPath),
                bakedRoot.NormalizeWhitespace(),
                // we can forgive the below nulls because RelativePath checks them, and returns null if they're null.
                filePath: proj.FullPath(bakedPath)
            ).Project;
        }

        ctx.SourceProject = proj;
    }

    private IEnumerable<KeyValuePair<string, CompilationUnitSyntax>> GetBaked(
        Dictionary<string, BakeSet> bakery,
        Dictionary<string, UsingDirectiveSyntax> aggregatedUsings
    )
    {
        foreach (var (subdir, bakeSet) in bakery)
        {
            foreach (var (fqTopLevelType, bakedMember) in bakeSet.Children)
            {
                var (iden, bakedSyntax) = Bake(bakedMember);
                if (iden is null)
                {
                    throw new InvalidOperationException(
                        "Cannot output an unidentified syntax. Top-level syntax should be type declarations only."
                    );
                }

                var ns = fqTopLevelType.LastIndexOf('.') is not -1 and var idx
                    ? fqTopLevelType[..idx]
                    : null;
                yield return new KeyValuePair<string, CompilationUnitSyntax>(
                    $"{subdir}/{PathForFullyQualified(fqTopLevelType)}",
                    CompilationUnit()
                        .WithMembers(
                            ns is null
                                ? SingletonList(bakedSyntax)
                                : SingletonList<MemberDeclarationSyntax>(
                                    FileScopedNamespaceDeclaration(
                                            ModUtils.NamespaceIntoIdentifierName(ns)
                                        )
                                        .WithMembers(SingletonList(bakedSyntax))
                                )
                        )
                        .WithUsings(ModCSharpSyntaxRewriter.GetUsings(aggregatedUsings, null))
                );
            }
        }
    }

    private static (string? Identifier, MemberDeclarationSyntax Syntax) Bake(BakedMember member) =>
        member.Syntax switch
        {
            TypeDeclarationSyntax ty => (
                ty.Identifier
                    + (
                        ty.TypeParameterList is { Parameters.Count: > 0 and var cnt }
                            ? $"`{cnt}"
                            : string.Empty
                    ),
                ty.WithMembers(
                    List(
                        ty.Members.Concat(
                            member
                                .Inner?.Children.Values.OrderBy(x => x.Index)
                                .Select(x => Bake(x).Syntax) ?? []
                        )
                    )
                )
            ),
            EnumDeclarationSyntax enumDecl => (
                enumDecl.Identifier.ToString(),
                enumDecl.WithMembers(
                    SeparatedList(
                        enumDecl.Members.Concat(
                            member
                                .Inner?.Children.Values.OrderBy(x => x.Index)
                                .Select(x => x.Syntax)
                                .OfType<EnumMemberDeclarationSyntax>() ?? []
                        )
                    )
                )
            ),
            DelegateDeclarationSyntax del => (
                del.Identifier
                    + (
                        del.TypeParameterList is { Parameters.Count: > 0 and var cnt }
                            ? $"`{cnt}"
                            : string.Empty
                    ),
                del
            ),
            var x => (null, x),
        };
}
