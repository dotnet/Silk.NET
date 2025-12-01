// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_PixelFormat")]
public enum PixelFormat : uint
{
    [NativeName("SDL_PIXELFORMAT_UNKNOWN")]
    Unknown = 0,

    [NativeName("SDL_PIXELFORMAT_INDEX1LSB")]
    Index1Lsb = 0x11100100U,

    [NativeName("SDL_PIXELFORMAT_INDEX1MSB")]
    Index1Msb = 0x11200100U,

    [NativeName("SDL_PIXELFORMAT_INDEX2LSB")]
    Index2Lsb = 0x1c100200U,

    [NativeName("SDL_PIXELFORMAT_INDEX2MSB")]
    Index2Msb = 0x1c200200U,

    [NativeName("SDL_PIXELFORMAT_INDEX4LSB")]
    Index4Lsb = 0x12100400U,

    [NativeName("SDL_PIXELFORMAT_INDEX4MSB")]
    Index4Msb = 0x12200400U,

    [NativeName("SDL_PIXELFORMAT_INDEX8")]
    Index8 = 0x13000801U,

    [NativeName("SDL_PIXELFORMAT_RGB332")]
    Rgb332 = 0x14110801U,

    [NativeName("SDL_PIXELFORMAT_XRGB4444")]
    Xrgb4444 = 0x15120c02U,

    [NativeName("SDL_PIXELFORMAT_XBGR4444")]
    Xbgr4444 = 0x15520c02U,

    [NativeName("SDL_PIXELFORMAT_XRGB1555")]
    Xrgb1555 = 0x15130f02U,

    [NativeName("SDL_PIXELFORMAT_XBGR1555")]
    Xbgr1555 = 0x15530f02U,

    [NativeName("SDL_PIXELFORMAT_ARGB4444")]
    Argb4444 = 0x15321002U,

    [NativeName("SDL_PIXELFORMAT_RGBA4444")]
    Rgba4444 = 0x15421002U,

    [NativeName("SDL_PIXELFORMAT_ABGR4444")]
    Abgr4444 = 0x15721002U,

    [NativeName("SDL_PIXELFORMAT_BGRA4444")]
    Bgra4444 = 0x15821002U,

    [NativeName("SDL_PIXELFORMAT_ARGB1555")]
    Argb1555 = 0x15331002U,

    [NativeName("SDL_PIXELFORMAT_RGBA5551")]
    Rgba5551 = 0x15441002U,

    [NativeName("SDL_PIXELFORMAT_ABGR1555")]
    Abgr1555 = 0x15731002U,

    [NativeName("SDL_PIXELFORMAT_BGRA5551")]
    Bgra5551 = 0x15841002U,

    [NativeName("SDL_PIXELFORMAT_RGB565")]
    Rgb565 = 0x15151002U,

    [NativeName("SDL_PIXELFORMAT_BGR565")]
    Bgr565 = 0x15551002U,

    [NativeName("SDL_PIXELFORMAT_RGB24")]
    Rgb24 = 0x17101803U,

    [NativeName("SDL_PIXELFORMAT_BGR24")]
    Bgr24 = 0x17401803U,

    [NativeName("SDL_PIXELFORMAT_XRGB8888")]
    Xrgb8888 = 0x16161804U,

    [NativeName("SDL_PIXELFORMAT_RGBX8888")]
    Rgbx8888 = 0x16261804U,

    [NativeName("SDL_PIXELFORMAT_XBGR8888")]
    Xbgr8888 = 0x16561804U,

    [NativeName("SDL_PIXELFORMAT_BGRX8888")]
    Bgrx8888 = 0x16661804U,

    [NativeName("SDL_PIXELFORMAT_ARGB8888")]
    Argb8888 = 0x16362004U,

    [NativeName("SDL_PIXELFORMAT_RGBA8888")]
    Rgba8888 = 0x16462004U,

    [NativeName("SDL_PIXELFORMAT_ABGR8888")]
    Abgr8888 = 0x16762004U,

