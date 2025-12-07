// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_PixelFormat")]
public enum PixelFormat
{
    [NativeName("SDL_PIXELFORMAT_UNKNOWN")]
    Unknown = 0,

    [NativeName("SDL_PIXELFORMAT_INDEX1LSB")]
    Index1Lsb = 286261504,

    [NativeName("SDL_PIXELFORMAT_INDEX1MSB")]
    Index1Msb = 287310080,

    [NativeName("SDL_PIXELFORMAT_INDEX2LSB")]
    Index2Lsb = 470811136,

    [NativeName("SDL_PIXELFORMAT_INDEX2MSB")]
    Index2Msb = 471859712,

    [NativeName("SDL_PIXELFORMAT_INDEX4LSB")]
    Index4Lsb = 303039488,

    [NativeName("SDL_PIXELFORMAT_INDEX4MSB")]
    Index4Msb = 304088064,

    [NativeName("SDL_PIXELFORMAT_INDEX8")]
    Index8 = 318769153,

    [NativeName("SDL_PIXELFORMAT_RGB332")]
    Rgb332 = 336660481,

    [NativeName("SDL_PIXELFORMAT_XRGB4444")]
    Xrgb4444 = 353504258,

    [NativeName("SDL_PIXELFORMAT_XBGR4444")]
    Xbgr4444 = 357698562,

    [NativeName("SDL_PIXELFORMAT_XRGB1555")]
    Xrgb1555 = 353570562,

    [NativeName("SDL_PIXELFORMAT_XBGR1555")]
    Xbgr1555 = 357764866,

    [NativeName("SDL_PIXELFORMAT_ARGB4444")]
    Argb4444 = 355602434,

    [NativeName("SDL_PIXELFORMAT_RGBA4444")]
    Rgba4444 = 356651010,

    [NativeName("SDL_PIXELFORMAT_ABGR4444")]
    Abgr4444 = 359796738,

    [NativeName("SDL_PIXELFORMAT_BGRA4444")]
    Bgra4444 = 360845314,

    [NativeName("SDL_PIXELFORMAT_ARGB1555")]
    Argb1555 = 355667970,

    [NativeName("SDL_PIXELFORMAT_RGBA5551")]
    Rgba5551 = 356782082,

    [NativeName("SDL_PIXELFORMAT_ABGR1555")]
    Abgr1555 = 359862274,

    [NativeName("SDL_PIXELFORMAT_BGRA5551")]
    Bgra5551 = 360976386,

    [NativeName("SDL_PIXELFORMAT_RGB565")]
    Rgb565 = 353701890,

    [NativeName("SDL_PIXELFORMAT_BGR565")]
    Bgr565 = 357896194,

    [NativeName("SDL_PIXELFORMAT_RGB24")]
    Rgb24 = 386930691,

    [NativeName("SDL_PIXELFORMAT_BGR24")]
    Bgr24 = 390076419,

    [NativeName("SDL_PIXELFORMAT_XRGB8888")]
    Xrgb8888 = 370546692,

    [NativeName("SDL_PIXELFORMAT_RGBX8888")]
    Rgbx8888 = 371595268,

    [NativeName("SDL_PIXELFORMAT_XBGR8888")]
    Xbgr8888 = 374740996,

    [NativeName("SDL_PIXELFORMAT_BGRX8888")]
    Bgrx8888 = 375789572,

    [NativeName("SDL_PIXELFORMAT_ARGB8888")]
    Argb8888 = 372645892,

    [NativeName("SDL_PIXELFORMAT_RGBA8888")]
    Rgba8888 = 373694468,

    [NativeName("SDL_PIXELFORMAT_ABGR8888")]
    Abgr8888 = 376840196,

    [NativeName("SDL_PIXELFORMAT_BGRA8888")]
    Bgra8888 = 377888772,

    [NativeName("SDL_PIXELFORMAT_XRGB2101010")]
    Xrgb2101010 = 370614276,

    [NativeName("SDL_PIXELFORMAT_XBGR2101010")]
    Xbgr2101010 = 374808580,

    [NativeName("SDL_PIXELFORMAT_ARGB2101010")]
    Argb2101010 = 372711428,

