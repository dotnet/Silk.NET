// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
{
    /// <summary>
    /// Represents a joystick button.
    /// </summary>
    public struct Button
    {
        /// <summary>
        /// The name of this button. Used to determine which button it is.
        /// </summary>
        public ButtonName Name { get; }
        
        /// <summary>
        /// The index of this button.
        /// </summary>
        public int Index { get; }
        
        /// <summary>
        /// Whether or not this button is currently pressed.
        /// </summary>
        public bool Pressed { get; }

        /// <summary>
        /// Creates a new instance of the Button struct.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="index"></param>
        /// <param name="pressed"></param>
        public Button(ButtonName name, int index, bool pressed)
        {
            Name = name;
            Index = index;
            Pressed = pressed;
        }
    }
}