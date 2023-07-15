// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_COLOR_GLYPH_RUN.xml' path='doc/member[@name="DWRITE_COLOR_GLYPH_RUN"]/*'/>
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct DWRITE_COLOR_GLYPH_RUN
{
    /// <include file='DWRITE_COLOR_GLYPH_RUN.xml' path='doc/member[@name="DWRITE_COLOR_GLYPH_RUN.glyphRun"]/*'/>
    public DWRITE_GLYPH_RUN glyphRun;
    /// <include file='DWRITE_COLOR_GLYPH_RUN.xml' path='doc/member[@name="DWRITE_COLOR_GLYPH_RUN.glyphRunDescription"]/*'/>
    public DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription;
    /// <include file='DWRITE_COLOR_GLYPH_RUN.xml' path='doc/member[@name="DWRITE_COLOR_GLYPH_RUN.baselineOriginX"]/*'/>
    public float baselineOriginX;
    /// <include file='DWRITE_COLOR_GLYPH_RUN.xml' path='doc/member[@name="DWRITE_COLOR_GLYPH_RUN.baselineOriginY"]/*'/>
    public float baselineOriginY;
    /// <include file='DWRITE_COLOR_GLYPH_RUN.xml' path='doc/member[@name="DWRITE_COLOR_GLYPH_RUN.runColor"]/*'/>
    [NativeTypeName("DWRITE_COLOR_F")]
    public DXGI_RGBA runColor;
    /// <include file='DWRITE_COLOR_GLYPH_RUN.xml' path='doc/member[@name="DWRITE_COLOR_GLYPH_RUN.paletteIndex"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort paletteIndex;
}