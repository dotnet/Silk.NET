using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Mods.Transformation;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// <see cref="CSharpSyntaxRewriter"/> containing common functionality for mods.
/// </summary>
public abstract class ModCSharpSyntaxRewriter(bool visitIntoStructuredTrivia = false)
    : CSharpSyntaxRewriter(visitIntoStructuredTrivia),
        ITransformationContext
{
    private ThreadLocal<Dictionary<string, UsingDirectiveSyntax>> _usingsToAdd =
        new(() => new Dictionary<string, UsingDirectiveSyntax>());

    /// <summary>
    /// <c>using</c>s to add to the appropriate place within the syntax tree.
    /// </summary>
    public Dictionary<string, UsingDirectiveSyntax> UsingsToAdd
    {
        get => _usingsToAdd.Value!;
        set => _usingsToAdd.Value = value;
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitCompilationUnit(CompilationUnitSyntax node)
    {
        var ret = base.VisitCompilationUnit(node);
        if (ret is not CompilationUnitSyntax comp)
        {
            return ret;
        }

        foreach (var use in comp.Usings.Where(use => !use.GlobalKeyword.IsKind(SyntaxKind.GlobalKeyword)))
        {
            AddUsing(use);
        }

        ret = comp.WithUsings(GetUsings(UsingsToAdd, comp))
            .WithMembers(
                UsingsToAdd.Count == 0
                    ? comp.Members
                    : List(
                        comp.Members.Select(x =>
                            x.WithLeadingTrivia(
                                x.GetLeadingTrivia()
                                    .Where(y =>
                                        y.Kind()
                                            is not SyntaxKind.SingleLineCommentTrivia
                                                and not SyntaxKind.MultiLineCommentTrivia
                                    )
                            )
                        )
                    )
            );

        return ret;
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitFileScopedNamespaceDeclaration(
        FileScopedNamespaceDeclarationSyntax node
    )
    {
        foreach (var use in node.Usings.Where(use => !use.GlobalKeyword.IsKind(SyntaxKind.GlobalKeyword)))
        {
            AddUsing(use);
        }

        return base.VisitFileScopedNamespaceDeclaration(node.WithUsings(default));
    }

    /// <summary>
    /// Gets all the usings for the given compilation unit.
    /// </summary>
    /// <param name="usingsToAdd">The usings to get.</param>
    /// <param name="comp">The compilation unit.</param>
    /// <returns>The using list.</returns>
    public static SyntaxList<UsingDirectiveSyntax> GetUsings(
        IReadOnlyCollection<KeyValuePair<string, UsingDirectiveSyntax>> usingsToAdd,
        CompilationUnitSyntax? comp
    ) =>
        List(
            usingsToAdd.Select(
                (x, i) =>
                    i == 0
                        ? x
                            .Value.WithoutTrailingTrivia()
                            .WithLeadingTrivia(
                                usingsToAdd
                                    .Select(y => y.Value.GetLeadingTrivia())
                                    .Concat(
                                        comp?.Members.Select(y => y.GetLeadingTrivia())
                                            ?? Enumerable.Empty<SyntaxTriviaList>()
                                    )
                                    .OrderByDescending(y =>
                                        y.Count(z =>
                                            z.Kind()
                                                is SyntaxKind.SingleLineCommentTrivia
                                                    or SyntaxKind.MultiLineCommentTrivia
                                                    or SyntaxKind.WhitespaceTrivia
                                        )
                                    )
                                    .FirstOrDefault()
                            )
                        : x.Value.WithoutTrivia()
            )
        );

    /// <inheritdoc />
    public virtual string? JobKey { get; set; }

    /// <inheritdoc />
    public MethodDeclarationSyntax? Original { get; set; }

    /// <inheritdoc />
    public IFunctionTransformer[]? Transformers { get; set; }

    /// <summary>
    /// Adds a namespace import to the resultant syntax tree.
    /// </summary>
    /// <param name="str">The dot-separated namespace.</param>
    /// <returns>Whether it was added.</returns>
    protected bool AddUsing(string str) =>
        AddUsing(UsingDirective(ModUtils.NamespaceIntoIdentifierName(str)));

    /// <summary>
    /// Adds a using directive to the resultant syntax tree.
    /// </summary>
    /// <param name="use">The directive.</param>
    /// <returns>Whether it was added.</returns>
    public bool AddUsing(UsingDirectiveSyntax use) => UsingsToAdd.TryAdd(Discrim(use), use);

    /// <summary>
    /// Gets a discriminator for the given using.
    /// </summary>
    /// <param name="use">The using.</param>
    /// <returns>The discriminator string.</returns>
    protected static string Discrim(UsingDirectiveSyntax use) =>
        new(use.WithoutTrivia().ToString().Where(char.IsAsciiLetterOrDigit).ToArray());
}
