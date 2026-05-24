using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch.Mods.LocationTransformation;

/// <summary>
/// Finds references to the provided symbols and applies a set of transformations on each referencing location.
/// This is meant to be used by <see cref="LocationTransformationUtils.ModifyAllReferencesAsync"/>.
/// </summary>
/// <remarks>
/// This rewriter identifies symbols and referencing locations when traversing downwards into the syntax tree
/// and modifies the nodes only when coming back up.
/// <br/>
/// Modifying nodes cause them to be detached from the semantic model (meaning no symbol information),
/// so this ensures that we gather all the data we need before making changes.
/// </remarks>
public class LocationTransformationRewriter : CSharpSyntaxRewriter
{
    // Symbols can also be referenced within XML doc, which are trivia nodes.
    /// <inheritdoc />
    public override bool VisitIntoStructuredTrivia => true;

    private readonly Dictionary<SyntaxNode, QueuedTransformation> _queuedTransformations = new();

    /// <param name="Symbol">The symbol for the node.</param>
    /// <param name="TransformerIndex">The index of the transformer that should be used when continuing the transformation process.</param>
    private record struct QueuedTransformation(ISymbol Symbol, int TransformerIndex);

    private readonly List<SyntaxNode> _tempNodeList = new();

    /// <summary>
    /// The semantic model of the currently processed document.
    /// </summary>
    private SemanticModel _semanticModel = null!;

    private readonly HashSet<ISymbol> _symbols;
    private readonly List<LocationTransformer> _transformers;
    private readonly HashSet<string> _relevantIdentifiers;

    /// <param name="symbols">Symbols to search for.</param>
    /// <param name="transformers">Transformers to use on each found symbol reference.</param>
    public LocationTransformationRewriter(
        HashSet<ISymbol> symbols,
        List<LocationTransformer> transformers
    )
    {
        _symbols = symbols;
        _transformers = transformers;

        // Used to skip symbol lookups
        // Does not handle the omission of the "-Attribute" suffix, but generally, we don't need to transform attributes
        _relevantIdentifiers = new HashSet<string>(_symbols.Count);
        foreach (var symbol in _symbols)
        {
            _relevantIdentifiers.Add(symbol.Name);
        }
    }

    private LocationTransformationRewriter(
        HashSet<ISymbol> symbols,
        List<LocationTransformer> transformers,
        HashSet<string> relevantIdentifiers
    )
    {
        _symbols = symbols;
        _transformers = transformers;
        _relevantIdentifiers = relevantIdentifiers;
    }

    /// <summary>
    /// Initializes the renamer to work for a new document. Must be called before visiting any nodes.
    /// </summary>
    public void Initialize(SemanticModel semanticModel) => _semanticModel = semanticModel;

    /// <summary>
    /// Clone this rewriter for purposes of thread safety.
    /// </summary>
    /// <remarks>
    /// This is allowed to return the current instance and share data.
    /// </remarks>
    public LocationTransformationRewriter GetThreadSafeCopy() =>
        new(_symbols, [.. _transformers.Select(t => t.GetThreadSafeCopy())], _relevantIdentifiers);

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
        if (_queuedTransformations.Remove(unmodifiedNode, out var transformation))
        {
            if (transformation.TransformerIndex >= 0)
            {
                // Apply deferred transformer
                var deferredTransformer = _transformers[transformation.TransformerIndex];
                modifiedNode = deferredTransformer
                    .Visit(modifiedNode)
                    .WithLeadingTrivia(unmodifiedNode.GetLeadingTrivia().Select(VisitTrivia))
                    .WithTrailingTrivia(unmodifiedNode.GetTrailingTrivia());
            }

            // Continue applying remaining transformers
            for (var i = transformation.TransformerIndex + 1; i < _transformers.Count; i++)
            {
                var transformer = _transformers[i];

                // Calculate hierarchy
                var hierarchy = _tempNodeList;
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
                    _queuedTransformations.Add(
                        selectedNode,
                        new QueuedTransformation(transformation.Symbol, i)
                    );

                    break;
                }

                // Transform the node
                modifiedNode = transformer
                    .Visit(modifiedNode)
                    .WithLeadingTrivia(unmodifiedNode.GetLeadingTrivia().Select(VisitTrivia))
                    .WithTrailingTrivia(unmodifiedNode.GetTrailingTrivia());
            }
        }

        return modifiedNode;
    }

    private void ReportSymbol(SyntaxNode node, ISymbol? symbol)
    {
        if (symbol == null || !_symbols.Contains(symbol))
        {
            return;
        }

        _queuedTransformations.Add(node, new QueuedTransformation(symbol, -1));
    }

    // ----- Types -----

    /// <inheritdoc />
    public override SyntaxNode VisitClassDeclaration(ClassDeclarationSyntax node)
    {
        var symbol = _semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitClassDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitStructDeclaration(StructDeclarationSyntax node)
    {
        var symbol = _semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitStructDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
    {
        var symbol = _semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitInterfaceDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitRecordDeclaration(RecordDeclarationSyntax node)
    {
        var symbol = _semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitRecordDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitDelegateDeclaration(DelegateDeclarationSyntax node)
    {
        var symbol = _semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitDelegateDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitEnumDeclaration(EnumDeclarationSyntax node)
    {
        var symbol = _semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitEnumDeclaration(node)!;
    }

    // ----- Members -----

    /// <inheritdoc />
    public override SyntaxNode VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
    {
        var symbol = _semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitEnumMemberDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitPropertyDeclaration(PropertyDeclarationSyntax node)
    {
        var symbol = _semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitPropertyDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitEventDeclaration(EventDeclarationSyntax node)
    {
        var symbol = _semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitEventDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
        var symbol = _semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitMethodDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
    {
        var symbol = _semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitConstructorDeclaration(node)!;
    }

    /// <inheritdoc />
    public override SyntaxNode VisitDestructorDeclaration(DestructorDeclarationSyntax node)
    {
        var symbol = _semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitDestructorDeclaration(node)!;
    }

    // ----- Other -----

    /// <inheritdoc />
    public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
    {
        if (!_relevantIdentifiers.Contains(node.Identifier.Text))
        {
            return node;
        }

        var symbol = _semanticModel.GetSymbolInfo(node).Symbol;
        ReportSymbol(node, symbol);

        return base.VisitIdentifierName(node)!;
    }

    // This also covers fields
    /// <inheritdoc />
    public override SyntaxNode VisitVariableDeclarator(VariableDeclaratorSyntax node)
    {
        var symbol = _semanticModel.GetDeclaredSymbol(node);
        ReportSymbol(node, symbol);

        return base.VisitVariableDeclarator(node)!;
    }

    // ----- Skipped nodes -----

    // Using statements contain a lot of identifier nodes, but never any symbol references that we care about.
    /// <inheritdoc />
    public override SyntaxNode VisitUsingDirective(UsingDirectiveSyntax node) => node;
}
