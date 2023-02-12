// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A <see cref="TypeReference"/> representing a <c>class</c>
/// </summary>
public sealed record ClassSymbol
(
    TypeId Id,
    IdentifierSymbol Identifier,
    ImmutableArray<MemberSymbol> Members,
    ImmutableArray<ISymbolAnnotation> Annotations
) : TypeSymbol(Id, Identifier, Annotations);
