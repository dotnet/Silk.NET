using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods.Transformation;

/// <summary>
/// Provides functionality for <see cref="IFunctionTransformer"/>s for influencing outside of the scope of the specific
/// function they're transforming.
/// </summary>
public interface ITransformationContext
{
    /// <summary>
    /// Adds a namespace import to the resultant syntax tree.
    /// </summary>
    /// <param name="str">The dot-separated namespace.</param>
    /// <returns>Whether it was added.</returns>
    bool AddUsing(string str) =>
        AddUsing(UsingDirective(ModUtils.NamespaceIntoIdentifierName(str)));

    /// <summary>
    /// Adds a using directive to the resultant syntax tree.
    /// </summary>
    /// <param name="use">The directive.</param>
    /// <returns>Whether it was added.</returns>
    bool AddUsing(UsingDirectiveSyntax use);
}
