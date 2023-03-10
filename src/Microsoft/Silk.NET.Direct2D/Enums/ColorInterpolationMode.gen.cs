// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_COLOR_INTERPOLATION_MODE")]
    public enum ColorInterpolationMode : int
    {
        [Obsolete("Deprecated in favour of \"Straight\"")]
        [NativeName("Name", "D2D1_COLOR_INTERPOLATION_MODE_STRAIGHT")]
        ColorInterpolationModeStraight = 0x0,
        [Obsolete("Deprecated in favour of \"Premultiplied\"")]
        [NativeName("Name", "D2D1_COLOR_INTERPOLATION_MODE_PREMULTIPLIED")]
        ColorInterpolationModePremultiplied = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_COLOR_INTERPOLATION_MODE_FORCE_DWORD")]
        ColorInterpolationModeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_COLOR_INTERPOLATION_MODE_STRAIGHT")]
        Straight = 0x0,
        [NativeName("Name", "D2D1_COLOR_INTERPOLATION_MODE_PREMULTIPLIED")]
        Premultiplied = 0x1,
        [NativeName("Name", "D2D1_COLOR_INTERPOLATION_MODE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
