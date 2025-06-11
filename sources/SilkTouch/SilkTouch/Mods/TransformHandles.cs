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
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods.LocationTransformation;
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
public class TransformHandles(IOptionsSnapshot<TransformHandles.Config> config, ILogger<TransformHandles> logger) : Mod
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

        var project = ctx.SourceProject;
        if (project == null)
        {
            return;
        }

        var compilation = await project.GetCompilationAsync(ct);
        if (compilation == null)
        {
            throw new InvalidOperationException("Failed to get compilation");
        }

        var cfg = config.Get(ctx.JobKey);

        // Phase 1. Gather data before modifying
        // Find handle documents
        var handleTypeDiscoverer = new HandleTypeDiscoverer(project, compilation, ct);
        var handleTypes = await handleTypeDiscoverer.GetHandleTypesAsync();

        // Store handle document IDs for later
        // We will use these IDs to know which documents to rewrite and rename
        var handleTypeDocumentIds = new List<(string OriginalName, DocumentId DocumentId)>();
        foreach (var handleTypeSymbol in handleTypes)
        {
            if (handleTypeSymbol.DeclaringSyntaxReferences.Length > 1)
            {
                // The struct is defined in multiple places (eg: partial keyword)
                // This means we don't know which of the parts to rewrite
                throw new InvalidOperationException("Struct has more than 1 declaring syntax reference");
            }

            var declaringSyntaxReference = handleTypeSymbol.DeclaringSyntaxReferences.Single();
            var documentId = project.GetDocumentId(declaringSyntaxReference.SyntaxTree);
            if (documentId != null)
            {
                handleTypeDocumentIds.Add((handleTypeSymbol.Name, documentId));
            }
        }

        // Get fully qualified metadata names for each handle type
        // This is because symbols are invalidated after modifying the project they come from
        // We use these names to restore the symbols
        // TODO: This actually requires rewriting the fully qualified metadata names since the names will be different after the rename below. AHHHH...
        // Rewriting RenameAllAsync to allow providing a list of CSharpSyntaxRewriters might work best
        var handleTypeMetadataNames = handleTypes
            .Select(t => {
                var ns = t.NamespaceFromSymbol();
                var name = string.IsNullOrEmpty(ns) ? t.Name : $"{ns}.{t.Name}";

                return name.Replace(t.Name, $"{t.Name}Handle");
            });

        // Phase 2. Modify project after gathering data
        // Add -Handle suffix
        ctx.SourceProject = project;
        await NameUtils.RenameAllAsync(ctx, logger, handleTypes.Select(t => ((ISymbol)t, $"{t.Name}Handle")), ct);
        project = ctx.SourceProject;

        // Get the compilation again
        compilation = await project.GetCompilationAsync(ct);
        if (compilation == null)
        {
            throw new InvalidOperationException("Failed to get compilation");
        }

        // Restore symbols invalidated by previous modification
        handleTypes = handleTypeMetadataNames.SelectMany(name => compilation.GetTypesByMetadataName(name)).ToList();

        // Reduce pointer dimensions
        ctx.SourceProject = project;
        await LocationTransformationUtils.ModifyAllReferencesAsync(ctx, logger, handleTypes,
            [new PointerDimensionReductionTransformer()], ct);
        project = ctx.SourceProject;

        // Use document IDs from earlier
        var handleTypeRewriter = new HandleTypeRewriter(cfg.UseDSL);
        foreach (var (originalName, documentId) in handleTypeDocumentIds)
        {
            var document = project.GetDocument(documentId) ?? throw new InvalidOperationException("Failed to find document");

            var syntaxTree = await document.GetSyntaxTreeAsync(ct);
            if (syntaxTree == null)
            {
                continue;
            }

            var syntaxRoot = await syntaxTree.GetRootAsync(ct);

            // Rewrite handle struct to include handle members
            document = document.WithSyntaxRoot(handleTypeRewriter.Visit(syntaxRoot).NormalizeWhitespace());

            // Add -Handle suffix to end of document name
            document = document.WithFilePath(
                    document.FilePath!.Replace(originalName, $"{originalName}Handle")
                )
                .WithName(document.Name.Replace(originalName, $"{originalName}Handle"));

            project = document.Project;
        }

        // At the time of writing this comment, this line effectively does nothing
        // However, if the code above is removed, then this line ensures that the context's project is updated properly
        ctx.SourceProject = project;
    }

    private class HandleTypeDiscoverer(Project project, Compilation compilation, CancellationToken ct) : SymbolVisitor
    {
        private readonly Solution _solution = project.Solution;

        /// <summary>
        /// All discovered empty structs. These are not all handle types.
        /// </summary>
        private readonly List<INamedTypeSymbol> _emptyStructs = new();

        /// <summary>
        /// Finds all symbols that correspond to a handle type.
        /// These symbols are identified by finding empty structs that are only ever referenced through a pointer.
        /// </summary>
        public async Task<List<INamedTypeSymbol>> GetHandleTypesAsync()
        {
            Visit(compilation.GlobalNamespace);

            var results = new List<INamedTypeSymbol>();
            var documents = project.Documents.ToImmutableHashSet();
            foreach (var structSymbol in _emptyStructs)
            {
                // For each struct, find its references
                // Verify that all references are through pointers
                // Also verify that there is at least one reference through a pointer
                var references = await SymbolFinder.FindReferencesAsync(structSymbol, _solution, documents, ct);

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

            _emptyStructs.Add(symbol);
        }
    }

    private class HandleTypeRewriter(bool useDSL) : CSharpSyntaxRewriter
    {
        public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
        {
            var structName = node.Identifier.Text;
            return node.WithIdentifier(Identifier(structName))
                .WithMembers(
                    List(
                        GetDefaultHandleMembers(structName).Concat(useDSL ? GetDSLHandleMembers(structName) : [])
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

        private static IEnumerable<MemberDeclarationSyntax> GetDefaultHandleMembers(string structName)
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
                            Parameter(Identifier("other")).WithType(IdentifierName(structName))
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
                                    IdentifierName(structName),
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
                                Parameter(Identifier("left")).WithType(IdentifierName(structName)),
                                Token(SyntaxKind.CommaToken),
                                Parameter(Identifier("right")).WithType(IdentifierName(structName))
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
                                Parameter(Identifier("left")).WithType(IdentifierName(structName)),
                                Parameter(Identifier("right")).WithType(IdentifierName(structName))
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

        private static IEnumerable<MemberDeclarationSyntax> GetDSLHandleMembers(string structName)
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
                                Parameter(Identifier("left")).WithType(IdentifierName(structName)),
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
                                Parameter(Identifier("left")).WithType(IdentifierName(structName)),
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
                    IdentifierName(structName)
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
