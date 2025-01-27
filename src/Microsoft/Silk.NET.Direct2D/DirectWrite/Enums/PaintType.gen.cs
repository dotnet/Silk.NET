// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PAINT_TYPE")]
    public enum PaintType : int
    {
        [NativeName("Name", "DWRITE_PAINT_TYPE_NONE")]
        None = 0x0,
        [NativeName("Name", "DWRITE_PAINT_TYPE_LAYERS")]
        Layers = 0x1,
        [NativeName("Name", "DWRITE_PAINT_TYPE_SOLID_GLYPH")]
        SolidGlyph = 0x2,
        [NativeName("Name", "DWRITE_PAINT_TYPE_SOLID")]
        Solid = 0x3,
        [NativeName("Name", "DWRITE_PAINT_TYPE_LINEAR_GRADIENT")]
        LinearGradient = 0x4,
        [NativeName("Name", "DWRITE_PAINT_TYPE_RADIAL_GRADIENT")]
        RadialGradient = 0x5,
        [NativeName("Name", "DWRITE_PAINT_TYPE_SWEEP_GRADIENT")]
        SweepGradient = 0x6,
        [NativeName("Name", "DWRITE_PAINT_TYPE_GLYPH")]
        Glyph = 0x7,
        [NativeName("Name", "DWRITE_PAINT_TYPE_COLOR_GLYPH")]
        ColorGlyph = 0x8,
        [NativeName("Name", "DWRITE_PAINT_TYPE_TRANSFORM")]
        Transform = 0x9,
        [NativeName("Name", "DWRITE_PAINT_TYPE_COMPOSITE")]
        Composite = 0xA,
    }
}
