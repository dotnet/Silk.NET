// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.Windowing;

/// <summary>
/// An interface implemented by recipients of events pertaining to surfaces.
/// </summary>
public interface ISurfaceActor
{
    /// <summary>
    /// Responds to the client size changing.
    /// </summary>
    /// <param name="newSize">The new client size.</param>
    void HandleClientSizeChanged(Vector2 newSize);

    /// <summary>
    /// Responds to operating system activity pertaining to the surface. This is executed at every opportunity, but most
    /// notably after an operating system event has been polled.
    /// </summary>
    void HandleTick();
}
