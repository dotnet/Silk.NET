// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Silk.NET.SilkTouch.Mods.LocationTransformation;

/// <summary>
/// Base class for location transformers used by <see cref="LocationTransformationUtils.ModifyAllReferencesAsync"/>.
/// </summary>
public abstract class LocationTransformer : CSharpSyntaxRewriter
{
    /// <summary>
    /// Given a node, this method should return the one of the nodes in the provided hierarchy or null.
    /// Returning null will lead to no node being modified.
    /// Returning a parent node will lead to the parent node being modified instead of the current node.
    /// Do not return child nodes.
    /// </summary>
    /// <remarks>
    /// <see cref="SyntaxNode.Parent"/> does not work because the current node (index 0)
    /// could already have been modified by a previous transformer.
    /// </remarks>
    /// <param name="hierarchy">The node hierarchy as a reversed stack. Index 0 is the current node. Index 1 is its parent and so on.</param>
    /// <param name="symbol">The symbol that is associated with this node.</param>
    /// <returns>The given node, another node, or null.</returns>
    public abstract SyntaxNode? GetNodeToModify(IReadOnlyList<SyntaxNode> hierarchy, ISymbol symbol);

    /// <summary>
    /// Clone this location transformer for purposes of thread safety.
    /// If the location transformer is already thread safe, the location transformer
    /// does not need to be cloned.
    /// </summary>
    public abstract LocationTransformer GetThreadSafeCopy();
}
