// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW"]/*'/>
public partial struct NEWTEXTMETRICW
{
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmHeight"]/*'/>
    [NativeTypeName("LONG")]
    public int tmHeight;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmAscent"]/*'/>
    [NativeTypeName("LONG")]
    public int tmAscent;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmDescent"]/*'/>
    [NativeTypeName("LONG")]
    public int tmDescent;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmInternalLeading"]/*'/>
    [NativeTypeName("LONG")]
    public int tmInternalLeading;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmExternalLeading"]/*'/>
    [NativeTypeName("LONG")]
    public int tmExternalLeading;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmAveCharWidth"]/*'/>
    [NativeTypeName("LONG")]
    public int tmAveCharWidth;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmMaxCharWidth"]/*'/>
    [NativeTypeName("LONG")]
    public int tmMaxCharWidth;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmWeight"]/*'/>
    [NativeTypeName("LONG")]
    public int tmWeight;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmOverhang"]/*'/>
    [NativeTypeName("LONG")]
    public int tmOverhang;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmDigitizedAspectX"]/*'/>
    [NativeTypeName("LONG")]
    public int tmDigitizedAspectX;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmDigitizedAspectY"]/*'/>
    [NativeTypeName("LONG")]
    public int tmDigitizedAspectY;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmFirstChar"]/*'/>
    [NativeTypeName("WCHAR")]
    public ushort tmFirstChar;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmLastChar"]/*'/>
    [NativeTypeName("WCHAR")]
    public ushort tmLastChar;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmDefaultChar"]/*'/>
    [NativeTypeName("WCHAR")]
    public ushort tmDefaultChar;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmBreakChar"]/*'/>
    [NativeTypeName("WCHAR")]
    public ushort tmBreakChar;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmItalic"]/*'/>
    public byte tmItalic;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmUnderlined"]/*'/>
    public byte tmUnderlined;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmStruckOut"]/*'/>
    public byte tmStruckOut;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmPitchAndFamily"]/*'/>
    public byte tmPitchAndFamily;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.tmCharSet"]/*'/>
    public byte tmCharSet;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.ntmFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ntmFlags;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.ntmSizeEM"]/*'/>
    public uint ntmSizeEM;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.ntmCellHeight"]/*'/>
    public uint ntmCellHeight;
    /// <include file='NEWTEXTMETRICW.xml' path='doc/member[@name="NEWTEXTMETRICW.ntmAvgWidth"]/*'/>
    public uint ntmAvgWidth;
}