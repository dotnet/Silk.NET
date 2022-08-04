// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// Represents a reference to an external type
/// </summary>
public sealed record ExternalTypeReference(IdentifierSymbol? Namespace, IdentifierSymbol TypeIdentifier) : TypeReference
{
}
