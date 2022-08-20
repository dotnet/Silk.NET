// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A <see cref="TypeReference"/> representing a pointer type
/// </summary>
/// <param name="Underlying">A reference to the pointed to type</param>
/// <param name="Annotations">The annotations of this symbol</param>
public sealed record PointerTypeReference
    (TypeReference Underlying, ImmutableArray<ISymbolAnnotation> Annotations) : TypeReference(Annotations);
