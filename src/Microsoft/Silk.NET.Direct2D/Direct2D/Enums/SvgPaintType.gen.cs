// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_SVG_PAINT_TYPE")]
    public enum SvgPaintType : int
    {
        [NativeName("Name", "D2D1_SVG_PAINT_TYPE_NONE")]
        None = 0x0,
        [NativeName("Name", "D2D1_SVG_PAINT_TYPE_COLOR")]
        Color = 0x1,
        [NativeName("Name", "D2D1_SVG_PAINT_TYPE_CURRENT_COLOR")]
        CurrentColor = 0x2,
        [NativeName("Name", "D2D1_SVG_PAINT_TYPE_URI")]
        Uri = 0x3,
        [NativeName("Name", "D2D1_SVG_PAINT_TYPE_URI_NONE")]
        UriNone = 0x4,
        [NativeName("Name", "D2D1_SVG_PAINT_TYPE_URI_COLOR")]
        UriColor = 0x5,
        [NativeName("Name", "D2D1_SVG_PAINT_TYPE_URI_CURRENT_COLOR")]
        UriCurrentColor = 0x6,
        [NativeName("Name", "D2D1_SVG_PAINT_TYPE_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
