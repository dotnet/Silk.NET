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
        /// Whether or not the window is visible.
        /// </summary>
        bool IsVisible { get; set; }

        /// <summary>
        /// If true, both updates and rendering will happen on the same thread. If false, both updating and rendering
        /// will be run on their own threads.
        /// </summary>
        bool UseSingleThreadedWindow { get; }

        /// <summary>
        /// The position of the window. If set to -1, use the backend default.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This will be replaced with an integer vector once System.Numerics supports them.
        /// </para>
        /// </remarks>
        Point Position { get; set; }

        /// <summary>
        /// The size of the window in pixels.
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
        double FramesPerSecond { get; set; }

        /// <summary>
        /// The number of update operations to run every second.
        /// </summary>
        double UpdatesPerSecond { get; set; }

        /// <summary>
        /// The graphics API to use, and associated configurations.
        /// </summary>
        GraphicsAPI API { get; }

        /// <summary>
        /// The window title.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// The window state.
        /// </summary>
        WindowState WindowState { get; set; }

        /// <summary>
        /// The window border.
        /// </summary>
        WindowBorder WindowBorder { get; set; }

        /// <summary>
        /// The VSync mode.
        /// </summary>
        VSyncMode VSync { get; set; }
        
        /// <summary>
        /// The number of frames the window needs to be running slowly for before <see cref="IWindow.IsRunningSlowly"/>
        /// is set to true.
        /// </summary>
        int RunningSlowTolerance { get; set; }
    }
}