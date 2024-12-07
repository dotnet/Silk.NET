// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Applies transformations to property signatures.
/// </summary>
/// <remarks>
/// Today, this only includes transforming properties like <c>static ReadOnlySpan&lt;byte&gt; Thing => "thing"u8;</c>
/// to be <c>static Utf8String Thing => "thing"u8;</c>.
/// </remarks>
public class TransformProperties : IMod
{
    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var rw = new Rewriter();
        var proj = ctx.SourceProject;
        foreach (var docId in ctx.SourceProject?.DocumentIds ?? [])
        {
            var doc =
                proj!.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            if (await doc.GetSyntaxRootAsync(ct) is { } root)
            {
                proj = doc.WithSyntaxRoot(rw.Visit(root)).Project;
            }
        }

        ctx.SourceProject = proj;
    }

    private class Rewriter : CSharpSyntaxRewriter
    {
        public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            if (
                node.Modifiers.Any(SyntaxKind.StaticKeyword)
                && node.Type
                    is GenericNameSyntax
                    {
                        TypeArgumentList.Arguments: [PredefinedTypeSyntax pt],
                        Identifier.Text: "ReadOnlySpan"
                    }
                && (
                    pt.Keyword.IsKind(SyntaxKind.ByteKeyword)
                    || pt.Keyword.IsKind(SyntaxKind.SByteKeyword)
                )
                && node.ExpressionBody is { Expression: LiteralExpressionSyntax lit }
                && lit.IsKind(SyntaxKind.Utf8StringLiteralExpression)
            )
            {
                node = node.WithType(IdentifierName("Utf8String")).NormalizeWhitespace();
            }

            return base.VisitPropertyDeclaration(node);
        }
    }
}
