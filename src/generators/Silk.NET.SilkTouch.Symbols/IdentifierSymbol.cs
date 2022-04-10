// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// An Identifier. Generally used to identify another symbol
/// </summary>
/// <seealso cref="TypeSymbol"/>
public sealed class IdentifierSymbol : Symbol
{
    /// <summary>
    /// Create an <see cref="IdentifierSymbol"/> from a string
    /// </summary>
    /// <param name="value">The identifier as a string</param>
    public IdentifierSymbol(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The Value of this Identifier as a String
    /// </summary>
    public string Value { get; }
}
