// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='DWRITE_GLYPH_RUN.xml' path='doc/member[@name="DWRITE_GLYPH_RUN"]/*'/>
public unsafe partial struct DWRITE_GLYPH_RUN
{
    /// <include file='DWRITE_GLYPH_RUN.xml' path='doc/member[@name="DWRITE_GLYPH_RUN.fontFace"]/*'/>
    public IDWriteFontFace* fontFace;
    /// <include file='DWRITE_GLYPH_RUN.xml' path='doc/member[@name="DWRITE_GLYPH_RUN.fontEmSize"]/*'/>
    public float fontEmSize;
    /// <include file='DWRITE_GLYPH_RUN.xml' path='doc/member[@name="DWRITE_GLYPH_RUN.glyphCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint glyphCount;
    /// <include file='DWRITE_GLYPH_RUN.xml' path='doc/member[@name="DWRITE_GLYPH_RUN.glyphIndices"]/*'/>
    [NativeTypeName("const UINT16 *")]
    public ushort* glyphIndices;
    /// <include file='DWRITE_GLYPH_RUN.xml' path='doc/member[@name="DWRITE_GLYPH_RUN.glyphAdvances"]/*'/>
    [NativeTypeName("const FLOAT *")]
    public float* glyphAdvances;
    /// <include file='DWRITE_GLYPH_RUN.xml' path='doc/member[@name="DWRITE_GLYPH_RUN.glyphOffsets"]/*'/>
    [NativeTypeName("const DWRITE_GLYPH_OFFSET *")]
    public DWRITE_GLYPH_OFFSET* glyphOffsets;
    /// <include file='DWRITE_GLYPH_RUN.xml' path='doc/member[@name="DWRITE_GLYPH_RUN.isSideways"]/*'/>
    public BOOL isSideways;
    /// <include file='DWRITE_GLYPH_RUN.xml' path='doc/member[@name="DWRITE_GLYPH_RUN.bidiLevel"]/*'/>
    [NativeTypeName("UINT32")]
    public uint bidiLevel;
}