// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Concurrent;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.FindSymbols;
using Microsoft.Extensions.Logging;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods.LocationTransformationOld;

/// <summary>
/// Utilities for transforming <see cref="Location"/>s.
/// </summary>
public static class LocationTransformationUtils
{
    /// <summary>
    /// Finds all references to the specified symbols and applies the specified transformations to them.
    /// Transformations will be done in order.
    /// </summary>
    public static async Task ModifyAllReferencesAsync(
        IModContext ctx,
        IEnumerable<ISymbol> symbols,
        IEnumerable<LocationTransformer> transformers,
        ILogger? logger = null,
        CancellationToken ct = default)
    {
        // Convert to lists
        // The parameters being IEnumerables is for convenience
        var symbolList = symbols.ToList();
        var transformersList = transformers.ToList();

        if (ctx.SourceProject == null)
        {
            return;
        }

        var compilation = await ctx.SourceProject.GetCompilationAsync(ct);
        if (compilation == null)
        {
            return;
        }

        var locations = new ConcurrentBag<(Location Location, LocationTransformerContext Context)>();

        // Add the locations of the declaration identifiers for each symbol
        foreach (var symbol in symbolList)
        {
            foreach (var declaringSyntaxReference in symbol.DeclaringSyntaxReferences)
            {
                locations.Add((declaringSyntaxReference.GetSyntax().GetLocation(),
                    new LocationTransformerContext(symbol, true, false)));
            }
        }

        // Find all locations where the symbols are referenced
        // TODO this needs parallelisation config & be sensitive to the environment (future src generator form factor?)
        ImmutableHashSet<Document> documents = [..ctx.SourceProject.Documents, ..ctx.TestProject?.Documents ?? []];
        await Parallel.ForEachAsync(
            symbolList,
            ct,
            async (symbol, _) => {
                var references = await SymbolFinder.FindReferencesAsync(symbol, ctx.SourceProject.Solution, documents, ct);
                foreach (var reference in references)
                {
                    foreach (var location in reference.Locations)
                    {
                        locations.Add((location.Location,
                            new LocationTransformerContext(symbol, false,
                                location.IsCandidateLocation || location.IsImplicit)));
                    }
                }
            }
        );

        // Group the locations by source tree. This will be used to prevent accidentally overwriting changes.
        var solution = ctx.SourceProject.Solution;
        var locationsBySourcetree = locations.GroupBy(l => l.Location.SourceTree);
        foreach (var group in locationsBySourcetree)
        {
            var syntaxTree = group.Key;
            if (syntaxTree == null)
            {
                continue;
            }

            var document = solution.GetDocument(syntaxTree);
            if (document == null)
            {
                continue;
            }

            var syntaxRoot = await syntaxTree.GetRootAsync(ct);

            // Modify each location
            // We order the locations so that we modify starting from the end of the file
            // This way we prevent changes from being accidentally overwriting changes
            foreach (var (location, context) in group.OrderByDescending(l => l.Location.SourceSpan))
            {
                foreach (var transformer in transformersList)
                {
                    var syntaxNode = syntaxRoot.FindNode(location.SourceSpan);
                    var nodeToModify = transformer.GetNodeToModify(syntaxNode, context);
                    if (nodeToModify == null)
                    {
                        continue;
                    }

                    var newNode = transformer.Visit(nodeToModify);
                    var originalLength = syntaxNode.FullSpan.Length;
                    var newLength = newNode.FullSpan.Length;

                    // Ensure that the new node's length is at least the original node's length
                    // This is because the last few nodes processed usually make up the entire document
                    // If the document's length has been reduced, then an ArgumentOutOfRangeException will be thrown
                    if (originalLength - newLength > 0)
                    {
                        newNode = newNode.WithTrailingTrivia(TriviaList([..newNode.GetTrailingTrivia(), Whitespace(new string(' ', originalLength - newLength))]));
                    }

                    syntaxRoot = syntaxRoot.ReplaceNode(nodeToModify, newNode);
                }
            }

            // Commit the changes to the solution
            var newDocument = document.WithSyntaxRoot(syntaxRoot.NormalizeWhitespace());
            solution = newDocument.Project.Solution;
        }

        ctx.SourceProject = solution.GetProject(ctx.SourceProject.Id);
    }
}
