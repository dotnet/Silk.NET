// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICBitmapPaletteType")]
    public enum BitmapPaletteType : int
    {
        [NativeName("Name", "WICBitmapPaletteTypeCustom")]
        BitmapPaletteTypeCustom = 0x0,
        [NativeName("Name", "WICBitmapPaletteTypeMedianCut")]
        BitmapPaletteTypeMedianCut = 0x1,
        [NativeName("Name", "WICBitmapPaletteTypeFixedBW")]
        BitmapPaletteTypeFixedBW = 0x2,
        [NativeName("Name", "WICBitmapPaletteTypeFixedHalftone8")]
        BitmapPaletteTypeFixedHalftone8 = 0x3,
        [NativeName("Name", "WICBitmapPaletteTypeFixedHalftone27")]
        BitmapPaletteTypeFixedHalftone27 = 0x4,
        [NativeName("Name", "WICBitmapPaletteTypeFixedHalftone64")]
        BitmapPaletteTypeFixedHalftone64 = 0x5,
        [NativeName("Name", "WICBitmapPaletteTypeFixedHalftone125")]
        BitmapPaletteTypeFixedHalftone125 = 0x6,
        [NativeName("Name", "WICBitmapPaletteTypeFixedHalftone216")]
        BitmapPaletteTypeFixedHalftone216 = 0x7,
        [NativeName("Name", "WICBitmapPaletteTypeFixedWebPalette")]
        BitmapPaletteTypeFixedWebPalette = 0x7,
        [NativeName("Name", "WICBitmapPaletteTypeFixedHalftone252")]
        BitmapPaletteTypeFixedHalftone252 = 0x8,
        [NativeName("Name", "WICBitmapPaletteTypeFixedHalftone256")]
        BitmapPaletteTypeFixedHalftone256 = 0x9,
        [NativeName("Name", "WICBitmapPaletteTypeFixedGray4")]
        BitmapPaletteTypeFixedGray4 = 0xA,
        [NativeName("Name", "WICBitmapPaletteTypeFixedGray16")]
        BitmapPaletteTypeFixedGray16 = 0xB,
        [NativeName("Name", "WICBitmapPaletteTypeFixedGray256")]
        BitmapPaletteTypeFixedGray256 = 0xC,
        [NativeName("Name", "WICBITMAPPALETTETYPE_FORCE_DWORD")]
        ItmappalettetypeForceDword = 0x7FFFFFFF,
    }
}
