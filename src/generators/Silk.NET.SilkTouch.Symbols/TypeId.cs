// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// The Id of a <see cref="TypeSymbol"/>
/// </summary>
public readonly struct TypeId
{
    private readonly Guid _guid;
    private TypeId(Guid guid)
    {
        _guid = guid;
    }
    
    /// <summary>
    /// Creates a new, unique, instance
    /// </summary>
    /// <returns>The new instance</returns>
    public static TypeId CreateNew() => new TypeId(Guid.NewGuid());
}
