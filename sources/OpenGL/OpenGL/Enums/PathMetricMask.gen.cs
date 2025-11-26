// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
[Flags]
public enum PathMetricMask : uint
{
    GlyphWidthBitNV = unchecked((uint)0x01),
    GlyphHeightBitNV = unchecked((uint)0x02),
    GlyphHorizontalBearingXBitNV = unchecked((uint)0x04),
    GlyphHorizontalBearingYBitNV = unchecked((uint)0x08),
    GlyphHorizontalBearingAdvanceBitNV = unchecked((uint)0x10),
    GlyphVerticalBearingXBitNV = unchecked((uint)0x20),
    GlyphVerticalBearingYBitNV = unchecked((uint)0x40),
    GlyphVerticalBearingAdvanceBitNV = unchecked((uint)0x80),
    GlyphHasKerningBitNV = unchecked((uint)0x100),
    FontXMinBoundsBitNV = unchecked((uint)0x00010000),
    FontYMinBoundsBitNV = unchecked((uint)0x00020000),
    FontXMaxBoundsBitNV = unchecked((uint)0x00040000),
    FontYMaxBoundsBitNV = unchecked((uint)0x00080000),
    FontUnitsPerEmBitNV = unchecked((uint)0x00100000),
    FontAscenderBitNV = unchecked((uint)0x00200000),
    FontDescenderBitNV = unchecked((uint)0x00400000),
    FontHeightBitNV = unchecked((uint)0x00800000),
    FontMaxAdvanceWidthBitNV = unchecked((uint)0x01000000),
    FontMaxAdvanceHeightBitNV = unchecked((uint)0x02000000),
    FontUnderlinePositionBitNV = unchecked((uint)0x04000000),
    FontUnderlineThicknessBitNV = unchecked((uint)0x08000000),
    FontHasKerningBitNV = unchecked((uint)0x10000000),
    FontNumGlyphIndicesBitNV = unchecked((uint)0x20000000),
}
