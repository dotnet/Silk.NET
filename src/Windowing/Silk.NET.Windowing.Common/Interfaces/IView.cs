// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Contexts;
using Silk.NET.Maths;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Represents a window view.
    /// </summary>
    public interface IView : IViewProperties, IGLContextSource, IVkSurfaceSource, IDisposable, INativeWindowSource
    {
        /// <summary>
        /// A handle to the underlying window.
        /// </summary>
        nint Handle { get; }

        /// <summary>
        /// Determines whether the underlying platform has requested the window to close.
        /// </summary>
        bool IsClosing { get; }

        /// <summary>
        /// Elapsed time in seconds since the View was initialized.
        /// </summary>
        double Time { get; }

        /// <summary>
        /// The size of the framebuffer. May differ from the window size.
        /// </summary>
        Vector2D<int> FramebufferSize { get; }

        /// <summary>
        /// Determines if the window is initialized.
        /// </summary>
        bool IsInitialized { get; }

        /// <summary>
        /// Raised when the window is resized.
        /// </summary>
        event Action<Vector2D<int>>? Resize;

        /// <summary>
        /// Raised when the window's framebuffer is resized.
        /// </summary>
        event Action<Vector2D<int>>? FramebufferResize;

        /// <summary>
        /// Raised when the window is about to close.
        /// </summary>
        event Action? Closing;

        /// <summary>
        /// Raised when the window focus changes.
        /// </summary>
        event Action<bool>? FocusChanged;

        /// <summary>
        /// Raised when the window first begins to run.
        /// </summary>
        event Action? Load;

        /// <summary>
        /// Raised when an update should be run.
        /// </summary>
        event Action<double>? Update;

        /// <summary>
        /// Raised when a frame should be rendered.
        /// </summary>
        event Action<double>? Render;

        /// <summary>
        /// Creates the window on the underlying platform.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Calls the Render event. On a multi-threaded window, this will run on an internally managed thread.
        /// </summary>
        void DoRender();

        /// <summary>
        /// Calls the Update event. On a multi-threaded window, this can run on any thread.
        /// </summary>
        void DoUpdate();

        /// <summary>
        /// Polls the underlying platform for events.
        /// </summary>
        void DoEvents();

        /// <summary>
        /// When using <see cref="WindowOptions.IsEventDriven"/> = true, wakes the main thread from
        /// its blocking wait on incoming events.  Can be called from any thread.
        /// </summary>
        void ContinueEvents();

        /// <summary>
        /// Unloads the window on the underlying platform.
        /// </summary>
        void Reset();

        /// <summary>
        /// Sets focus to current window.
        /// </summary>
        void Focus();

        /// <summary>
        /// Close this window.
        /// </summary>
        void Close();

        /// <summary>
        /// Converts this point to client coordinates.
        /// </summary>
        /// <param name="point">The point to transform.</param>
        /// <returns>The transformed point.</returns>
        /// <remarks>Expects screen coordinates as input.</remarks>
        Vector2D<int> PointToClient(Vector2D<int> point);

        /// <summary>
        /// Converts this point to screen coordinates.
        /// </summary>
        /// <param name="point">The point to transform.</param>
        /// <returns>The transformed point.</returns>
        /// <remarks>Expects client coordinates as input.</remarks>
        Vector2D<int> PointToScreen(Vector2D<int> point);

        /// <summary>
        /// Converts this point to framebuffer coordinates.
        /// </summary>
        /// <param name="point">The point to transform.</param>
        /// <returns>The transformed point.</returns>
        /// <remarks>Expects client coordinates as input.</remarks>
        Vector2D<int> PointToFramebuffer(Vector2D<int> point);

        /// <summary>
        /// Invokes this delegate on the window's main thread, with the provided arguments.
        /// </summary>
        /// <param name="d">The delegate to run.</param>
        /// <param name="args">The delegate's arguments.</param>
        /// <returns>An object returned from the delegate.</returns>
        object Invoke(Delegate d, params object[] args);

        /// <summary>
        /// Initiates a render loop in which the given callback is called as fast as the underlying platform can manage.
        /// </summary>
        /// <param name="onFrame">The callback to run each frame.</param>
        void Run(Action onFrame);
    }
}
