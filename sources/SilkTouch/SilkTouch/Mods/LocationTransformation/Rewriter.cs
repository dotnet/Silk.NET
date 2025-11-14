using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch.Mods.LocationTransformation;

/// <summary>
/// Renames all references to each symbol with the specified new name.
/// </summary>
/// <param name="symbols">Symbols to search for.</param>
/// <param name="transformers">Transformers to use on each found symbol reference.</param>
public class Rewriter(HashSet<ISymbol> symbols, List<LocationTransformer> transformers) : CSharpSyntaxRewriter
{
    // Identifiers can also be referenced within XML doc, which are trivia nodes.
    /// <inheritdoc />
    public override bool VisitIntoStructuredTrivia => true;

    private readonly Dictionary<SyntaxNode, QueuedTransformation> queuedTransformations = new();

    /// <param name="Symbol">The symbol for the node.</param>
    /// <param name="TransformerIndex">The index of the transformer that should be used when continuing the transformation process.</param>
    private record struct QueuedTransformation(ISymbol Symbol, int TransformerIndex);

    private readonly List<SyntaxNode> tempNodeList = new();

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

    /// <inheritdoc />
    [return: NotNullIfNotNull("unmodifiedNode")]
    public override SyntaxNode? Visit(SyntaxNode? unmodifiedNode)
    {
        if (unmodifiedNode == null)
        {
            return unmodifiedNode;
        }

        // Visit
        var modifiedNode = base.Visit(unmodifiedNode);

        // Check for queued transformation
        // To apply a transformation, we must be in the same level in the hierarchy as the selected node
        // We also must apply transformations when going back up in the hierarchy so we don't overwrite previous transformations
        if (queuedTransformations.Remove(unmodifiedNode, out var transformation))
        {
            if (transformation.TransformerIndex >= 0)
            {
                // Apply deferred transformer
                var deferredTransformer = transformers[transformation.TransformerIndex];
                modifiedNode = deferredTransformer.Visit(modifiedNode)
                    .WithLeadingTrivia(unmodifiedNode.GetLeadingTrivia().Select(VisitTrivia))
                    .WithTrailingTrivia(unmodifiedNode.GetTrailingTrivia());
            }

            // Continue applying remaining transformers
            for (var i = transformation.TransformerIndex + 1; i < transformers.Count; i++)
            {
                var transformer = transformers[i];

                // Calculate hierarchy
                var hierarchy = tempNodeList;
                {
                    hierarchy.Clear();

                    // First is the current, modified node
                    // Modified nodes don't have parents
                    hierarchy.Add(modifiedNode);

                    // Remaining entries come from the original node's parents
                    var current = unmodifiedNode;
                    while (current.Parent != null)
                    {
                        hierarchy.Add(current.Parent);
                        current = current.Parent!;
                    }
                }

                // Select node to transform
                var selectedNode = transformer.GetNodeToModify(hierarchy, transformation.Symbol);
                if (selectedNode == null)
                {
                    continue;
                }

                if (selectedNode != modifiedNode)
                {
                    // We can't directly transform the node since we are at the wrong place in the hierarchy
                    // Defer it so it is processed later
                    queuedTransformations.Add(selectedNode, new QueuedTransformation(transformation.Symbol, i));

                    break;
                }

                // Transform the node
                modifiedNode = transformer.Visit(modifiedNode)
                    .WithLeadingTrivia(unmodifiedNode.GetLeadingTrivia().Select(VisitTrivia))
                    .WithTrailingTrivia(unmodifiedNode.GetTrailingTrivia());
            }
        }

        return modifiedNode;
    }

    private void ReportSymbol(SyntaxNode node, ISymbol? symbol)
    {
        if (symbol == null || !symbols.Contains(symbol))
        {
            return;
        }

        queuedTransformations.Add(node, new QueuedTransformation(symbol, -1));
    }

    // ----- Types -----

    /// <inheritdoc />
    public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitClassDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitStructDeclaration(StructDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitStructDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitInterfaceDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitRecordDeclaration(RecordDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitRecordDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitDelegateDeclaration(DelegateDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitDelegateDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitEnumDeclaration(EnumDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitEnumDeclaration(node)!;
    }

    // ----- Members -----

    /// <inheritdoc />
    public override SyntaxNode VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitEnumMemberDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitPropertyDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitEventDeclaration(EventDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitEventDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitMethodDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitConstructorDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitDestructorDeclaration(DestructorDeclarationSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitDestructorDeclaration(node)!;
    }

    // ----- Other -----

    /// <inheritdoc />
    public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
    {
        var symbol = semanticModel.GetSymbolInfo(node).Symbol ?? semanticModel.GetTypeInfo(node).Type;
        ReportSymbol(node, symbol);

        return base.VisitIdentifierName(node)!;
    }

    // This also covers fields
    /// <inheritdoc />
    public override SyntaxNode VisitVariableDeclarator(VariableDeclaratorSyntax node)
    {
        var symbol = semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitVariableDeclarator(node)!;
    }
}
