// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathMetricMask")]
[Transformed]
[Flags]
public enum PathMetricMask : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_WIDTH_BIT_NV")]
    GlyphWidthBitnv = unchecked((uint)0x01),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_HEIGHT_BIT_NV")]
    GlyphHeightBitnv = unchecked((uint)0x02),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_HORIZONTAL_BEARING_X_BIT_NV")]
    GlyphHorizontalBearingXBitnv = unchecked((uint)0x04),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_HORIZONTAL_BEARING_Y_BIT_NV")]
    GlyphHorizontalBearingYBitnv = unchecked((uint)0x08),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_HORIZONTAL_BEARING_ADVANCE_BIT_NV")]
    GlyphHorizontalBearingAdvanceBitnv = unchecked((uint)0x10),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_VERTICAL_BEARING_X_BIT_NV")]
    GlyphVerticalBearingXBitnv = unchecked((uint)0x20),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_VERTICAL_BEARING_Y_BIT_NV")]
    GlyphVerticalBearingYBitnv = unchecked((uint)0x40),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_VERTICAL_BEARING_ADVANCE_BIT_NV")]
    GlyphVerticalBearingAdvanceBitnv = unchecked((uint)0x80),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_GLYPH_HAS_KERNING_BIT_NV")]
    GlyphHasKerningBitnv = unchecked((uint)0x100),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_X_MIN_BOUNDS_BIT_NV")]
    FontXMinBoundsBitnv = unchecked((uint)0x00010000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_Y_MIN_BOUNDS_BIT_NV")]
    FontYMinBoundsBitnv = unchecked((uint)0x00020000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_X_MAX_BOUNDS_BIT_NV")]
    FontXMaxBoundsBitnv = unchecked((uint)0x00040000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_Y_MAX_BOUNDS_BIT_NV")]
    FontYMaxBoundsBitnv = unchecked((uint)0x00080000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_UNITS_PER_EM_BIT_NV")]
    FontUnitsPerEmBitnv = unchecked((uint)0x00100000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_ASCENDER_BIT_NV")]
    FontAscenderBitnv = unchecked((uint)0x00200000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_DESCENDER_BIT_NV")]
    FontDescenderBitnv = unchecked((uint)0x00400000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_HEIGHT_BIT_NV")]
    FontHeightBitnv = unchecked((uint)0x00800000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_MAX_ADVANCE_WIDTH_BIT_NV")]
    FontMaxAdvanceWidthBitnv = unchecked((uint)0x01000000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_MAX_ADVANCE_HEIGHT_BIT_NV")]
    FontMaxAdvanceHeightBitnv = unchecked((uint)0x02000000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_UNDERLINE_POSITION_BIT_NV")]
    FontUnderlinePositionBitnv = unchecked((uint)0x04000000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_UNDERLINE_THICKNESS_BIT_NV")]
    FontUnderlineThicknessBitnv = unchecked((uint)0x08000000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_HAS_KERNING_BIT_NV")]
    FontHasKerningBitnv = unchecked((uint)0x10000000),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FONT_NUM_GLYPH_INDICES_BIT_NV")]
    FontNumGlyphIndicesBitnv = unchecked((uint)0x20000000),
}
