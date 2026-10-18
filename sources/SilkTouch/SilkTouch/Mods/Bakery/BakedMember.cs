// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch.Mods.Bakery;

/// <summary>
/// Represents a baked <see cref="MemberDeclarationSyntax" /> with its own child
/// <see cref="MemberDeclarationSyntax"/>es, if any, split into a separate inner <see cref="BakeSet" />.
/// </summary>
public record BakedMember
{
    /// <summary>
    /// Creates a <see cref="Silk.NET.SilkTouch.Mods.Bakery.BakedMember"/>.
    /// </summary>
    /// <param name="Syntax">The baked declaration.</param>
    /// <param name="Inner">The children contained in this member.</param>
    /// <param name="Index">A hint for the order in which this member was declared in its parent.</param>
    public BakedMember(MemberDeclarationSyntax Syntax, BakeSet? Inner, int Index)
    {
        this.Syntax = Syntax;
        this.Inner = Inner;
        this.Index = Index;
    }

    /// <summary>The baked declaration.</summary>
    public MemberDeclarationSyntax Syntax { get; set; }

    /// <summary>The children contained in this member.</summary>
    public BakeSet? Inner { get; set; }

    /// <summary>A hint for the order in which this member was declared in its parent.</summary>
    public int Index { get; set; }
}
