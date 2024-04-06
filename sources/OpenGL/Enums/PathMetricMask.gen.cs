// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum PathMetricMask
{
    GlyphWidthBitNV = 0x01,
    GlyphHeightBitNV = 0x02,
    GlyphHorizontalBearingXBitNV = 0x04,
    GlyphHorizontalBearingYBitNV = 0x08,
    GlyphHorizontalBearingAdvanceBitNV = 0x10,
    GlyphVerticalBearingXBitNV = 0x20,
    GlyphVerticalBearingYBitNV = 0x40,
    GlyphVerticalBearingAdvanceBitNV = 0x80,
    GlyphHasKerningBitNV = 0x100,
    FontXMinBoundsBitNV = 0x00010000,
    FontYMinBoundsBitNV = 0x00020000,
    FontXMaxBoundsBitNV = 0x00040000,
    FontYMaxBoundsBitNV = 0x00080000,
    FontUnitsPerEmBitNV = 0x00100000,
    FontAscenderBitNV = 0x00200000,
    FontDescenderBitNV = 0x00400000,
    FontHeightBitNV = 0x00800000,
    FontMaxAdvanceWidthBitNV = 0x01000000,
    FontMaxAdvanceHeightBitNV = 0x02000000,
    FontUnderlinePositionBitNV = 0x04000000,
    FontUnderlineThicknessBitNV = 0x08000000,
    FontHasKerningBitNV = 0x10000000,
    FontNumGlyphIndicesBitNV = 0x20000000
}
