// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
    /// The original method signature.
    /// </summary>
    public MethodDeclarationSyntax? Original { get; set; }

    /// <summary>
    /// The transformers in use.
    /// </summary>
    public IFunctionTransformer[]? Transformers { get; set; }

    /// <summary>
    /// Adds a namespace import to the resultant syntax tree.
    /// </summary>
    /// <param name="ns">The dot-separated namespace.</param>
    /// <returns>Whether it was added.</returns>
    public bool AddUsing(string ns) =>
        AddUsing(UsingDirective(ModUtils.NamespaceIntoIdentifierName(ns)));

    /// <summary>
    /// Adds a using directive to the resultant syntax tree.
    /// </summary>
    /// <param name="use">The directive.</param>
    /// <returns>Whether it was added.</returns>
    public bool AddUsing(UsingDirectiveSyntax use);
}
