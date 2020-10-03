// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Drawing;

namespace Silk.NET.Input.Common
{
    /// <summary>
    /// An interface representing a mouse.
    /// </summary>
    public interface IMouse : IInputDevice
    {
        /// <summary>
        /// The buttons this mouse has available.
        /// </summary>
        // ReSharper disable once ReturnTypeCanBeEnumerable.Global
        IReadOnlyList<MouseButton> SupportedButtons { get; }

        /// <summary>
        /// The scroll wheels this mouse has available.
        /// </summary>
        IReadOnlyList<ScrollWheel> ScrollWheels { get; }

        /// <summary>
        /// The position of the cursor.
        /// </summary>
        PointF Position { get; set; }

        /// <summary>
        /// The cursor to use.
        /// </summary>
        ICursor Cursor { get; }

        /// The maximum time in milliseconds between two
        /// consecutive clicks to count as a double click.
        /// </summary>
        int DoubleClickTime { get; set; }

        /// <summary>
        /// The maximum distance in pixels between two
        /// consecutive clicks to count as a double click.
        /// </summary>
        int DoubleClickRange { get; set; }

        /// <summary>
        /// Checks if a specific button is currently pressed.
        /// </summary>
        /// <param name="btn">The button to check.</param>
        /// <returns>Whether or not the button is pressed down.</returns>
        bool IsButtonPressed(MouseButton btn);

        /// <summary>
        /// Called when a mouse button is pressed down.
        /// </summary>
        event Action<IMouse, MouseButton> MouseDown;

        /// <summary>
        /// Called when a mouse button is released.
        /// </summary>
        event Action<IMouse, MouseButton> MouseUp;

        /// <summary>
        /// Called when a single click is performed.
        /// </summary>
        event Action<IMouse, MouseButton> Click;

        /// <summary>
        /// Called when a double click is performed.
        /// </summary>
        event Action<IMouse, MouseButton> DoubleClick;

        /// <summary>
        /// Called when the mouse is moved.
        /// </summary>
        event Action<IMouse, PointF> MouseMove;

        /// <summary>
        /// Called when the mouse wheel scrolls.
        /// </summary>
        event Action<IMouse, ScrollWheel> Scroll;
    }
}
