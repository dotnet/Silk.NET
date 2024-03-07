// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core;
using Silk.NET.Maths;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Extensions for IWindow
    /// </summary>
    public static class WindowExtensions
    {
        /// <summary>
        /// Executes a Func&lt;T&gt; delegate on the given view.
        /// </summary>
        /// <param name="view">The view to invoke on.</param>
        /// <param name="t">The function to invoke.</param>
        /// <typeparam name="T">Type of the function.</typeparam>
        /// <remarks>This function is not applicable on single-threaded windows</remarks>
        /// <returns>The return value of the given delegate.</returns>
        public static T Invoke<T>(this IView view, Func<T> t)
        {
            return (T) view.Invoke(t);
        }

        /// <summary>
        /// Executes an <see cref="Action"/> on the given view.
        /// </summary>
        /// <param name="view">The view to invoke on.</param>
        /// <param name="t">The action to invoke.</param>
        /// <remarks>This function is not applicable on single-threaded windows</remarks>
        public static void Invoke(this IView view, Action t)
        {
            view.Invoke(t);
        }

        /// <summary>
        /// Start the default event loop on this view.
        /// </summary>
        /// <param name="view">The view to begin the loop on.</param>
        public static void Run(this IView view)
        {
            view.Initialize();
            view.Run
            (
                () =>
                {
                    view.DoEvents();
                    if (!view.IsClosing)
                    {
                        view.DoUpdate();
                    }
                    if (!view.IsClosing)
                    {
                        view.DoRender();
                    }
                }
            );

            view.DoEvents();
            view.Reset();
        }

        public static void SwapBuffers(this IView view) => view.GLContext?.SwapBuffers();
        public static void MakeCurrent(this IView view) => view.GLContext?.MakeCurrent();
        public static void ClearContext(this IView view) => view.GLContext?.Clear();

        /// <summary>
        /// Gets the full size of the given window including its borders.
        /// </summary>
        /// <param name="window">The window to get size information from.</param>
        /// <returns>The full size of the window (including both content area and borders)</returns>
        public static Vector2D<int> GetFullSize(this IWindow window) => Vector2D.Add(window.Size, window.BorderSize.Size);

        /// <summary>
        /// Centers this window to the given monitor or, if null, the current monitor the window's on.
        /// </summary>
        /// <param name="window">The window to center.</param>
        /// <param name="monitor">The specific monitor to center the window to, if any.</param>
        public static void Center(this IWindow window, IMonitor? monitor = null)
        {
            monitor ??= window.Monitor;
            var monitorBounds = monitor.Bounds;
            var windowFullSize = window.GetFullSize();
            window.Position = Vector2D.Add
            (
                monitorBounds.Origin,
                new Vector2D<int>
                (
                    monitorBounds.Size.X / 2 - windowFullSize.X / 2,
                    monitorBounds.Size.Y / 2 - windowFullSize.Y / 2
                )
            );
        }

        /// <summary>
        /// Sets the window icon to default on the given window.
        /// </summary>
        /// <param name="window">The window.</param>
        public static void SetDefaultIcon(this IWindow window) => window.SetWindowIcon(null);

        /// <summary>
        /// Sets a single window icon on the given window.
        /// </summary>
        /// <param name="window">The window.</param>
        /// <param name="icon">The icon to set.</param>
        public static void SetWindowIcon(this IWindow window, ref RawImage icon) => window.SetWindowIcon
#if NETSTANDARD2_1
            (System.Runtime.InteropServices.MemoryMarshal.CreateReadOnlySpan(ref icon, 1));
#else
            (new[] { icon });
#endif
    }
}