// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// An Identifier. Generally used to identify another symbol
/// </summary>
/// <param name="Value">The String Value of this identifier</param>
/// <seealso cref="TypeSymbol"/>
public sealed record IdentifierSymbol(string Value) : Symbol
{
    /// <inheritdoc cref="object.ToString"/>
    public override string ToString() => Value;
}
