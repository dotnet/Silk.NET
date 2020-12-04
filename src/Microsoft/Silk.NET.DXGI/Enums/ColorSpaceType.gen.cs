// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_COLOR_SPACE_TYPE")]
    public enum ColorSpaceType
    {
        [NativeName("Name", "DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P709")]
        ColorSpaceRgbFullG22NoneP709 = 0x0,
        [NativeName("Name", "DXGI_COLOR_SPACE_RGB_FULL_G10_NONE_P709")]
        ColorSpaceRgbFullG10NoneP709 = 0x1,
        [NativeName("Name", "DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P709")]
        ColorSpaceRgbStudioG22NoneP709 = 0x2,
        [NativeName("Name", "DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P2020")]
        ColorSpaceRgbStudioG22NoneP2020 = 0x3,
        [NativeName("Name", "DXGI_COLOR_SPACE_RESERVED")]
        ColorSpaceReserved = 0x4,
        [NativeName("Name", "DXGI_COLOR_SPACE_YCBCR_FULL_G22_NONE_P709_X601")]
        ColorSpaceYcbcrFullG22NoneP709X601 = 0x5,
        [NativeName("Name", "DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601")]
        ColorSpaceYcbcrStudioG22LeftP601 = 0x6,
        [NativeName("Name", "DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P601")]
        ColorSpaceYcbcrFullG22LeftP601 = 0x7,
        [NativeName("Name", "DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P709")]
        ColorSpaceYcbcrStudioG22LeftP709 = 0x8,
        [NativeName("Name", "DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P709")]
        ColorSpaceYcbcrFullG22LeftP709 = 0x9,
        [NativeName("Name", "DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P2020")]
        ColorSpaceYcbcrStudioG22LeftP2020 = 0xA,
        [NativeName("Name", "DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P2020")]
        ColorSpaceYcbcrFullG22LeftP2020 = 0xB,
        [NativeName("Name", "DXGI_COLOR_SPACE_RGB_FULL_G2084_NONE_P2020")]
        ColorSpaceRgbFullG2084NoneP2020 = 0xC,
        [NativeName("Name", "DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_LEFT_P2020")]
        ColorSpaceYcbcrStudioG2084LeftP2020 = 0xD,
        [NativeName("Name", "DXGI_COLOR_SPACE_RGB_STUDIO_G2084_NONE_P2020")]
        ColorSpaceRgbStudioG2084NoneP2020 = 0xE,
        [NativeName("Name", "DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_TOPLEFT_P2020")]
        ColorSpaceYcbcrStudioG22TopleftP2020 = 0xF,
        [NativeName("Name", "DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_TOPLEFT_P2020")]
        ColorSpaceYcbcrStudioG2084TopleftP2020 = 0x10,
        [NativeName("Name", "DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P2020")]
        ColorSpaceRgbFullG22NoneP2020 = 0x11,
        [NativeName("Name", "DXGI_COLOR_SPACE_YCBCR_STUDIO_GHLG_TOPLEFT_P2020")]
        ColorSpaceYcbcrStudioGhlgTopleftP2020 = 0x12,
        [NativeName("Name", "DXGI_COLOR_SPACE_YCBCR_FULL_GHLG_TOPLEFT_P2020")]
        ColorSpaceYcbcrFullGhlgTopleftP2020 = 0x13,
        [NativeName("Name", "DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P709")]
        ColorSpaceRgbStudioG24NoneP709 = 0x14,
        [NativeName("Name", "DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P2020")]
        ColorSpaceRgbStudioG24NoneP2020 = 0x15,
        [NativeName("Name", "DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P709")]
        ColorSpaceYcbcrStudioG24LeftP709 = 0x16,
        [NativeName("Name", "DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P2020")]
        ColorSpaceYcbcrStudioG24LeftP2020 = 0x17,
        [NativeName("Name", "DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_TOPLEFT_P2020")]
        ColorSpaceYcbcrStudioG24TopleftP2020 = 0x18,
        [NativeName("Name", "DXGI_COLOR_SPACE_CUSTOM")]
        ColorSpaceCustom = unchecked((int)0xFFFFFFFFFFFFFFFF),
    }
}
