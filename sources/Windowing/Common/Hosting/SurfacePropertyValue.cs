// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.InteropServices;
using Silk.NET.Maths;

namespace Silk.NET.Windowing.Hosting;

/// <summary>
/// A union of value types for properties.
/// </summary>
[StructLayout(LayoutKind.Explicit)]
public struct SurfacePropertyValue
{
    /// <summary>
    /// The property value for <see cref="SurfaceProperty.IsFloat"/> properties. In cases where the property represents
    /// a scalar float, only <see cref="Vector2.X"/> will be used. This is expected to be known at the point of usage.
    /// </summary>
    [FieldOffset(0)]
    public Vector2 Float;

    /// <summary>
    /// The property value for <see cref="SurfaceProperty.IsInteger"/> properties. In cases where the property
    /// represents a scalar integer, only <see cref="Vector2D{T}.X"/> will be used. This is expected to be known at the
    /// point of usage.
    /// </summary>
    [FieldOffset(0)]
    public Vector2D<int> Integer;

    /// <summary>
    /// The property value for <see cref="SurfaceProperty.IsBoolean"/> properties.
    /// </summary>
    [FieldOffset(0)]
    public bool Boolean;
}
