// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// Represents a reference to a type that is also defined as part of this symbol tree.
/// </summary>
/// <param name="Referenced">The Type referenced</param>
public sealed record InternalTypeReference(TypeSymbol Referenced) : TypeReference()
{
}
