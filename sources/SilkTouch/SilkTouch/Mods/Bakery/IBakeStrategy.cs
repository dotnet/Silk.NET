// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
    public MemberDeclarationSyntax? Cleanup(MemberDeclarationSyntax? node);

    /// <summary>
    /// Merges the two specified members into a final syntax node.
    /// </summary>
    /// <param name="discrim">The discriminator for this member.</param>
    /// <param name="first">The first member.</param>
    /// <param name="second">The second member.</param>
    /// <returns>The merged member declaration.</returns>
    public MemberDeclarationSyntax? Merge(string discrim, BakedMember first, BakedMember second);
}
