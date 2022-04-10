// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A generic <see cref="Symbol"/> representing a named type.
/// </summary>
/// <seealso cref="StructSymbol"/>
public abstract class TypeSymbol : Symbol
{
    /// <summary>
    /// The identifier of this type
    /// </summary>
    public abstract IdentifierSymbol Identifier { get; }
}
