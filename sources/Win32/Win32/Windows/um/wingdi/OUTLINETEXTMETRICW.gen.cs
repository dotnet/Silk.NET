// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct OUTLINETEXTMETRICW
{
    public uint otmSize;
    public TEXTMETRICW otmTextMetrics;
    public byte otmFiller;
    public PANOSE otmPanoseNumber;
    public uint otmfsSelection;
    public uint otmfsType;
    public int otmsCharSlopeRise;
    public int otmsCharSlopeRun;
    public int otmItalicAngle;
    public uint otmEMSquare;
    public int otmAscent;
    public int otmDescent;
    public uint otmLineGap;
    public uint otmsCapEmHeight;
    public uint otmsXHeight;
    public RECT otmrcFontBox;
    public int otmMacAscent;
    public int otmMacDescent;
    public uint otmMacLineGap;
    public uint otmusMinimumPPEM;
    public POINT otmptSubscriptSize;
    public POINT otmptSubscriptOffset;
    public POINT otmptSuperscriptSize;
    public POINT otmptSuperscriptOffset;
    public uint otmsStrikeoutSize;
    public int otmsStrikeoutPosition;
    public int otmsUnderscoreSize;
    public int otmsUnderscorePosition;

    [NativeTypeName("PSTR")]
    public sbyte* otmpFamilyName;

    [NativeTypeName("PSTR")]
    public sbyte* otmpFaceName;

    [NativeTypeName("PSTR")]
    public sbyte* otmpStyleName;

    [NativeTypeName("PSTR")]
    public sbyte* otmpFullName;
}
