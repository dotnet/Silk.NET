// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION.xml' path='doc/member[@name="D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION"]/*' />
public enum D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION
{
    /// <include file='D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION.xml' path='doc/member[@name="D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION.D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DEFAULT"]/*' />
    D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DEFAULT = 0,

    /// <include file='D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION.xml' path='doc/member[@name="D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION.D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DISABLE"]/*' />
    D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_DISABLE = 1,

    /// <include file='D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION.xml' path='doc/member[@name="D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION.D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_FORCE_DWORD"]/*' />
    D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
