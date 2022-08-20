// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A static external method symbol.
/// External meaning it must be loaded 
/// </summary>
public sealed record StaticExternalMethodSymbol
(
    TypeReference ReturnType,
    ImmutableArray<Parameter> Parameters,
    IdentifierSymbol Identifier,
    ImmutableArray<ISymbolAnnotation> Annotations
) : MethodSymbol(ReturnType, Parameters, Identifier, Annotations);
