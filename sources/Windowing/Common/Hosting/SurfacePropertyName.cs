// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing.Hosting;

/// <summary>
/// Enumerates properties available on surfaces.
/// </summary>
/// <remarks>Do not rely on the integral values of this enum, they may change in the future.</remarks>
public enum SurfacePropertyName : byte
{
    // XXXYYYYY
    // X = Property Type (0b000 = Vector2, 0b001 = Vector2D<int>, 0b010 = bool), Y = Property Name
    /// <summary>
    /// The client size.
    /// </summary>
    ClientSizeVector2 = 0b0000_0001,

    /// <summary>
    /// Whether events should be pumped on a separate thread to the root surface.
    /// </summary>
    UseSeparateEventThreadBoolean = 0b0100_0010,

    /// <summary>
    /// Whether events should be buffered instead of serialized (i.e. don't wait for all surfaces to read an event
    /// before polling for another event)
    /// </summary>
    UseBufferedEventLoopBoolean = 0b0100_0011
}
