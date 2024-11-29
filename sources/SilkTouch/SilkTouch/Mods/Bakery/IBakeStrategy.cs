// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
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
    string Name { get; }

    /// <summary>
    /// Gets a declaration to store in a <see cref="BakeSet" /> element, merging the encountered declaration with the
    /// existing one in that <see cref="BakeSet" /> element if provided.
    /// </summary>
    /// <param name="node">The encountered syntax node.</param>
    /// <param name="discrim">The discriminator for this member.</param>
    /// <param name="existing">The current member stored in the <see cref="BakeSet" />.</param>
    /// <returns>The merged type declaration.</returns>
    MemberDeclarationSyntax BakeMember(
        MemberDeclarationSyntax node,
        string? discrim,
        BakedMember? existing
    );
}
