// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A <see cref="Symbol"/> representing a <c>namespace</c>
/// </summary>
/// <param name="Identifier">The Identifier of this Namespace</param>
/// <param name="Types">The types in this namespace</param>
/// <param name="Annotations">The annotations of this symbol</param>
public sealed record NamespaceSymbol
(
    IdentifierSymbol Identifier,
    ImmutableArray<TypeSymbol> Types,
    ImmutableArray<ISymbolAnnotation> Annotations
) : Symbol(Annotations);
