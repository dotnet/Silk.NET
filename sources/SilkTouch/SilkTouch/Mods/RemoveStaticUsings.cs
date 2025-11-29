// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Logging;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// A mod that will remove any lingering static usings
/// </summary>
/// <param name="logger">The logger.</param>
/// <param name="progressService">the progress service</param>
public class RemoveStaticUsings(
    ILogger<RemoveStaticUsings> logger,
    IProgressService progressService
    ) : Mod
{
    /// <summary>
    /// The configuration for the remap types mod.
    /// </summary>
    public record Configuration // DON'T USE CONSTRUCTOR-STYLE RECORDS! Needs a default ctor.
    {
        /// <summary>
        /// List of type Mapping
        /// </summary>
        public required Dictionary<string, string> Mappings { get; init; }
    }

    /// <inheritdoc/>
    public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        await base.ExecuteAsync(ctx, ct);

        if (ctx.SourceProject is null)
        {
            return;
        }

        var proj = ctx.SourceProject;
        var comp =
            await proj.GetCompilationAsync(ct)
            ?? throw new InvalidOperationException(
                "Failed to obtain compilation for source project!"
            );

        int count = proj?.DocumentIds.Count ?? 0;
        int index = 0;

        progressService.SetTask("Removing Static Usings");

        Rewriter rewriter = new Rewriter();

        foreach (var docId in proj?.DocumentIds ?? [])
        {
            index++;
            var doc =
                proj?.GetDocument(docId)
                ?? throw new InvalidOperationException("Document missing");
            if (await doc.GetSyntaxRootAsync(ct) is not { } root)
            {
                continue;
            }

            var syntaxTree = await doc.GetSyntaxTreeAsync();
            if (syntaxTree is null)
            {
                logger.LogWarning("unable to retrieve Semantic Model for {}", doc.Name);
                continue;
            }
            rewriter.SemanticModel = comp is not null
                    ? comp.GetSemanticModel(syntaxTree!)
                    : await doc.GetSemanticModelAsync();

            doc = doc.WithSyntaxRoot(rewriter.Visit(root).NormalizeWhitespace());
            rewriter.Clear();

            proj = doc.Project;

            progressService.SetProgress((float)index / count);
        }
        ctx.SourceProject = proj;
        progressService.SetProgress(1);
    }

    class Rewriter() : CSharpSyntaxRewriter
    {
        List<INamedTypeSymbol> _staticTypes = new List<INamedTypeSymbol>();
        public SemanticModel? SemanticModel;

        public override SyntaxNode? VisitUsingDirective(UsingDirectiveSyntax node)
        {
            if (node.StaticKeyword != default && node.Name is not null)
            {
                ISymbol? symbol = SemanticModel?.GetSymbolInfo(node.Name).Symbol;

                if (symbol is INamedTypeSymbol typeSymbol)
                {
                    _staticTypes.Add(typeSymbol);
                    return null;
                }
            }
            return base.VisitUsingDirective(node);
        }

        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node) => _staticTypes.Count > 0 ? base.VisitClassDeclaration(node) : node;
        public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node) => _staticTypes.Count > 0 ? base.VisitStructDeclaration(node) : node;
        public override SyntaxNode? VisitInterfaceDeclaration(InterfaceDeclarationSyntax node) => _staticTypes.Count > 0 ? base.VisitInterfaceDeclaration(node) : node;

        public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
        {
            if (node.Parent is not MemberAccessExpressionSyntax)
            {
                var symbol = SemanticModel.GetSymbolInfo(node).Symbol;

                if (symbol != null)
                {
                    foreach (var staticSymbol in _staticTypes)
                    {
                        if (SymbolEqualityComparer.Default.Equals(symbol.ContainingType, staticSymbol))
                        {
                            var newNode = MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, ParseTypeName(staticSymbol.Name), node.WithoutTrivia())
                                .WithLeadingTrivia(node.GetLeadingTrivia())
                                .WithTrailingTrivia(node.GetTrailingTrivia());

                            return newNode;
                        }
                    }
                }
            }
            return base.VisitIdentifierName(node);
        }

        public void Clear()
        {
            _staticTypes.Clear();
        }
    }
}
