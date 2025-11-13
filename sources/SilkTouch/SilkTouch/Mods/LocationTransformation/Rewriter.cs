using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch.Mods.LocationTransformation;

/// <summary>
/// Renames all references to each symbol with the specified new name.
/// </summary>
/// <param name="symbols">Symbols to search for.</param>
/// <param name="transformers">Transformers to use on each found symbol reference.</param>
public class Rewriter(IEnumerable<ISymbol> symbols, IEnumerable<LocationTransformer> transformers) : CSharpSyntaxRewriter
{
    // Identifiers can also be referenced within XML doc, which are trivia nodes.
    /// <inheritdoc />
    public override bool VisitIntoStructuredTrivia => true;

    private readonly IReadOnlySet<ISymbol> symbolLookup = new HashSet<ISymbol>(symbols, SymbolEqualityComparer.Default);

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

    private SyntaxNode Process(SyntaxNode node, ISymbol? symbol)
    {
        if (symbol == null || !symbolLookup.Contains(symbol))
        {
            return node;
        }

        var original = node;
        foreach (var transformer in transformers)
        {
            // TODO: Can't use the return value here directly
            var selectedNode = transformer.GetNodeToModify(node, symbol);
            if (selectedNode != node)
            {
                throw new NotImplementedException("Not supported yet");
            }

            node = transformer.Visit(node)
                .WithLeadingTrivia(original.GetLeadingTrivia().Select(VisitTrivia))
                .WithTrailingTrivia(original.GetTrailingTrivia());
        }

        return node;
    }

    // ----- Types -----

    /// <inheritdoc />
    public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        return (ClassDeclarationSyntax)Process(base.VisitClassDeclaration(node)!, symbol);
    }

    /// <inheritdoc />
    public override SyntaxNode VisitStructDeclaration(StructDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        return (StructDeclarationSyntax)Process(base.VisitStructDeclaration(node)!, symbol);
    }

    /// <inheritdoc />
    public override SyntaxNode VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        return (InterfaceDeclarationSyntax)Process(base.VisitInterfaceDeclaration(node)!, symbol);
    }

    /// <inheritdoc />
    public override SyntaxNode VisitRecordDeclaration(RecordDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        return (RecordDeclarationSyntax)Process(base.VisitRecordDeclaration(node)!, symbol);
    }

    /// <inheritdoc />
    public override SyntaxNode VisitDelegateDeclaration(DelegateDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        return (DelegateDeclarationSyntax)Process(base.VisitDelegateDeclaration(node)!, symbol);
    }

    /// <inheritdoc />
    public override SyntaxNode VisitEnumDeclaration(EnumDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        return (EnumDeclarationSyntax)Process(base.VisitEnumDeclaration(node)!, symbol);
    }

    // ----- Members -----

    /// <inheritdoc />
    public override SyntaxNode VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        return (EnumMemberDeclarationSyntax)Process(base.VisitEnumMemberDeclaration(node)!, symbol);
    }

    /// <inheritdoc />
    public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        return (PropertyDeclarationSyntax)Process(base.VisitPropertyDeclaration(node)!, symbol);
    }

    /// <inheritdoc />
    public override SyntaxNode VisitEventDeclaration(EventDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        return (EventDeclarationSyntax)Process(base.VisitEventDeclaration(node)!, symbol);
    }

    /// <inheritdoc />
    public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        return (MethodDeclarationSyntax)Process(base.VisitMethodDeclaration(node)!, symbol);
    }

    /// <inheritdoc />
    public override SyntaxNode VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        return (ConstructorDeclarationSyntax)Process(base.VisitConstructorDeclaration(node)!, symbol);
    }

    /// <inheritdoc />
    public override SyntaxNode VisitDestructorDeclaration(DestructorDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        return (DestructorDeclarationSyntax)Process(base.VisitDestructorDeclaration(node)!, symbol);
    }

    // ----- Other -----

    /// <inheritdoc />
    public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
    {
        var symbol = semanticModel.GetSymbolInfo(node).Symbol ?? semanticModel.GetTypeInfo(node).Type;
        return (IdentifierNameSyntax)Process(base.VisitIdentifierName(node)!, symbol);
    }

    // This also covers fields
    /// <inheritdoc />
    public override SyntaxNode VisitVariableDeclarator(VariableDeclaratorSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        return (VariableDeclaratorSyntax)Process(base.VisitVariableDeclarator(node)!, symbol);
    }
}
