//
// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.GLFW
{
    /// <summary>
    /// This describes the input state of a gamepad.
    /// </summary>
    public struct GamepadState
    {
        /// <summary>
        /// State of each of the 15 gamepad buttons, equal to <see cref="InputAction.Press"/> or <see cref="InputAction.Release"/>.
        /// </summary>
        public byte[] Buttons;

        /// <summary>
        /// State of each of the 6 gamepad axes, ranging from -1.0 to 1.0.
        /// </summary>
        public float[] Axes;
    }
}
