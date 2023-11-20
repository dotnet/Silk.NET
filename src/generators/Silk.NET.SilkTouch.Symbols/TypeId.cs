// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Silk.NET.SilkTouch.Symbols;

/// <summary>
/// The Id of a <see cref="TypeSymbol"/>
/// </summary>
[JsonConverter(typeof(TypeId.JsonConverter))]
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

    /// <summary>
    /// Creates a new TypeID from a GUID. This is not a stable interface. DO NOT USE
    /// </summary>
    /// <param name="guid">The Guid to use for underlying identity</param>
    /// <returns>The Type ID</returns>
    [Obsolete("DO NOT USE. THIS IS NOT A STABLE INTERFACE")]
    public static TypeId From(Guid guid) => new TypeId(guid);

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

    /// <inheritdoc />
    public override string ToString()
    {
        return _guid.ToString();
    }

    private sealed class JsonConverter : JsonConverter<TypeId>
    {
        public override TypeId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (!reader.TryGetGuid(out var guid))
                throw new InvalidOperationException("Could not parse TypeId");

            return new TypeId(guid);
        }
        public override void Write(Utf8JsonWriter writer, TypeId value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value._guid);
        }
    }
}
