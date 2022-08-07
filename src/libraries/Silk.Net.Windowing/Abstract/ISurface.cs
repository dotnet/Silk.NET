// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using Silk.NET.Core;
using Silk.NET.Maths;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Represents a surface with a framebuffer on which to draw on.
    /// </summary>
    public interface ISurface : IWindowHandlesSource, IDisposable
    {
        /// <summary>
        /// Determines whether the surface is being destroyed by the platform.
        /// </summary>
        bool IsTerminating { get; }
        
        /// <summary>
        /// Determines whether the surface is being paused by the platform.
        /// </summary>
        bool IsPausing { get; }

        /// <summary>
        /// Elapsed time in seconds since the Run method last started.
        /// </summary>
        double Time { get; }

        /// <summary>
        /// The size of the surface's inner framebuffer. May differ from the surface size.
        /// </summary>
        // NB: This is not OpenGL specific and is valid in any case where there's a high DPI monitor.
        Vector2D<int> FramebufferSize { get; }

        /// <summary>
        /// The size of the surface.
        /// </summary>
        Vector2D<int> Size { get; }

        /// <summary>
        /// The number of rendering operations to run every second.
        /// </summary>
        double FramesPerSecond { get; set; }

        /// <summary>
        /// The number of update operations to run every second.
        /// </summary>
        double UpdatesPerSecond { get; set; }

        /// <summary>
        /// Raised when the surface is resized.
        /// </summary>
        event Vector2DAction? Resize;

        /// <summary>
        /// Raised when the surface's framebuffer is resized.
        /// </summary>
        event Vector2DAction? FramebufferResize;

        /// <summary>
        /// Raised when the surface is being terminated.
        /// </summary>
        event Action? Terminating;

        /// <summary>
        /// Raised when the surface is running low on memory.
        /// </summary>
        event Action? LowMemory;

        /// <summary>
        /// Raised when the surface is about to pause. This is a good indicator that the Run method is about to exit, though this may not necessarily be the case, but the surface isn't terminating yet.
        /// </summary>
        event Action? Pausing;

        /// <summary>
        /// Raised when the surface is about to resume. This is a good indicator to expect the entry point to be called again, though this may not necessarily be the case. 
        /// </summary>
        event Action? Resuming;

        /// <summary>
        /// Raised when the surface is initialized for the first time.
        /// </summary>
        event Action? Created;
        
        /// <summary>
        /// Raised just before the Update event is raised.
        /// </summary>
        event Action? PreUpdate;

        /// <summary>
        /// Raised when an update should be run.
        /// </summary>
        event DeltaAction? Update;

        /// <summary>
        /// Raised when a frame should be rendered.
        /// </summary>
        event DeltaAction? Render;

        /// <summary>
        /// Creates the surface on the underlying platform.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Calls the Render event.
        /// </summary>
        void DoRender();

        /// <summary>
        /// Calls the Update event.
        /// </summary>
        void DoUpdate();

        /// <summary>
        /// Polls the underlying platform for events.
        /// </summary>
        void DoEvents();

        /// <summary>
        /// Unloads the surface on the underlying platform.
        /// </summary>
        void Reset();

        /// <summary>
        /// Terminates this surface.
        /// </summary>
        void Terminate();

        /// <summary>
        /// Converts this point to framebuffer coordinates.
        /// </summary>
        /// <param name="point">The point to transform.</param>
        /// <returns>The transformed point.</returns>
        /// <remarks>Expects client coordinates as input.</remarks>
        Vector2D<int> PointToFramebuffer(Vector2D<int> point);

        /// <summary>
        /// Initiates a render loop in which the given callback is called as fast as the underlying platform can manage.
        /// </summary>
        /// <param name="onFrame">The callback to run each frame.</param>
        void Run(Action onFrame);
    }
}