    [NativeName("SDL_PIXELFORMAT_BGRA8888")]
    Bgra8888 = 0x16862004U,

    [NativeName("SDL_PIXELFORMAT_XRGB2101010")]
    Xrgb2101010 = 0x16172004U,

    [NativeName("SDL_PIXELFORMAT_XBGR2101010")]
    Xbgr2101010 = 0x16572004U,

    [NativeName("SDL_PIXELFORMAT_ARGB2101010")]
    Argb2101010 = 0x16372004U,

    [NativeName("SDL_PIXELFORMAT_ABGR2101010")]
    Abgr2101010 = 0x16772004U,

    [NativeName("SDL_PIXELFORMAT_RGB48")]
    Rgb48 = 0x18103006U,

    [NativeName("SDL_PIXELFORMAT_BGR48")]
    Bgr48 = 0x18403006U,

    [NativeName("SDL_PIXELFORMAT_RGBA64")]
    Rgba64 = 0x18204008U,

    [NativeName("SDL_PIXELFORMAT_ARGB64")]
    Argb64 = 0x18304008U,

    [NativeName("SDL_PIXELFORMAT_BGRA64")]
    Bgra64 = 0x18504008U,

    [NativeName("SDL_PIXELFORMAT_ABGR64")]
    Abgr64 = 0x18604008U,

    [NativeName("SDL_PIXELFORMAT_RGB48_FLOAT")]
    Rgb48Float = 0x1a103006U,

    [NativeName("SDL_PIXELFORMAT_BGR48_FLOAT")]
    Bgr48Float = 0x1a403006U,

    [NativeName("SDL_PIXELFORMAT_RGBA64_FLOAT")]
    Rgba64Float = 0x1a204008U,

    [NativeName("SDL_PIXELFORMAT_ARGB64_FLOAT")]
    Argb64Float = 0x1a304008U,

    [NativeName("SDL_PIXELFORMAT_BGRA64_FLOAT")]
    Bgra64Float = 0x1a504008U,

    [NativeName("SDL_PIXELFORMAT_ABGR64_FLOAT")]
    Abgr64Float = 0x1a604008U,

    [NativeName("SDL_PIXELFORMAT_RGB96_FLOAT")]
    Rgb96Float = 0x1b10600cU,

    [NativeName("SDL_PIXELFORMAT_BGR96_FLOAT")]
    Bgr96Float = 0x1b40600cU,

    [NativeName("SDL_PIXELFORMAT_RGBA128_FLOAT")]
    Rgba128Float = 0x1b208010U,

    [NativeName("SDL_PIXELFORMAT_ARGB128_FLOAT")]
    Argb128Float = 0x1b308010U,

    [NativeName("SDL_PIXELFORMAT_BGRA128_FLOAT")]
    Bgra128Float = 0x1b508010U,

    [NativeName("SDL_PIXELFORMAT_ABGR128_FLOAT")]
    Abgr128Float = 0x1b608010U,

    [NativeName("SDL_PIXELFORMAT_YV12")]
    Yv12 = 0x32315659U,

    [NativeName("SDL_PIXELFORMAT_IYUV")]
    Iyuv = 0x56555949U,

    [NativeName("SDL_PIXELFORMAT_YUY2")]
    Yuy2 = 0x32595559U,

    [NativeName("SDL_PIXELFORMAT_UYVY")]
    Uyvy = 0x59565955U,

    [NativeName("SDL_PIXELFORMAT_YVYU")]
    Yvyu = 0x55595659U,

    [NativeName("SDL_PIXELFORMAT_NV12")]
    Nv12 = 0x3231564eU,

    [NativeName("SDL_PIXELFORMAT_NV21")]
    Nv21 = 0x3132564eU,

    [NativeName("SDL_PIXELFORMAT_P010")]
    P010 = 0x30313050U,

    [NativeName("SDL_PIXELFORMAT_EXTERNAL_OES")]
    ExternalOes = 0x2053454fU,

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
