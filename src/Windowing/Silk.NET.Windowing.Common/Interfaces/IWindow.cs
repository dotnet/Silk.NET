// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;
using Silk.NET.Windowing.Common.Structs;

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
        /// Gets or sets whether the window has been requested to close.
        /// </summary>
        new bool IsClosing { get; set; }

        /// <summary>
        /// Gets the distances in screen coordinates from the edges of the content area to the corresponding edges of
        /// the full window.
        /// </summary>
        /// <remarks>
        /// Because these are distances and not coordinates, they are always zero or positive.
        /// </remarks>
        /// <seealso cref="WindowExtensions.GetFullSize"/>
        // This is in IWindow because it can't be configured.
        Rectangle BorderSize { get; }

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

        /// <summary>
        /// Sets the window icons.
        /// </summary>
        /// <param name="icons">Either a collection of window icons, or null to set to the default icon.</param>
        void SetWindowIcon(Span<WindowIcon> icons);
    }
}