// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Marks identifiers with the [NativeName] attribute.
/// </summary>
[ModConfiguration<Configuration>]
public class MarkNativeNames(IOptionsSnapshot<MarkNativeNames.Configuration> cfg) : IMod
{
    /// <summary>
    /// <see cref="MarkNativeNames"/> mod configuration.
    /// </summary>
    public record Configuration
    {
        /// <summary>
        /// Should identifiers marked with the [Transformed] attribute be included?
        /// These are ignored by default.
        /// </summary>
        public bool IncludeTransformed { get; init; } = true; // TODO: We probably want this to be false by default. Leaving as true during development though.

        // TODO: Probably add an exclude regex list
    }

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var config = cfg.Get(ctx.JobKey);

        var proj = ctx.SourceProject;
        if (proj == null)
        {
            return;
        }

        var compilation = await proj.GetCompilationAsync(ct);
        if (compilation == null)
        {
            return;
        }

        var rewriter = new Rewriter(config);
        foreach (var docId in proj.DocumentIds)
        {
            var doc = proj.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            proj = doc.WithSyntaxRoot(
                rewriter.Visit(await doc.GetSyntaxRootAsync(ct))?.NormalizeWhitespace()
                ?? throw new InvalidOperationException("Visit returned null.")
            ).Project;
        }

        ctx.SourceProject = proj;
    }

    private class Rewriter(Configuration config) : ModCSharpSyntaxRewriter
    {
        private SyntaxList<AttributeListSyntax> TryAddNativeNameAttribute(SyntaxList<AttributeListSyntax> attributeLists, SyntaxToken identifier)
        {
            if (attributeLists.TryGetNativeName(out _))
            {
                return attributeLists;
            }

            var hasTransformedAttribute = attributeLists.Any(list => list.Attributes.Any(attribute => attribute.IsAttribute("Silk.NET.Core.Transformed")));
            if (hasTransformedAttribute && !config.IncludeTransformed)
            {
                return attributeLists;
            }

            return attributeLists.WithNativeName(identifier.Text);
        }

        // ----- Types -----

        /// <inheritdoc />
        public override SyntaxNode VisitStructDeclaration(StructDeclarationSyntax node)
        {
            node = node.WithAttributeLists(TryAddNativeNameAttribute(node.AttributeLists, node.Identifier));
            node = (StructDeclarationSyntax)base.VisitStructDeclaration(node)!;
            return node;
        }

        /// <inheritdoc />
        public override SyntaxNode VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            node = node.WithAttributeLists(TryAddNativeNameAttribute(node.AttributeLists, node.Identifier));
            node = (EnumDeclarationSyntax)base.VisitEnumDeclaration(node)!;
            return node;
        }

        // ----- Members -----

        /// <inheritdoc />
        public override SyntaxNode VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
        {
            node = node.WithAttributeLists(TryAddNativeNameAttribute(node.AttributeLists, node.Identifier));
            node = (EnumMemberDeclarationSyntax)base.VisitEnumMemberDeclaration(node)!;
            return node;
        }

        /// <inheritdoc />
        public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            node = node.WithAttributeLists(TryAddNativeNameAttribute(node.AttributeLists, node.Identifier));
            node = (PropertyDeclarationSyntax)base.VisitPropertyDeclaration(node)!;
            return node;
        }

        /// <inheritdoc />
        public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            node = node.WithAttributeLists(TryAddNativeNameAttribute(node.AttributeLists, node.Identifier));
            node = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node)!;
            return node;
        }

        /// <inheritdoc />
        public override SyntaxNode VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            // This just uses the first declared field's identifier in cases where a field declares multiple variables
            // Eg: int a, b;
            node = node.WithAttributeLists(TryAddNativeNameAttribute(node.AttributeLists, node.Declaration.Variables.First().Identifier));
            node = (FieldDeclarationSyntax)base.VisitFieldDeclaration(node)!;
            return node;
        }

        // ----- Other -----

        public override SyntaxNode VisitParameter(ParameterSyntax node)
        {
            node = node.WithAttributeLists(TryAddNativeNameAttribute(node.AttributeLists, node.Identifier));
            node = (ParameterSyntax)base.VisitParameter(node)!;
            return node;
        }
    }
}
