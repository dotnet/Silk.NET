// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods.LocationTransformationOld;

/// <summary>
/// Renames the identifiers for all locations transformed.
/// </summary>
/// <param name="newNamesBySymbol">The new names for each symbol as a dictionary.</param>
/// <param name="includeDeclarations">Should declaration references be renamed?</param>
/// <param name="includeCandidateLocations">Should candidate references or implicit references be renamed?</param>
public class IdentifierRenamingTransformer(IEnumerable<(ISymbol Symbol, string NewName)> newNamesBySymbol, bool includeDeclarations = true, bool includeCandidateLocations = false) : LocationTransformer
{
    // Identifiers can also be referenced within XML doc, which are trivia nodes.
    /// <inheritdoc />
    public override bool VisitIntoStructuredTrivia => true;

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

    private SyntaxToken GetNewName(string currentName)
    {
        var symbolName = _context.Symbol switch
        {
            // Constructor/destructor symbols have a name of .ctor/.dtor, which isn't what we want
            IMethodSymbol { MethodKind: MethodKind.Constructor or MethodKind.Destructor } methodSymbol => methodSymbol.ContainingType.Name,
            _ => _context.Symbol.Name,
        };

        if (currentName != symbolName)
        {
            return Identifier(currentName);
        }

        return Identifier(_newNameLookup[_context.Symbol]);
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
        => IdentifierName(GetNewName(node.Identifier.ValueText))
            .WithLeadingTrivia(node.GetLeadingTrivia())
            .WithTrailingTrivia(node.GetTrailingTrivia());

    // ----- Types -----

    /// <inheritdoc />
    public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
        => node.WithIdentifier(GetNewName(node.Identifier.ValueText))
        .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
        .WithTrailingTrivia(node.GetTrailingTrivia());

    /// <inheritdoc />
    public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
        => node.WithIdentifier(GetNewName(node.Identifier.ValueText))
        .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
        .WithTrailingTrivia(node.GetTrailingTrivia());

    /// <inheritdoc />
    public override SyntaxNode? VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
        => node.WithIdentifier(GetNewName(node.Identifier.ValueText))
        .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
        .WithTrailingTrivia(node.GetTrailingTrivia());

    /// <inheritdoc />
    public override SyntaxNode? VisitRecordDeclaration(RecordDeclarationSyntax node)
        => node.WithIdentifier(GetNewName(node.Identifier.ValueText))
        .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
        .WithTrailingTrivia(node.GetTrailingTrivia());

    /// <inheritdoc />
    public override SyntaxNode? VisitDelegateDeclaration(DelegateDeclarationSyntax node)
        => node.WithIdentifier(GetNewName(node.Identifier.ValueText))
        .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
        .WithTrailingTrivia(node.GetTrailingTrivia());

    /// <inheritdoc />
    public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node)
        => node.WithIdentifier(GetNewName(node.Identifier.ValueText))
        .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
        .WithTrailingTrivia(node.GetTrailingTrivia());

    // ----- Members -----

    /// <inheritdoc />
    public override SyntaxNode? VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
        => node.WithIdentifier(GetNewName(node.Identifier.ValueText))
        .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
        .WithTrailingTrivia(node.GetTrailingTrivia());

    /// <inheritdoc />
    public override SyntaxNode? VisitEventDeclaration(EventDeclarationSyntax node)
        => node.WithIdentifier(GetNewName(node.Identifier.ValueText))
        .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
        .WithTrailingTrivia(node.GetTrailingTrivia());

    /// <inheritdoc />
    public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
        => node.WithIdentifier(GetNewName(node.Identifier.ValueText))
        .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
        .WithTrailingTrivia(node.GetTrailingTrivia());

    /// <inheritdoc />
    public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        => node.WithIdentifier(GetNewName(node.Identifier.ValueText))
        .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
        .WithTrailingTrivia(node.GetTrailingTrivia());

    /// <inheritdoc />
    public override SyntaxNode? VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
        => node.WithIdentifier(GetNewName(node.Identifier.ValueText))
        .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
        .WithTrailingTrivia(node.GetTrailingTrivia());

    /// <inheritdoc />
    public override SyntaxNode? VisitDestructorDeclaration(DestructorDeclarationSyntax node)
        => node.WithIdentifier(GetNewName(node.Identifier.ValueText))
        .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
        .WithTrailingTrivia(node.GetTrailingTrivia());

    // ----- Other -----

    /// <inheritdoc />
    public override SyntaxNode? VisitVariableDeclarator(VariableDeclaratorSyntax node)
        => node.WithIdentifier(GetNewName(node.Identifier.ValueText))
        .WithLeadingTrivia(node.GetLeadingTrivia())
        .WithTrailingTrivia(node.GetTrailingTrivia());

    /// <inheritdoc />
    public override SyntaxNode? VisitTypeParameter(TypeParameterSyntax node)
        => node.WithIdentifier(GetNewName(node.Identifier.ValueText))
        .WithLeadingTrivia(node.GetLeadingTrivia())
        .WithTrailingTrivia(node.GetTrailingTrivia());
}
