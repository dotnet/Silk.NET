// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A generic <see cref="Symbol"/> representing a named type.
/// </summary>
/// <param name="Id">An Identifier used for referencing types globally</param>
/// <param name="Identifier">The identifier of this type</param>
/// <param name="Members">The members of this type</param>
/// <param name="Annotations">The annotations of this symbol</param>
/// <seealso cref="StructSymbol"/>
public abstract record TypeSymbol
    (TypeId Id, IdentifierSymbol Identifier, ImmutableArray<MemberSymbol> Members, ImmutableArray<ISymbolAnnotation> Annotations) : Symbol(Annotations);
