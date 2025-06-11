// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Concurrent;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.FindSymbols;
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
    public static async Task ModifyAllReferencesAsync(
        IModContext ctx,
        ILogger logger,
        IEnumerable<ISymbol> symbols,
        IEnumerable<LocationTransformer> transformers,
        CancellationToken ct = default)
    {
        // Convert to lists
        // The parameters being IEnumerables is for convenience
        var symbolList = symbols.ToList();
        var transformersList = transformers.ToList();

        var project = ctx.SourceProject;
        if (project == null)
        {
            return;
        }

        var compilation = await project.GetCompilationAsync(ct);
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
        var documents = project.Documents.ToImmutableHashSet();
        await Parallel.ForEachAsync(
            symbolList,
            ct,
            async (symbol, _) => {
                var references = await SymbolFinder.FindReferencesAsync(symbol, project.Solution, documents, ct);
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
        var locationsBySourcetree = locations.GroupBy(l => l.Location.SourceTree);
        foreach (var group in locationsBySourcetree)
        {
            var syntaxTree = group.Key;
            if (syntaxTree == null)
            {
                continue;
            }

            var document = project.GetDocument(syntaxTree);
            if (document == null)
            {
                continue;
            }

            var syntaxRoot = await syntaxTree.GetRootAsync(ct);

            // Modify each location
            // We order the locations so that we modify starting from the end of the file
            // This way we prevent changes from being accidentally overwriting changes
            foreach (var (location, context) in group.OrderByDescending(l => l.Location.SourceSpan.Start))
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
                    syntaxRoot = syntaxRoot.ReplaceNode(nodeToModify, newNode);
                }
            }

            // Commit the changes to the project
            var newDocument = document.WithSyntaxRoot(syntaxRoot);
            project = newDocument.Project;
        }

        ctx.SourceProject = project;
    }
}
