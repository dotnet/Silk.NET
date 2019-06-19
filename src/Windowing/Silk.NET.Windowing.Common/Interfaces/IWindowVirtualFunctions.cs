// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Drawing;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// Contains all virtual window functions.
    /// </summary>
    public interface IWindowVirtualFunctions
    {
        /// <summary>
        /// Called when the window is moved.
        /// </summary>
        /// <param name="newPosition">The new position of the window.</param>
        void OnMove(Point newPosition);

        /// <summary>
        /// Called when the window is resized.
        /// </summary>
        /// <param name="newSize">The new size of the window.</param>
        void OnResize(Size newSize);

        /// <summary>
        /// Called when the window is about to close.
        /// </summary>
        void OnClosing();

        /// <summary>
        /// Called when the window state is changed.
        /// </summary>
        /// <param name="newState">The new state of the window.</param>
        void OnWindowStateChanged(WindowState newState);

        /// <summary>
        /// Called when the window focus changes.
        /// </summary>
        /// <param name="isFocused">If the window is focused or not.</param>
        void OnFocusChanged(bool isFocused);

        /// <summary>
        /// Called when the window visibility changes.
        /// </summary>
        /// <param name="isVisible">If the window is visible or not.</param>
        void OnVisibilityChanged(bool isVisible);

        /// <summary>
        /// Called when the user drops files onto the window.
        /// </summary>
        /// <param name="files">An array of paths to the files dropped.</param>
        void OnFileDrop(string[] files);

        void OnUpdate(double delta);

        void OnRender(double delta);
    }
}