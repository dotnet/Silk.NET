// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch.Mods.Bakery;

/// <summary>
/// Represents a map of API discriminators to a merged ("baked") declaration syntax, a <see cref="BakeSet"/>
/// representing the APIs contained therein, and a declaration order hint.
/// </summary>
public class BakeSet
{
    /// <summary>
    /// The bake set.
    /// </summary>
    public Dictionary<string, BakedMember> Children { get; } = new();
}