    [NativeName("SDL_PIXELFORMAT_ABGR2101010")]
    Abgr2101010 = 376905732,

    [NativeName("SDL_PIXELFORMAT_RGB48")]
    Rgb48 = 403714054,

    [NativeName("SDL_PIXELFORMAT_BGR48")]
    Bgr48 = 406859782,

    [NativeName("SDL_PIXELFORMAT_RGBA64")]
    Rgba64 = 404766728,

    [NativeName("SDL_PIXELFORMAT_ARGB64")]
    Argb64 = 405815304,

    [NativeName("SDL_PIXELFORMAT_BGRA64")]
    Bgra64 = 407912456,

    [NativeName("SDL_PIXELFORMAT_ABGR64")]
    Abgr64 = 408961032,

    [NativeName("SDL_PIXELFORMAT_RGB48_FLOAT")]
    Rgb48Float = 437268486,

    [NativeName("SDL_PIXELFORMAT_BGR48_FLOAT")]
    Bgr48Float = 440414214,

    [NativeName("SDL_PIXELFORMAT_RGBA64_FLOAT")]
    Rgba64Float = 438321160,

    [NativeName("SDL_PIXELFORMAT_ARGB64_FLOAT")]
    Argb64Float = 439369736,

    [NativeName("SDL_PIXELFORMAT_BGRA64_FLOAT")]
    Bgra64Float = 441466888,

    [NativeName("SDL_PIXELFORMAT_ABGR64_FLOAT")]
    Abgr64Float = 442515464,

    [NativeName("SDL_PIXELFORMAT_RGB96_FLOAT")]
    Rgb96Float = 454057996,

    [NativeName("SDL_PIXELFORMAT_BGR96_FLOAT")]
    Bgr96Float = 457203724,

    [NativeName("SDL_PIXELFORMAT_RGBA128_FLOAT")]
    Rgba128Float = 455114768,

    [NativeName("SDL_PIXELFORMAT_ARGB128_FLOAT")]
    Argb128Float = 456163344,

    [NativeName("SDL_PIXELFORMAT_BGRA128_FLOAT")]
    Bgra128Float = 458260496,

    [NativeName("SDL_PIXELFORMAT_ABGR128_FLOAT")]
    Abgr128Float = 459309072,

    [NativeName("SDL_PIXELFORMAT_YV12")]
    Yv12 = 842094169,

    [NativeName("SDL_PIXELFORMAT_IYUV")]
    Iyuv = 1448433993,

    [NativeName("SDL_PIXELFORMAT_YUY2")]
    Yuy2 = 844715353,

    [NativeName("SDL_PIXELFORMAT_UYVY")]
    Uyvy = 1498831189,

    [NativeName("SDL_PIXELFORMAT_YVYU")]
    Yvyu = 1431918169,

    [NativeName("SDL_PIXELFORMAT_NV12")]
    Nv12 = 842094158,

    [NativeName("SDL_PIXELFORMAT_NV21")]
    Nv21 = 825382478,

    [NativeName("SDL_PIXELFORMAT_P010")]
    P010 = 808530000,

    [NativeName("SDL_PIXELFORMAT_EXTERNAL_OES")]
    ExternalOes = 542328143,

    [NativeName("SDL_PIXELFORMAT_RGBA32")]
    Rgba32 = Abgr8888,

    [NativeName("SDL_PIXELFORMAT_ARGB32")]
    Argb32 = Bgra8888,

    [NativeName("SDL_PIXELFORMAT_BGRA32")]
    Bgra32 = Argb8888,

    [NativeName("SDL_PIXELFORMAT_ABGR32")]
    Abgr32 = Rgba8888,

    [NativeName("SDL_PIXELFORMAT_RGBX32")]
    Rgbx32 = Xbgr8888,

    [NativeName("SDL_PIXELFORMAT_XRGB32")]
    Xrgb32 = Bgrx8888,

    [NativeName("SDL_PIXELFORMAT_BGRX32")]
    Bgrx32 = Xrgb8888,

    [NativeName("SDL_PIXELFORMAT_XBGR32")]
    Xbgr32 = Rgbx8888,
}
