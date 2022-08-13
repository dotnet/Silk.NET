// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using Silk.NET.Core;
using Silk.NET.Maths;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Extensions for ISurface
    /// </summary>
    public static class SurfaceExtensions
    {
        /// <summary>
        /// Start the default event loop on this surface.
        /// </summary>
        /// <param name="surface">The surface to begin the loop on.</param>
        public static void Run(this ISurface surface)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the full size of the given window including its borders.
        /// </summary>
        /// <param name="window">The window to get size information from.</param>
        /// <returns>The full size of the window (including both content area and borders)</returns>
        public static Vector2D<int> GetFullSize(this IDesktopSurface window)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Centers this window to the given monitor or, if null, the current monitor the window's on.
        /// </summary>
        /// <param name="window">The window to center.</param>
        /// <param name="screen">The specific screen to center the window to, if any.</param>
        public static void Center(this IDesktopSurface window, IScreen? screen = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the window icon to default on the given window.
        /// </summary>
        /// <param name="window">The window.</param>
        public static void SetDefaultIcon(this IDesktopSurface window)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets a single window icon on the given window.
        /// </summary>
        /// <param name="window">The window.</param>
        /// <param name="icon">The icon to set.</param>
        public static void SetWindowIcon(this IDesktopSurface window, RawImage icon)
        {
            throw new NotImplementedException();   
        }
    }
}
