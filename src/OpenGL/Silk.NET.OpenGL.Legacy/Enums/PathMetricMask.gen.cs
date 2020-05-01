// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    public enum PathMetricMask
    {
        GlyphWidthBitNV = 0x1,
        GlyphHeightBitNV = 0x2,
        GlyphHorizontalBearingXBitNV = 0x4,
        GlyphHorizontalBearingYBitNV = 0x8,
        GlyphHorizontalBearingAdvanceBitNV = 0x10,
        GlyphVerticalBearingXBitNV = 0x20,
        GlyphVerticalBearingYBitNV = 0x40,
        GlyphVerticalBearingAdvanceBitNV = 0x80,
        GlyphHasKerningBitNV = 0x100,
        FontXMinBoundsBitNV = 0x10000,
        FontYMinBoundsBitNV = 0x20000,
        FontXMaxBoundsBitNV = 0x40000,
        FontYMaxBoundsBitNV = 0x80000,
        FontUnitsPerEMBitNV = 0x100000,
        FontAscenderBitNV = 0x200000,
        FontDescenderBitNV = 0x400000,
        FontHeightBitNV = 0x800000,
        FontMaxAdvanceWidthBitNV = 0x1000000,
        FontMaxAdvanceHeightBitNV = 0x2000000,
        FontUnderlinePositionBitNV = 0x4000000,
        FontUnderlineThicknessBitNV = 0x8000000,
        FontHasKerningBitNV = 0x10000000,
        FontNumGlyphIndicesBitNV = 0x20000000,
    }
}
