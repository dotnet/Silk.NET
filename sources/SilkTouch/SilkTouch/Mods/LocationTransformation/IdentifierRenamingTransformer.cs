// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch.Mods.LocationTransformation;

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

    private SyntaxToken GetNewName() => SyntaxFactory.Identifier(_newNameLookup[_context.Symbol]);

    /// <inheritdoc />
    public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
        => SyntaxFactory.IdentifierName(GetNewName());

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
