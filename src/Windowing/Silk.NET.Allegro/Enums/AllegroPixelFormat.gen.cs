// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "ALLEGRO_PIXEL_FORMAT")]
    public enum AllegroPixelFormat
    {
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_ANY")]
        AllegroPixelFormatAny = 0x0,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_ANY_NO_ALPHA")]
        AllegroPixelFormatAnyNoAlpha = 0x1,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_ANY_WITH_ALPHA")]
        AllegroPixelFormatAnyWithAlpha = 0x2,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_ANY_15_NO_ALPHA")]
        AllegroPixelFormatAny15NoAlpha = 0x3,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_ANY_16_NO_ALPHA")]
        AllegroPixelFormatAny16NoAlpha = 0x4,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_ANY_16_WITH_ALPHA")]
        AllegroPixelFormatAny16WithAlpha = 0x5,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_ANY_24_NO_ALPHA")]
        AllegroPixelFormatAny24NoAlpha = 0x6,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_ANY_32_NO_ALPHA")]
        AllegroPixelFormatAny32NoAlpha = 0x7,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_ANY_32_WITH_ALPHA")]
        AllegroPixelFormatAny32WithAlpha = 0x8,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_ARGB_8888")]
        AllegroPixelFormatArgb8888 = 0x9,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_RGBA_8888")]
        AllegroPixelFormatRgba8888 = 0xA,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_ARGB_4444")]
        AllegroPixelFormatArgb4444 = 0xB,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_RGB_888")]
        AllegroPixelFormatRgb888 = 0xC,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_RGB_565")]
        AllegroPixelFormatRgb565 = 0xD,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_RGB_555")]
        AllegroPixelFormatRgb555 = 0xE,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_RGBA_5551")]
        AllegroPixelFormatRgba5551 = 0xF,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_ARGB_1555")]
        AllegroPixelFormatArgb1555 = 0x10,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_ABGR_8888")]
        AllegroPixelFormatAbgr8888 = 0x11,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_XBGR_8888")]
        AllegroPixelFormatXbgr8888 = 0x12,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_BGR_888")]
        AllegroPixelFormatBgr888 = 0x13,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_BGR_565")]
        AllegroPixelFormatBgr565 = 0x14,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_BGR_555")]
        AllegroPixelFormatBgr555 = 0x15,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_RGBX_8888")]
        AllegroPixelFormatRgbx8888 = 0x16,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_XRGB_8888")]
        AllegroPixelFormatXrgb8888 = 0x17,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_ABGR_F32")]
        AllegroPixelFormatAbgrF32 = 0x18,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_ABGR_8888_LE")]
        AllegroPixelFormatAbgr8888LE = 0x19,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_RGBA_4444")]
        AllegroPixelFormatRgba4444 = 0x1A,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_SINGLE_CHANNEL_8")]
        AllegroPixelFormatSingleChannel8 = 0x1B,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_COMPRESSED_RGBA_DXT1")]
        AllegroPixelFormatCompressedRgbaDxt1 = 0x1C,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_COMPRESSED_RGBA_DXT3")]
        AllegroPixelFormatCompressedRgbaDxt3 = 0x1D,
        [NativeName("Name", "ALLEGRO_PIXEL_FORMAT_COMPRESSED_RGBA_DXT5")]
        AllegroPixelFormatCompressedRgbaDxt5 = 0x1E,
        [NativeName("Name", "ALLEGRO_NUM_PIXEL_FORMATS")]
        AllegroNumPixelFormats = 0x1F,
    }
}
