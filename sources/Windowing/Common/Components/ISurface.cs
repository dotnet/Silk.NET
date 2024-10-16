// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Silk.NET.Windowing;

/// <summary>
/// Represents a native surface that has a drawable area (using operating system APIs) and that produces operating
/// system events.
/// </summary>
public interface ISurface : IDisposable
{
    /// <summary>
    /// Gets the size of the client area (drawing area) in pixels.
    /// </summary>
    /// <remarks>
    /// This accounts for high density displays and may differ from the size in window coordinates.
    /// Note that for this reason it is expected not to be accurate until <see cref="Launch{T}"/> is called.
    /// </remarks>
    Vector2 ClientSize { get; }

    /// <summary>
    /// Gets a unique handle representing this surface. This may be null if <see cref="Launch{T}"/> is not called.
    /// </summary>
    nint Handle { get; }

    /// <summary>
    /// Gets an implementation of the given component type if implemented by this surface.
    /// </summary>
    /// <param name="component">The component implementation.</param>
    /// <typeparam name="T">The component type.</typeparam>
    /// <returns>The </returns>
    bool TryGetComponent<T>([NotNullWhen(true)] out T? component);

    /// <summary>
    /// Runs the window's event loop, dispatching events to the given actor. This may be blocking, but won't always be
    /// blocking. You should dispose of your window and other resources in the window callbacks themselves. For
    /// instance, on mobile platforms a busy thread is often created by the underlying implementation implicitly,
    /// therefore the busy loop runs as a separate runnable. In this case, the window merely dispatches to that thread.
    /// </summary>
    /// <param name="actor">The actor receiving events.</param>
    /// <typeparam name="T">The type of the actor.</typeparam>
    void Launch<T>(T actor)
        where T : ISurfaceActor;
}
