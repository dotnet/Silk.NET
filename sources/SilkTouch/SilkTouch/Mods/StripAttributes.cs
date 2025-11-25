// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Strips matching attributes from the generated bindings.
/// </summary>
[ModConfiguration<Configuration>]
public class StripAttributes(IOptionsSnapshot<StripAttributes.Configuration> cfg) : IMod
{
    /// <summary>
    /// <see cref="StripAttributes"/> mod configuration.
    /// </summary>
    public record Configuration
    {
        /// <summary>
        /// The list of attribute types to remove. These must be exact matches.
        /// </summary>
        public HashSet<string> Remove { get; init; } = new();
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
        private SyntaxList<AttributeListSyntax> StripAttributes(SyntaxList<AttributeListSyntax> attributeLists)
        {
            var results = attributeLists
                .Select(list =>
                {
                    var attributes = list.Attributes;
                    attributes = [..attributes.Where(attribute => !config.Remove.Contains(attribute.Name.ToString()))];

                    return attributes.Count == 0 ? null : list.WithAttributes(attributes);
                })
                .Where(list => list != null)
                .Cast<AttributeListSyntax>();

            return List(results);
        }

        // ----- Types -----

        /// <inheritdoc />
        public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            node = node.WithAttributeLists(StripAttributes(node.AttributeLists));
            node = (ClassDeclarationSyntax)base.VisitClassDeclaration(node)!;
            return node;
        }

        /// <inheritdoc />
        public override SyntaxNode VisitStructDeclaration(StructDeclarationSyntax node)
        {
            node = node.WithAttributeLists(StripAttributes(node.AttributeLists));
            node = (StructDeclarationSyntax)base.VisitStructDeclaration(node)!;
            return node;
        }

        /// <inheritdoc />
        public override SyntaxNode VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            node = node.WithAttributeLists(StripAttributes(node.AttributeLists));
            node = (EnumDeclarationSyntax)base.VisitEnumDeclaration(node)!;
            return node;
        }

        public override SyntaxNode VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
        {
            node = node.WithAttributeLists(StripAttributes(node.AttributeLists));
            node = (InterfaceDeclarationSyntax)base.VisitInterfaceDeclaration(node)!;
            return node;
        }

        public override SyntaxNode VisitRecordDeclaration(RecordDeclarationSyntax node)
        {
            node = node.WithAttributeLists(StripAttributes(node.AttributeLists));
            node = (RecordDeclarationSyntax)base.VisitRecordDeclaration(node)!;
            return node;
        }

        public override SyntaxNode VisitDelegateDeclaration(DelegateDeclarationSyntax node)
        {
            node = node.WithAttributeLists(StripAttributes(node.AttributeLists));
            node = (DelegateDeclarationSyntax)base.VisitDelegateDeclaration(node)!;
            return node;
        }

        // ----- Members -----

        /// <inheritdoc />
        public override SyntaxNode VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
        {
            node = node.WithAttributeLists(StripAttributes(node.AttributeLists));
            node = (EnumMemberDeclarationSyntax)base.VisitEnumMemberDeclaration(node)!;
            return node;
        }

        /// <inheritdoc />
        public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            node = node.WithAttributeLists(StripAttributes(node.AttributeLists));
            node = (PropertyDeclarationSyntax)base.VisitPropertyDeclaration(node)!;
            return node;
        }

        /// <inheritdoc />
        public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            node = node.WithAttributeLists(StripAttributes(node.AttributeLists));
            node = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node)!;
            return node;
        }

        /// <inheritdoc />
        public override SyntaxNode VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            // This just uses the first declared field's identifier in cases where a field declares multiple variables
            // Eg: int a, b;
            node = node.WithAttributeLists(StripAttributes(node.AttributeLists));
            node = (FieldDeclarationSyntax)base.VisitFieldDeclaration(node)!;
            return node;
        }

        public override SyntaxNode VisitEventDeclaration(EventDeclarationSyntax node)
        {
            node = node.WithAttributeLists(StripAttributes(node.AttributeLists));
            node = (EventDeclarationSyntax)base.VisitEventDeclaration(node)!;
            return node;
        }

        public override SyntaxNode VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
        {
            node = node.WithAttributeLists(StripAttributes(node.AttributeLists));
            node = (ConstructorDeclarationSyntax)base.VisitConstructorDeclaration(node)!;
            return node;
        }

        public override SyntaxNode VisitDestructorDeclaration(DestructorDeclarationSyntax node)
        {
            node = node.WithAttributeLists(StripAttributes(node.AttributeLists));
            node = (DestructorDeclarationSyntax)base.VisitDestructorDeclaration(node)!;
            return node;
        }

        // ----- Other -----

        public override SyntaxNode VisitParameter(ParameterSyntax node)
        {
            node = node.WithAttributeLists(StripAttributes(node.AttributeLists));
            node = (ParameterSyntax)base.VisitParameter(node)!;
            return node;
        }
    }
}
