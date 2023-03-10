// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS")]
    public enum DwriteGlyphImageFormats : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_NONE")]
        DwriteGlyphImageFormatsNone = 0x0,
        [Obsolete("Deprecated in favour of \"Truetype\"")]
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_TRUETYPE")]
        DwriteGlyphImageFormatsTruetype = 0x1,
        [Obsolete("Deprecated in favour of \"Cff\"")]
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_CFF")]
        DwriteGlyphImageFormatsCff = 0x2,
        [Obsolete("Deprecated in favour of \"Colr\"")]
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_COLR")]
        DwriteGlyphImageFormatsColr = 0x4,
        [Obsolete("Deprecated in favour of \"Svg\"")]
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_SVG")]
        DwriteGlyphImageFormatsSvg = 0x8,
        [Obsolete("Deprecated in favour of \"Png\"")]
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_PNG")]
        DwriteGlyphImageFormatsPng = 0x10,
        [Obsolete("Deprecated in favour of \"Jpeg\"")]
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_JPEG")]
        DwriteGlyphImageFormatsJpeg = 0x20,
        [Obsolete("Deprecated in favour of \"Tiff\"")]
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_TIFF")]
        DwriteGlyphImageFormatsTiff = 0x40,
        [Obsolete("Deprecated in favour of \"PremultipliedB8G8R8A8\"")]
        [NativeName("Name", "DWRITE_GLYPH_IMAGE_FORMATS_PREMULTIPLIED_B8G8R8A8")]
        DwriteGlyphImageFormatsPremultipliedB8G8R8A8 = 0x80,
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
    }
}
