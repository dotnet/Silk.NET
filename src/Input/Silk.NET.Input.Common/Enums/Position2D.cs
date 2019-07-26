// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Input.Common
{
    /// <summary>
    /// Represents the position of a joystick <see cref="Hat"/>
    /// </summary>
    [Flags]
    public enum Position2D
    {
        Centered = 0,
        Up = 1,
        Down = 2,
        Left = 4,
        Right = 8,
        
        UpLeft = Up | Left,
        UpRight = Up | Right,
        DownLeft = Down | Left,
        DownRight = Down | Right
    }
}