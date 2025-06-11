// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Concurrent;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.FindSymbols;
using Microsoft.Extensions.Logging;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

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
        var symbolSet = symbols.ToList();
        var transformersSet = transformers.ToList();

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

        // Find all locations where the symbols are referenced
        var documents = project.Documents.ToImmutableHashSet();
        var locations = new ConcurrentBag<(ISymbol Symbol, Location Location)>();
        // TODO this needs parallelisation config & be sensitive to the environment (future src generator form factor?)
        await Parallel.ForEachAsync(
            symbolSet,
            ct,
            async (symbol, _) => {
                var references = await SymbolFinder.FindReferencesAsync(symbol, project.Solution, documents, ct);
                foreach (var reference in references)
                {
                    foreach (var location in reference.Locations)
                    {
                        locations.Add((symbol, location.Location));
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
            foreach (var (symbol, location) in group.OrderByDescending(l => l.Location.SourceSpan.Start))
            {
                foreach (var transformer in transformersSet)
                {
                    var syntaxNode = syntaxRoot.FindNode(location.SourceSpan);
                    var nodeToModify = transformer.GetNodeToModify(syntaxNode, symbol);
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

/// <summary>
/// Base class for location transformers used by <see cref="LocationTransformationUtils.ModifyAllReferencesAsync"/>.
/// </summary>
public abstract class LocationTransformer : CSharpSyntaxRewriter
{
    /// <summary>
    /// Given a node, this method should return a parent node, the given node, or null.
    /// Returning null will lead to no node being modified.
    /// Returning the parent node will lead to the parent node being modified instead of the original node.
    /// </summary>
    /// <param name="current">The current node.</param>
    /// <param name="symbol">The symbol that was used to find the current node.</param>
    /// <returns>The parent of the given node, the given node, or null.</returns>
    public abstract SyntaxNode? GetNodeToModify(SyntaxNode current, ISymbol symbol);
}

// // TODO: Implement this
// /// <summary>
// /// Renames the identifiers for all locations transformed.
// /// </summary>
// public class IdentifierRenamingTransformer(bool includeDeclarations = true, bool includeCandidateLocations = false) : LocationTransformer
// {
//     /// <inheritdoc />
//     public override SyntaxNode? GetNodeToModify(SyntaxNode current, ISymbol symbol) => current;
//
//     /// <inheritdoc />
//     public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
//     {
//         return IdentifierName("Equals");
//     }
// }

/// <summary>
/// Reduces the pointer dimension by one for all locations transformed.
/// If the location is already a non-pointer, then nothing will be done.
/// </summary>
/// <example>
/// <c>Handle**</c> will be replaced with <c>Handle*</c>. <br/>
/// <c>Handle*</c> will be replaced with <c>Handle</c>.
/// </example>
public class PointerDimensionReductionTransformer : LocationTransformer
{
    /// <inheritdoc />
    public override SyntaxNode? GetNodeToModify(SyntaxNode current, ISymbol symbol)
    {
        if (current.Parent is PointerTypeSyntax parent)
        {
            return parent;
        }

        return null;
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitPointerType(PointerTypeSyntax node) => node.ElementType;
}
