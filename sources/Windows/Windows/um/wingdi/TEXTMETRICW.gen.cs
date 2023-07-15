// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW"]/*'/>
public partial struct TEXTMETRICW
{
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmHeight"]/*'/>
    [NativeTypeName("LONG")]
    public int tmHeight;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmAscent"]/*'/>
    [NativeTypeName("LONG")]
    public int tmAscent;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmDescent"]/*'/>
    [NativeTypeName("LONG")]
    public int tmDescent;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmInternalLeading"]/*'/>
    [NativeTypeName("LONG")]
    public int tmInternalLeading;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmExternalLeading"]/*'/>
    [NativeTypeName("LONG")]
    public int tmExternalLeading;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmAveCharWidth"]/*'/>
    [NativeTypeName("LONG")]
    public int tmAveCharWidth;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmMaxCharWidth"]/*'/>
    [NativeTypeName("LONG")]
    public int tmMaxCharWidth;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmWeight"]/*'/>
    [NativeTypeName("LONG")]
    public int tmWeight;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmOverhang"]/*'/>
    [NativeTypeName("LONG")]
    public int tmOverhang;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmDigitizedAspectX"]/*'/>
    [NativeTypeName("LONG")]
    public int tmDigitizedAspectX;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmDigitizedAspectY"]/*'/>
    [NativeTypeName("LONG")]
    public int tmDigitizedAspectY;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmFirstChar"]/*'/>
    [NativeTypeName("WCHAR")]
    public ushort tmFirstChar;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmLastChar"]/*'/>
    [NativeTypeName("WCHAR")]
    public ushort tmLastChar;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmDefaultChar"]/*'/>
    [NativeTypeName("WCHAR")]
    public ushort tmDefaultChar;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmBreakChar"]/*'/>
    [NativeTypeName("WCHAR")]
    public ushort tmBreakChar;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmItalic"]/*'/>
    public byte tmItalic;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmUnderlined"]/*'/>
    public byte tmUnderlined;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmStruckOut"]/*'/>
    public byte tmStruckOut;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmPitchAndFamily"]/*'/>
    public byte tmPitchAndFamily;
    /// <include file='TEXTMETRICW.xml' path='doc/member[@name="TEXTMETRICW.tmCharSet"]/*'/>
    public byte tmCharSet;
}