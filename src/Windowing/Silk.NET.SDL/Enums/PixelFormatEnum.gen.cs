// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_pixels_L175_C9")]
    [NativeName("Name", "SDL_PixelFormatEnum")]
    public enum PixelFormatEnum : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_UNKNOWN")]
        PixelformatUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Index1Lsb\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX1LSB")]
        PixelformatIndex1Lsb = 0x11100100,
        [Obsolete("Deprecated in favour of \"Index1Msb\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX1MSB")]
        PixelformatIndex1Msb = 0x11200100,
        [Obsolete("Deprecated in favour of \"Index2Lsb\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX2LSB")]
        PixelformatIndex2Lsb = 0x1C100200,
        [Obsolete("Deprecated in favour of \"Index2Msb\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX2MSB")]
        PixelformatIndex2Msb = 0x1C200200,
        [Obsolete("Deprecated in favour of \"Index4Lsb\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX4LSB")]
        PixelformatIndex4Lsb = 0x12100400,
        [Obsolete("Deprecated in favour of \"Index4Msb\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX4MSB")]
        PixelformatIndex4Msb = 0x12200400,
        [Obsolete("Deprecated in favour of \"Index8\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX8")]
        PixelformatIndex8 = 0x13000801,
        [Obsolete("Deprecated in favour of \"Rgb332\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_RGB332")]
        PixelformatRgb332 = 0x14110801,
        [Obsolete("Deprecated in favour of \"Xrgb4444\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_XRGB4444")]
        PixelformatXrgb4444 = 0x15120C02,
        [Obsolete("Deprecated in favour of \"Rgb444\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_RGB444")]
        PixelformatRgb444 = 0x15120C02,
        [Obsolete("Deprecated in favour of \"Xbgr4444\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_XBGR4444")]
        PixelformatXbgr4444 = 0x15520C02,
        [Obsolete("Deprecated in favour of \"Bgr444\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_BGR444")]
        PixelformatBgr444 = 0x15520C02,
        [Obsolete("Deprecated in favour of \"Xrgb1555\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_XRGB1555")]
        PixelformatXrgb1555 = 0x15130F02,
        [Obsolete("Deprecated in favour of \"Rgb555\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_RGB555")]
        PixelformatRgb555 = 0x15130F02,
        [Obsolete("Deprecated in favour of \"Xbgr1555\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_XBGR1555")]
        PixelformatXbgr1555 = 0x15530F02,
        [Obsolete("Deprecated in favour of \"Bgr555\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_BGR555")]
        PixelformatBgr555 = 0x15530F02,
        [Obsolete("Deprecated in favour of \"Argb4444\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_ARGB4444")]
        PixelformatArgb4444 = 0x15321002,
        [Obsolete("Deprecated in favour of \"Rgba4444\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_RGBA4444")]
        PixelformatRgba4444 = 0x15421002,
        [Obsolete("Deprecated in favour of \"Abgr4444\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_ABGR4444")]
        PixelformatAbgr4444 = 0x15721002,
        [Obsolete("Deprecated in favour of \"Bgra4444\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_BGRA4444")]
        PixelformatBgra4444 = 0x15821002,
        [Obsolete("Deprecated in favour of \"Argb1555\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_ARGB1555")]
        PixelformatArgb1555 = 0x15331002,
        [Obsolete("Deprecated in favour of \"Rgba5551\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_RGBA5551")]
        PixelformatRgba5551 = 0x15441002,
        [Obsolete("Deprecated in favour of \"Abgr1555\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_ABGR1555")]
        PixelformatAbgr1555 = 0x15731002,
        [Obsolete("Deprecated in favour of \"Bgra5551\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_BGRA5551")]
        PixelformatBgra5551 = 0x15841002,
        [Obsolete("Deprecated in favour of \"Rgb565\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_RGB565")]
        PixelformatRgb565 = 0x15151002,
        [Obsolete("Deprecated in favour of \"Bgr565\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_BGR565")]
        PixelformatBgr565 = 0x15551002,
        [Obsolete("Deprecated in favour of \"Rgb24\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_RGB24")]
        PixelformatRgb24 = 0x17101803,
        [Obsolete("Deprecated in favour of \"Bgr24\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_BGR24")]
        PixelformatBgr24 = 0x17401803,
        [Obsolete("Deprecated in favour of \"Xrgb8888\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_XRGB8888")]
        PixelformatXrgb8888 = 0x16161804,
        [Obsolete("Deprecated in favour of \"Rgb888\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_RGB888")]
        PixelformatRgb888 = 0x16161804,
        [Obsolete("Deprecated in favour of \"Rgbx8888\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_RGBX8888")]
        PixelformatRgbx8888 = 0x16261804,
        [Obsolete("Deprecated in favour of \"Xbgr8888\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_XBGR8888")]
        PixelformatXbgr8888 = 0x16561804,
        [Obsolete("Deprecated in favour of \"Bgr888\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_BGR888")]
        PixelformatBgr888 = 0x16561804,
        [Obsolete("Deprecated in favour of \"Bgrx8888\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_BGRX8888")]
        PixelformatBgrx8888 = 0x16661804,
        [Obsolete("Deprecated in favour of \"Argb8888\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_ARGB8888")]
        PixelformatArgb8888 = 0x16362004,
        [Obsolete("Deprecated in favour of \"Rgba8888\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_RGBA8888")]
        PixelformatRgba8888 = 0x16462004,
        [Obsolete("Deprecated in favour of \"Abgr8888\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_ABGR8888")]
        PixelformatAbgr8888 = 0x16762004,
        [Obsolete("Deprecated in favour of \"Bgra8888\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_BGRA8888")]
        PixelformatBgra8888 = 0x16862004,
        [Obsolete("Deprecated in favour of \"Argb2101010\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_ARGB2101010")]
        PixelformatArgb2101010 = 0x16372004,
        [Obsolete("Deprecated in favour of \"Rgba32\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_RGBA32")]
        PixelformatRgba32 = 0x16762004,
        [Obsolete("Deprecated in favour of \"Argb32\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_ARGB32")]
        PixelformatArgb32 = 0x16862004,
        [Obsolete("Deprecated in favour of \"Bgra32\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_BGRA32")]
        PixelformatBgra32 = 0x16362004,
        [Obsolete("Deprecated in favour of \"Abgr32\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_ABGR32")]
        PixelformatAbgr32 = 0x16462004,
        [Obsolete("Deprecated in favour of \"Rgbx32\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_RGBX32")]
        PixelformatRgbx32 = 0x16561804,
        [Obsolete("Deprecated in favour of \"Xrgb32\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_XRGB32")]
        PixelformatXrgb32 = 0x16661804,
        [Obsolete("Deprecated in favour of \"Bgrx32\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_BGRX32")]
        PixelformatBgrx32 = 0x16161804,
        [Obsolete("Deprecated in favour of \"Xbgr32\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_XBGR32")]
        PixelformatXbgr32 = 0x16261804,
        [Obsolete("Deprecated in favour of \"YV12\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_YV12")]
        PixelformatYV12 = 0x32315659,
        [Obsolete("Deprecated in favour of \"Iyuv\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_IYUV")]
        PixelformatIyuv = 0x56555949,
        [Obsolete("Deprecated in favour of \"Yuy2\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_YUY2")]
        PixelformatYuy2 = 0x32595559,
        [Obsolete("Deprecated in favour of \"Uyvy\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_UYVY")]
        PixelformatUyvy = 0x59565955,
        [Obsolete("Deprecated in favour of \"Yvyu\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_YVYU")]
        PixelformatYvyu = 0x55595659,
        [Obsolete("Deprecated in favour of \"NV12\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_NV12")]
        PixelformatNV12 = 0x3231564E,
        [Obsolete("Deprecated in favour of \"NV21\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_NV21")]
        PixelformatNV21 = 0x3132564E,
        [Obsolete("Deprecated in favour of \"ExternalOes\"")]
        [NativeName("Name", "SDL_PIXELFORMAT_EXTERNAL_OES")]
        PixelformatExternalOes = 0x2053454F,
        [NativeName("Name", "SDL_PIXELFORMAT_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX1LSB")]
        Index1Lsb = 0x11100100,
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX1MSB")]
        Index1Msb = 0x11200100,
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX2LSB")]
        Index2Lsb = 0x1C100200,
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX2MSB")]
        Index2Msb = 0x1C200200,
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX4LSB")]
        Index4Lsb = 0x12100400,
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX4MSB")]
        Index4Msb = 0x12200400,
        [NativeName("Name", "SDL_PIXELFORMAT_INDEX8")]
        Index8 = 0x13000801,
        [NativeName("Name", "SDL_PIXELFORMAT_RGB332")]
        Rgb332 = 0x14110801,
        [NativeName("Name", "SDL_PIXELFORMAT_XRGB4444")]
        Xrgb4444 = 0x15120C02,
        [NativeName("Name", "SDL_PIXELFORMAT_RGB444")]
        Rgb444 = 0x15120C02,
        [NativeName("Name", "SDL_PIXELFORMAT_XBGR4444")]
        Xbgr4444 = 0x15520C02,
        [NativeName("Name", "SDL_PIXELFORMAT_BGR444")]
        Bgr444 = 0x15520C02,
        [NativeName("Name", "SDL_PIXELFORMAT_XRGB1555")]
        Xrgb1555 = 0x15130F02,
        [NativeName("Name", "SDL_PIXELFORMAT_RGB555")]
        Rgb555 = 0x15130F02,
        [NativeName("Name", "SDL_PIXELFORMAT_XBGR1555")]
        Xbgr1555 = 0x15530F02,
        [NativeName("Name", "SDL_PIXELFORMAT_BGR555")]
        Bgr555 = 0x15530F02,
        [NativeName("Name", "SDL_PIXELFORMAT_ARGB4444")]
        Argb4444 = 0x15321002,
        [NativeName("Name", "SDL_PIXELFORMAT_RGBA4444")]
        Rgba4444 = 0x15421002,
        [NativeName("Name", "SDL_PIXELFORMAT_ABGR4444")]
        Abgr4444 = 0x15721002,
        [NativeName("Name", "SDL_PIXELFORMAT_BGRA4444")]
        Bgra4444 = 0x15821002,
        [NativeName("Name", "SDL_PIXELFORMAT_ARGB1555")]
        Argb1555 = 0x15331002,
        [NativeName("Name", "SDL_PIXELFORMAT_RGBA5551")]
        Rgba5551 = 0x15441002,
        [NativeName("Name", "SDL_PIXELFORMAT_ABGR1555")]
        Abgr1555 = 0x15731002,
        [NativeName("Name", "SDL_PIXELFORMAT_BGRA5551")]
        Bgra5551 = 0x15841002,
        [NativeName("Name", "SDL_PIXELFORMAT_RGB565")]
        Rgb565 = 0x15151002,
        [NativeName("Name", "SDL_PIXELFORMAT_BGR565")]
        Bgr565 = 0x15551002,
        [NativeName("Name", "SDL_PIXELFORMAT_RGB24")]
        Rgb24 = 0x17101803,
        [NativeName("Name", "SDL_PIXELFORMAT_BGR24")]
        Bgr24 = 0x17401803,
        [NativeName("Name", "SDL_PIXELFORMAT_XRGB8888")]
        Xrgb8888 = 0x16161804,
        [NativeName("Name", "SDL_PIXELFORMAT_RGB888")]
        Rgb888 = 0x16161804,
        [NativeName("Name", "SDL_PIXELFORMAT_RGBX8888")]
        Rgbx8888 = 0x16261804,
        [NativeName("Name", "SDL_PIXELFORMAT_XBGR8888")]
        Xbgr8888 = 0x16561804,
        [NativeName("Name", "SDL_PIXELFORMAT_BGR888")]
        Bgr888 = 0x16561804,
        [NativeName("Name", "SDL_PIXELFORMAT_BGRX8888")]
        Bgrx8888 = 0x16661804,
        [NativeName("Name", "SDL_PIXELFORMAT_ARGB8888")]
        Argb8888 = 0x16362004,
        [NativeName("Name", "SDL_PIXELFORMAT_RGBA8888")]
        Rgba8888 = 0x16462004,
        [NativeName("Name", "SDL_PIXELFORMAT_ABGR8888")]
        Abgr8888 = 0x16762004,
        [NativeName("Name", "SDL_PIXELFORMAT_BGRA8888")]
        Bgra8888 = 0x16862004,
        [NativeName("Name", "SDL_PIXELFORMAT_ARGB2101010")]
        Argb2101010 = 0x16372004,
        [NativeName("Name", "SDL_PIXELFORMAT_RGBA32")]
        Rgba32 = 0x16762004,
        [NativeName("Name", "SDL_PIXELFORMAT_ARGB32")]
        Argb32 = 0x16862004,
        [NativeName("Name", "SDL_PIXELFORMAT_BGRA32")]
        Bgra32 = 0x16362004,
        [NativeName("Name", "SDL_PIXELFORMAT_ABGR32")]
        Abgr32 = 0x16462004,
        [NativeName("Name", "SDL_PIXELFORMAT_RGBX32")]
        Rgbx32 = 0x16561804,
        [NativeName("Name", "SDL_PIXELFORMAT_XRGB32")]
        Xrgb32 = 0x16661804,
        [NativeName("Name", "SDL_PIXELFORMAT_BGRX32")]
        Bgrx32 = 0x16161804,
        [NativeName("Name", "SDL_PIXELFORMAT_XBGR32")]
        Xbgr32 = 0x16261804,
        [NativeName("Name", "SDL_PIXELFORMAT_YV12")]
        YV12 = 0x32315659,
        [NativeName("Name", "SDL_PIXELFORMAT_IYUV")]
        Iyuv = 0x56555949,
        [NativeName("Name", "SDL_PIXELFORMAT_YUY2")]
        Yuy2 = 0x32595559,
        [NativeName("Name", "SDL_PIXELFORMAT_UYVY")]
        Uyvy = 0x59565955,
        [NativeName("Name", "SDL_PIXELFORMAT_YVYU")]
        Yvyu = 0x55595659,
        [NativeName("Name", "SDL_PIXELFORMAT_NV12")]
        NV12 = 0x3231564E,
        [NativeName("Name", "SDL_PIXELFORMAT_NV21")]
        NV21 = 0x3132564E,
        [NativeName("Name", "SDL_PIXELFORMAT_EXTERNAL_OES")]
        ExternalOes = 0x2053454F,
    }
}
