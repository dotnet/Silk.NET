// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Adds empty handle structs by searching for missing types referenced through pointers.
/// If all references to the missing type are through a pointer,
/// that missing type is then added as an empty struct.
/// <para/>
/// See <see cref="TransformHandles"/> for applying further transformations.
/// </summary>
public class ExtractHandles(ILogger<ExtractHandles> logger) : Mod
{
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

        // Find missing handle types
        var handleDiscoverer = new MissingHandleTypeDiscoverer(logger, compilation, ct);
        var missingHandleTypes = handleDiscoverer.GetMissingHandleTypes();

        // Generate syntax nodes containing empty structs to represent the missing handle types
        var structGenerator = new EmptyStructGenerator();
        var syntaxNodes = structGenerator.GenerateSyntaxNodes(missingHandleTypes);

        // Add syntax nodes to the project as new documents
        foreach (var (fullyQualifiedName, node) in syntaxNodes)
        {
            var relativePath = $"Handles/{PathForFullyQualified(fullyQualifiedName)}";
            project = project
                .AddDocument(
                    Path.GetFileName(relativePath),
                    node,
                    filePath: project.FullPath(relativePath)
                )
                .Project;
        }

        ctx.SourceProject = project;
    }

    private class MissingHandleTypeDiscoverer(
        ILogger logger,
        Compilation compilation,
        CancellationToken ct
    ) : SymbolVisitor
    {
        private readonly HashSet<IErrorTypeSymbol> _nonHandleTypes =
            new(SymbolEqualityComparer.Default);
        private readonly Dictionary<IErrorTypeSymbol, string> _missingTypes =
            new(SymbolEqualityComparer.Default);

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
            var typeErrors = compilation
                .GetDiagnostics(ct)
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
                            var symbol = semanticModel.GetDeclaredSymbol(
                                memberDeclarationSyntax,
                                ct
                            );
                            if (symbol != null)
                            {
                                symbolsFound.Add(symbol);
                                isSuccess = true;
                            }

                            break;
                        }
                        // Skip syntaxes that will never contain handle types
                        case BaseTypeSyntax:
                        case AttributeSyntax:
                        {
                            isSuccess = true;
                            break;
                        }
                    }

                    currentSyntax = currentSyntax.Parent;
                }

                if (!isSuccess)
                {
                    // This is to warn of unhandled cases
                    logger.LogWarning(
                        "Failed to find corresponding symbol for type error. There may be an unhandled case in the code"
                    );
                }
            }

            // These symbols contain at least one IErrorTypeSymbol, we need to search downwards for them
            foreach (var symbol in symbolsFound)
            {
                Visit(symbol);
            }

            return new Dictionary<IErrorTypeSymbol, string>(
                _missingTypes.Where(kvp => !_nonHandleTypes.Contains(kvp.Key)),
                SymbolEqualityComparer.Default
            );
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
                    throw new InvalidOperationException(
                        $"{nameof(_currentNamespace)} should not be null"
                    );
                }

                if (_pointerTypeDepth == 0)
                {
                    _nonHandleTypes.Add(errorTypeSymbol);
                }

                if (_missingTypes.TryGetValue(errorTypeSymbol, out var sharedNamespace))
                {
                    _missingTypes[errorTypeSymbol] = NameUtils
                        .FindCommonPrefix([sharedNamespace, _currentNamespace], true, false, true)
                        .Trim('.');
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
            Dictionary<IErrorTypeSymbol, string> typesToGenerate
        ) =>
            GenerateSyntaxNodes(
                typesToGenerate
                    .Select(kvp => new KeyValuePair<string, string>(kvp.Key.Name, kvp.Value))
                    .ToDictionary()
            );

        /// <summary>
        /// Generates a syntax node for each specified type.
        /// </summary>
        /// <param name="missingHandleTypes">Map from type name to the namespace the type should be created in.</param>
        /// <returns>Map from the fully qualified name of the generated type to the syntax node containing code for that type.</returns>
        public Dictionary<string, SyntaxNode> GenerateSyntaxNodes(
            Dictionary<string, string> missingHandleTypes
        )
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
                                    .WithMembers(
                                        SingletonList<MemberDeclarationSyntax>(
                                            structDeclarationSyntax
                                        )
                                    )
                        )
                    );
            }

            return results;
        }
    }
}
