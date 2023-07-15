// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='DWRITE_FONT_METRICS1.xml' path='doc/member[@name="DWRITE_FONT_METRICS1"]/*'/>
[NativeTypeName("struct DWRITE_FONT_METRICS1 : DWRITE_FONT_METRICS")]
[NativeInheritance("DWRITE_FONT_METRICS")]
public partial struct DWRITE_FONT_METRICS1
{
    public DWRITE_FONT_METRICS Base;
    /// <include file='DWRITE_FONT_METRICS1.xml' path='doc/member[@name="DWRITE_FONT_METRICS1.glyphBoxLeft"]/*'/>
    [NativeTypeName("INT16")]
    public short glyphBoxLeft;
    /// <include file='DWRITE_FONT_METRICS1.xml' path='doc/member[@name="DWRITE_FONT_METRICS1.glyphBoxTop"]/*'/>
    [NativeTypeName("INT16")]
    public short glyphBoxTop;
    /// <include file='DWRITE_FONT_METRICS1.xml' path='doc/member[@name="DWRITE_FONT_METRICS1.glyphBoxRight"]/*'/>
    [NativeTypeName("INT16")]
    public short glyphBoxRight;
    /// <include file='DWRITE_FONT_METRICS1.xml' path='doc/member[@name="DWRITE_FONT_METRICS1.glyphBoxBottom"]/*'/>
    [NativeTypeName("INT16")]
    public short glyphBoxBottom;
    /// <include file='DWRITE_FONT_METRICS1.xml' path='doc/member[@name="DWRITE_FONT_METRICS1.subscriptPositionX"]/*'/>
    [NativeTypeName("INT16")]
    public short subscriptPositionX;
    /// <include file='DWRITE_FONT_METRICS1.xml' path='doc/member[@name="DWRITE_FONT_METRICS1.subscriptPositionY"]/*'/>
    [NativeTypeName("INT16")]
    public short subscriptPositionY;
    /// <include file='DWRITE_FONT_METRICS1.xml' path='doc/member[@name="DWRITE_FONT_METRICS1.subscriptSizeX"]/*'/>
    [NativeTypeName("INT16")]
    public short subscriptSizeX;
    /// <include file='DWRITE_FONT_METRICS1.xml' path='doc/member[@name="DWRITE_FONT_METRICS1.subscriptSizeY"]/*'/>
    [NativeTypeName("INT16")]
    public short subscriptSizeY;
    /// <include file='DWRITE_FONT_METRICS1.xml' path='doc/member[@name="DWRITE_FONT_METRICS1.superscriptPositionX"]/*'/>
    [NativeTypeName("INT16")]
    public short superscriptPositionX;
    /// <include file='DWRITE_FONT_METRICS1.xml' path='doc/member[@name="DWRITE_FONT_METRICS1.superscriptPositionY"]/*'/>
    [NativeTypeName("INT16")]
    public short superscriptPositionY;
    /// <include file='DWRITE_FONT_METRICS1.xml' path='doc/member[@name="DWRITE_FONT_METRICS1.superscriptSizeX"]/*'/>
    [NativeTypeName("INT16")]
    public short superscriptSizeX;
    /// <include file='DWRITE_FONT_METRICS1.xml' path='doc/member[@name="DWRITE_FONT_METRICS1.superscriptSizeY"]/*'/>
    [NativeTypeName("INT16")]
    public short superscriptSizeY;
    /// <include file='DWRITE_FONT_METRICS1.xml' path='doc/member[@name="DWRITE_FONT_METRICS1.hasTypographicMetrics"]/*'/>
    public BOOL hasTypographicMetrics;
}