// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods.Scraping;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Transforms any pointers to an opaque/empty struct or pointers to a non-existent type to be "handle" type.
/// A handle type is a struct that wraps the underlying opaque pointer (or other underlying value).
/// </summary>
/// <example>
/// For the following pointer, <c>VkBuffer*</c>, a corresponding handle struct will be generated, <c>struct VkBuffer</c>.
/// Usages of that pointer will then be replaced with <c>VkBuffer</c>.
/// </example>
/// <remarks>
/// It is assumed that all handle types in the generated syntax do not require a <c>using</c> directive in order to be
/// in scope. That is, if a file with the namespace <c>Silk.NET.OpenGL</c> is encountered and it is referencing
/// <c>Program</c>, <c>Program</c> must be declared in <c>Silk.NET.OpenGL</c>, <c>Silk.NET</c>, or <c>Silk</c>.
/// When <see cref="Config.AssumeMissingTypesOpaque"/> is used, types will be generated to this effect.
/// </remarks>
[ModConfiguration<Config>]
public class TransformHandles(IOptionsSnapshot<TransformHandles.Config> config) : Mod
{
    /// <summary>
    /// The configuration for the <see cref="TransformHandles"/> mod.
    /// </summary>
    public class Config
    {
        /// <summary>
        /// Whether it should be assumed that missing types are likely opaque if they are only used as a pointer type
        /// and therefore should be subjected to handle transformations.
        /// </summary>
        public bool AssumeMissingTypesOpaque { get; init; }

        /// <summary>
        /// Whether the DSL (i.e. <c>nullptr</c>) should be usable with handle types.
        /// </summary>
        public bool UseDSL { get; init; }
    }

    /// <inheritdoc />
    public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        await base.ExecuteAsync(ctx, ct);

        var proj = ctx.SourceProject;
        var cfg = config.Get(ctx.JobKey);

        // First pass to discover any existing or missing handle types
        var discoverer = new HandleTypeDiscoverer();
        foreach (var doc in ctx.SourceProject?.Documents ?? [])
        {
            if (await doc.GetSyntaxRootAsync(ct) is { } root)
            {
                discoverer.Visit(root);
            }
        }

        // Get the discovered handle types and missing handle types
        Dictionary<string, SyntaxNode>? missingFullyQualifiedTypeNamesToRootNodes =
            cfg.AssumeMissingTypesOpaque ? [] : null;
        var handles = discoverer.GetHandleTypes(missingFullyQualifiedTypeNamesToRootNodes);
        if (missingFullyQualifiedTypeNamesToRootNodes is not null)
        {
            // // Generate missing handle types
            // foreach (var (fqTypeName, node) in missingFullyQualifiedTypeNamesToRootNodes)
            // {
            //     var rel = $"Handles/{PathForFullyQualified(fqTypeName)}";
            //     proj = proj
            //         ?.AddDocument(
            //             Path.GetFileName(rel),
            //             node.NormalizeWhitespace(),
            //             filePath: proj.FullPath(rel)
            //         )
            //         .Project;
            // }
        }

        // Before the execution of this foreach loop, the handle structs are empty
        //
        // During this foreach loop, we do two things:
        // 1. Rewrite all type references to refer to the handle structs
        // 2. Add members to handle structs (as identified the handles variable)
        var rewriter = new Rewriter(handles, cfg.UseDSL);
        foreach (var docId in proj?.DocumentIds ?? [])
        {
            var doc =
                proj?.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            if (await doc.GetSyntaxRootAsync(ct) is not { } root)
            {
                continue;
            }

            doc = doc.WithSyntaxRoot(rewriter.Visit(root).NormalizeWhitespace());
            var effectiveName = ModUtils.GetEffectiveName(doc.FilePath).ToString();

            // Add "Handle" suffix if the document represents a handle struct
            if (handles.ContainsKey(effectiveName))
            {
                doc = doc.WithFilePath(
                        doc.FilePath!.Replace(effectiveName, $"{effectiveName}Handle")
                    )
                    .WithName(doc.Name.Replace(effectiveName, $"{effectiveName}Handle"));
            }

            proj = doc.Project;
        }

