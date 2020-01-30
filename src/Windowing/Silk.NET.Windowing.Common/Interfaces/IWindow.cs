// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// An interface representing a window.
    /// </summary>
    public interface IWindow : IWindowProperties, IWindowHost, IView
    {
        // TODO maybe we could do a IsSubwindow => Parent is IWindow
        /// <summary>
        /// Gets the window host on which this window is active.
        /// </summary>
        /// <remarks>
        /// This may be a <see cref="IWindow"/> or a <see cref="IMonitor"/>.
        /// </remarks>
        IWindowHost Parent { get; }

        /// <summary>
        /// Gets the monitor on which this window is active.
        /// </summary>
        IMonitor Monitor { get; set; }

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