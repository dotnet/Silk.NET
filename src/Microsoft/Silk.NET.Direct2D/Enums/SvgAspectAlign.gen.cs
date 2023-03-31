// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN")]
    public enum SvgAspectAlign : int
    {
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MIN")]
        XMinYMin = 0x1,
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MIN")]
        XMidYMin = 0x2,
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MIN")]
        XMaxYMin = 0x3,
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MID")]
        XMinYMid = 0x4,
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MID")]
        XMidYMid = 0x5,
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MID")]
        XMaxYMid = 0x6,
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MAX")]
        XMinYMax = 0x7,
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MAX")]
        XMidYMax = 0x8,
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MAX")]
        XMaxYMax = 0x9,
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