        ctx.SourceProject = proj;
    }

    class Rewriter(Dictionary<string, Dictionary<string, string>> handles, bool useDSL)
        : CSharpSyntaxRewriter
    {
        /// <summary>
        /// The current scope i.e. fully qualified type name.
        /// </summary>
        private string _currentScope = string.Empty;

        private bool _isPointerType;
        private bool _derefPtr;

        private SyntaxNode? VisitType<T>(T type, SyntaxToken identifier, Func<T, SyntaxNode?> @base)
            where T : SyntaxNode
        {
            var before = _currentScope;
            _currentScope = string.IsNullOrWhiteSpace(_currentScope)
                ? $"{type.NamespaceFromSyntaxNode()}.{identifier}"
                : $"{_currentScope}.{identifier}";
            var ret = @base(type);
            _currentScope = before;
            return ret;
        }

        public override SyntaxNode? VisitPointerType(PointerTypeSyntax node)
        {
            if (HandleTypeDiscoverer.SkipTypeNode(node))
            {
                return node;
            }
            var before = _isPointerType;
            _isPointerType = true;
            var ret = base.VisitPointerType(node);
            _isPointerType = before;
            if (_derefPtr && ret is PointerTypeSyntax ptr)
            {
                ret = ptr.ElementType;
            }

            _derefPtr = false;
            return ret;
        }

        public override SyntaxNode VisitGenericName(GenericNameSyntax node) => node;

        public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
        {
            if (HandleTypeDiscoverer.SkipTypeNode(node))
            {
                return node;
            }

            _derefPtr =
                handles.TryGetValue(node.Identifier.ToString(), out var applicableScopes)
                && applicableScopes.ContainsKey(_currentScope);
            return _derefPtr ? node.WithIdentifier(Identifier($"{node.Identifier}Handle")) : node;
        }

        public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
        {
            if (
                handles.TryGetValue(node.Identifier.ToString(), out var scopes)
                && scopes.ContainsValue(node.NamespaceFromSyntaxNode())
            )
            {
                var self = $"{node.Identifier}Handle";
                return node.WithIdentifier(Identifier(self))
                    .WithMembers(
                        List(
                            GetDefaultMembers(self).Concat(useDSL ? GetDSLImplementation(self) : [])
                        )
                    )
                    .WithModifiers(
                        TokenList(
                            Token(SyntaxKind.PublicKeyword),
                            Token(SyntaxKind.ReadOnlyKeyword),
                            Token(SyntaxKind.UnsafeKeyword),
                            Token(SyntaxKind.PartialKeyword)
                        )
                    );
            }

            return VisitType(node, node.Identifier, base.VisitStructDeclaration);
        }

        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node) =>
            VisitType(node, node.Identifier, base.VisitClassDeclaration);

        public override SyntaxNode? VisitRecordDeclaration(RecordDeclarationSyntax node) =>
            VisitType(node, node.Identifier, base.VisitRecordDeclaration);

        public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node) =>
            VisitType(node, node.Identifier, base.VisitEnumDeclaration);

        public override SyntaxNode? VisitDelegateDeclaration(DelegateDeclarationSyntax node) =>
            VisitType(node, node.Identifier, base.VisitDelegateDeclaration);

        public override SyntaxNode? VisitInterfaceDeclaration(InterfaceDeclarationSyntax node) =>
            VisitType(node, node.Identifier, base.VisitInterfaceDeclaration);

        private static IEnumerable<MemberDeclarationSyntax> GetDefaultMembers(string self)
        {
            yield return FieldDeclaration(
                    VariableDeclaration(
                        PointerType(PredefinedType(Token(SyntaxKind.VoidKeyword))),
                        SingletonSeparatedList(VariableDeclarator("Handle"))
                    )
                )
                .WithModifiers(
                    TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.ReadOnlyKeyword))
                );
            yield return MethodDeclaration(
                    PredefinedType(Token(SyntaxKind.BoolKeyword)),
                    Identifier("Equals")
                )
                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                .WithParameterList(
                    ParameterList(
                        SingletonSeparatedList(
                            Parameter(Identifier("other")).WithType(IdentifierName(self))
                        )
                    )
                )
                .WithExpressionBody(
                    ArrowExpressionClause(
                        BinaryExpression(
                            SyntaxKind.EqualsExpression,
                            IdentifierName("Handle"),
                            MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                IdentifierName("other"),
                                IdentifierName("Handle")
                            )
                        )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            yield return MethodDeclaration(
                    PredefinedType(Token(SyntaxKind.BoolKeyword)),
                    Identifier("Equals")
                )
                .WithModifiers(
                    TokenList([Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.OverrideKeyword)])
                )
                .WithParameterList(
                    ParameterList(
                        SingletonSeparatedList(
                            Parameter(Identifier("obj"))
                                .WithType(
                                    NullableType(PredefinedType(Token(SyntaxKind.ObjectKeyword)))
                                )
                        )
                    )
                )
                .WithExpressionBody(
                    ArrowExpressionClause(
                        BinaryExpression(
                            SyntaxKind.LogicalAndExpression,
                            IsPatternExpression(
                                IdentifierName("obj"),
                                DeclarationPattern(
                                    IdentifierName(self),
                                    SingleVariableDesignation(Identifier("other"))
                                )
                            ),
                            InvocationExpression(IdentifierName("Equals"))
                                .WithArgumentList(
                                    ArgumentList(
                                        SingletonSeparatedList(Argument(IdentifierName("other")))
                                    )
                                )
                        )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            yield return MethodDeclaration(
                    PredefinedType(Token(SyntaxKind.IntKeyword)),
                    Identifier("GetHashCode")
                )
                .WithModifiers(
                    TokenList([Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.OverrideKeyword)])
                )
                .WithExpressionBody(
                    ArrowExpressionClause(
                        InvocationExpression(
                                MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    IdentifierName("HashCode"),
                                    IdentifierName("Combine")
                                )
                            )
                            .WithArgumentList(
                                ArgumentList(
                                    SingletonSeparatedList(
                                        Argument(
                                            CastExpression(
                                                IdentifierName("nuint"),
                                                IdentifierName("Handle")
                                            )
                                        )
                                    )
                                )
                            )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            yield return OperatorDeclaration(
                    PredefinedType(Token(SyntaxKind.BoolKeyword)),
                    Token(SyntaxKind.EqualsEqualsToken)
                )
                .WithModifiers(
                    TokenList([Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword)])
                )
                .WithParameterList(
                    ParameterList(
                        SeparatedList<ParameterSyntax>(
                            new SyntaxNodeOrToken[]
                            {
                                Parameter(Identifier("left")).WithType(IdentifierName(self)),
                                Token(SyntaxKind.CommaToken),
                                Parameter(Identifier("right")).WithType(IdentifierName(self))
                            }
                        )
                    )
                )
                .WithExpressionBody(
                    ArrowExpressionClause(
                        InvocationExpression(
                                MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    IdentifierName("left"),
                                    IdentifierName("Equals")
                                )
                            )
                            .WithArgumentList(
                                ArgumentList(
                                    SingletonSeparatedList(Argument(IdentifierName("right")))
                                )
                            )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            yield return OperatorDeclaration(
                    PredefinedType(Token(SyntaxKind.BoolKeyword)),
                    Token(SyntaxKind.ExclamationEqualsToken)
                )
                .WithModifiers(
                    TokenList([Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword)])
                )
                .WithParameterList(
                    ParameterList(
                        SeparatedList(
                            [
                                Parameter(Identifier("left")).WithType(IdentifierName(self)),
                                Parameter(Identifier("right")).WithType(IdentifierName(self))
                            ]
                        )
                    )
                )
                .WithExpressionBody(
                    ArrowExpressionClause(
                        PrefixUnaryExpression(
                            SyntaxKind.LogicalNotExpression,
                            InvocationExpression(
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName("left"),
                                        IdentifierName("Equals")
                                    )
                                )
                                .WithArgumentList(
                                    ArgumentList(
                                        SingletonSeparatedList(Argument(IdentifierName("right")))
                                    )
                                )
                        )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
        }

        private static IEnumerable<MemberDeclarationSyntax> GetDSLImplementation(string self)
        {
            yield return MethodDeclaration(
                    PredefinedType(Token(SyntaxKind.BoolKeyword)),
                    Identifier("Equals")
                )
                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                .WithParameterList(
                    ParameterList(
                        SingletonSeparatedList(
                            Parameter(Identifier("_")).WithType(IdentifierName("NullPtr"))
                        )
                    )
                )
                .WithExpressionBody(
                    ArrowExpressionClause(
                        IsPatternExpression(
                            IdentifierName("Handle"),
                            ConstantPattern(LiteralExpression(SyntaxKind.NullLiteralExpression))
                        )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            yield return OperatorDeclaration(
                    PredefinedType(Token(SyntaxKind.BoolKeyword)),
                    Token(SyntaxKind.EqualsEqualsToken)
                )
                .WithModifiers(
                    TokenList([Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword)])
                )
                .WithParameterList(
                    ParameterList(
                        SeparatedList<ParameterSyntax>(
                            new SyntaxNodeOrToken[]
                            {
                                Parameter(Identifier("left")).WithType(IdentifierName(self)),
                                Token(SyntaxKind.CommaToken),
                                Parameter(Identifier("right")).WithType(IdentifierName("NullPtr"))
                            }
                        )
                    )
                )
                .WithExpressionBody(
                    ArrowExpressionClause(
                        InvocationExpression(
                                MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    IdentifierName("left"),
                                    IdentifierName("Equals")
                                )
                            )
                            .WithArgumentList(
                                ArgumentList(
                                    SingletonSeparatedList(Argument(IdentifierName("right")))
                                )
                            )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            yield return OperatorDeclaration(
                    PredefinedType(Token(SyntaxKind.BoolKeyword)),
                    Token(SyntaxKind.ExclamationEqualsToken)
                )
                .WithModifiers(
                    TokenList([Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword)])
                )
                .WithParameterList(
                    ParameterList(
                        SeparatedList(
                            [
                                Parameter(Identifier("left")).WithType(IdentifierName(self)),
                                Parameter(Identifier("right")).WithType(IdentifierName("NullPtr"))
                            ]
                        )
                    )
                )
                .WithExpressionBody(
                    ArrowExpressionClause(
                        PrefixUnaryExpression(
                            SyntaxKind.LogicalNotExpression,
                            InvocationExpression(
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        IdentifierName("left"),
                                        IdentifierName("Equals")
                                    )
                                )
                                .WithArgumentList(
                                    ArgumentList(
                                        SingletonSeparatedList(Argument(IdentifierName("right")))
                                    )
                                )
                        )
                    )
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
            yield return ConversionOperatorDeclaration(
                    Token(SyntaxKind.ImplicitKeyword),
                    IdentifierName(self)
                )
                .WithModifiers(
                    TokenList([Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.StaticKeyword)])
                )
                .WithParameterList(
                    ParameterList(
                        SingletonSeparatedList(
                            Parameter(
                                    Identifier(
                                        TriviaList(),
                                        SyntaxKind.UnderscoreToken,
                                        "_",
                                        "_",
                                        TriviaList()
                                    )
                                )
                                .WithType(IdentifierName("NullPtr"))
                        )
                    )
                )
                .WithExpressionBody(
                    ArrowExpressionClause(LiteralExpression(SyntaxKind.DefaultLiteralExpression))
                )
                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken));
        }
    }
}
