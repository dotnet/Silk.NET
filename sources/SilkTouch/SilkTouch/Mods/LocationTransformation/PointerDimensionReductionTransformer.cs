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
        var locations = new List<Location>();
        var documents = project.Documents.ToImmutableHashSet();
        foreach (var symbol in symbolSet)
        {
            var references = await SymbolFinder.FindReferencesAsync(symbol, project.Solution, documents, ct);
            locations.AddRange(references.SelectMany(r => r.Locations).Select(rl => rl.Location));
        }

        // var locations = new ConcurrentDictionary<Location, string>();
        // // TODO this needs parallelisation config & be sensitive to the environment (future src generator form factor?)
        // await Parallel.ForEachAsync(
        //     toRename,
        //     ct,
        //     async (tuple, _) =>
        //     {
        //         // First, let's add all of the locations of the declaration identifiers.
        //         var (symbol, newName) = tuple;
        //         if (includeDeclarations)
        //         {
        //             foreach (var syntaxRef in symbol.DeclaringSyntaxReferences)
        //             {
        //                 var identifierLocation = IdentifierLocation(
        //                     await syntaxRef.GetSyntaxAsync(ct)
        //                 );
        //                 if (identifierLocation is not null)
        //                 {
        //                     locations.TryAdd(identifierLocation, newName);
        //                 }
        //             }
        //         }
        //
        //         // Next, let's find all the references of the symbols.
        //         var references = await SymbolFinder.FindReferencesAsync(
        //             symbol,
        //             ctx.SourceProject?.Solution
        //                 ?? throw new ArgumentException("SourceProject is null"),
        //             ct
        //         );
        //
        //         foreach (var referencedSymbol in references)
        //         {
        //             foreach (var referencedSymbolLocation in referencedSymbol.Locations)
        //             {
        //                 if (
        //                     !includeCandidateLocations
        //                     && (
        //                         referencedSymbolLocation.IsCandidateLocation
        //                         || referencedSymbolLocation.IsImplicit
        //                     )
        //                 )
        //                 {
        //                     continue;
        //                 }
        //
        //                 locations.TryAdd(referencedSymbolLocation.Location, newName);
        //             }
        //         }
        //     }
        // );

        // Group the locations by source tree. This will be used to prevent accidentally overwriting changes.
        var locationsBySourcetree = locations.GroupBy(l => l.SourceTree);
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
            foreach (var location in group.OrderByDescending(l => l.SourceSpan.Start))
            {
                foreach (var transformer in transformersSet)
                {
                    var syntaxNode = syntaxRoot.FindNode(location.SourceSpan);
                    var nodeToModify = transformer.GetNodeToModify(syntaxNode);
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
    /// <param name="current">TODO</param>
    /// <returns>TODO</returns>
    public abstract SyntaxNode? GetNodeToModify(SyntaxNode current);
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
    public override SyntaxNode? GetNodeToModify(SyntaxNode current)
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
