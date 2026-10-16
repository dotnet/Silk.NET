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
        /// <remarks>
        /// Both the keys and values correspond to folder paths in the source project.
        /// The key defines the folder to take documents from.
        /// The value defines the folder to merge documents into.
        /// <para/>
        /// For example, at time of writing, Silk's OpenGL bindings have 4 source sets: glcompat -> gl, glcore -> gl, gles1 -> gl, gles2 -> gl.
        /// These correspond to four input folders of the same name.
        /// After baking, there will be one output folder named "gl".
        /// <para/>
        /// The input folder's internal structure does not affect the output.
        /// The output folder will contain a flattened list of documents.
        /// </remarks>
        public required Dictionary<string, string> SourceSets { get; init; }
    }

    private class Visitor(IBakeStrategy strategy) : CSharpSyntaxWalker
    {
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

        /// <summary>
        /// The baked members currently being built.
        /// Last in list is the current.
        /// </summary>
        private readonly List<BakedMember> _stack = new();

        /// <summary>
        /// The source set key to add bake sets to.
        /// </summary>
        public string? SourceSet { get; set; }

        /// <summary>
        /// The bake set containing the members of each source set.
        /// Keyed by the input source set key.
        /// </summary>
        public Dictionary<string, BakeSet> BakeSets { get; } = new();

        public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node) =>
            ReportMember(
                node,
                node.Identifier
                    + (
                        node is { TypeParameterList.Parameters.Count: > 0 and var cnt }
                            ? $"`{cnt}"
                            : string.Empty
                    ),
                base.VisitDelegateDeclaration
            );

        public override void VisitEventDeclaration(EventDeclarationSyntax node) =>
            ReportMember(node, node.Identifier.ToString(), base.VisitEventDeclaration);

        public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node) =>
            ReportMember(node, node.Identifier.ToString(), base.VisitPropertyDeclaration);

        public override void VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node) =>
            ReportMember(node, node.Identifier.ToString(), base.VisitEnumMemberDeclaration);

        public override void VisitIndexerDeclaration(IndexerDeclarationSyntax node) =>
            ReportMember(
                node,
                $"this[{string.Join(", ", node.ParameterList.Parameters.Select(ModUtils.GetMethodDiscriminator))}]",
                base.VisitIndexerDeclaration
            );

        public override void VisitVariableDeclarator(VariableDeclaratorSyntax node)
        {
            if (
                node.FirstAncestorOrSelf<BaseFieldDeclarationSyntax>() is { } baseFld
                && node.FirstAncestorOrSelf<VariableDeclarationSyntax>() is { } varDecl
            )
            {
                Report(
                    // We want to add just this one specific individual standalone field.
                    baseFld.WithDeclaration(varDecl.WithVariables(SingletonSeparatedList(node))),
                    // But we're visiting the inner declarator representing that field.
                    node,
                    node.Identifier.ToString(),
                    // And if for whatever reason we can't continue on with the baking logic, we carry on to the base
                    // inner declarator visitation logic as usual.
                    base.VisitVariableDeclarator
                );
            }
            else
            {
                base.VisitVariableDeclarator(node);
            }
        }

        public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node) =>
            ReportMember(
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

        public override void VisitDestructorDeclaration(DestructorDeclarationSyntax node) =>
            ReportMember(node, "~", base.VisitDestructorDeclaration);

        public override void VisitOperatorDeclaration(OperatorDeclarationSyntax node) =>
            ReportMember(
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

        public override void VisitConversionOperatorDeclaration(
            ConversionOperatorDeclarationSyntax node
        ) =>
            ReportMember(
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

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node) =>
            ReportMember(
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

        public override void VisitStructDeclaration(StructDeclarationSyntax node) =>
            ReportType(node, base.VisitStructDeclaration);

        public override void VisitClassDeclaration(ClassDeclarationSyntax node) =>
            ReportType(node, base.VisitClassDeclaration);

        public override void VisitEnumDeclaration(EnumDeclarationSyntax node) =>
            ReportType(node, base.VisitEnumDeclaration);

        public override void VisitRecordDeclaration(RecordDeclarationSyntax node) =>
            ReportType(node, base.VisitRecordDeclaration);

        public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node) =>
            ReportType(node, base.VisitInterfaceDeclaration);

        private void ReportType<T>(T node, Action<T> visitChildren)
            where T : BaseTypeDeclarationSyntax
        {
            var discrim = $"{node.Identifier}";
            var isTopLevel = _stack.Count == 0;
            if (isTopLevel)
            {
                var nsPre = node.NamespaceFromSyntaxNode() is { Length: > 0 } ns
                    ? $"{ns}."
                    : string.Empty;
                discrim = $"{nsPre}{discrim}";
            }

            if (
                node is TypeDeclarationSyntax
                {
                    TypeParameterList.Parameters.Count: > 0 and var cnt,
                }
            )
            {
                discrim = $"{discrim}`{cnt}";
            }

            Report(node, node, discrim, visitChildren);
        }

        private void ReportMember<T>(T node, string discrim, Action<T> visitChildren)
            where T : MemberDeclarationSyntax => Report(node, node, discrim, visitChildren);

        /// <summary>
        /// Adds the specified node to the current bake set.
        /// </summary>
        /// <param name="nodeToAdd">The logical representation of the node that we plan to output.</param>
        /// <param name="nodeVisiting">The node as it exists in the syntax tree.</param>
        /// <param name="discrim">The discriminator used for identifying the node.</param>
        /// <param name="visitChildren">The method used to visit the <paramref name="nodeVisiting"/>'s child nodes.</param>
        /// <remarks>
        /// Field declaration syntax nodes can contain multiple variable declarators (eg: public int a, b, c;).
        /// This method deduplicates the member handling code by treating the nodeToAdd and nodeVisiting separately.
        /// This effectively treats each variable declarator as their own field declaration.
        /// </remarks>
        private void Report<TSeparated, TVisiting>(
            TSeparated nodeToAdd,
            TVisiting nodeVisiting,
            string discrim,
            Action<TVisiting> visitChildren
        )
            where TSeparated : MemberDeclarationSyntax
            where TVisiting : SyntaxNode
        {
            var self = strategy.Cleanup(nodeToAdd);

            // Add self before visiting children
            if (self != null)
            {
                var parentBakedMember = _stack.Count > 0 ? _stack[^1] : null;
                var selfBakedMember = new BakedMember(
                    nodeToAdd,
                    null,
                    parentBakedMember?.Inner?.Children.Count ?? 0
                );
                if (parentBakedMember == null)
                {
                    var sourceSetKey =
                        SourceSet ?? throw new InvalidOperationException("SourceSet not set");
                    if (!BakeSets.TryGetValue(sourceSetKey, out var bakeSet))
                    {
                        BakeSets[sourceSetKey] = bakeSet = new BakeSet();
                    }

                    bakeSet.Children.Add(discrim, selfBakedMember);
                }
                else
                {
                    parentBakedMember.Inner ??= new BakeSet();
                    parentBakedMember.Inner.Children.Add(discrim, selfBakedMember);
                }

                _stack.Add(selfBakedMember);
                try
                {
                    visitChildren(nodeVisiting);
                }
                finally
                {
                    _stack.RemoveAt(_stack.Count - 1);
                }
            }
        }
    }

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        if (ctx.SourceProject is null)
        {
            return;
        }

        // Locate the configured bake strategy.
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

        // Visit each doc
        var visitor = new Visitor(strategy);
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

            // Identify the source set the document is part of
            // sourceSet is a key value pair: SourceSetFrom -> SourceSetTo
            var sourceSet = config
                .SourceSets.Where(x => path.StartsWith(x.Key, StringComparison.OrdinalIgnoreCase))
                .MaxBy(x => x.Key.Length);
            logger.LogDebug("Identified profile {} for {}", sourceSet.Key, path);

            baked.Add(path);

            visitor.SourceSet = sourceSet.Key;
            visitor.Visit(root);
        }

        // TODO
        Environment.Exit(1);

        // Remove documents that were used as baker input
        var proj = ctx.SourceProject.RemoveDocuments([
            .. ctx
                .SourceProject.Documents.Where(x =>
                    x.RelativePath() is { } rp && baked.Contains(rp)
                )
                .Select(x => x.Id),
        ]);

        // Add the final baked documents
        foreach (var (bakedRoot, bakedPath) in GetBaked(bakery).Select(x => (x.Value, path: x.Key)))
        {
            proj = proj.AddDocument(
                Path.GetFileName(bakedPath),
                documentFactory.PopulateDocument(bakedRoot),
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
