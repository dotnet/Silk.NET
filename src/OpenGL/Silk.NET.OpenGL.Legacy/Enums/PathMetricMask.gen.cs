// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [Flags]
    [NativeName("Name", "PathMetricMask")]
    public enum PathMetricMask : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "GL_GLYPH_WIDTH_BIT_NV")]
        GlyphWidthBitNV = 0x1,
        [NativeName("Name", "GL_GLYPH_HEIGHT_BIT_NV")]
        GlyphHeightBitNV = 0x2,
        [NativeName("Name", "GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV")]
        GlyphHorizontalBearingXBitNV = 0x4,
        [NativeName("Name", "GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV")]
        GlyphHorizontalBearingYBitNV = 0x8,
        [NativeName("Name", "GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV")]
        GlyphHorizontalBearingAdvanceBitNV = 0x10,
        [NativeName("Name", "GL_GLYPH_VERTICAL_BEARING_X_BIT_NV")]
        GlyphVerticalBearingXBitNV = 0x20,
        [NativeName("Name", "GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV")]
        GlyphVerticalBearingYBitNV = 0x40,
        [NativeName("Name", "GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV")]
        GlyphVerticalBearingAdvanceBitNV = 0x80,
        [NativeName("Name", "GL_GLYPH_HAS_KERNING_BIT_NV")]
        GlyphHasKerningBitNV = 0x100,
        [NativeName("Name", "GL_FONT_X_MIN_BOUNDS_BIT_NV")]
        FontXMinBoundsBitNV = 0x10000,
        [NativeName("Name", "GL_FONT_Y_MIN_BOUNDS_BIT_NV")]
        FontYMinBoundsBitNV = 0x20000,
        [NativeName("Name", "GL_FONT_X_MAX_BOUNDS_BIT_NV")]
        FontXMaxBoundsBitNV = 0x40000,
        [NativeName("Name", "GL_FONT_Y_MAX_BOUNDS_BIT_NV")]
        FontYMaxBoundsBitNV = 0x80000,
        [NativeName("Name", "GL_FONT_UNITS_PER_EM_BIT_NV")]
        FontUnitsPerEMBitNV = 0x100000,
        [NativeName("Name", "GL_FONT_ASCENDER_BIT_NV")]
        FontAscenderBitNV = 0x200000,
        [NativeName("Name", "GL_FONT_DESCENDER_BIT_NV")]
        FontDescenderBitNV = 0x400000,
        [NativeName("Name", "GL_FONT_HEIGHT_BIT_NV")]
        FontHeightBitNV = 0x800000,
        [NativeName("Name", "GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV")]
        FontMaxAdvanceWidthBitNV = 0x1000000,
        [NativeName("Name", "GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV")]
        FontMaxAdvanceHeightBitNV = 0x2000000,
        [NativeName("Name", "GL_FONT_UNDERLINE_POSITION_BIT_NV")]
        FontUnderlinePositionBitNV = 0x4000000,
        [NativeName("Name", "GL_FONT_UNDERLINE_THICKNESS_BIT_NV")]
        FontUnderlineThicknessBitNV = 0x8000000,
        [NativeName("Name", "GL_FONT_HAS_KERNING_BIT_NV")]
        FontHasKerningBitNV = 0x10000000,
        [NativeName("Name", "GL_FONT_NUM_GLYPH_INDICES_BIT_NV")]
        FontNumGlyphIndicesBitNV = 0x20000000,
    }
}
