// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// Represents a parsed <see cref="NameAffixAttribute"/>.
/// </summary>
/// <param name="Type">The type of affix.</param>
/// <param name="Category">The category of the affix.</param>
/// <param name="Affix">The affix of the identifier.</param>
/// <param name="DeclarationOrder">
/// The order that the attribute was declared in.
/// 0 is the first and indicates that the affix is on the inside of the name.
/// </param>
public record struct NameAffix(
    NameAffixType Type,
    string Category,
    string Affix,
    int DeclarationOrder
);
