// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing;

/// <summary>
/// Represents a single window icon.
/// </summary>
public ref struct WindowIcon
{
    /// <summary>
    /// The width of the window icon.
    /// </summary>
    public required int Width { get; init; }

    /// <summary>
    /// The height of the window icon.
    /// </summary>
    public required int Height { get; init; }

    /// <summary>
    /// The window icon's pixel data in row-major order, where 4 bytes are allocated for each pixel and 1 byte
    /// representing each of the red, green, blue, and alpha channels (in that order).
    /// </summary>
    public required ReadOnlySpan<byte> Data { get; init; }
}
