// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DWRITE_COLOR_GLYPH_RUN1.xml' path='doc/member[@name="DWRITE_COLOR_GLYPH_RUN1"]/*'/>
[NativeTypeName("struct DWRITE_COLOR_GLYPH_RUN1 : DWRITE_COLOR_GLYPH_RUN")]
[NativeInheritance("DWRITE_COLOR_GLYPH_RUN")]
public partial struct DWRITE_COLOR_GLYPH_RUN1
{
    public DWRITE_COLOR_GLYPH_RUN Base;
    /// <include file='DWRITE_COLOR_GLYPH_RUN1.xml' path='doc/member[@name="DWRITE_COLOR_GLYPH_RUN1.glyphImageFormat"]/*'/>
    public DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat;
    /// <include file='DWRITE_COLOR_GLYPH_RUN1.xml' path='doc/member[@name="DWRITE_COLOR_GLYPH_RUN1.measuringMode"]/*'/>
    public DWRITE_MEASURING_MODE measuringMode;
}