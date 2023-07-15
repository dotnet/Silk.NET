// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA"]/*'/>
public unsafe partial struct OUTLINETEXTMETRICA
{
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmSize"]/*'/>
    public uint otmSize;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmTextMetrics"]/*'/>
    public TEXTMETRICA otmTextMetrics;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmFiller"]/*'/>
    public byte otmFiller;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmPanoseNumber"]/*'/>
    public PANOSE otmPanoseNumber;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmfsSelection"]/*'/>
    public uint otmfsSelection;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmfsType"]/*'/>
    public uint otmfsType;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmsCharSlopeRise"]/*'/>
    public int otmsCharSlopeRise;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmsCharSlopeRun"]/*'/>
    public int otmsCharSlopeRun;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmItalicAngle"]/*'/>
    public int otmItalicAngle;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmEMSquare"]/*'/>
    public uint otmEMSquare;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmAscent"]/*'/>
    public int otmAscent;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmDescent"]/*'/>
    public int otmDescent;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmLineGap"]/*'/>
    public uint otmLineGap;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmsCapEmHeight"]/*'/>
    public uint otmsCapEmHeight;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmsXHeight"]/*'/>
    public uint otmsXHeight;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmrcFontBox"]/*'/>
    public RECT otmrcFontBox;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmMacAscent"]/*'/>
    public int otmMacAscent;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmMacDescent"]/*'/>
    public int otmMacDescent;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmMacLineGap"]/*'/>
    public uint otmMacLineGap;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmusMinimumPPEM"]/*'/>
    public uint otmusMinimumPPEM;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmptSubscriptSize"]/*'/>
    public POINT otmptSubscriptSize;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmptSubscriptOffset"]/*'/>
    public POINT otmptSubscriptOffset;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmptSuperscriptSize"]/*'/>
    public POINT otmptSuperscriptSize;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmptSuperscriptOffset"]/*'/>
    public POINT otmptSuperscriptOffset;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmsStrikeoutSize"]/*'/>
    public uint otmsStrikeoutSize;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmsStrikeoutPosition"]/*'/>
    public int otmsStrikeoutPosition;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmsUnderscoreSize"]/*'/>
    public int otmsUnderscoreSize;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmsUnderscorePosition"]/*'/>
    public int otmsUnderscorePosition;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmpFamilyName"]/*'/>
    [NativeTypeName("PSTR")]
    public sbyte* otmpFamilyName;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmpFaceName"]/*'/>
    [NativeTypeName("PSTR")]
    public sbyte* otmpFaceName;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmpStyleName"]/*'/>
    [NativeTypeName("PSTR")]
    public sbyte* otmpStyleName;
    /// <include file='OUTLINETEXTMETRICA.xml' path='doc/member[@name="OUTLINETEXTMETRICA.otmpFullName"]/*'/>
    [NativeTypeName("PSTR")]
    public sbyte* otmpFullName;
}