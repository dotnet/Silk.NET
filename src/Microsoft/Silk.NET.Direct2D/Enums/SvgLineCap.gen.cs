// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_SVG_LINE_CAP")]
    public enum SvgLineCap : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Butt\"")]
        [NativeName("Name", "D2D1_SVG_LINE_CAP_BUTT")]
        SvgLineCapButt = 0x0,
        [Obsolete("Deprecated in favour of \"Square\"")]
        [NativeName("Name", "D2D1_SVG_LINE_CAP_SQUARE")]
        SvgLineCapSquare = 0x1,
        [Obsolete("Deprecated in favour of \"Round\"")]
        [NativeName("Name", "D2D1_SVG_LINE_CAP_ROUND")]
        SvgLineCapRound = 0x2,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SVG_LINE_CAP_FORCE_DWORD")]
        SvgLineCapForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_SVG_LINE_CAP_BUTT")]
        Butt = 0x0,
        [NativeName("Name", "D2D1_SVG_LINE_CAP_SQUARE")]
        Square = 0x1,
        [NativeName("Name", "D2D1_SVG_LINE_CAP_ROUND")]
        Round = 0x2,
        [NativeName("Name", "D2D1_SVG_LINE_CAP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
