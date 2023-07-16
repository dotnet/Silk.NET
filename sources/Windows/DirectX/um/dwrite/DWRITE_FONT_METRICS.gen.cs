// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DWRITE_FONT_METRICS.xml' path='doc/member[@name="DWRITE_FONT_METRICS"]/*'/>
public partial struct DWRITE_FONT_METRICS
{
    /// <include file='DWRITE_FONT_METRICS.xml' path='doc/member[@name="DWRITE_FONT_METRICS.designUnitsPerEm"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort designUnitsPerEm;
    /// <include file='DWRITE_FONT_METRICS.xml' path='doc/member[@name="DWRITE_FONT_METRICS.ascent"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort ascent;
    /// <include file='DWRITE_FONT_METRICS.xml' path='doc/member[@name="DWRITE_FONT_METRICS.descent"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort descent;
    /// <include file='DWRITE_FONT_METRICS.xml' path='doc/member[@name="DWRITE_FONT_METRICS.lineGap"]/*'/>
    [NativeTypeName("INT16")]
    public short lineGap;
    /// <include file='DWRITE_FONT_METRICS.xml' path='doc/member[@name="DWRITE_FONT_METRICS.capHeight"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort capHeight;
    /// <include file='DWRITE_FONT_METRICS.xml' path='doc/member[@name="DWRITE_FONT_METRICS.xHeight"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort xHeight;
    /// <include file='DWRITE_FONT_METRICS.xml' path='doc/member[@name="DWRITE_FONT_METRICS.underlinePosition"]/*'/>
    [NativeTypeName("INT16")]
    public short underlinePosition;
    /// <include file='DWRITE_FONT_METRICS.xml' path='doc/member[@name="DWRITE_FONT_METRICS.underlineThickness"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort underlineThickness;
    /// <include file='DWRITE_FONT_METRICS.xml' path='doc/member[@name="DWRITE_FONT_METRICS.strikethroughPosition"]/*'/>
    [NativeTypeName("INT16")]
    public short strikethroughPosition;
    /// <include file='DWRITE_FONT_METRICS.xml' path='doc/member[@name="DWRITE_FONT_METRICS.strikethroughThickness"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort strikethroughThickness;
}