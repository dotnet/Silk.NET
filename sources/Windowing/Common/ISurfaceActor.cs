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
    /// Responds to the surface's initial creation.
    /// </summary>
    void HandleCreated();

    /// <summary>
    /// Responds to the surface being about to terminate irrevocably.
    /// </summary>
    void HandleTerminating();

    /// <summary>
    /// Responds surface requesting, possibly as a result of user action, closure. This may still be reversible at this
    /// stage.
    /// </summary>
    void HandleClosing();

    /// <summary>
    /// Responds to the surface pausing on request of the operating system.
    /// </summary>
    void HandlePausing();

    /// <summary>
    /// Responds to the surface resuming on request of the operating system.
    /// </summary>
    void HandleResuming();

    /// <summary>
    /// Responds to the surface being issued a low memory warning.
    /// </summary>
    void HandleLowMemory();

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
