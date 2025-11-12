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

        // TODO: For debugging only
        if (DateTime.Now != DateTime.UnixEpoch)
        {
            return;
        }

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

        // Find missing handle types
        var handleDiscoverer = new MissingHandleTypeDiscoverer(logger, compilation, ct);
        var missingHandleTypes = handleDiscoverer.GetMissingHandleTypes();

        // Second pass to modify project based on gathered data
        if (cfg.AssumeMissingTypesOpaque)
        {
            // Generate syntax nodes containing empty structs to represent the missing handle types
            var structGenerator = new EmptyStructGenerator();
            var syntaxNodes = structGenerator.GenerateSyntaxNodes(missingHandleTypes);

            // Add syntax nodes to the project as new documents
            foreach (var (fullyQualifiedName, node) in syntaxNodes)
            {
                var relativePath = $"Handles/{PathForFullyQualified(fullyQualifiedName)}";
                project = project
                    ?.AddDocument(
                        Path.GetFileName(relativePath),
                        node.NormalizeWhitespace(),
                        filePath: project.FullPath(relativePath)
                    )
                    .Project;
            }
        }

        if (project == null)
        {
            return;
        }

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

        // Phase 2. Modify project after gathering data
        // Do the two following transformation to all references of the handle types:
        // 1. Add -Handle suffix
        // 2. Reduce pointer dimensions
        ctx.SourceProject = project;
        await LocationTransformationUtils.ModifyAllReferencesAsync(ctx, handleTypes, [
            new IdentifierRenamingTransformer(handleTypes.Select(t => ((ISymbol)t, $"{t.Name}Handle"))),
            new PointerDimensionReductionTransformer()
        ], logger, ct);
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

        ctx.SourceProject = project;
    }

    private class MissingHandleTypeDiscoverer(ILogger logger, Compilation compilation, CancellationToken ct) : SymbolVisitor
    {
        private readonly HashSet<IErrorTypeSymbol> _nonHandleTypes = new(SymbolEqualityComparer.Default);
        private readonly Dictionary<IErrorTypeSymbol, string> _missingTypes = new(SymbolEqualityComparer.Default);

        private string? _currentNamespace = null;
        private int _pointerTypeDepth = 0;

        /// <summary>
        /// Gets all missing handle types that are found and the namespace that they should be created in.
        /// </summary>
        public Dictionary<IErrorTypeSymbol, string> GetMissingHandleTypes()
        {
            // We need to find and generate all missing handle types
            // Handle types are types that are only referenced through a pointer
            // We do this by parsing through the list of type errors
            var typeErrors = compilation.GetDiagnostics(ct)
                .Where(d => d.Id == "CS0246") // Type errors
                .ToList();

            // Find symbols that contain ITypeErrorSymbols
            // These symbols are not necessarily ITypeErrorSymbols
            var symbolsFound = new HashSet<ISymbol>(SymbolEqualityComparer.Default);
            foreach (var typeError in typeErrors)
            {
                var syntaxTree = typeError.Location.SourceTree;
                if (syntaxTree == null)
                {
                    continue;
                }

                var semanticModel = compilation.GetSemanticModel(syntaxTree);

                // Get the syntax node the type error corresponds to
                var currentSyntax = syntaxTree.GetRoot().FindNode(typeError.Location.SourceSpan);

                // Search upwards to find a syntax node that we can call GetDeclaredSymbol on
                // This is because calling GetDeclaredSymbol on the starting node will just return null
                var isSuccess = false;
                while (currentSyntax != null && currentSyntax is not TypeDeclarationSyntax)
                {
                    switch (currentSyntax)
                    {
                        case VariableDeclarationSyntax variableDeclarationSyntax:
                        {
                            foreach (var declaratorSyntax in variableDeclarationSyntax.Variables)
                            {
                                var symbol = semanticModel.GetDeclaredSymbol(declaratorSyntax, ct);
                                if (symbol != null)
                                {
                                    symbolsFound.Add(symbol);
                                    isSuccess = true;

                                    // All of the declarators will have the same type, so getting the first symbol is enough
                                    break;
                                }
                            }

                            break;
                        }
                        case MemberDeclarationSyntax memberDeclarationSyntax:
                        {
                            var symbol = semanticModel.GetDeclaredSymbol(memberDeclarationSyntax, ct);
                            if (symbol != null)
                            {
                                symbolsFound.Add(symbol);
                                isSuccess = true;
                            }

                            break;
                        }
                        case AttributeSyntax:
                        {
                            // Skip AttributeSyntaxes
                            // A handle type will never be used as an attribute
                            isSuccess = true;

                            break;
                        }
                    }

                    currentSyntax = currentSyntax.Parent;
                }

                if (!isSuccess)
                {
                    // This is to warn of unhandled cases
                    logger.LogWarning("Failed to find corresponding symbol for type error. There may be an unhandled case in the code");
                }
            }

            // These symbols contain at least one IErrorTypeSymbol, we need to search downwards for them
            foreach (var symbol in symbolsFound)
            {
                Visit(symbol);
            }

            return new Dictionary<IErrorTypeSymbol, string>(_missingTypes.Where(kvp => !_nonHandleTypes.Contains(kvp.Key)), SymbolEqualityComparer.Default);
        }

        public override void VisitMethod(IMethodSymbol symbol)
        {
            base.VisitMethod(symbol);

            _currentNamespace = symbol.NamespaceFromSymbol();
            foreach (var parameterSymbol in symbol.Parameters)
            {
                Visit(parameterSymbol);
            }
            _currentNamespace = null;
        }

        public override void VisitParameter(IParameterSymbol symbol)
        {
            base.VisitParameter(symbol);

            _currentNamespace = symbol.NamespaceFromSymbol();
            Visit(symbol.Type);
            _currentNamespace = null;
        }

        public override void VisitProperty(IPropertySymbol symbol)
        {
            base.VisitProperty(symbol);

            _currentNamespace = symbol.NamespaceFromSymbol();
            Visit(symbol.Type);
            _currentNamespace = null;
        }

        public override void VisitField(IFieldSymbol symbol)
        {
            base.VisitField(symbol);

            _currentNamespace = symbol.NamespaceFromSymbol();
            Visit(symbol.Type);
            _currentNamespace = null;
        }

        public override void VisitLocal(ILocalSymbol symbol)
        {
            base.VisitLocal(symbol);

            _currentNamespace = symbol.NamespaceFromSymbol();
            Visit(symbol.Type);
            _currentNamespace = null;
        }

        public override void VisitPointerType(IPointerTypeSymbol symbol)
        {
            base.VisitPointerType(symbol);

            _pointerTypeDepth++;
            Visit(symbol.PointedAtType);
            _pointerTypeDepth--;
        }

        public override void VisitNamedType(INamedTypeSymbol symbol)
        {
            base.VisitNamedType(symbol);

            if (symbol is IErrorTypeSymbol errorTypeSymbol)
            {
                if (_currentNamespace == null)
                {
                    throw new InvalidOperationException($"{nameof(_currentNamespace)} should not be null");
                }

                if (_pointerTypeDepth == 0)
                {
                    _nonHandleTypes.Add(errorTypeSymbol);
                }

                if (_missingTypes.TryGetValue(errorTypeSymbol, out var sharedNamespace))
                {
                    _missingTypes[errorTypeSymbol] = NameUtils.FindCommonPrefix([sharedNamespace, _currentNamespace], true, false, true).Trim('.');
                }
                else
                {
                    _missingTypes[errorTypeSymbol] = _currentNamespace;
                }
            }
        }
    }

    private class EmptyStructGenerator
    {
        /// <summary>
        /// Generates a syntax node for each specified type.
        /// </summary>
        /// <param name="typesToGenerate">Map from error type symbol to the namespace the type should be created in.</param>
        /// <returns>Map from the fully qualified name of the generated type to the syntax node containing code for that type.</returns>
        public Dictionary<string, SyntaxNode> GenerateSyntaxNodes(
            Dictionary<IErrorTypeSymbol, string> typesToGenerate) =>
            GenerateSyntaxNodes(typesToGenerate
                .Select(kvp => new KeyValuePair<string, string>(kvp.Key.Name, kvp.Value))
                .ToDictionary());

        /// <summary>
        /// Generates a syntax node for each specified type.
        /// </summary>
        /// <param name="missingHandleTypes">Map from type name to the namespace the type should be created in.</param>
        /// <returns>Map from the fully qualified name of the generated type to the syntax node containing code for that type.</returns>
        public Dictionary<string, SyntaxNode> GenerateSyntaxNodes(
            Dictionary<string, string> missingHandleTypes)
        {
            var results = new Dictionary<string, SyntaxNode>();
            foreach (var (name, ns) in missingHandleTypes)
            {
                var fullyQualifiedName = string.IsNullOrWhiteSpace(ns) ? name : $"{ns}.{name}";
                var structDeclarationSyntax = StructDeclaration(name)
                    .WithModifiers(
                        TokenList(
                            Token(SyntaxKind.PublicKeyword),
                            Token(SyntaxKind.UnsafeKeyword),
                            Token(SyntaxKind.PartialKeyword)
                        )
                    );

                results[fullyQualifiedName] = CompilationUnit()
                    .WithMembers(
                        SingletonList<MemberDeclarationSyntax>(
                            string.IsNullOrWhiteSpace(ns)
                                ? structDeclarationSyntax
                                : FileScopedNamespaceDeclaration(
                                        ModUtils.NamespaceIntoIdentifierName(ns)
                                    )
                                    .WithMembers(SingletonList<MemberDeclarationSyntax>(structDeclarationSyntax))
                        )
                    );
            }

            return results;
        }
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
