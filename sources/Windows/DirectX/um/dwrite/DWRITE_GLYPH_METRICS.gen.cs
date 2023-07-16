// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DWRITE_GLYPH_METRICS.xml' path='doc/member[@name="DWRITE_GLYPH_METRICS"]/*'/>
public partial struct DWRITE_GLYPH_METRICS
{
    /// <include file='DWRITE_GLYPH_METRICS.xml' path='doc/member[@name="DWRITE_GLYPH_METRICS.leftSideBearing"]/*'/>
    [NativeTypeName("INT32")]
    public int leftSideBearing;
    /// <include file='DWRITE_GLYPH_METRICS.xml' path='doc/member[@name="DWRITE_GLYPH_METRICS.advanceWidth"]/*'/>
    [NativeTypeName("UINT32")]
    public uint advanceWidth;
    /// <include file='DWRITE_GLYPH_METRICS.xml' path='doc/member[@name="DWRITE_GLYPH_METRICS.rightSideBearing"]/*'/>
    [NativeTypeName("INT32")]
    public int rightSideBearing;
    /// <include file='DWRITE_GLYPH_METRICS.xml' path='doc/member[@name="DWRITE_GLYPH_METRICS.topSideBearing"]/*'/>
    [NativeTypeName("INT32")]
    public int topSideBearing;
    /// <include file='DWRITE_GLYPH_METRICS.xml' path='doc/member[@name="DWRITE_GLYPH_METRICS.advanceHeight"]/*'/>
    [NativeTypeName("UINT32")]
    public uint advanceHeight;
    /// <include file='DWRITE_GLYPH_METRICS.xml' path='doc/member[@name="DWRITE_GLYPH_METRICS.bottomSideBearing"]/*'/>
    [NativeTypeName("INT32")]
    public int bottomSideBearing;
    /// <include file='DWRITE_GLYPH_METRICS.xml' path='doc/member[@name="DWRITE_GLYPH_METRICS.verticalOriginY"]/*'/>
    [NativeTypeName("INT32")]
    public int verticalOriginY;
}