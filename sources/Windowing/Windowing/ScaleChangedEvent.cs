// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing;

/// <summary>
/// Contains properties pertaining to a change in a surface's scale.
/// </summary>
/// <param name="Surface">The surface to which the change in scale occurred.</param>
/// <param name="OldContent">The previous value for <see cref="ISurfaceScale.Content"/>.</param>
/// <param name="NewContent">The new value for <see cref="ISurfaceScale.Content"/>.</param>
/// <param name="OldDraw">The previous value for <see cref="ISurfaceScale.Draw"/>.</param>
/// <param name="NewDraw">The new value for <see cref="ISurfaceScale.Draw"/>.</param>
/// <param name="OldPixelDensity">The previous value for <see cref="ISurfaceScale.PixelDensity"/>.</param>
/// <param name="NewPixelDensity">The new value for <see cref="ISurfaceScale.PixelDensity"/>.</param>
public readonly record struct ScaleChangedEvent(
    Surface Surface,
    float OldContent,
    float NewContent,
    float OldDraw,
    float NewDraw,
    float OldPixelDensity,
    float NewPixelDensity
);
