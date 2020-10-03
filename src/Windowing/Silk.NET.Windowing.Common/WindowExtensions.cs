// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;
using Silk.NET.Windowing.Common.Structs;

namespace Silk.NET.Windowing.Common
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
                        view.DoRender();
                    }
                }
            );

            view.DoEvents();
            view.Reset();
        }

        /// <summary>
        /// Gets the full size of the given window including its borders.
        /// </summary>
        /// <param name="window">The window to get size information from.</param>
        /// <returns>The full size of the window (including both content area and borders)</returns>
        public static Size GetFullSize(this IWindow window) => Size.Add(window.Size, window.BorderSize.Size);

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
            window.Position = Point.Add
            (
                monitorBounds.Location,
                new Size
                (
                    monitorBounds.Size.Width / 2 - windowFullSize.Width / 2,
                    monitorBounds.Size.Height / 2 - windowFullSize.Height / 2
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
        public static void SetWindowIcon(this IWindow window, ref WindowIcon icon) => window.SetWindowIcon
            (new[] { icon });
    }
}
