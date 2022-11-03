// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Contexts;
using Silk.NET.Maths;

namespace Silk.NET.Windowing
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
        Vector2D<int> Position { get; set; }

        /// <summary>
        /// The size of the window in pixels.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This will be replaced with an integer vector once System.Numerics supports them.
        /// </para>
        /// </remarks>
        new Vector2D<int> Size { get; set; }

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
        
        /// <summary>
        /// Whether or not the window will be on the top of all the other windows.
        /// </summary>
        bool TopMost { get; set; }

        /// <summary>
        /// The context with which this window's context's resources are shared.
        /// </summary>
        IGLContext? SharedContext { get; }

        /// <summary>
        /// Window class name used in systems like X11.
        /// Also known as WM_CLASS.
        /// </summary>
        /// <remarks>
        /// If omitted the following default values are used:
        /// - The name of the main assembly without extension
        /// - "Silk.NET" if the name of the main assembly could not be determined
        /// </remarks>
        string? WindowClass { get; }
    }
}
