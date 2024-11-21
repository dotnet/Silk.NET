// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing;

using System.Numerics;
using Silk.NET.Maths;

/// <summary>
/// Contains properties pertaining to the window's position or size changing.
/// </summary>
/// <param name="Surface">The surface that owns the window the event pertains to.</param>
/// <param name="OldBounds">The previous value of <see cref="ISurfaceWindow.Bounds" />.</param>
/// <param name="NewBounds">The new value of <see cref="ISurfaceWindow.Bounds" />.</param>
/// <param name="OldClientArea">The previous value of <see cref="ISurfaceWindow.ClientArea" />.</param>
/// <param name="NewClientArea">The new value of <see cref="ISurfaceWindow.ClientArea" />.</param>
public readonly record struct WindowCoordinatesEvent(
    Surface Surface,
    Rectangle<float> OldBounds,
    Rectangle<float> NewBounds,
    Rectangle<float> OldClientArea,
    Rectangle<float> NewClientArea
)
{
    /// <summary>
    /// The previous value of <see cref="ISurfaceWindow.Size" />.
    /// </summary>
    public Vector2 OldSize => (Vector2)OldBounds.Size;

    /// <summary>
    /// The new value of <see cref="ISurfaceWindow.Size" />.
    /// </summary>
    public Vector2 NewSize => (Vector2)NewBounds.Size;

    /// <summary>
    /// The previous value of <see cref="ISurfaceWindow.ClientSize" />.
    /// </summary>
    public Vector2 OldClientSize => (Vector2)OldClientArea.Size;

    /// <summary>
    /// The new value of <see cref="ISurfaceWindow.ClientSize" />.
    /// </summary>
    public Vector2 NewClientSize => (Vector2)NewClientArea.Size;

    /// <summary>
    /// The previous value of <see cref="ISurfaceWindow.Position" />.
    /// </summary>
    public Vector2 OldPosition => (Vector2)OldBounds.Origin;

    /// <summary>
    /// The new value of <see cref="ISurfaceWindow.Position" />.
    /// </summary>
    public Vector2 NewPosition => (Vector2)NewBounds.Origin;
}
