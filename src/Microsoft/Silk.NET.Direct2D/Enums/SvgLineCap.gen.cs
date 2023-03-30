// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_SVG_LINE_CAP")]
    public enum SvgLineCap : int
    {
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
