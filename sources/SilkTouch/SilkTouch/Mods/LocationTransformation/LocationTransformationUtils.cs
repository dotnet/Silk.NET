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
        CancellationToken ct = default)
    {
        var sourceProject = ctx.SourceProject;
        if (sourceProject == null)
        {
            return;
        }

        // We need to track both the original solution and modified solution
        // The original is where we retrieve documents and semantic models
        // The modified solution is where we place the results
        IReadOnlyList<DocumentId> documentIds = [.. sourceProject.DocumentIds, .. ctx.TestProject?.DocumentIds ?? []];

        var originalSolution = sourceProject.Solution;
        var newDocuments = new ConcurrentDictionary<DocumentId, SyntaxNode>();
        var symbolSet = new HashSet<ISymbol>(symbols, SymbolEqualityComparer.Default);
        await Parallel.ForEachAsync(documentIds, ct, async (documentId, _) => {
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
            var rewriter = new LocationTransformationRewriter(symbolSet, [..transformers.Select(t => t.GetThreadSafeCopy())]);
            rewriter.Initialize(semanticModel);

            var newRoot = rewriter.Visit(originalRoot);
            newDocuments.TryAdd(documentId, newRoot);
        });

        var modifiedSolution = sourceProject.Solution;
        foreach (var (documentId, newRoot) in newDocuments)
        {
            var modifiedDocument = modifiedSolution.GetDocument(documentId);
            if (modifiedDocument == null)
            {
                return;
            }

            modifiedSolution = modifiedDocument.WithSyntaxRoot(newRoot).Project.Solution;
        }

        ctx.SourceProject = modifiedSolution.GetProject(sourceProject.Id);
    }
}
