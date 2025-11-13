// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch.Mods.LocationTransformation;

/// <summary>
/// Reduces the pointer dimension by one for all locations transformed.
/// If the location is already a non-pointer, then nothing will be done.
/// </summary>
/// <example>
/// <c>Handle**</c> will be replaced with <c>Handle*</c>. <br/>
/// <c>Handle*</c> will be replaced with <c>Handle</c>.
/// </example>
public class PointerDimensionReductionTransformer : LocationTransformer
{
    /// <inheritdoc />
    public override SyntaxNode? GetNodeToModify(SyntaxNode current, ISymbol symbol)
    {
        if (current.Parent is PointerTypeSyntax parent)
        {
            return parent;
        }

        return null;
    }

    /// <inheritdoc />
    public override SyntaxNode? VisitPointerType(PointerTypeSyntax node) => node.ElementType;

    /// <inheritdoc />
    public override LocationTransformer GetThreadSafeCopy()
    {
        return this;
    }
}
