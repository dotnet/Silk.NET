// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Status of a joystick hat.
    /// </summary>
    public enum JoystickHats : byte
    {
        /// <summary>
        /// Hat is centered.
        /// </summary>
        Centered = 0,

        /// <summary>
        /// Hat is pointing up.
        /// </summary>
        Up = 1,

        /// <summary>
        /// Hat is pointing right.
        /// </summary>
        Right = 2,

        /// <summary>
        /// Hat is pointing down.
        /// </summary>
        Down = 4,

        /// <summary>
        /// Hat is pointing left.
        /// </summary>
        Left = 8,

        /// <summary>
        /// Hat is pointing up and to the right.
        /// </summary>
        RightUp = Right | Up,

        /// <summary>
        /// Hat is pointing down and to the right.
        /// </summary>
        RightDown = Right | Down,

        /// <summary>
        /// Hat is pointing up and to the left.
        /// </summary>
        LeftUp = Left | Up,

        /// <summary>
        /// Hat is pointing down and to the left.
        /// </summary>
        LeftDown = Left | Down
    }
}