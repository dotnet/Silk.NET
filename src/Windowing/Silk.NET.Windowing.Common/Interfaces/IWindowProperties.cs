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
    public interface IWindowProperties : IViewProperties
    {
        /// <summary>
        /// Whether or not the window is visible.
        /// </summary>
        bool IsVisible { get; set; }

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
        new Size Size { get; set; }

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
        /// Whether or not the window's framebuffer should be transparent.
        /// </summary>
        bool TransparentFramebuffer { get; }
    }
}