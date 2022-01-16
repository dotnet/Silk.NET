// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Represents the current state of the window.
    /// </summary>
    public enum WindowState
    {
        /// <summary>
        /// The window is in its regular configuration.
        /// </summary>
        Normal = 0,

        /// <summary>
        /// The window has been minimized to the task bar.
        /// </summary>
        Minimized,

        /// <summary>
        /// The window has been maximized, covering the entire desktop, but not the taskbar.
        /// </summary>
        Maximized,

        /// <summary>
        /// The window has been fullscreened, covering the entire surface of the monitor.
        /// </summary>
        Fullscreen
    }
}