// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.DirectX;
/// <include file='DWRITE_GLYPH_IMAGE_FORMATS.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_FORMATS"]/*'/>
[Flags]
public enum DWRITE_GLYPH_IMAGE_FORMATS
{
    /// <include file='DWRITE_GLYPH_IMAGE_FORMATS.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_FORMATS.DWRITE_GLYPH_IMAGE_FORMATS_NONE"]/*'/>
    DWRITE_GLYPH_IMAGE_FORMATS_NONE = 0x00000000,
    /// <include file='DWRITE_GLYPH_IMAGE_FORMATS.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_FORMATS.DWRITE_GLYPH_IMAGE_FORMATS_TRUETYPE"]/*'/>
    DWRITE_GLYPH_IMAGE_FORMATS_TRUETYPE = 0x00000001,
    /// <include file='DWRITE_GLYPH_IMAGE_FORMATS.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_FORMATS.DWRITE_GLYPH_IMAGE_FORMATS_CFF"]/*'/>
    DWRITE_GLYPH_IMAGE_FORMATS_CFF = 0x00000002,
    /// <include file='DWRITE_GLYPH_IMAGE_FORMATS.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_FORMATS.DWRITE_GLYPH_IMAGE_FORMATS_COLR"]/*'/>
    DWRITE_GLYPH_IMAGE_FORMATS_COLR = 0x00000004,
    /// <include file='DWRITE_GLYPH_IMAGE_FORMATS.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_FORMATS.DWRITE_GLYPH_IMAGE_FORMATS_SVG"]/*'/>
    DWRITE_GLYPH_IMAGE_FORMATS_SVG = 0x00000008,
    /// <include file='DWRITE_GLYPH_IMAGE_FORMATS.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_FORMATS.DWRITE_GLYPH_IMAGE_FORMATS_PNG"]/*'/>
    DWRITE_GLYPH_IMAGE_FORMATS_PNG = 0x00000010,
    /// <include file='DWRITE_GLYPH_IMAGE_FORMATS.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_FORMATS.DWRITE_GLYPH_IMAGE_FORMATS_JPEG"]/*'/>
    DWRITE_GLYPH_IMAGE_FORMATS_JPEG = 0x00000020,
    /// <include file='DWRITE_GLYPH_IMAGE_FORMATS.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_FORMATS.DWRITE_GLYPH_IMAGE_FORMATS_TIFF"]/*'/>
    DWRITE_GLYPH_IMAGE_FORMATS_TIFF = 0x00000040,
    /// <include file='DWRITE_GLYPH_IMAGE_FORMATS.xml' path='doc/member[@name="DWRITE_GLYPH_IMAGE_FORMATS.DWRITE_GLYPH_IMAGE_FORMATS_PREMULTIPLIED_B8G8R8A8"]/*'/>
    DWRITE_GLYPH_IMAGE_FORMATS_PREMULTIPLIED_B8G8R8A8 = 0x00000080,
}