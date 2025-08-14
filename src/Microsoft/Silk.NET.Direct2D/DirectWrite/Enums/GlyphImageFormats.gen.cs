// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [Flags]
    [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS")]
    public enum GlyphImageFormats : int
    {
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_NONE")]
        None = 0x0,
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_TRUETYPE")]
        Truetype = 0x1,
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_CFF")]
        Cff = 0x2,
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_COLR")]
        Colr = 0x4,
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_SVG")]
        Svg = 0x8,
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_PNG")]
        Png = 0x10,
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_JPEG")]
        Jpeg = 0x20,
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_TIFF")]
        Tiff = 0x40,
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_PREMULTIPLIED_B8G8R8A8")]
        PremultipliedB8G8R8A8 = 0x80,
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_COLR_PAINT_TREE")]
        ColrPaintTree = 0x100,
    }
}
