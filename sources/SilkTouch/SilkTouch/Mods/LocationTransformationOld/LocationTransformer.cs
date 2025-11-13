// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Silk.NET.SilkTouch.Mods.LocationTransformationOld;

/// <summary>
/// Base class for location transformers used by <see cref="LocationTransformationUtils.ModifyAllReferencesAsync"/>.
/// </summary>
public abstract class LocationTransformer : CSharpSyntaxRewriter
{
    /// <summary>
    /// Given a node, this method should return the given node, another node, or null.
    /// Returning null will lead to no node being modified.
    /// Returning the another node will lead to the other node being modified instead of the original node.
    /// </summary>
    /// <param name="current">The current node.</param>
    /// <param name="context">Additional information about the syntax node being processed.</param>
    /// <returns>The given node, another node, or null.</returns>
    public abstract SyntaxNode? GetNodeToModify(SyntaxNode current, LocationTransformerContext context);
}
