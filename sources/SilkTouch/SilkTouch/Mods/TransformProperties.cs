// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Mods.Transformation;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Applies transformations to fields and properties.
/// </summary>
/// <remarks>
/// Despite the name of the name, fields are also handled here because
/// they often need to be transformed alongside properties.
/// <para/>
/// This currently does the following transformations:
/// 1. Transform string constant properties like
/// <c>static ReadOnlySpan&lt;byte&gt; Thing => "thing"u8;</c> to be
/// <c>static Utf8String Thing => "thing"u8;</c>.
/// 2. Transform fields and properties that are recognised
/// to be akin to booleans to use the <c>MaybeBool</c> type.
/// This functionality is based on <see cref="BoolTransformer"/>.
/// </remarks>
[ModConfiguration<Configuration>]
public class TransformProperties(IOptionsSnapshot<TransformProperties.Configuration> cfg) : IMod
{
    /// <summary>
    /// Configuration for the <see cref="TransformProperties"/>.
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// Types to treat as boolean and their boolean schemes if different from the default.
        /// </summary>
        public Dictionary<string, string?> BoolTypes { get; init; } = [];
    }

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var config = cfg.Get(ctx.JobKey);

        var rw = new Rewriter(config);
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

    private class Rewriter(Configuration config) : CSharpSyntaxRewriter
    {
        public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            // Transform bool-like fields to use MaybeBool
            var nativeType =
                node.AttributeLists.GetNativeTypeName() ?? node.Declaration.Type.ToString();
            if (config.BoolTypes.TryGetValue(nativeType, out var scheme))
            {
                var newType = string.IsNullOrWhiteSpace(scheme)
                    ? GenericName(
                        Identifier("MaybeBool"),
                        TypeArgumentList(SingletonSeparatedList(node.Declaration.Type))
                    )
                    : GenericName(
                        Identifier("MaybeBool"),
                        TypeArgumentList(
                            SeparatedList(
                                // ReSharper disable once RedundantCast <-- false positive
                                (IEnumerable<TypeSyntax>)
                                    [node.Declaration.Type, IdentifierName(scheme)]
                            )
                        )
                    );

                node = node.WithDeclaration(node.Declaration.WithType(newType));
            }

            return base.VisitFieldDeclaration(node);
        }

        public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            // Transform bool-like properties to use MaybeBool
            var nativeType = node.AttributeLists.GetNativeTypeName() ?? node.Type.ToString();
            if (config.BoolTypes.TryGetValue(nativeType, out var scheme))
            {
                var newType = string.IsNullOrWhiteSpace(scheme)
                    ? GenericName(
                        Identifier("MaybeBool"),
                        TypeArgumentList(SingletonSeparatedList(node.Type))
                    )
                    : GenericName(
                        Identifier("MaybeBool"),
                        TypeArgumentList(
                            SeparatedList(
                                // ReSharper disable once RedundantCast <-- false positive
                                (IEnumerable<TypeSyntax>)[node.Type, IdentifierName(scheme)]
                            )
                        )
                    );

                node = node.WithType(newType);
            }

            // Transform ReadOnlySpan<byte> string constants to use Utf8String
            if (
                node.Modifiers.Any(SyntaxKind.StaticKeyword)
                && node.Type
                    is GenericNameSyntax
                    {
                        TypeArgumentList.Arguments: [PredefinedTypeSyntax pt],
                        Identifier.Text: "ReadOnlySpan",
                    }
                && (
                    pt.Keyword.IsKind(SyntaxKind.ByteKeyword)
                    || pt.Keyword.IsKind(SyntaxKind.SByteKeyword)
                )
                && node.ExpressionBody is { Expression: LiteralExpressionSyntax lit }
                && lit.IsKind(SyntaxKind.Utf8StringLiteralExpression)
            )
            {
                node = node.WithType(IdentifierName("Utf8String"));
            }

            return base.VisitPropertyDeclaration(node);
        }
    }
}
