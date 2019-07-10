// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Input.Common
{
    [Flags]
    public enum Position2D
    {
        Up,
        Down,
        Left,
        Right,
        
        UpLeft = Up | Left,
        UpRight = Up | Right,
        DownLeft = Down | Left,
        DownRight = Down | Right
    }
}