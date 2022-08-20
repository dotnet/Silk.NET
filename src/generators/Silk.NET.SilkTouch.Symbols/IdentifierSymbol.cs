// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// An Identifier. Generally used to identify another symbol
/// </summary>
/// <param name="Value">The String Value of this identifier</param>
/// <param name="Annotations">The annotations of this symbol</param>
/// <seealso cref="TypeSymbol"/>
public sealed record IdentifierSymbol(string Value, ImmutableArray<ISymbolAnnotation> Annotations) : Symbol(Annotations)
{
    /// <inheritdoc cref="object.ToString"/>
    public override string ToString() => Value;
}
