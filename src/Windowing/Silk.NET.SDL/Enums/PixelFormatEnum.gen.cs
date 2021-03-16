// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_pixels_L171_C9")]
    [NativeName("Name", "SDL_PixelFormatEnum")]
    public enum PixelFormatEnum : int
    {
        [NativeName("Name", "SDL_PIXELFORMAT_UNKNOWN")]
        PixelformatUnknown = 0x0,
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX1LSB")]
        PixelformatIndex1Lsb = 0x11100100,
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX1MSB")]
        PixelformatIndex1Msb = 0x11200100,
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX4LSB")]
        PixelformatIndex4Lsb = 0x12100400,
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX4MSB")]
        PixelformatIndex4Msb = 0x12200400,
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX8")]
        PixelformatIndex8 = 0x13000801,
        [NativeName("Name", "SDL_PIXELFORMAT_RGB332")]
        PixelformatRgb332 = 0x14110801,
        [NativeName("Name", "SDL_PIXELFORMAT_RGB444")]
        PixelformatRgb444 = 0x15120C02,
        [NativeName("Name", "SDL_PIXELFORMAT_BGR444")]
        PixelformatBgr444 = 0x15520C02,
        [NativeName("Name", "SDL_PIXELFORMAT_RGB555")]
        PixelformatRgb555 = 0x15130F02,
        [NativeName("Name", "SDL_PIXELFORMAT_BGR555")]
        PixelformatBgr555 = 0x15530F02,
        [NativeName("Name", "SDL_PIXELFORMAT_ARGB4444")]
        PixelformatArgb4444 = 0x15321002,
        [NativeName("Name", "SDL_PIXELFORMAT_RGBA4444")]
        PixelformatRgba4444 = 0x15421002,
        [NativeName("Name", "SDL_PIXELFORMAT_ABGR4444")]
        PixelformatAbgr4444 = 0x15721002,
        [NativeName("Name", "SDL_PIXELFORMAT_BGRA4444")]
        PixelformatBgra4444 = 0x15821002,
        [NativeName("Name", "SDL_PIXELFORMAT_ARGB1555")]
        PixelformatArgb1555 = 0x15331002,
        [NativeName("Name", "SDL_PIXELFORMAT_RGBA5551")]
        PixelformatRgba5551 = 0x15441002,
        [NativeName("Name", "SDL_PIXELFORMAT_ABGR1555")]
        PixelformatAbgr1555 = 0x15731002,
        [NativeName("Name", "SDL_PIXELFORMAT_BGRA5551")]
        PixelformatBgra5551 = 0x15841002,
        [NativeName("Name", "SDL_PIXELFORMAT_RGB565")]
        PixelformatRgb565 = 0x15151002,
        [NativeName("Name", "SDL_PIXELFORMAT_BGR565")]
        PixelformatBgr565 = 0x15551002,
        [NativeName("Name", "SDL_PIXELFORMAT_RGB24")]
        PixelformatRgb24 = 0x17101803,
        [NativeName("Name", "SDL_PIXELFORMAT_BGR24")]
        PixelformatBgr24 = 0x17401803,
        [NativeName("Name", "SDL_PIXELFORMAT_RGB888")]
        PixelformatRgb888 = 0x16161804,
        [NativeName("Name", "SDL_PIXELFORMAT_RGBX8888")]
        PixelformatRgbx8888 = 0x16261804,
        [NativeName("Name", "SDL_PIXELFORMAT_BGR888")]
        PixelformatBgr888 = 0x16561804,
        [NativeName("Name", "SDL_PIXELFORMAT_BGRX8888")]
        PixelformatBgrx8888 = 0x16661804,
        [NativeName("Name", "SDL_PIXELFORMAT_ARGB8888")]
        PixelformatArgb8888 = 0x16362004,
        [NativeName("Name", "SDL_PIXELFORMAT_RGBA8888")]
        PixelformatRgba8888 = 0x16462004,
        [NativeName("Name", "SDL_PIXELFORMAT_ABGR8888")]
        PixelformatAbgr8888 = 0x16762004,
        [NativeName("Name", "SDL_PIXELFORMAT_BGRA8888")]
        PixelformatBgra8888 = 0x16862004,
        [NativeName("Name", "SDL_PIXELFORMAT_ARGB2101010")]
        PixelformatArgb2101010 = 0x16372004,
        [NativeName("Name", "SDL_PIXELFORMAT_RGBA32")]
        PixelformatRgba32 = 0x16762004,
        [NativeName("Name", "SDL_PIXELFORMAT_ARGB32")]
        PixelformatArgb32 = 0x16862004,
        [NativeName("Name", "SDL_PIXELFORMAT_BGRA32")]
        PixelformatBgra32 = 0x16362004,
        [NativeName("Name", "SDL_PIXELFORMAT_ABGR32")]
        PixelformatAbgr32 = 0x16462004,
        [NativeName("Name", "SDL_PIXELFORMAT_YV12")]
        PixelformatYV12 = 0x32315659,
        [NativeName("Name", "SDL_PIXELFORMAT_IYUV")]
        PixelformatIyuv = 0x56555949,
        [NativeName("Name", "SDL_PIXELFORMAT_YUY2")]
        PixelformatYuy2 = 0x32595559,
        [NativeName("Name", "SDL_PIXELFORMAT_UYVY")]
        PixelformatUyvy = 0x59565955,
        [NativeName("Name", "SDL_PIXELFORMAT_YVYU")]
        PixelformatYvyu = 0x55595659,
        [NativeName("Name", "SDL_PIXELFORMAT_NV12")]
        PixelformatNV12 = 0x3231564E,
        [NativeName("Name", "SDL_PIXELFORMAT_NV21")]
        PixelformatNV21 = 0x3132564E,
        [NativeName("Name", "SDL_PIXELFORMAT_EXTERNAL_OES")]
        PixelformatExternalOes = 0x2053454F,
    }
}
