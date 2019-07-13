// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;

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
        IReadOnlyCollection<MouseButton> SupportedButtons { get; }
        
        /// <summary>
        /// The scroll wheels this mouse has available.
        /// </summary>
        IReadOnlyCollection<ScrollWheel> ScrollWheels { get; }
        
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
        /// Called when the mouse wheel scrolls.
        /// </summary>
        event Action<IMouse, ScrollWheel> Scroll;
    }
}
