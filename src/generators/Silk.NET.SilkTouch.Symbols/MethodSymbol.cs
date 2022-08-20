// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A <see cref="MemberSymbol"/> representing a method with a signature.
/// </summary>
public abstract record MethodSymbol
(
    TypeReference ReturnType,
    ImmutableArray<Parameter> Parameters,
    IdentifierSymbol Identifier,
    ImmutableArray<ISymbolAnnotation> Annotations
) : MemberSymbol(Identifier, Annotations);

/// <summary>
/// Represents a Parameter to a <see cref="MethodSymbol"/>
/// </summary>
/// <param name="TypeReference">The type of this parameter</param>
/// <param name="Identifier">The identifier of this parameter</param>
public sealed record Parameter(TypeReference TypeReference, IdentifierSymbol Identifier);
