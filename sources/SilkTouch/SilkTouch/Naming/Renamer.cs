using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// Renames all references to each symbol with the specified new name.
/// </summary>
/// <param name="newNameLookup">The new names for each symbol.</param>
public class Renamer(IReadOnlyDictionary<string, List<(ISymbol Symbol, string NewName)>> newNameLookup) : CSharpSyntaxRewriter
{
    // Identifiers can also be referenced within XML doc, which are trivia nodes.
    /// <inheritdoc />
    public override bool VisitIntoStructuredTrivia => true;

    /// <summary>
    /// The semantic model of the currently processed document.
    /// </summary>
    private SemanticModel semanticModel = null!;

    /// <summary>
    /// Initializes the renamer to work for a new document. Must be called before visiting any nodes.
    /// </summary>
    public void Initialize(SemanticModel semanticModel)
    {
        this.semanticModel = semanticModel;
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
        var symbol = semanticModel.GetDeclaredSymbol(node);
        var current = (ClassDeclarationSyntax)base.VisitClassDeclaration(node)!;

        if (symbol != null)
        {
            current = current.WithIdentifier(GetRenamed(symbol, node.Identifier))
                .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
                .WithTrailingTrivia(node.GetTrailingTrivia());
        }

        return current;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitStructDeclaration(StructDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        var current = (StructDeclarationSyntax)base.VisitStructDeclaration(node)!;

        if (symbol != null)
        {
            current = current.WithIdentifier(GetRenamed(symbol, node.Identifier))
                .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
                .WithTrailingTrivia(node.GetTrailingTrivia());
        }

        return current;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        var current = (InterfaceDeclarationSyntax)base.VisitInterfaceDeclaration(node)!;

        if (symbol != null)
        {
            current = current.WithIdentifier(GetRenamed(symbol, node.Identifier))
                .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
                .WithTrailingTrivia(node.GetTrailingTrivia());
        }

        return current;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitRecordDeclaration(RecordDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        var current = (RecordDeclarationSyntax)base.VisitRecordDeclaration(node)!;

        if (symbol != null)
        {
            current = current.WithIdentifier(GetRenamed(symbol, node.Identifier))
                .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
                .WithTrailingTrivia(node.GetTrailingTrivia());
        }

        return current;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitDelegateDeclaration(DelegateDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        var current = (DelegateDeclarationSyntax)base.VisitDelegateDeclaration(node)!;

        if (symbol != null)
        {
            current = current.WithIdentifier(GetRenamed(symbol, node.Identifier))
                .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
                .WithTrailingTrivia(node.GetTrailingTrivia());
        }

        return current;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitEnumDeclaration(EnumDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        var current = (EnumDeclarationSyntax)base.VisitEnumDeclaration(node)!;

        if (symbol != null)
        {
            current = current.WithIdentifier(GetRenamed(symbol, node.Identifier))
                .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
                .WithTrailingTrivia(node.GetTrailingTrivia());
        }

        return current;
    }

    // ----- Members -----

    /// <inheritdoc />
    public override SyntaxNode VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        var current = (EnumMemberDeclarationSyntax)base.VisitEnumMemberDeclaration(node)!;

        if (symbol != null)
        {
            current = current.WithIdentifier(GetRenamed(symbol, node.Identifier))
                .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
                .WithTrailingTrivia(node.GetTrailingTrivia());
        }

        return current;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        var current = (PropertyDeclarationSyntax)base.VisitPropertyDeclaration(node)!;

        if (symbol != null)
        {
            current = current.WithIdentifier(GetRenamed(symbol, node.Identifier))
                .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
                .WithTrailingTrivia(node.GetTrailingTrivia());
        }

        return current;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitEventDeclaration(EventDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        var current = (EventDeclarationSyntax)base.VisitEventDeclaration(node)!;

        if (symbol != null)
        {
            current = current.WithIdentifier(GetRenamed(symbol, node.Identifier))
                .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
                .WithTrailingTrivia(node.GetTrailingTrivia());
        }

        return current;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        var current = (MethodDeclarationSyntax)base.VisitMethodDeclaration(node)!;

        if (symbol != null)
        {
            current = current.WithIdentifier(GetRenamed(symbol, node.Identifier))
                .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
                .WithTrailingTrivia(node.GetTrailingTrivia());
        }

        return current;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        var current = (ConstructorDeclarationSyntax)base.VisitConstructorDeclaration(node)!;

        if (symbol != null)
        {
            current = current.WithIdentifier(GetRenamed(symbol, node.Identifier))
                .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
                .WithTrailingTrivia(node.GetTrailingTrivia());
        }

        return current;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitDestructorDeclaration(DestructorDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        var current = (DestructorDeclarationSyntax)base.VisitDestructorDeclaration(node)!;

        if (symbol != null)
        {
            current = current.WithIdentifier(GetRenamed(symbol, node.Identifier))
                .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
                .WithTrailingTrivia(node.GetTrailingTrivia());
        }

        return current;
    }

    // ----- Other -----

    /// <inheritdoc />
    public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
    {
        var symbol = semanticModel.GetSymbolInfo(node).Symbol ?? semanticModel.GetTypeInfo(node).Type;
        var current = (IdentifierNameSyntax)base.VisitIdentifierName(node)!;

        if (symbol != null)
        {
            current = current.WithIdentifier(GetRenamed(symbol, node.Identifier))
                .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
                .WithTrailingTrivia(node.GetTrailingTrivia());
        }

        return current;
    }

    // This also covers fields
    /// <inheritdoc />
    public override SyntaxNode VisitVariableDeclarator(VariableDeclaratorSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        var current = (VariableDeclaratorSyntax)base.VisitVariableDeclarator(node)!;

        if (symbol != null)
        {
            current = current.WithIdentifier(GetRenamed(symbol, node.Identifier))
                .WithLeadingTrivia(node.GetLeadingTrivia().Select(VisitTrivia))
                .WithTrailingTrivia(node.GetTrailingTrivia());
        }

        return current;
    }
}
