// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Drawing;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// Contains all window properties.
    /// </summary>
    public interface IWindowProperties
    {
        /// <summary>
        /// Gets whether or not the window should use a single-threaded implementation. If false,
        /// rendering will be moved to its own thread.
        /// </summary>
        bool UseSingleThreadedWindow { get; }

        /// <summary>
        /// Gets or sets the position of the top-left corner of the window on the desktop.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This will be replaced with an integer vector once System.Numerics supports them.
        /// </para>
        /// </remarks>
        Point Position { get; set; }

        /// <summary>
        /// Gets or sets the size of the window in pixels.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This will be replaced with an integer vector once System.Numerics supports them.
        /// </para>
        /// </remarks>
        Size Size { get; set; }

        /// <summary>
        /// The number of rendering operations to run every second.
        /// </summary>
        double FramesPerSecond { get; }

        /// <summary>
        /// The number of update operations to run every second.
        /// </summary>
        double UpdatesPerSecond { get; }

        /// <summary>
        /// Gets the graphics API the window will use.
        /// </summary>
        GraphicsAPI API { get; }

        /// <summary>
        /// Gets or sets the window state.
        /// </summary>
        WindowState WindowState { get; set; }

        /// <summary>
        /// Gets or sets the window border.
        /// </summary>
        WindowBorder WindowBorder { get; set; }

        /// <summary>
        /// Gets or sets the VSync mode.
        /// </summary>
        VSyncMode VSync { get; set; }
    }
}