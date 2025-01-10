// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
public enum DWRITE_GLYPH_IMAGE_FORMATS
{
    DWRITE_GLYPH_IMAGE_FORMATS_NONE = 0x00000000,
    DWRITE_GLYPH_IMAGE_FORMATS_TRUETYPE = 0x00000001,
    DWRITE_GLYPH_IMAGE_FORMATS_CFF = 0x00000002,
    DWRITE_GLYPH_IMAGE_FORMATS_COLR = 0x00000004,
    DWRITE_GLYPH_IMAGE_FORMATS_SVG = 0x00000008,
    DWRITE_GLYPH_IMAGE_FORMATS_PNG = 0x00000010,
    DWRITE_GLYPH_IMAGE_FORMATS_JPEG = 0x00000020,
    DWRITE_GLYPH_IMAGE_FORMATS_TIFF = 0x00000040,
    DWRITE_GLYPH_IMAGE_FORMATS_PREMULTIPLIED_B8G8R8A8 = 0x00000080,
    DWRITE_GLYPH_IMAGE_FORMATS_COLR_PAINT_TREE = 0x00000100,
}
