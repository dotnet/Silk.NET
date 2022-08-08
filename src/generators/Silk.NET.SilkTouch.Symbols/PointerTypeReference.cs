// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// A <see cref="TypeReference"/> representing a pointer type
/// </summary>
/// <param name="Underlying">A reference to the pointed to type</param>
public sealed record PointerTypeReference(TypeReference Underlying) : TypeReference;
