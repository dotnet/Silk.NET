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
        /// Called when the window is about to close.
        /// </summary>
        event EventHandler OnClosing;

        /// <summary>
        /// Called when the window state is changed.
        /// </summary>
        /// <param name="newState">The new state of the window.</param>
        event EventHandler<WindowState> OnStateChanged;

        /// <summary>
        /// Called when the window focus changes.
        /// </summary>
        /// <param name="isFocused">If the window is focused or not.</param>
        event EventHandler<bool> OnFocusChanged;

        /// <summary>
        /// Called when the window visibility changes.
        /// </summary>
        /// <param name="isVisible">If the window is visible or not.</param>
        event EventHandler<bool> OnVisibilityChanged;

        /// <summary>
        /// Called when the user drops files onto the window.
        /// </summary>
        /// <param name="files">An array of paths to the files dropped.</param>
        event EventHandler<string[]> OnFileDrop;

        /// <summary>
        /// Called when the window first begins to run.
        /// </summary>
        event EventHandler OnLoad;

        /// <summary>
        /// Called when an update should be run.
        /// </summary>
        /// <param name="delta">The number of milliseconds since the last update event.</param>
        event EventHandler<double> OnUpdate;

        /// <summary>
        /// Called when a frame should be rendered.
        /// </summary>
        /// <param name="delta">The number of milliseconds since the last render event.</param>
        event EventHandler<double> OnRender;
    }
}