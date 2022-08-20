// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// Represents a reference to a type, commonly used in places where a type needs to be referenced, but no access to all its members is required.
/// </summary>
/// <seealso cref="ExternalTypeReference"/>
/// <seealso cref="InternalTypeReference"/>
public abstract record TypeReference(ImmutableArray<ISymbolAnnotation> Annotations) : Symbol(Annotations);
