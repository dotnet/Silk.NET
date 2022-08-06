// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// Represents a reference to a type that is also defined as part of this symbol tree.
/// </summary>
/// <param name="ReferencedTypeId">The <see cref="Type"/>.Id of the <see cref="Type"/> referenced.</param>
public sealed record InternalTypeReference(Guid ReferencedTypeId) : TypeReference()
{
}
