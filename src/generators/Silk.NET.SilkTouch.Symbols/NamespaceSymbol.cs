// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A <see cref="Symbol"/> representing a <c>namespace</c>
/// </summary>
public sealed record NamespaceSymbol(IdentifierSymbol Identifier, ImmutableArray<TypeSymbol> Types) : Symbol
{
}
