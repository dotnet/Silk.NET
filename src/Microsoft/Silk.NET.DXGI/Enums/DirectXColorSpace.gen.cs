// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DirectXColorSpace")]
    public enum DirectXColorSpace : int
    {
        [Obsolete("Deprecated in favour of \"RgbFullG22NoneP709\"")]
        [NativeName("Name", "DirectXColorSpace_RgbFullG22NoneP709")]
        DirectXColorSpaceRgbFullG22NoneP709 = 0x0,
        [Obsolete("Deprecated in favour of \"RgbFullG10NoneP709\"")]
        [NativeName("Name", "DirectXColorSpace_RgbFullG10NoneP709")]
        DirectXColorSpaceRgbFullG10NoneP709 = 0x1,
        [Obsolete("Deprecated in favour of \"RgbStudioG22NoneP709\"")]
        [NativeName("Name", "DirectXColorSpace_RgbStudioG22NoneP709")]
        DirectXColorSpaceRgbStudioG22NoneP709 = 0x2,
        [Obsolete("Deprecated in favour of \"RgbStudioG22NoneP2020\"")]
        [NativeName("Name", "DirectXColorSpace_RgbStudioG22NoneP2020")]
        DirectXColorSpaceRgbStudioG22NoneP2020 = 0x3,
        [Obsolete("Deprecated in favour of \"Reserved\"")]
        [NativeName("Name", "DirectXColorSpace_Reserved")]
        DirectXColorSpaceReserved = 0x4,
        [Obsolete("Deprecated in favour of \"YccFullG22NoneP709X601\"")]
        [NativeName("Name", "DirectXColorSpace_YccFullG22NoneP709X601")]
        DirectXColorSpaceYccFullG22NoneP709X601 = 0x5,
        [Obsolete("Deprecated in favour of \"YccStudioG22LeftP601\"")]
        [NativeName("Name", "DirectXColorSpace_YccStudioG22LeftP601")]
        DirectXColorSpaceYccStudioG22LeftP601 = 0x6,
        [Obsolete("Deprecated in favour of \"YccFullG22LeftP601\"")]
        [NativeName("Name", "DirectXColorSpace_YccFullG22LeftP601")]
        DirectXColorSpaceYccFullG22LeftP601 = 0x7,
        [Obsolete("Deprecated in favour of \"YccStudioG22LeftP709\"")]
        [NativeName("Name", "DirectXColorSpace_YccStudioG22LeftP709")]
        DirectXColorSpaceYccStudioG22LeftP709 = 0x8,
        [Obsolete("Deprecated in favour of \"YccFullG22LeftP709\"")]
        [NativeName("Name", "DirectXColorSpace_YccFullG22LeftP709")]
        DirectXColorSpaceYccFullG22LeftP709 = 0x9,
        [Obsolete("Deprecated in favour of \"YccStudioG22LeftP2020\"")]
        [NativeName("Name", "DirectXColorSpace_YccStudioG22LeftP2020")]
        DirectXColorSpaceYccStudioG22LeftP2020 = 0xA,
        [Obsolete("Deprecated in favour of \"YccFullG22LeftP2020\"")]
        [NativeName("Name", "DirectXColorSpace_YccFullG22LeftP2020")]
        DirectXColorSpaceYccFullG22LeftP2020 = 0xB,
        [Obsolete("Deprecated in favour of \"RgbFullG2084NoneP2020\"")]
        [NativeName("Name", "DirectXColorSpace_RgbFullG2084NoneP2020")]
        DirectXColorSpaceRgbFullG2084NoneP2020 = 0xC,
        [Obsolete("Deprecated in favour of \"YccStudioG2084LeftP2020\"")]
        [NativeName("Name", "DirectXColorSpace_YccStudioG2084LeftP2020")]
        DirectXColorSpaceYccStudioG2084LeftP2020 = 0xD,
        [Obsolete("Deprecated in favour of \"RgbStudioG2084NoneP2020\"")]
        [NativeName("Name", "DirectXColorSpace_RgbStudioG2084NoneP2020")]
        DirectXColorSpaceRgbStudioG2084NoneP2020 = 0xE,
        [Obsolete("Deprecated in favour of \"YccStudioG22TopLeftP2020\"")]
        [NativeName("Name", "DirectXColorSpace_YccStudioG22TopLeftP2020")]
        DirectXColorSpaceYccStudioG22TopLeftP2020 = 0xF,
        [Obsolete("Deprecated in favour of \"YccStudioG2084TopLeftP2020\"")]
        [NativeName("Name", "DirectXColorSpace_YccStudioG2084TopLeftP2020")]
        DirectXColorSpaceYccStudioG2084TopLeftP2020 = 0x10,
        [Obsolete("Deprecated in favour of \"RgbFullG22NoneP2020\"")]
        [NativeName("Name", "DirectXColorSpace_RgbFullG22NoneP2020")]
        DirectXColorSpaceRgbFullG22NoneP2020 = 0x11,
        [Obsolete("Deprecated in favour of \"YccStudioGHlgTopLeftP2020\"")]
        [NativeName("Name", "DirectXColorSpace_YccStudioGHlgTopLeftP2020")]
        DirectXColorSpaceYccStudioGHlgTopLeftP2020 = 0x12,
        [Obsolete("Deprecated in favour of \"YccFullGHlgTopLeftP2020\"")]
        [NativeName("Name", "DirectXColorSpace_YccFullGHlgTopLeftP2020")]
        DirectXColorSpaceYccFullGHlgTopLeftP2020 = 0x13,
        [Obsolete("Deprecated in favour of \"RgbStudioG24NoneP709\"")]
        [NativeName("Name", "DirectXColorSpace_RgbStudioG24NoneP709")]
        DirectXColorSpaceRgbStudioG24NoneP709 = 0x14,
        [Obsolete("Deprecated in favour of \"RgbStudioG24NoneP2020\"")]
        [NativeName("Name", "DirectXColorSpace_RgbStudioG24NoneP2020")]
        DirectXColorSpaceRgbStudioG24NoneP2020 = 0x15,
        [Obsolete("Deprecated in favour of \"YccStudioG24LeftP709\"")]
        [NativeName("Name", "DirectXColorSpace_YccStudioG24LeftP709")]
        DirectXColorSpaceYccStudioG24LeftP709 = 0x16,
        [Obsolete("Deprecated in favour of \"YccStudioG24LeftP2020\"")]
        [NativeName("Name", "DirectXColorSpace_YccStudioG24LeftP2020")]
        DirectXColorSpaceYccStudioG24LeftP2020 = 0x17,
        [Obsolete("Deprecated in favour of \"YccStudioG24TopLeftP2020\"")]
        [NativeName("Name", "DirectXColorSpace_YccStudioG24TopLeftP2020")]
        DirectXColorSpaceYccStudioG24TopLeftP2020 = 0x18,
        [NativeName("Name", "DirectXColorSpace_RgbFullG22NoneP709")]
        RgbFullG22NoneP709 = 0x0,
        [NativeName("Name", "DirectXColorSpace_RgbFullG10NoneP709")]
        RgbFullG10NoneP709 = 0x1,
        [NativeName("Name", "DirectXColorSpace_RgbStudioG22NoneP709")]
        RgbStudioG22NoneP709 = 0x2,
        [NativeName("Name", "DirectXColorSpace_RgbStudioG22NoneP2020")]
        RgbStudioG22NoneP2020 = 0x3,
        [NativeName("Name", "DirectXColorSpace_Reserved")]
        Reserved = 0x4,
        [NativeName("Name", "DirectXColorSpace_YccFullG22NoneP709X601")]
        YccFullG22NoneP709X601 = 0x5,
        [NativeName("Name", "DirectXColorSpace_YccStudioG22LeftP601")]
        YccStudioG22LeftP601 = 0x6,
        [NativeName("Name", "DirectXColorSpace_YccFullG22LeftP601")]
        YccFullG22LeftP601 = 0x7,
        [NativeName("Name", "DirectXColorSpace_YccStudioG22LeftP709")]
        YccStudioG22LeftP709 = 0x8,
        [NativeName("Name", "DirectXColorSpace_YccFullG22LeftP709")]
        YccFullG22LeftP709 = 0x9,
        [NativeName("Name", "DirectXColorSpace_YccStudioG22LeftP2020")]
        YccStudioG22LeftP2020 = 0xA,
        [NativeName("Name", "DirectXColorSpace_YccFullG22LeftP2020")]
        YccFullG22LeftP2020 = 0xB,
        [NativeName("Name", "DirectXColorSpace_RgbFullG2084NoneP2020")]
        RgbFullG2084NoneP2020 = 0xC,
        [NativeName("Name", "DirectXColorSpace_YccStudioG2084LeftP2020")]
        YccStudioG2084LeftP2020 = 0xD,
        [NativeName("Name", "DirectXColorSpace_RgbStudioG2084NoneP2020")]
        RgbStudioG2084NoneP2020 = 0xE,
        [NativeName("Name", "DirectXColorSpace_YccStudioG22TopLeftP2020")]
        YccStudioG22TopLeftP2020 = 0xF,
        [NativeName("Name", "DirectXColorSpace_YccStudioG2084TopLeftP2020")]
        YccStudioG2084TopLeftP2020 = 0x10,
        [NativeName("Name", "DirectXColorSpace_RgbFullG22NoneP2020")]
        RgbFullG22NoneP2020 = 0x11,
        [NativeName("Name", "DirectXColorSpace_YccStudioGHlgTopLeftP2020")]
        YccStudioGHlgTopLeftP2020 = 0x12,
        [NativeName("Name", "DirectXColorSpace_YccFullGHlgTopLeftP2020")]
        YccFullGHlgTopLeftP2020 = 0x13,
        [NativeName("Name", "DirectXColorSpace_RgbStudioG24NoneP709")]
        RgbStudioG24NoneP709 = 0x14,
        [NativeName("Name", "DirectXColorSpace_RgbStudioG24NoneP2020")]
        RgbStudioG24NoneP2020 = 0x15,
        [NativeName("Name", "DirectXColorSpace_YccStudioG24LeftP709")]
        YccStudioG24LeftP709 = 0x16,
        [NativeName("Name", "DirectXColorSpace_YccStudioG24LeftP2020")]
        YccStudioG24LeftP2020 = 0x17,
        [NativeName("Name", "DirectXColorSpace_YccStudioG24TopLeftP2020")]
        YccStudioG24TopLeftP2020 = 0x18,
    }
}
