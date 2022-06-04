// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// Represents a reference to an external type
/// </summary>
public record ExternalTypeReference(string? Namespace, string TypeName) : Symbol
{
    /// <summary>
    /// Gets the full unique name in C# global:: format.
    /// </summary>
    public string FullType => (Namespace is not null ? "global::" + Namespace + "." : "") + TypeName;
}
