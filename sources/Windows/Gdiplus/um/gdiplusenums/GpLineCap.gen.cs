// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Gdiplus;
/// <include file='GpLineCap.xml' path='doc/member[@name="GpLineCap"]/*'/>
public enum GpLineCap
{
    /// <include file='GpLineCap.xml' path='doc/member[@name="GpLineCap.LineCapFlat"]/*'/>
    LineCapFlat = 0,
    /// <include file='GpLineCap.xml' path='doc/member[@name="GpLineCap.LineCapSquare"]/*'/>
    LineCapSquare = 1,
    /// <include file='GpLineCap.xml' path='doc/member[@name="GpLineCap.LineCapRound"]/*'/>
    LineCapRound = 2,
    /// <include file='GpLineCap.xml' path='doc/member[@name="GpLineCap.LineCapTriangle"]/*'/>
    LineCapTriangle = 3,
    /// <include file='GpLineCap.xml' path='doc/member[@name="GpLineCap.LineCapNoAnchor"]/*'/>
    LineCapNoAnchor = 0x10,
    /// <include file='GpLineCap.xml' path='doc/member[@name="GpLineCap.LineCapSquareAnchor"]/*'/>
    LineCapSquareAnchor = 0x11,
    /// <include file='GpLineCap.xml' path='doc/member[@name="GpLineCap.LineCapRoundAnchor"]/*'/>
    LineCapRoundAnchor = 0x12,
    /// <include file='GpLineCap.xml' path='doc/member[@name="GpLineCap.LineCapDiamondAnchor"]/*'/>
    LineCapDiamondAnchor = 0x13,
    /// <include file='GpLineCap.xml' path='doc/member[@name="GpLineCap.LineCapArrowAnchor"]/*'/>
    LineCapArrowAnchor = 0x14,
    /// <include file='GpLineCap.xml' path='doc/member[@name="GpLineCap.LineCapCustom"]/*'/>
    LineCapCustom = 0xff,
    /// <include file='GpLineCap.xml' path='doc/member[@name="GpLineCap.LineCapAnchorMask"]/*'/>
    LineCapAnchorMask = 0xf0,
}