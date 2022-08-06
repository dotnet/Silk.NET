// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// The Id of a <see cref="TypeSymbol"/>
/// </summary>
public readonly struct TypeId : IEquatable<TypeId>
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

    /// <inheritdoc />
    public bool Equals(TypeId other) => _guid.Equals(other._guid);
    
    /// <inheritdoc />
    public override bool Equals(object? obj) => obj is TypeId other && Equals(other);
    
    /// <inheritdoc />
    public override int GetHashCode() => _guid.GetHashCode();
    
    /// <inheritdoc />
    public static bool operator ==(TypeId left, TypeId right) => left.Equals(right);
    
    /// <inheritdoc />
    public static bool operator !=(TypeId left, TypeId right) => !left.Equals(right);
}
