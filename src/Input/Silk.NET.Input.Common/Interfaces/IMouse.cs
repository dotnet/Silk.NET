// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Numerics;

namespace Silk.NET.Input
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
        Vector2 Position { get; set; }

        /// <summary>
        /// The cursor to use.
        /// </summary>
        ICursor Cursor { get; }

        /// <summary>
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
        event Action<IMouse, MouseButton, Vector2> Click;

        /// <summary>
        /// Called when a double click is performed.
        /// </summary>
        event Action<IMouse, MouseButton, Vector2> DoubleClick;

        /// <summary>
        /// Called when the mouse is moved.
        /// </summary>
        event Action<IMouse, Vector2> MouseMove;

        /// <summary>
        /// Called when the mouse wheel scrolls.
        /// </summary>
        event Action<IMouse, ScrollWheel> Scroll;
    }
}
