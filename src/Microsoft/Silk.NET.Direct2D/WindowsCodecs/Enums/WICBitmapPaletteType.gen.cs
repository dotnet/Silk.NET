// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICBitmapPaletteType")]
    public enum WICBitmapPaletteType : int
    {
        [Obsolete("Deprecated in favour of \"BitmapPaletteTypeCustom\"")]
        [NativeName("Name", "WICBitmapPaletteTypeCustom")]
        WicbitmapPaletteTypeCustom = 0x0,
        [Obsolete("Deprecated in favour of \"BitmapPaletteTypeMedianCut\"")]
        [NativeName("Name", "WICBitmapPaletteTypeMedianCut")]
        WicbitmapPaletteTypeMedianCut = 0x1,
        [Obsolete("Deprecated in favour of \"BitmapPaletteTypeFixedBW\"")]
        [NativeName("Name", "WICBitmapPaletteTypeFixedBW")]
        WicbitmapPaletteTypeFixedBW = 0x2,
        [Obsolete("Deprecated in favour of \"BitmapPaletteTypeFixedHalftone8\"")]
        [NativeName("Name", "WICBitmapPaletteTypeFixedHalftone8")]
        WicbitmapPaletteTypeFixedHalftone8 = 0x3,
        [Obsolete("Deprecated in favour of \"BitmapPaletteTypeFixedHalftone27\"")]
        [NativeName("Name", "WICBitmapPaletteTypeFixedHalftone27")]
        WicbitmapPaletteTypeFixedHalftone27 = 0x4,
        [Obsolete("Deprecated in favour of \"BitmapPaletteTypeFixedHalftone64\"")]
        [NativeName("Name", "WICBitmapPaletteTypeFixedHalftone64")]
        WicbitmapPaletteTypeFixedHalftone64 = 0x5,
        [Obsolete("Deprecated in favour of \"BitmapPaletteTypeFixedHalftone125\"")]
        [NativeName("Name", "WICBitmapPaletteTypeFixedHalftone125")]
        WicbitmapPaletteTypeFixedHalftone125 = 0x6,
        [Obsolete("Deprecated in favour of \"BitmapPaletteTypeFixedHalftone216\"")]
        [NativeName("Name", "WICBitmapPaletteTypeFixedHalftone216")]
        WicbitmapPaletteTypeFixedHalftone216 = 0x7,
        [Obsolete("Deprecated in favour of \"BitmapPaletteTypeFixedWebPalette\"")]
        [NativeName("Name", "WICBitmapPaletteTypeFixedWebPalette")]
        WicbitmapPaletteTypeFixedWebPalette = 0x7,
        [Obsolete("Deprecated in favour of \"BitmapPaletteTypeFixedHalftone252\"")]
        [NativeName("Name", "WICBitmapPaletteTypeFixedHalftone252")]
        WicbitmapPaletteTypeFixedHalftone252 = 0x8,
        [Obsolete("Deprecated in favour of \"BitmapPaletteTypeFixedHalftone256\"")]
        [NativeName("Name", "WICBitmapPaletteTypeFixedHalftone256")]
        WicbitmapPaletteTypeFixedHalftone256 = 0x9,
        [Obsolete("Deprecated in favour of \"BitmapPaletteTypeFixedGray4\"")]
        [NativeName("Name", "WICBitmapPaletteTypeFixedGray4")]
        WicbitmapPaletteTypeFixedGray4 = 0xA,
        [Obsolete("Deprecated in favour of \"BitmapPaletteTypeFixedGray16\"")]
        [NativeName("Name", "WICBitmapPaletteTypeFixedGray16")]
        WicbitmapPaletteTypeFixedGray16 = 0xB,
        [Obsolete("Deprecated in favour of \"BitmapPaletteTypeFixedGray256\"")]
        [NativeName("Name", "WICBitmapPaletteTypeFixedGray256")]
        WicbitmapPaletteTypeFixedGray256 = 0xC,
        [Obsolete("Deprecated in favour of \"ItmappalettetypeForceDword\"")]
        [NativeName("Name", "WICBITMAPPALETTETYPE_FORCE_DWORD")]
        WicbitmappalettetypeForceDword = 0x7FFFFFFF,
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
