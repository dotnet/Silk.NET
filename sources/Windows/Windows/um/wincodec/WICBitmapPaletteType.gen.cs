// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WICBitmapPaletteType.xml' path='doc/member[@name="WICBitmapPaletteType"]/*'/>
public enum WICBitmapPaletteType
{
    /// <include file='WICBitmapPaletteType.xml' path='doc/member[@name="WICBitmapPaletteType.WICBitmapPaletteTypeCustom"]/*'/>
    WICBitmapPaletteTypeCustom = 0,
    /// <include file='WICBitmapPaletteType.xml' path='doc/member[@name="WICBitmapPaletteType.WICBitmapPaletteTypeMedianCut"]/*'/>
    WICBitmapPaletteTypeMedianCut = 0x1,
    /// <include file='WICBitmapPaletteType.xml' path='doc/member[@name="WICBitmapPaletteType.WICBitmapPaletteTypeFixedBW"]/*'/>
    WICBitmapPaletteTypeFixedBW = 0x2,
    /// <include file='WICBitmapPaletteType.xml' path='doc/member[@name="WICBitmapPaletteType.WICBitmapPaletteTypeFixedHalftone8"]/*'/>
    WICBitmapPaletteTypeFixedHalftone8 = 0x3,
    /// <include file='WICBitmapPaletteType.xml' path='doc/member[@name="WICBitmapPaletteType.WICBitmapPaletteTypeFixedHalftone27"]/*'/>
    WICBitmapPaletteTypeFixedHalftone27 = 0x4,
    /// <include file='WICBitmapPaletteType.xml' path='doc/member[@name="WICBitmapPaletteType.WICBitmapPaletteTypeFixedHalftone64"]/*'/>
    WICBitmapPaletteTypeFixedHalftone64 = 0x5,
    /// <include file='WICBitmapPaletteType.xml' path='doc/member[@name="WICBitmapPaletteType.WICBitmapPaletteTypeFixedHalftone125"]/*'/>
    WICBitmapPaletteTypeFixedHalftone125 = 0x6,
    /// <include file='WICBitmapPaletteType.xml' path='doc/member[@name="WICBitmapPaletteType.WICBitmapPaletteTypeFixedHalftone216"]/*'/>
    WICBitmapPaletteTypeFixedHalftone216 = 0x7,
    /// <include file='WICBitmapPaletteType.xml' path='doc/member[@name="WICBitmapPaletteType.WICBitmapPaletteTypeFixedWebPalette"]/*'/>
    WICBitmapPaletteTypeFixedWebPalette = WICBitmapPaletteTypeFixedHalftone216,
    /// <include file='WICBitmapPaletteType.xml' path='doc/member[@name="WICBitmapPaletteType.WICBitmapPaletteTypeFixedHalftone252"]/*'/>
    WICBitmapPaletteTypeFixedHalftone252 = 0x8,
    /// <include file='WICBitmapPaletteType.xml' path='doc/member[@name="WICBitmapPaletteType.WICBitmapPaletteTypeFixedHalftone256"]/*'/>
    WICBitmapPaletteTypeFixedHalftone256 = 0x9,
    /// <include file='WICBitmapPaletteType.xml' path='doc/member[@name="WICBitmapPaletteType.WICBitmapPaletteTypeFixedGray4"]/*'/>
    WICBitmapPaletteTypeFixedGray4 = 0xa,
    /// <include file='WICBitmapPaletteType.xml' path='doc/member[@name="WICBitmapPaletteType.WICBitmapPaletteTypeFixedGray16"]/*'/>
    WICBitmapPaletteTypeFixedGray16 = 0xb,
    /// <include file='WICBitmapPaletteType.xml' path='doc/member[@name="WICBitmapPaletteType.WICBitmapPaletteTypeFixedGray256"]/*'/>
    WICBitmapPaletteTypeFixedGray256 = 0xc,
    /// <include file='WICBitmapPaletteType.xml' path='doc/member[@name="WICBitmapPaletteType.WICBITMAPPALETTETYPE_FORCE_DWORD"]/*'/>
    WICBITMAPPALETTETYPE_FORCE_DWORD = 0x7fffffff,
}