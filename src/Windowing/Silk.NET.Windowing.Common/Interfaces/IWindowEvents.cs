// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// Contains all window events.
    /// </summary>
    public interface IWindowEvents
    {
        /// <summary>
        /// Raised when the window is moved.
        /// </summary>
        event Action<Point> Move;

        /// <summary>
        /// Raised when the window is resized.
        /// </summary>
        event Action<Size> Resize;

        /// <summary>
        /// Raised when the window is about to close.
        /// </summary>
        event Action Closing;

        /// <summary>
        /// Raised when the window state is changed.
        /// </summary>
        event Action<WindowState> StateChanged;

        /// <summary>
        /// Raised when the window focus changes.
        /// </summary>
        event Action<bool> FocusChanged;

        /// <summary>
        /// Raised when the user drops files onto the window.
        /// </summary>
        event Action<string[]> FileDrop;

        /// <summary>
        /// Raised when the window first begins to run.
        /// </summary>
        event Action Load;

        /// <summary>
        /// Raised when an update should be run.
        /// </summary>
        event Action<double> Update;

        /// <summary>
        /// Raised when a frame should be rendered.
        /// </summary>
        event Action<double> Render;
    }
}