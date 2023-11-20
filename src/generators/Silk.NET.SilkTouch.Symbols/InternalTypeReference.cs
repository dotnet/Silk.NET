// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// Represents a reference to a type that is also defined as part of this symbol tree.
/// </summary>
/// <param name="ReferencedTypeId">The <see cref="TypeSymbol.Id"/> of the <see cref="TypeSymbol"/> referenced.</param>
/// <param name="Annotations">The annotations of this symbol</param>
public sealed record InternalTypeReference
    (TypeId ReferencedTypeId, ImmutableArray<ISymbolAnnotation> Annotations) : TypeReference(Annotations);
