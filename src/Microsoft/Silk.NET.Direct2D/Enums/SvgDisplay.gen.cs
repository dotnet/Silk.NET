// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Flags]
    [NativeName("Name", "D2D1_SVG_DISPLAY")]
    public enum SvgDisplay : int
    {
        [Obsolete("Deprecated in favour of \"Inline\"")]
        [NativeName("Name", "D2D1_SVG_DISPLAY_INLINE")]
        SvgDisplayInline = 0x0,
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D2D1_SVG_DISPLAY_NONE")]
        SvgDisplayNone = 0x1,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_SVG_DISPLAY_FORCE_DWORD")]
        SvgDisplayForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_SVG_DISPLAY_INLINE")]
        Inline = 0x0,
        [NativeName("Name", "D2D1_SVG_DISPLAY_NONE")]
        None = 0x1,
        [NativeName("Name", "D2D1_SVG_DISPLAY_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
