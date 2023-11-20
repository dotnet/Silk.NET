// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A <see cref="MemberSymbol"/>, representing a generic member of some <see cref="TypeSymbol"/>
/// </summary>
/// <param name="Identifier">The Identifier of this member</param>
/// <param name="Annotations">The annotations of this symbol</param>
/// <seealso cref="FieldSymbol"/>
public abstract record MemberSymbol
    (IdentifierSymbol Identifier, ImmutableArray<ISymbolAnnotation> Annotations) : Symbol(Annotations);
