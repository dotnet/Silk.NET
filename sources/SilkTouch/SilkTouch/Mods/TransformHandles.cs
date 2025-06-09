// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.FindSymbols;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Identifies handle types by finding pointers to empty structs.
/// In general, a handle type is a struct that wraps an underlying opaque pointer (or some other underlying value).
/// These handle types are then transformed by making the struct wrap the underlying pointer and
/// reducing the dimension of pointers referencing that handle type by one.
/// </summary>
/// <example>
/// Given an empty struct, <c>struct VkBuffer</c>, and all usages of that struct are through a pointer,
/// <c>VkBuffer*</c>, usages of that pointer will be replaced by <c>VkBufferHandle</c>. For a 2-dimensional pointer,
/// <c>VkBuffer**</c>, the resulting replacement is <c>VkBufferHandle*</c>.
/// </example>
/// <remarks>
/// It is assumed that all handle types in the generated syntax do not require a <c>using</c> directive in order to be
/// in scope. That is, if a file with the namespace <c>Silk.NET.OpenGL</c> is encountered and it is referencing
/// <c>Program</c>, <c>Program</c> must be declared in <c>Silk.NET.OpenGL</c>, <c>Silk.NET</c>, or <c>Silk</c>.
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
        /// Whether the DSL (i.e. <c>nullptr</c>) should be usable with handle types.
        /// </summary>
        public bool UseDSL { get; init; }
    }

    /// <inheritdoc />
    public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        await base.ExecuteAsync(ctx, ct);

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

        var cfg = config.Get(ctx.JobKey);

        // First pass to gather data
        var handleTypeDiscoverer = new HandleTypeDiscoverer(proj, compilation, ct);
        var handleTypes = await handleTypeDiscoverer.GetHandleTypesAsync();

        // Second pass to modify the project based on gathered data
        foreach (var handleTypeSymbol in handleTypes)
        {
            foreach (var declaringSyntaxReference in handleTypeSymbol.DeclaringSyntaxReferences)
            {
                var handleTypeName = handleTypeSymbol.Name;
                var document = proj.GetDocument(declaringSyntaxReference.SyntaxTree);
                if (document != null)
                {
                    // Add -Handle suffix to end of document name
                    document = document.WithFilePath(
                            document.FilePath!.Replace(handleTypeName, $"{handleTypeName}Handle")
                        )
                        .WithName(document.Name.Replace(handleTypeName, $"{handleTypeName}Handle"));

                    proj = document.Project;
                }
            }
        }

        // // Second pass to modify the project based on gathered data
        // // Before the execution of this foreach loop, the handle structs are empty
        // //
        // // During this foreach loop, we do two things:
        // // 1. Rewrite all type references to refer to the handle structs
        // // 2. Add members to handle structs (as identified the handles variable)
        // var rewriter = new Rewriter(handles, cfg.UseDSL);
        // foreach (var docId in proj?.DocumentIds ?? [])
        // {
        //     var doc =
        //         proj?.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
        //     if (await doc.GetSyntaxRootAsync(ct) is not { } root)
        //     {
        //         continue;
        //     }
        //
        //     doc = doc.WithSyntaxRoot(rewriter.Visit(root).NormalizeWhitespace());
        //
        //     proj = doc.Project;
        // }

        ctx.SourceProject = proj;
    }

    private class HandleTypeDiscoverer(Project project, Compilation compilation, CancellationToken ct) : SymbolVisitor
    {
        private readonly Solution solution = project.Solution;

        /// <summary>
        /// All discovered empty structs. These are not all handle types.
        /// </summary>
        private readonly List<INamedTypeSymbol> emptyStructs = new();

        /// <summary>
        /// Finds all symbols that correspond to a handle type.
        /// These symbols are identified by finding empty structs that are only ever referenced through a pointer.
        /// </summary>
        public async Task<List<INamedTypeSymbol>> GetHandleTypesAsync()
        {
            Clear();

            Visit(compilation.GlobalNamespace);

            var results = new List<INamedTypeSymbol>();
            var documents = project.Documents.ToImmutableHashSet();
            foreach (var structSymbol in emptyStructs)
            {
                // For each struct, find its references
                // Verify that all references are through pointers
                // Also verify that there is at least one reference through a pointer
                var references = await SymbolFinder.FindReferencesAsync(structSymbol, solution, documents, ct);

                var wasReferencedAsPointer = false;
                var wasReferencedAsNonPointer = false;
                foreach (var referencedLocation in references.SelectMany(r => r.Locations))
                {
                    var syntaxTree = referencedLocation.Location.SourceTree;
                    if (syntaxTree == null)
                    {
                        continue;
                    }

                    // Get the syntax node that references this struct
                    var syntaxRoot = await syntaxTree.GetRootAsync(ct);
                    var syntaxNode = syntaxRoot.FindNode(referencedLocation.Location.SourceSpan);
                    if (syntaxNode.Parent.IsKind(SyntaxKind.PointerType))
                    {
                        // This lets us know if there was at least one reference through a pointer
                        wasReferencedAsPointer = true;
                    }
                    else
                    {
                        // Was referenced through a non-pointer
                        // Immediately break
                        wasReferencedAsNonPointer = true;

                        break;
                    }
                }

                if (wasReferencedAsPointer && !wasReferencedAsNonPointer)
                {
                    results.Add(structSymbol);
                }
            }

            return results;
        }

        /// <summary>
        /// Clears all internal state
        /// </summary>
        private void Clear()
        {
            emptyStructs.Clear();
        }

        public override void VisitNamespace(INamespaceSymbol symbol)
        {
            base.VisitNamespace(symbol);

            foreach (var member in symbol.Members())
            {
                Visit(member);
            }
        }

        public override void VisitNamedType(INamedTypeSymbol symbol)
        {
            base.VisitNamedType(symbol);

            // Find empty structs
            // IsImplicitlyDeclared lets us ignore implicitly declared constructors
            // SpecialType lets us ignore Void and System.RuntimeArgumentHandle
            if (symbol.TypeKind != TypeKind.Struct || symbol.Members().Any(member => !member.IsImplicitlyDeclared) || symbol.SpecialType != SpecialType.None)
            {
                return;
            }

            emptyStructs.Add(symbol);
        }
    }

    class Rewriter(Dictionary<string, Dictionary<string, string>> handles, bool useDSL) : CSharpSyntaxRewriter
    {
        /// <summary>
        /// The current scope i.e. fully qualified type name.
        /// </summary>
        private string _currentScope = string.Empty;

        private bool _isPointerType;
        private bool _derefPtr;

        // We restrict the allowed parents to hopefully avoid mistaking references to e.g. variable names as type
        // references.
        private static bool SkipTypeNode(SyntaxNode node) =>
            node.Parent
                is not (
                TypeSyntax
                or BaseParameterSyntax
                or BaseMethodDeclarationSyntax
                or VariableDeclarationSyntax
                )
                or QualifiedNameSyntax;

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
            if (SkipTypeNode(node))
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
            if (SkipTypeNode(node))
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
