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
    public interface IWindowEvents : IViewEvents
    {
        /// <summary>
        /// Raised when the window is moved.
        /// </summary>
        event Action<Point> Move;

        /// <summary>
        /// Raised when the window state is changed.
        /// </summary>
        event Action<WindowState> StateChanged;

        /// <summary>
        /// Raised when the user drops files onto the window.
        /// </summary>
        event Action<string[]> FileDrop;
    }
}