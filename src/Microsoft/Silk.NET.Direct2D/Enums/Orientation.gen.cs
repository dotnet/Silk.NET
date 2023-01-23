// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_ORIENTATION")]
    public enum Orientation : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "D2D1_ORIENTATION_DEFAULT")]
        OrientationDefault = 0x1,
        [Obsolete("Deprecated in favour of \"FlipHorizontal\"")]
        [NativeName("Name", "D2D1_ORIENTATION_FLIP_HORIZONTAL")]
        OrientationFlipHorizontal = 0x2,
        [Obsolete("Deprecated in favour of \"RotateClockwise180\"")]
        [NativeName("Name", "D2D1_ORIENTATION_ROTATE_CLOCKWISE180")]
        OrientationRotateClockwise180 = 0x3,
        [Obsolete("Deprecated in favour of \"RotateClockwise180FlipHorizontal\"")]
        [NativeName("Name", "D2D1_ORIENTATION_ROTATE_CLOCKWISE180_FLIP_HORIZONTAL")]
        OrientationRotateClockwise180FlipHorizontal = 0x4,
        [Obsolete("Deprecated in favour of \"RotateClockwise90FlipHorizontal\"")]
        [NativeName("Name", "D2D1_ORIENTATION_ROTATE_CLOCKWISE90_FLIP_HORIZONTAL")]
        OrientationRotateClockwise90FlipHorizontal = 0x5,
        [Obsolete("Deprecated in favour of \"RotateClockwise270\"")]
        [NativeName("Name", "D2D1_ORIENTATION_ROTATE_CLOCKWISE270")]
        OrientationRotateClockwise270 = 0x6,
        [Obsolete("Deprecated in favour of \"RotateClockwise270FlipHorizontal\"")]
        [NativeName("Name", "D2D1_ORIENTATION_ROTATE_CLOCKWISE270_FLIP_HORIZONTAL")]
        OrientationRotateClockwise270FlipHorizontal = 0x7,
        [Obsolete("Deprecated in favour of \"RotateClockwise90\"")]
        [NativeName("Name", "D2D1_ORIENTATION_ROTATE_CLOCKWISE90")]
        OrientationRotateClockwise90 = 0x8,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_ORIENTATION_FORCE_DWORD")]
        OrientationForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_ORIENTATION_DEFAULT")]
        Default = 0x1,
        [NativeName("Name", "D2D1_ORIENTATION_FLIP_HORIZONTAL")]
        FlipHorizontal = 0x2,
        [NativeName("Name", "D2D1_ORIENTATION_ROTATE_CLOCKWISE180")]
        RotateClockwise180 = 0x3,
        [NativeName("Name", "D2D1_ORIENTATION_ROTATE_CLOCKWISE180_FLIP_HORIZONTAL")]
        RotateClockwise180FlipHorizontal = 0x4,
        [NativeName("Name", "D2D1_ORIENTATION_ROTATE_CLOCKWISE90_FLIP_HORIZONTAL")]
        RotateClockwise90FlipHorizontal = 0x5,
        [NativeName("Name", "D2D1_ORIENTATION_ROTATE_CLOCKWISE270")]
        RotateClockwise270 = 0x6,
        [NativeName("Name", "D2D1_ORIENTATION_ROTATE_CLOCKWISE270_FLIP_HORIZONTAL")]
        RotateClockwise270FlipHorizontal = 0x7,
        [NativeName("Name", "D2D1_ORIENTATION_ROTATE_CLOCKWISE90")]
        RotateClockwise90 = 0x8,
        [NativeName("Name", "D2D1_ORIENTATION_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
