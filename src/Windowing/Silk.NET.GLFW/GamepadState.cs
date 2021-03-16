// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// This describes the input state of a gamepad.
    /// </summary>
    public struct GamepadState
    {
        /// <summary>
        /// State of each of the 15 gamepad buttons, equal to <see cref="InputAction.Press" /> or
        /// <see cref="InputAction.Release" />.
        /// </summary>
        public unsafe fixed byte Buttons[15];

        /// <summary>
        /// State of each of the 6 gamepad axes, ranging from -1.0 to 1.0.
        /// </summary>
        public unsafe fixed float Axes[15];
    }
}