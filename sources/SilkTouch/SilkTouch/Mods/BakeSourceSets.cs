// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Configuration;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Mods.Bakery;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Merges the APIs of multiple source sets into a single source set.
/// </summary>
/// <param name="documentFactory">The document factory to use.</param>
/// <param name="logger">The logger to use.</param>
/// <param name="config">The configuration snapshot.</param>
/// <param name="strategies">
/// The available bake strategies. The actual strategy to use is determined from the configuration.
/// </param>
public class BakeSourceSets(
    DocumentFactory documentFactory,
    ILogger<BakeSourceSets> logger,
    BakeSourceSets.Configuration config,
    IEnumerable<IBakeStrategy> strategies
) : IMod
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

    private class Rewriter(IBakeStrategy strategy, ILogger<BakeSourceSets> logger)
        : CSharpSyntaxRewriter
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
            Report(
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
            Report(node, node.Identifier.ToString(), base.VisitEventDeclaration);

        public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node) =>
            Report(node, node.Identifier.ToString(), base.VisitPropertyDeclaration);

        public override SyntaxNode? VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node) =>
            Report(node, node.Identifier.ToString(), base.VisitEnumMemberDeclaration);

        public override SyntaxNode? VisitIndexerDeclaration(IndexerDeclarationSyntax node) =>
            Report(
                node,
                $"this[{string.Join(", ", node.ParameterList.Parameters.Select(ModUtils.GetMethodDiscriminator))}]",
                base.VisitIndexerDeclaration
            );

        public override SyntaxNode? VisitVariableDeclarator(VariableDeclaratorSyntax node) =>
            node.FirstAncestorOrSelf<BaseFieldDeclarationSyntax>() is { } baseFld
            && node.FirstAncestorOrSelf<VariableDeclarationSyntax>() is { } varDecl
                ? Report(
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
            Report(
                node,
                ModUtils.GetMethodDiscriminator(
                    node.Modifiers,
                    null,
                    string.Empty,
                    node.ParameterList,
                    null
                ),
                base.VisitConstructorDeclaration
            );

        public override SyntaxNode? VisitDestructorDeclaration(DestructorDeclarationSyntax node) =>
            Report(node, "~", base.VisitDestructorDeclaration);

        public override SyntaxNode? VisitOperatorDeclaration(OperatorDeclarationSyntax node) =>
            Report(
                node,
                ModUtils.GetMethodDiscriminator(
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
            Report(
                node,
                ModUtils.GetMethodDiscriminator(
                    node.Modifiers,
                    null,
                    $"op_{node.ImplicitOrExplicitKeyword.Kind()}",
                    node.ParameterList,
                    node.Type
                ),
                base.VisitConversionOperatorDeclaration
            );

        public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node) =>
            Report(
                node,
                ModUtils.GetMethodDiscriminator(
                    node.Modifiers,
                    node.TypeParameterList,
                    node.Identifier.ToString(),
                    node.ParameterList,
                    node.ReturnType
                ),
                base.VisitMethodDeclaration
            );

        public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node) =>
            ReportType(node, base.VisitStructDeclaration);

        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node) =>
            ReportType(node, base.VisitClassDeclaration);

        public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node) =>
            ReportType(node, base.VisitEnumDeclaration);

        public override SyntaxNode? VisitRecordDeclaration(RecordDeclarationSyntax node) =>
            ReportType(node, base.VisitRecordDeclaration);

        public override SyntaxNode? VisitInterfaceDeclaration(InterfaceDeclarationSyntax node) =>
            ReportType(node, base.VisitInterfaceDeclaration);

        private SyntaxNode? ReportType<T>(T node, Func<T, SyntaxNode?> @base)
            where T : BaseTypeDeclarationSyntax
        {
            @base(node);

            // Get this type's bake set for some final validation checks.
            // This also registers the bake set if the type had no members.
            GetOrRegisterTypeBakeSet(node);

            return null; // baking erases, but the caller should know that.
        }

        private SyntaxNode? Report<T>(T node, string discrim, Func<T, SyntaxNode?> @base)
            where T : MemberDeclarationSyntax => Report(node, node, discrim, @base);

        /// <param name="nodeToAdd">The logical representation of the node that we plan to output.</param>
        /// <param name="nodeVisiting">The node as it exists in the syntax tree.</param>
        /// <param name="discrim">The discriminator used for identifying the node.</param>
        /// <param name="visitChildren">The method used to visit the <see cref="nodeVisiting"/>'s child nodes.</param>
        /// <remarks>
        /// Field declaration syntax nodes can contain multiple variable declarators (eg: public int a, b, c;).
        /// This method deduplicates the member handling code by treating the nodeToAdd and nodeVisiting separately.
        /// This effectively treats each variable declarator as their own field declaration.
        /// </remarks>
        private SyntaxNode? Report<TSeparated, TVisiting>(
            TSeparated nodeToAdd,
            TVisiting nodeVisiting,
            string discrim,
            Func<TVisiting, SyntaxNode?> visitChildren
        )
            where TSeparated : MemberDeclarationSyntax
            where TVisiting : SyntaxNode
        {
            // First, call the base visitor logic.
            _ = visitChildren(nodeVisiting);

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

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        if (ctx.SourceProject is null)
        {
            return;
        }

        // Locate the bake strategy the user's after.
        var strategy = strategies.FirstOrDefault(x =>
            x.Name == config.Strategy
            || (config.Strategy is null && x.GetType() == typeof(DefaultBakeStrategy))
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
            var srcSet = config
                .SourceSets.Where(x => path.StartsWith(x.Key, StringComparison.OrdinalIgnoreCase))
                .MaxBy(x => x.Key.Length);
            rewriter.SourceSet = srcSet.Key;

            logger.LogDebug("Identified profile {} for {}", rewriter.SourceSet, path);
            var discrim = srcSet.Value.Trim('/');
            if (!bakery.TryGetValue(discrim, out var bakeSet))
            {
                bakeSet = bakery[discrim] = new BakeSet();
            }

            rewriter.Baked = bakeSet;
            baked.Add(path);

            rewriter.Visit(root);
            rewriter.Baked = null;
            rewriter.SourceSet = null;
        }

        var proj = ctx.SourceProject.RemoveDocuments([
            .. ctx
                .SourceProject.Documents.Where(x =>
                    x.RelativePath() is { } rp && baked.Contains(rp)
                )
                .Select(x => x.Id),
        ]);
        foreach (var (bakedRoot, bakedPath) in GetBaked(bakery).Select(x => (x.Value, path: x.Key)))
        {
            proj = proj.AddDocument(
                Path.GetFileName(bakedPath),
                documentFactory.PopulateDocument(bakedRoot),
                // we can forgive the below nulls because RelativePath checks them, and returns null if they're null.
                filePath: proj.FullPath(bakedPath)
            ).Project;
        }

        ctx.SourceProject = proj;
    }

    private IEnumerable<KeyValuePair<string, CompilationUnitSyntax>> GetBaked(
        Dictionary<string, BakeSet> bakery
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
                    $"{subdir}/{documentFactory.PathForFullyQualified(fqTopLevelType)}",
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
                                .Select(x => Bake(x).Syntax)
                                ?? []
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
                                .OfType<EnumMemberDeclarationSyntax>()
                                ?? []
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
