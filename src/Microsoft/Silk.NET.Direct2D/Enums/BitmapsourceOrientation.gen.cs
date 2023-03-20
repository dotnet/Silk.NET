// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_BITMAPSOURCE_ORIENTATION")]
    public enum BitmapsourceOrientation : int
    {
        [NativeName("Name", "D2D1_BITMAPSOURCE_ORIENTATION_DEFAULT")]
        Default = 0x1,
        [NativeName("Name", "D2D1_BITMAPSOURCE_ORIENTATION_FLIP_HORIZONTAL")]
        FlipHorizontal = 0x2,
        [NativeName("Name", "D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE180")]
        RotateClockwise180 = 0x3,
        [NativeName("Name", "D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE180_FLIP_HORIZONTAL")]
        RotateClockwise180FlipHorizontal = 0x4,
        [NativeName("Name", "D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE270_FLIP_HORIZONTAL")]
        RotateClockwise270FlipHorizontal = 0x5,
        [NativeName("Name", "D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE90")]
        RotateClockwise90 = 0x6,
        [NativeName("Name", "D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE90_FLIP_HORIZONTAL")]
        RotateClockwise90FlipHorizontal = 0x7,
        [NativeName("Name", "D2D1_BITMAPSOURCE_ORIENTATION_ROTATE_CLOCKWISE270")]
        RotateClockwise270 = 0x8,
        [NativeName("Name", "D2D1_BITMAPSOURCE_ORIENTATION_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
