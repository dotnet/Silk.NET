// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA"]/*' />
public partial struct TEXTMETRICA
{
    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmHeight"]/*' />
    [NativeTypeName("LONG")]
    public int tmHeight;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmAscent"]/*' />
    [NativeTypeName("LONG")]
    public int tmAscent;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmDescent"]/*' />
    [NativeTypeName("LONG")]
    public int tmDescent;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmInternalLeading"]/*' />
    [NativeTypeName("LONG")]
    public int tmInternalLeading;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmExternalLeading"]/*' />
    [NativeTypeName("LONG")]
    public int tmExternalLeading;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmAveCharWidth"]/*' />
    [NativeTypeName("LONG")]
    public int tmAveCharWidth;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmMaxCharWidth"]/*' />
    [NativeTypeName("LONG")]
    public int tmMaxCharWidth;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmWeight"]/*' />
    [NativeTypeName("LONG")]
    public int tmWeight;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmOverhang"]/*' />
    [NativeTypeName("LONG")]
    public int tmOverhang;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmDigitizedAspectX"]/*' />
    [NativeTypeName("LONG")]
    public int tmDigitizedAspectX;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmDigitizedAspectY"]/*' />
    [NativeTypeName("LONG")]
    public int tmDigitizedAspectY;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmFirstChar"]/*' />
    public byte tmFirstChar;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmLastChar"]/*' />
    public byte tmLastChar;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmDefaultChar"]/*' />
    public byte tmDefaultChar;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmBreakChar"]/*' />
    public byte tmBreakChar;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmItalic"]/*' />
    public byte tmItalic;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmUnderlined"]/*' />
    public byte tmUnderlined;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmStruckOut"]/*' />
    public byte tmStruckOut;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmPitchAndFamily"]/*' />
    public byte tmPitchAndFamily;

    /// <include file='TEXTMETRICA.xml' path='doc/member[@name="TEXTMETRICA.tmCharSet"]/*' />
    public byte tmCharSet;
}
