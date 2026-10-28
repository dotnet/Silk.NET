// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Concurrent;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging;

namespace Silk.NET.SilkTouch.Mods.LocationTransformation;

/// <summary>
/// Utilities for transforming <see cref="Location"/>s.
/// </summary>
public static class LocationTransformationUtils
{
    /// <summary>
    /// Finds all references to the specified symbols and applies the specified transformations to them.
    /// Transformations will be done in order.
    /// </summary>
    /// <param name="ctx">Mod context to use.</param>
    /// <param name="symbols">Symbols to search for.</param>
    /// <param name="transformers">Transformers to use on each found symbol reference.</param>
    /// <param name="logger">Logger to use.</param>
    /// <param name="ct">Cancellation token to use.</param>
    public static async Task ModifyAllReferencesAsync(
        IModContext ctx,
        IEnumerable<ISymbol> symbols,
        IEnumerable<LocationTransformer> transformers,
        ILogger? logger = null,
        CancellationToken ct = default
    )
    {
        var sourceProject = ctx.SourceProject;

        // We need to track both the original solution and modified solution
        // The original is where we retrieve documents and semantic models
        // The modified solution is where we place the results
        IReadOnlyList<DocumentId> documentIds =
        [
            .. sourceProject.DocumentIds,
            .. ctx.TestProject?.DocumentIds ?? [],
        ];

        var test = await ctx.TestProject!.GetCompilationAsync(ct);
        foreach (var diagnostic in test!.GetDiagnostics(ct))
        {
            Console.WriteLine(diagnostic);
        }

        var originalSolution = sourceProject.Solution;
        var newDocuments = new ConcurrentDictionary<DocumentId, SyntaxNode>();
        var symbolSet = new HashSet<ISymbol>(symbols, SymbolEqualityComparer.Default);
        Console.WriteLine(symbolSet.Count);
        var baseRewriter = new LocationTransformationRewriter(symbolSet, transformers.ToList());
        await Parallel.ForEachAsync(
            documentIds,
            ct,
            async (documentId, _) =>
            {
                var originalDocument = originalSolution.GetDocument(documentId);
                if (originalDocument == null)
                {
                    return;
                }

                var originalRoot = await originalDocument.GetSyntaxRootAsync(ct);
                var semanticModel = await originalDocument.GetSemanticModelAsync(ct);
                if (originalRoot == null || semanticModel == null)
                {
                    return;
                }

                // Since this is multithreaded, each thread needs their own copy of the rewriter and transformers
                var rewriter = baseRewriter.GetThreadSafeCopy();

                rewriter.Initialize(semanticModel);
                var newRoot = rewriter.Visit(originalRoot);
                newDocuments.TryAdd(documentId, newRoot);
            }
        );

        Console.WriteLine(newDocuments.Count);

        Console.WriteLine("ModifyAllReferencesAsync0");
        var modifiedSolution = originalSolution;
        foreach (var (documentId, newRoot) in newDocuments)
        {
            var modifiedDocument = modifiedSolution.GetDocument(documentId);
            if (modifiedDocument == null)
            {
                return;
            }

            modifiedDocument = modifiedDocument.WithSyntaxRoot(newRoot);
            Console.WriteLine(modifiedDocument.Project.Name);
            Console.WriteLine(newRoot.NormalizeWhitespace().ToFullString());
            modifiedSolution = modifiedDocument.Project.Solution;
        }

        ctx.SourceProject =
            modifiedSolution.GetProject(sourceProject.Id)
            ?? throw new InvalidOperationException("Failed to get source project");

        if (ctx.TestProject != null && ctx.SourceProject.Solution != ctx.TestProject.Solution)
        {
            throw new InvalidOperationException(
                "IModContext must ensure the source and test projects belong to the same solution"
            );
        }
    }
}
