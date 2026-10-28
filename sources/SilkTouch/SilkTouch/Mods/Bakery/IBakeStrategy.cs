// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch.Mods.Bakery;

/// <summary>
/// Represents a strategy with which syntax declarations and hierarchies from multiple source sets are merged.
/// </summary>
public interface IBakeStrategy // the temptation to call this IRecipe was sooooooooooo big
{
    /// <summary>
    /// A name for the bake strategy as identified in <see cref="BakeSourceSets.Configuration.Strategy" />.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Cleans up the specified syntax node.
    /// </summary>
    /// <remarks>
    /// This typically is used to remove the members of the syntax node since baking involves extracting all members of each type.
    /// </remarks>
    public MemberDeclarationSyntax? Cleanup(MemberDeclarationSyntax? node);

    /// <summary>
    /// Merges the two specified members into a final syntax node.
    /// </summary>
    /// <remarks>
    /// This is only called when two bake sets have the same member.
    /// </remarks>
    /// <param name="discrim">The discriminator for this member.</param>
    /// <param name="existingParent">The parent of the existing member.</param>
    /// <param name="existing">The existing member.</param>
    /// <param name="incomingParent">The parent of the incoming member.</param>
    /// <param name="incoming">The incoming member.</param>
    /// <returns>The merged member declaration.</returns>
    public MemberDeclarationSyntax? Merge(
        string discrim,
        SyntaxNode? existingParent,
        BakedMember? existing,
        SyntaxNode? incomingParent,
        BakedMember incoming
    );
}
