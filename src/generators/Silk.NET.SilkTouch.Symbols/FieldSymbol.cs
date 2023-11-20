// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A <see cref="FieldSymbol"/>. A field is simply a named location that can hold some type.
/// </summary>
/// <param name="Identifier">The identifier of this field</param>
/// <param name="Type">The <see cref="TypeReference"/> of the data stored in this field</param>
/// <param name="Annotations">The annotations of this symbol</param>
/// <seealso cref="MemberSymbol"/>
public sealed record FieldSymbol
    (TypeReference Type, IdentifierSymbol Identifier, ImmutableArray<ISymbolAnnotation> Annotations)
    : MemberSymbol(Identifier, Annotations);
