// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA"]/*' />
public partial struct NEWTEXTMETRICA
{
    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmHeight"]/*' />
    [NativeTypeName("LONG")]
    public int tmHeight;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmAscent"]/*' />
    [NativeTypeName("LONG")]
    public int tmAscent;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmDescent"]/*' />
    [NativeTypeName("LONG")]
    public int tmDescent;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmInternalLeading"]/*' />
    [NativeTypeName("LONG")]
    public int tmInternalLeading;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmExternalLeading"]/*' />
    [NativeTypeName("LONG")]
    public int tmExternalLeading;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmAveCharWidth"]/*' />
    [NativeTypeName("LONG")]
    public int tmAveCharWidth;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmMaxCharWidth"]/*' />
    [NativeTypeName("LONG")]
    public int tmMaxCharWidth;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmWeight"]/*' />
    [NativeTypeName("LONG")]
    public int tmWeight;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmOverhang"]/*' />
    [NativeTypeName("LONG")]
    public int tmOverhang;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmDigitizedAspectX"]/*' />
    [NativeTypeName("LONG")]
    public int tmDigitizedAspectX;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmDigitizedAspectY"]/*' />
    [NativeTypeName("LONG")]
    public int tmDigitizedAspectY;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmFirstChar"]/*' />
    public byte tmFirstChar;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmLastChar"]/*' />
    public byte tmLastChar;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmDefaultChar"]/*' />
    public byte tmDefaultChar;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmBreakChar"]/*' />
    public byte tmBreakChar;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmItalic"]/*' />
    public byte tmItalic;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmUnderlined"]/*' />
    public byte tmUnderlined;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmStruckOut"]/*' />
    public byte tmStruckOut;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmPitchAndFamily"]/*' />
    public byte tmPitchAndFamily;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.tmCharSet"]/*' />
    public byte tmCharSet;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.ntmFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint ntmFlags;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.ntmSizeEM"]/*' />
    public uint ntmSizeEM;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.ntmCellHeight"]/*' />
    public uint ntmCellHeight;

    /// <include file='NEWTEXTMETRICA.xml' path='doc/member[@name="NEWTEXTMETRICA.ntmAvgWidth"]/*' />
    public uint ntmAvgWidth;
}
