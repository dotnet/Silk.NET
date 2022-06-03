// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A <see cref="TypeSymbol"/> representing a <c>struct</c>.
/// </summary>
/// <param name="Identifier">The Identifier of this struct</param>
/// <param name="Fields">The fields of this struct</param>
/// <remarks>
/// In this context, a Struct means a type that represents the layout of a continuous block of memory.
/// </remarks>
/// <remarks>
/// Structs are implicitly sequential in layout. There is no way to provide an offset at which to place a struct.
/// For types that would require such behavior there are separate symbols that may be defined.
/// </remarks>
public sealed record StructSymbol(IdentifierSymbol Identifier, ImmutableArray<FieldSymbol> Fields) : TypeSymbol(Identifier);
