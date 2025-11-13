// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods.LocationTransformation;

/// <summary>
/// Renames all references to each symbol with the specified new name.
/// </summary>
public class IdentifierRenamingTransformer : LocationTransformer
{
    private ISymbol symbol = null!;

    private readonly IReadOnlyDictionary<string, List<(ISymbol Symbol, string NewName)>> newNameLookup;

    /// <summary>
    /// Creates a new IdentifierRenamingTransformer.
    /// </summary>
    /// <param name="newNames">The new names for each symbol</param>
    public IdentifierRenamingTransformer(IEnumerable<(ISymbol Symbol, string NewName)> newNames) : this(CreateNameLookup(newNames)) {}

    /// <summary>
    /// Creates a new IdentifierRenamingTransformer.
    /// </summary>
    /// <param name="newNameLookup">The new names for each symbol grouped by symbol name.</param>
    public IdentifierRenamingTransformer(IReadOnlyDictionary<string, List<(ISymbol Symbol, string NewName)>> newNameLookup)
    {
        this.newNameLookup = newNameLookup;
    }

    /// <summary>
    /// Creates a name lookup dictionary designed for <see cref="IdentifierRenamingTransformer"/>.
    /// </summary>
    public static IReadOnlyDictionary<string, List<(ISymbol Symbol, string NewName)>> CreateNameLookup(IEnumerable<(ISymbol Symbol, string NewName)> names)
    {
        return names.GroupBy(t => t.Symbol.Name).ToDictionary(group => group.Key, group => group.ToList());
    }

    /// <inheritdoc />
    public override SyntaxNode GetNodeToModify(SyntaxNode current, ISymbol symbol)
    {
        this.symbol = symbol;
        return current;
    }

    /// <inheritdoc />
    public override LocationTransformer GetThreadSafeCopy()
    {
        return new IdentifierRenamingTransformer(newNameLookup);
    }

    private SyntaxToken GetRenamed(ISymbol symbol, SyntaxToken currentNameIdentifier)
    {
        if (newNameLookup.TryGetValue(symbol.Name, out var potentialCandidates))
        {
            foreach (var candidate in potentialCandidates)
            {
                if (SymbolEqualityComparer.Default.Equals(candidate.Symbol, symbol))
                {
                    return Identifier(candidate.NewName);
                }
            }
        }

        return currentNameIdentifier;
    }

     // ----- Types -----

    /// <inheritdoc />
    public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
    {
        return node.WithIdentifier(GetRenamed(symbol, node.Identifier));
    }

    /// <inheritdoc />
    public override SyntaxNode VisitStructDeclaration(StructDeclarationSyntax node)
    {
        return node.WithIdentifier(GetRenamed(symbol, node.Identifier));
    }

    /// <inheritdoc />
    public override SyntaxNode VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
    {
        return node.WithIdentifier(GetRenamed(symbol, node.Identifier));
    }

    /// <inheritdoc />
    public override SyntaxNode VisitRecordDeclaration(RecordDeclarationSyntax node)
    {
        return node.WithIdentifier(GetRenamed(symbol, node.Identifier));
    }

    /// <inheritdoc />
    public override SyntaxNode VisitDelegateDeclaration(DelegateDeclarationSyntax node)
    {
        return node.WithIdentifier(GetRenamed(symbol, node.Identifier));
    }

    /// <inheritdoc />
    public override SyntaxNode VisitEnumDeclaration(EnumDeclarationSyntax node)
    {
        return node.WithIdentifier(GetRenamed(symbol, node.Identifier));
    }

    // ----- Members -----

    /// <inheritdoc />
    public override SyntaxNode VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
    {
        return node.WithIdentifier(GetRenamed(symbol, node.Identifier));
    }

    /// <inheritdoc />
    public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node)
    {
        return node.WithIdentifier(GetRenamed(symbol, node.Identifier));
    }

    /// <inheritdoc />
    public override SyntaxNode VisitEventDeclaration(EventDeclarationSyntax node)
    {
        return node.WithIdentifier(GetRenamed(symbol, node.Identifier));
    }

    /// <inheritdoc />
    public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
        return node.WithIdentifier(GetRenamed(symbol, node.Identifier));
    }

    /// <inheritdoc />
    public override SyntaxNode VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
    {
        return node.WithIdentifier(GetRenamed(symbol, node.Identifier));
    }

    /// <inheritdoc />
    public override SyntaxNode VisitDestructorDeclaration(DestructorDeclarationSyntax node)
    {
        return node.WithIdentifier(GetRenamed(symbol, node.Identifier));
    }

    // ----- Other -----

    /// <inheritdoc />
    public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
    {
        return node.WithIdentifier(GetRenamed(symbol, node.Identifier));
    }

    // This also covers fields
    /// <inheritdoc />
    public override SyntaxNode VisitVariableDeclarator(VariableDeclaratorSyntax node)
    {
        return node.WithIdentifier(GetRenamed(symbol, node.Identifier));
    }
}
