// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// Represents a parsed <see cref="NameAffixAttribute"/>.
/// </summary>
/// <param name="IsPrefix">True if the affix is declared as a prefix. False if it is a suffix.</param>
/// <param name="Category">The category of the affix.</param>
/// <param name="Affix">The affix of the identifier.</param>
/// <param name="DeclarationOrder">The order that the attribute was declared in. 0 is the first.</param>
public record struct NameAffix(bool IsPrefix, string Category, string Affix, int DeclarationOrder);
