// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A <see cref="TypeReference"/> representing a function pointer.
/// </summary>
public sealed record FunctionPointerTypeReference
(
    TypeReference ReturnType,
    ImmutableArray<TypeReference> ParameterTypes,
    ImmutableArray<ISymbolAnnotation> Annotations
) : TypeReference(Annotations);
