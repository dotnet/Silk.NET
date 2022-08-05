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
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_NONE")]
        SvgAspectAlignNone = 0x0,
        [Obsolete("Deprecated in favour of \"XMinYMin\"")]
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MIN")]
        SvgAspectAlignXMinYMin = 0x1,
        [Obsolete("Deprecated in favour of \"XMidYMin\"")]
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MIN")]
        SvgAspectAlignXMidYMin = 0x2,
        [Obsolete("Deprecated in favour of \"XMaxYMin\"")]
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MIN")]
        SvgAspectAlignXMaxYMin = 0x3,
        [Obsolete("Deprecated in favour of \"XMinYMid\"")]
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MID")]
        SvgAspectAlignXMinYMid = 0x4,
        [Obsolete("Deprecated in favour of \"XMidYMid\"")]
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MID")]
        SvgAspectAlignXMidYMid = 0x5,
        [Obsolete("Deprecated in favour of \"XMaxYMid\"")]
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MID")]
        SvgAspectAlignXMaxYMid = 0x6,
        [Obsolete("Deprecated in favour of \"XMinYMax\"")]
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MAX")]
        SvgAspectAlignXMinYMax = 0x7,
        [Obsolete("Deprecated in favour of \"XMidYMax\"")]
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MAX")]
        SvgAspectAlignXMidYMax = 0x8,
        [Obsolete("Deprecated in favour of \"XMaxYMax\"")]
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MAX")]
        SvgAspectAlignXMaxYMax = 0x9,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SVG_ASPECT_ALIGN_FORCE_DWORD")]
        SvgAspectAlignForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
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
