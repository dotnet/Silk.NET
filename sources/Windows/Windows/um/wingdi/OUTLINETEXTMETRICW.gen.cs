// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW"]/*'/>
public unsafe partial struct OUTLINETEXTMETRICW
{
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmSize"]/*'/>
    public uint otmSize;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmTextMetrics"]/*'/>
    public TEXTMETRICW otmTextMetrics;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmFiller"]/*'/>
    public byte otmFiller;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmPanoseNumber"]/*'/>
    public PANOSE otmPanoseNumber;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmfsSelection"]/*'/>
    public uint otmfsSelection;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmfsType"]/*'/>
    public uint otmfsType;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmsCharSlopeRise"]/*'/>
    public int otmsCharSlopeRise;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmsCharSlopeRun"]/*'/>
    public int otmsCharSlopeRun;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmItalicAngle"]/*'/>
    public int otmItalicAngle;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmEMSquare"]/*'/>
    public uint otmEMSquare;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmAscent"]/*'/>
    public int otmAscent;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmDescent"]/*'/>
    public int otmDescent;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmLineGap"]/*'/>
    public uint otmLineGap;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmsCapEmHeight"]/*'/>
    public uint otmsCapEmHeight;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmsXHeight"]/*'/>
    public uint otmsXHeight;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmrcFontBox"]/*'/>
    public RECT otmrcFontBox;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmMacAscent"]/*'/>
    public int otmMacAscent;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmMacDescent"]/*'/>
    public int otmMacDescent;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmMacLineGap"]/*'/>
    public uint otmMacLineGap;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmusMinimumPPEM"]/*'/>
    public uint otmusMinimumPPEM;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmptSubscriptSize"]/*'/>
    public POINT otmptSubscriptSize;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmptSubscriptOffset"]/*'/>
    public POINT otmptSubscriptOffset;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmptSuperscriptSize"]/*'/>
    public POINT otmptSuperscriptSize;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmptSuperscriptOffset"]/*'/>
    public POINT otmptSuperscriptOffset;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmsStrikeoutSize"]/*'/>
    public uint otmsStrikeoutSize;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmsStrikeoutPosition"]/*'/>
    public int otmsStrikeoutPosition;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmsUnderscoreSize"]/*'/>
    public int otmsUnderscoreSize;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmsUnderscorePosition"]/*'/>
    public int otmsUnderscorePosition;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmpFamilyName"]/*'/>
    [NativeTypeName("PSTR")]
    public sbyte* otmpFamilyName;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmpFaceName"]/*'/>
    [NativeTypeName("PSTR")]
    public sbyte* otmpFaceName;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmpStyleName"]/*'/>
    [NativeTypeName("PSTR")]
    public sbyte* otmpStyleName;
    /// <include file='OUTLINETEXTMETRICW.xml' path='doc/member[@name="OUTLINETEXTMETRICW.otmpFullName"]/*'/>
    [NativeTypeName("PSTR")]
    public sbyte* otmpFullName;
}