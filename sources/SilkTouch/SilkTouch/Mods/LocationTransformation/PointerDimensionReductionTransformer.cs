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

/// <summary>
/// Additional information about the syntax node being processed.
/// </summary>
/// <param name="Symbol">The symbol used to find the node.</param>
/// <param name="IsDeclaration">Does the syntax node represent the declaration of the symbol?</param>
/// <param name="IsCandidateLocation">Does the syntax node represent a candidate location?</param>
public record struct LocationTransformerContext(ISymbol Symbol, bool IsDeclaration, bool IsCandidateLocation);

/// <summary>
/// Base class for location transformers used by <see cref="LocationTransformationUtils.ModifyAllReferencesAsync"/>.
/// </summary>
public abstract class LocationTransformer : CSharpSyntaxRewriter
{
    /// <summary>
    /// Given a node, this method should return the given node, another node, or null.
    /// Returning null will lead to no node being modified.
    /// Returning the another node will lead to the other node being modified instead of the original node.
    /// </summary>
    /// <param name="current">The current node.</param>
    /// <param name="context">Additional information about the syntax node being processed.</param>
    /// <returns>The given node, another node, or null.</returns>
    public abstract SyntaxNode? GetNodeToModify(SyntaxNode current, LocationTransformerContext context);
}

/// <summary>
/// Renames the identifiers for all locations transformed.
/// </summary>
/// <param name="newNamesBySymbol">The new names for each symbol as a dictionary.</param>
/// <param name="includeDeclarations">Should declaration references be renamed?</param>
/// <param name="includeCandidateLocations">Should candidate references or implicit references be renamed?</param>
public class IdentifierRenamingTransformer(IEnumerable<(ISymbol Symbol, string NewName)> newNamesBySymbol, bool includeDeclarations = true, bool includeCandidateLocations = false) : LocationTransformer
{
    private LocationTransformerContext _context;
    private Dictionary<ISymbol, string> _newNameLookup = newNamesBySymbol.Select(t => new KeyValuePair<ISymbol, string>(t.Symbol, t.NewName)).ToDictionary(SymbolEqualityComparer.Default);

    /// <inheritdoc />
    public override SyntaxNode? GetNodeToModify(SyntaxNode current, LocationTransformerContext context)
    {
        _context = context;

        if (!includeDeclarations && context.IsDeclaration)
        {
            return null;
        }

        if (!includeCandidateLocations && context.IsCandidateLocation)
        {
            return null;
        }

        return current;
    }

    private SyntaxToken GetNewName() => Identifier(_newNameLookup[_context.Symbol]);

    /// <inheritdoc />
    public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
        => IdentifierName(GetNewName());

    // ----- Types -----

    /// <inheritdoc />
    public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
        => node.WithIdentifier(GetNewName());

    /// <inheritdoc />
    public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
        => node.WithIdentifier(GetNewName());

    /// <inheritdoc />
    public override SyntaxNode? VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
        => node.WithIdentifier(GetNewName());

    /// <inheritdoc />
    public override SyntaxNode? VisitRecordDeclaration(RecordDeclarationSyntax node)
        => node.WithIdentifier(GetNewName());

    /// <inheritdoc />
    public override SyntaxNode? VisitDelegateDeclaration(DelegateDeclarationSyntax node)
        => node.WithIdentifier(GetNewName());

    /// <inheritdoc />
    public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node)
        => node.WithIdentifier(GetNewName());

    // ----- Members -----

    /// <inheritdoc />
    public override SyntaxNode? VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
        => node.WithIdentifier(GetNewName());

    /// <inheritdoc />
    public override SyntaxNode? VisitEventDeclaration(EventDeclarationSyntax node)
        => node.WithIdentifier(GetNewName());

    /// <inheritdoc />
    public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
        => node.WithIdentifier(GetNewName());

    /// <inheritdoc />
    public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        => node.WithIdentifier(GetNewName());

    /// <inheritdoc />
    public override SyntaxNode? VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
        => node.WithIdentifier(GetNewName());

    /// <inheritdoc />
    public override SyntaxNode? VisitDestructorDeclaration(DestructorDeclarationSyntax node)
        => node.WithIdentifier(GetNewName());

    // ----- Other -----

    /// <inheritdoc />
    public override SyntaxNode? VisitVariableDeclarator(VariableDeclaratorSyntax node)
        => node.WithIdentifier(GetNewName());

    /// <inheritdoc />
    public override SyntaxNode? VisitTypeParameter(TypeParameterSyntax node)
        => node.WithIdentifier(GetNewName());
}

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
    public override SyntaxNode? GetNodeToModify(SyntaxNode current, LocationTransformerContext context)
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
