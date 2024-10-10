// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.InteropServices;
using Silk.NET.Maths;

namespace Silk.NET.Windowing.Hosting;

/// <summary>
/// Encapsulates a surface property as a union.
/// </summary>
public struct SurfaceProperty
{
    /// <summary>
    /// The property name.
    /// </summary>
    public SurfacePropertyName PropertyName;

    /// <summary>
    /// Determines whether <see cref="PropertyName"/> represents a float property for which <see cref="Float"/>
    /// should be used. In cases where the property represents a scalar float, only <see cref="Vector2.X"/> will be
    /// used. This is expected to be known at the point of usage.
    /// </summary>
    public bool IsFloat => ((byte)PropertyName & 0b1110_0000) == 0;

    /// <summary>
    /// Determines whether <see cref="PropertyName"/> represents an integer property for which <see cref="Float"/>
    /// should be used. In cases where the property represents a scalar float, only <see cref="Vector2.X"/> will be
    /// used. This is expected to be known at the point of usage.
    /// </summary>
    public bool IsInteger => ((byte)PropertyName & 0b1110_0000) == 0b0010_0000;

    /// <summary>
    /// Determines whether <see cref="PropertyName"/> represents a boolean property.
    /// </summary>
    public bool IsBoolean => ((byte)PropertyName & 0b1110_0000) == 0b0100_0000;

    /// <summary>
    /// The value for the property.
    /// </summary>
    public SurfacePropertyValue Value;

    /// <summary>
    /// The property value for <see cref="SurfaceProperty.IsFloat"/> properties. In cases where the property represents
    /// a scalar float, only <see cref="Vector2.X"/> will be used. This is expected to be known at the point of usage.
    /// </summary>
    public Vector2 Float
    {
        get => Value.Float;
        set => Value.Float = value;
    }

    /// <summary>
    /// The property value for <see cref="SurfaceProperty.IsInteger"/> properties. In cases where the property
    /// represents a scalar integer, only <see cref="Vector2D{T}.X"/> will be used. This is expected to be known at the
    /// point of usage.
    /// </summary>
    public Vector2D<int> Integer
    {
        get => Value.Integer;
        set => Value.Integer = value;
    }

    /// <summary>
    /// The property value for <see cref="IsBoolean"/> properties.
    /// </summary>
    public bool Boolean
    {
        get => Value.Boolean;
        set => Value.Boolean = value;
    }
}
