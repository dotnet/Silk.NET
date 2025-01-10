// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TEXTMETRICA
{
    [NativeTypeName("LONG")]
    public int tmHeight;

    [NativeTypeName("LONG")]
    public int tmAscent;

    [NativeTypeName("LONG")]
    public int tmDescent;

    [NativeTypeName("LONG")]
    public int tmInternalLeading;

    [NativeTypeName("LONG")]
    public int tmExternalLeading;

    [NativeTypeName("LONG")]
    public int tmAveCharWidth;

    [NativeTypeName("LONG")]
    public int tmMaxCharWidth;

    [NativeTypeName("LONG")]
    public int tmWeight;

    [NativeTypeName("LONG")]
    public int tmOverhang;

    [NativeTypeName("LONG")]
    public int tmDigitizedAspectX;

    [NativeTypeName("LONG")]
    public int tmDigitizedAspectY;
    public byte tmFirstChar;
    public byte tmLastChar;
    public byte tmDefaultChar;
    public byte tmBreakChar;
    public byte tmItalic;
    public byte tmUnderlined;
    public byte tmStruckOut;
    public byte tmPitchAndFamily;
    public byte tmCharSet;
}
