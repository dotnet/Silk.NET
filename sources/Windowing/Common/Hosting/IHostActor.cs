// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing.Hosting;

/// <summary>
/// An actor that responds to messages regarding the lifecycle of all surfaces hosted on the <see cref="ISurfaceHost"/>.
/// </summary>
public interface IHostActor
{
    /// <summary>
    /// Called upon initialisation of each surface on the <see cref="ISurfaceHost"/>.
    /// </summary>
    /// <param name="surface">The surface initialising.</param>
    void HandleInit(SurfaceHandle surface);

    /// <summary>
    /// Called at every possible opportunity.
    /// </summary>
    void HandleTick();

    /// <summary>
    /// Called when the given surface is shutting down.
    /// </summary>
    void HandleQuit(SurfaceHandle surface);
}
