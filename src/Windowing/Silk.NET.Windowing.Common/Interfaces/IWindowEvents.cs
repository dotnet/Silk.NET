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
        event EventHandler<Point> OnMove;

        /// <summary>
        /// Raised when the window is resized.
        /// </summary>
        event EventHandler<Size> OnResize;

        /// <summary>
        /// Raised when the window is about to close.
        /// </summary>
        event EventHandler OnClosing;

        /// <summary>
        /// Raised when the window state is changed.
        /// </summary>
        event EventHandler<WindowState> OnStateChanged;

        /// <summary>
        /// Raised when the window focus changes.
        /// </summary>
        event EventHandler<bool> OnFocusChanged;

        /// <summary>
        /// Raised when the window visibility changes.
        /// </summary>
        event EventHandler<bool> OnVisibilityChanged;

        /// <summary>
        /// Raised when the user drops files onto the window.
        /// </summary>
        event EventHandler<string[]> OnFileDrop;

        /// <summary>
        /// Raised when the window first begins to run.
        /// </summary>
        event EventHandler OnLoad;

        /// <summary>
        /// Raised when an update should be run.
        /// </summary>
        event EventHandler<double> OnUpdate;

        /// <summary>
        /// Raised when a frame should be rendered.
        /// </summary>
        event EventHandler<double> OnRender;
    }
}