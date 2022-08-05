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
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D2D1_SVG_PAINT_TYPE_NONE")]
        SvgPaintTypeNone = 0x0,
        [Obsolete("Deprecated in favour of \"Color\"")]
        [NativeName("Name", "D2D1_SVG_PAINT_TYPE_COLOR")]
        SvgPaintTypeColor = 0x1,
        [Obsolete("Deprecated in favour of \"CurrentColor\"")]
        [NativeName("Name", "D2D1_SVG_PAINT_TYPE_CURRENT_COLOR")]
        SvgPaintTypeCurrentColor = 0x2,
        [Obsolete("Deprecated in favour of \"Uri\"")]
        [NativeName("Name", "D2D1_SVG_PAINT_TYPE_URI")]
        SvgPaintTypeUri = 0x3,
        [Obsolete("Deprecated in favour of \"UriNone\"")]
        [NativeName("Name", "D2D1_SVG_PAINT_TYPE_URI_NONE")]
        SvgPaintTypeUriNone = 0x4,
        [Obsolete("Deprecated in favour of \"UriColor\"")]
        [NativeName("Name", "D2D1_SVG_PAINT_TYPE_URI_COLOR")]
        SvgPaintTypeUriColor = 0x5,
        [Obsolete("Deprecated in favour of \"UriCurrentColor\"")]
        [NativeName("Name", "D2D1_SVG_PAINT_TYPE_URI_CURRENT_COLOR")]
        SvgPaintTypeUriCurrentColor = 0x6,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SVG_PAINT_TYPE_FORCE_DWORD")]
        SvgPaintTypeForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
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
