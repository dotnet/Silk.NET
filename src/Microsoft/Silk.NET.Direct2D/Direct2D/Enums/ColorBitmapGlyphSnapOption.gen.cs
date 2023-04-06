// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION")]
    public enum ColorBitmapGlyphSnapOption : int
    {
        [NativeName("Name", "D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DISABLE")]
        Disable = 0x1,
        [NativeName("Name", "D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
