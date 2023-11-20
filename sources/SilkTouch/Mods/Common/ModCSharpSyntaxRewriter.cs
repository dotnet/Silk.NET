using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// <see cref="CSharpSyntaxRewriter"/> containing common functionality for mods.
/// </summary>
public abstract class ModCSharpSyntaxRewriter(bool visitIntoStructuredTrivia = false)
    : CSharpSyntaxRewriter(visitIntoStructuredTrivia)
{
    private bool _hasCompLevelUsings;

    /// <summary>
    /// <c>using</c>s to add to the appropriate place within the syntax tree.
    /// </summary>
    protected List<string> UsingsToAdd { get; set; } = new();

    private IEnumerable<UsingDirectiveSyntax> UsingDirectivesToAdd =>
        UsingsToAdd.Distinct().Select(x => UsingDirective(ModUtils.NamespaceIntoIdentifierName(x)));

    /// <inheritdoc />
    public override SyntaxNode? VisitCompilationUnit(CompilationUnitSyntax node)
    {
        if (node.Usings.Count > 0)
        {
            _hasCompLevelUsings = true;
        }
        var ret = base.VisitCompilationUnit(node);
        if (UsingsToAdd.Count > 0 && node.Usings.Count > 0)
        {
            UsingsToAdd.RemoveAll(x => node.Usings.Any(y => y.Name?.ToString() == x));
        }
        if (UsingsToAdd.Count <= 0 || ret is not CompilationUnitSyntax comp)
        {
            return ret;
        }

        ret = comp.WithUsings(comp.Usings.AddRange(UsingDirectivesToAdd));
        UsingsToAdd.Clear();
        return ret;
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
    {
        var ret = base.VisitNamespaceDeclaration(node);
        if (UsingsToAdd.Count > 0 && node.Usings.Count > 0)
        {
            UsingsToAdd.RemoveAll(x => node.Usings.Any(y => y.Name?.ToString() == x));
        }

        if (UsingsToAdd.Count <= 0 || _hasCompLevelUsings || ret is not CompilationUnitSyntax comp)
        {
            return ret;
        }

        ret = comp.WithUsings(comp.Usings.AddRange(UsingDirectivesToAdd));
        UsingsToAdd.Clear();
        return ret;
    }
}
