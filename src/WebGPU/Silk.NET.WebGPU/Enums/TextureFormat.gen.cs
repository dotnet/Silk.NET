// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUTextureFormat")]
    public enum TextureFormat : int
    {
        [NativeName("Name", "WGPUTextureFormat_BC1RGBAUnorm")]
        BC1RgbaUnorm = 0x2C,
        [NativeName("Name", "WGPUTextureFormat_BC1RGBAUnormSrgb")]
        BC1RgbaUnormSrgb = 0x2D,
        [NativeName("Name", "WGPUTextureFormat_BC2RGBAUnorm")]
        BC2RgbaUnorm = 0x2E,
        [NativeName("Name", "WGPUTextureFormat_BC2RGBAUnormSrgb")]
        BC2RgbaUnormSrgb = 0x2F,
        [NativeName("Name", "WGPUTextureFormat_BC3RGBAUnorm")]
        BC3RgbaUnorm = 0x30,
        [NativeName("Name", "WGPUTextureFormat_BC3RGBAUnormSrgb")]
        BC3RgbaUnormSrgb = 0x31,
        [NativeName("Name", "WGPUTextureFormat_BC5RGUnorm")]
        BC5RGUnorm = 0x34,
        [NativeName("Name", "WGPUTextureFormat_BC5RGSnorm")]
        BC5RGSnorm = 0x35,
        [NativeName("Name", "WGPUTextureFormat_BC6HRGBUfloat")]
        BC6HrgbUfloat = 0x36,
        [NativeName("Name", "WGPUTextureFormat_BC6HRGBFloat")]
        BC6HrgbFloat = 0x37,
        [NativeName("Name", "WGPUTextureFormat_BC7RGBAUnorm")]
        BC7RgbaUnorm = 0x38,
        [NativeName("Name", "WGPUTextureFormat_BC7RGBAUnormSrgb")]
        BC7RgbaUnormSrgb = 0x39,
        [NativeName("Name", "WGPUTextureFormat_Undefined")]
        Undefined = 0x0,
        [NativeName("Name", "WGPUTextureFormat_R8Unorm")]
        R8Unorm = 0x1,
        [NativeName("Name", "WGPUTextureFormat_R8Snorm")]
        R8Snorm = 0x2,
        [NativeName("Name", "WGPUTextureFormat_R8Uint")]
        R8Uint = 0x3,
        [NativeName("Name", "WGPUTextureFormat_R8Sint")]
        R8Sint = 0x4,
        [NativeName("Name", "WGPUTextureFormat_R16Uint")]
        R16Uint = 0x5,
        [NativeName("Name", "WGPUTextureFormat_R16Sint")]
        R16Sint = 0x6,
        [NativeName("Name", "WGPUTextureFormat_R16Float")]
        R16float = 0x7,
        [NativeName("Name", "WGPUTextureFormat_RG8Unorm")]
        RG8Unorm = 0x8,
        [NativeName("Name", "WGPUTextureFormat_RG8Snorm")]
        RG8Snorm = 0x9,
        [NativeName("Name", "WGPUTextureFormat_RG8Uint")]
        RG8Uint = 0xA,
        [NativeName("Name", "WGPUTextureFormat_RG8Sint")]
        RG8Sint = 0xB,
        [NativeName("Name", "WGPUTextureFormat_R32Float")]
        R32float = 0xC,
        [NativeName("Name", "WGPUTextureFormat_R32Uint")]
        R32Uint = 0xD,
        [NativeName("Name", "WGPUTextureFormat_R32Sint")]
        R32Sint = 0xE,
        [NativeName("Name", "WGPUTextureFormat_RG16Uint")]
        RG16Uint = 0xF,
        [NativeName("Name", "WGPUTextureFormat_RG16Sint")]
        RG16Sint = 0x10,
        [NativeName("Name", "WGPUTextureFormat_RG16Float")]
        RG16float = 0x11,
        [NativeName("Name", "WGPUTextureFormat_RGBA8Unorm")]
        Rgba8Unorm = 0x12,
        [NativeName("Name", "WGPUTextureFormat_RGBA8UnormSrgb")]
        Rgba8UnormSrgb = 0x13,
        [NativeName("Name", "WGPUTextureFormat_RGBA8Snorm")]
        Rgba8Snorm = 0x14,
        [NativeName("Name", "WGPUTextureFormat_RGBA8Uint")]
        Rgba8Uint = 0x15,
        [NativeName("Name", "WGPUTextureFormat_RGBA8Sint")]
        Rgba8Sint = 0x16,
        [NativeName("Name", "WGPUTextureFormat_BGRA8Unorm")]
        Bgra8Unorm = 0x17,
        [NativeName("Name", "WGPUTextureFormat_BGRA8UnormSrgb")]
        Bgra8UnormSrgb = 0x18,
        [NativeName("Name", "WGPUTextureFormat_RGB10A2Uint")]
        Rgb10A2Uint = 0x19,
        [NativeName("Name", "WGPUTextureFormat_RGB10A2Unorm")]
        Rgb10A2Unorm = 0x1A,
        [NativeName("Name", "WGPUTextureFormat_RG11B10Ufloat")]
        RG11B10Ufloat = 0x1B,
        [NativeName("Name", "WGPUTextureFormat_RGB9E5Ufloat")]
        Rgb9E5Ufloat = 0x1C,
        [NativeName("Name", "WGPUTextureFormat_RG32Float")]
        RG32float = 0x1D,
        [NativeName("Name", "WGPUTextureFormat_RG32Uint")]
        RG32Uint = 0x1E,
        [NativeName("Name", "WGPUTextureFormat_RG32Sint")]
        RG32Sint = 0x1F,
        [NativeName("Name", "WGPUTextureFormat_RGBA16Uint")]
        Rgba16Uint = 0x20,
        [NativeName("Name", "WGPUTextureFormat_RGBA16Sint")]
        Rgba16Sint = 0x21,
        [NativeName("Name", "WGPUTextureFormat_RGBA16Float")]
        Rgba16float = 0x22,
        [NativeName("Name", "WGPUTextureFormat_RGBA32Float")]
        Rgba32float = 0x23,
        [NativeName("Name", "WGPUTextureFormat_RGBA32Uint")]
        Rgba32Uint = 0x24,
        [NativeName("Name", "WGPUTextureFormat_RGBA32Sint")]
        Rgba32Sint = 0x25,
        [NativeName("Name", "WGPUTextureFormat_Stencil8")]
        Stencil8 = 0x26,
        [NativeName("Name", "WGPUTextureFormat_Depth16Unorm")]
        Depth16Unorm = 0x27,
        [NativeName("Name", "WGPUTextureFormat_Depth24Plus")]
        Depth24Plus = 0x28,
        [NativeName("Name", "WGPUTextureFormat_Depth24PlusStencil8")]
        Depth24PlusStencil8 = 0x29,
        [NativeName("Name", "WGPUTextureFormat_Depth32Float")]
        Depth32float = 0x2A,
        [NativeName("Name", "WGPUTextureFormat_Depth32FloatStencil8")]
        Depth32floatStencil8 = 0x2B,
        [Obsolete("Deprecated in favour of \"BC1RgbaUnorm\"")]
        [NativeName("Name", "WGPUTextureFormat_BC1RGBAUnorm")]
        BC1Rgbaunorm = 0x2C,
        [Obsolete("Deprecated in favour of \"BC1RgbaUnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_BC1RGBAUnormSrgb")]
        BC1RgbaunormSrgb = 0x2D,
        [Obsolete("Deprecated in favour of \"BC2RgbaUnorm\"")]
        [NativeName("Name", "WGPUTextureFormat_BC2RGBAUnorm")]
        BC2Rgbaunorm = 0x2E,
        [Obsolete("Deprecated in favour of \"BC2RgbaUnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_BC2RGBAUnormSrgb")]
        BC2RgbaunormSrgb = 0x2F,
        [Obsolete("Deprecated in favour of \"BC3RgbaUnorm\"")]
        [NativeName("Name", "WGPUTextureFormat_BC3RGBAUnorm")]
        BC3Rgbaunorm = 0x30,
        [Obsolete("Deprecated in favour of \"BC3RgbaUnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_BC3RGBAUnormSrgb")]
        BC3RgbaunormSrgb = 0x31,
        [NativeName("Name", "WGPUTextureFormat_BC4RUnorm")]
        BC4RUnorm = 0x32,
        [NativeName("Name", "WGPUTextureFormat_BC4RSnorm")]
        BC4RSnorm = 0x33,
        [Obsolete("Deprecated in favour of \"BC5RGUnorm\"")]
        [NativeName("Name", "WGPUTextureFormat_BC5RGUnorm")]
        BC5Rgunorm = 0x34,
        [Obsolete("Deprecated in favour of \"BC5RGSnorm\"")]
        [NativeName("Name", "WGPUTextureFormat_BC5RGSnorm")]
        BC5Rgsnorm = 0x35,
        [Obsolete("Deprecated in favour of \"BC6HrgbUfloat\"")]
        [NativeName("Name", "WGPUTextureFormat_BC6HRGBUfloat")]
        BC6Hrgbufloat = 0x36,
        [Obsolete("Deprecated in favour of \"BC6HrgbFloat\"")]
        [NativeName("Name", "WGPUTextureFormat_BC6HRGBFloat")]
        BC6Hrgbfloat = 0x37,
        [Obsolete("Deprecated in favour of \"BC7RgbaUnorm\"")]
        [NativeName("Name", "WGPUTextureFormat_BC7RGBAUnorm")]
        BC7Rgbaunorm = 0x38,
        [Obsolete("Deprecated in favour of \"BC7RgbaUnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_BC7RGBAUnormSrgb")]
        BC7RgbaunormSrgb = 0x39,
        [NativeName("Name", "WGPUTextureFormat_ETC2RGB8Unorm")]
        Etc2Rgb8Unorm = 0x3A,
        [NativeName("Name", "WGPUTextureFormat_ETC2RGB8UnormSrgb")]
        Etc2Rgb8UnormSrgb = 0x3B,
        [NativeName("Name", "WGPUTextureFormat_ETC2RGB8A1Unorm")]
        Etc2Rgb8A1Unorm = 0x3C,
        [NativeName("Name", "WGPUTextureFormat_ETC2RGB8A1UnormSrgb")]
        Etc2Rgb8A1UnormSrgb = 0x3D,
        [NativeName("Name", "WGPUTextureFormat_ETC2RGBA8Unorm")]
        Etc2Rgba8Unorm = 0x3E,
        [NativeName("Name", "WGPUTextureFormat_ETC2RGBA8UnormSrgb")]
        Etc2Rgba8UnormSrgb = 0x3F,
        [NativeName("Name", "WGPUTextureFormat_EACR11Unorm")]
        Eacr11Unorm = 0x40,
        [NativeName("Name", "WGPUTextureFormat_EACR11Snorm")]
        Eacr11Snorm = 0x41,
        [NativeName("Name", "WGPUTextureFormat_EACRG11Unorm")]
        Eacrg11Unorm = 0x42,
        [NativeName("Name", "WGPUTextureFormat_EACRG11Snorm")]
        Eacrg11Snorm = 0x43,
        [NativeName("Name", "WGPUTextureFormat_ASTC4x4Unorm")]
        Astc4x4Unorm = 0x44,
        [NativeName("Name", "WGPUTextureFormat_ASTC4x4UnormSrgb")]
        Astc4x4UnormSrgb = 0x45,
        [NativeName("Name", "WGPUTextureFormat_ASTC5x4Unorm")]
        Astc5x4Unorm = 0x46,
        [NativeName("Name", "WGPUTextureFormat_ASTC5x4UnormSrgb")]
        Astc5x4UnormSrgb = 0x47,
        [NativeName("Name", "WGPUTextureFormat_ASTC5x5Unorm")]
        Astc5x5Unorm = 0x48,
        [NativeName("Name", "WGPUTextureFormat_ASTC5x5UnormSrgb")]
        Astc5x5UnormSrgb = 0x49,
        [NativeName("Name", "WGPUTextureFormat_ASTC6x5Unorm")]
        Astc6x5Unorm = 0x4A,
        [NativeName("Name", "WGPUTextureFormat_ASTC6x5UnormSrgb")]
        Astc6x5UnormSrgb = 0x4B,
        [NativeName("Name", "WGPUTextureFormat_ASTC6x6Unorm")]
        Astc6x6Unorm = 0x4C,
        [NativeName("Name", "WGPUTextureFormat_ASTC6x6UnormSrgb")]
        Astc6x6UnormSrgb = 0x4D,
        [NativeName("Name", "WGPUTextureFormat_ASTC8x5Unorm")]
        Astc8x5Unorm = 0x4E,
        [NativeName("Name", "WGPUTextureFormat_ASTC8x5UnormSrgb")]
        Astc8x5UnormSrgb = 0x4F,
        [NativeName("Name", "WGPUTextureFormat_ASTC8x6Unorm")]
        Astc8x6Unorm = 0x50,
        [NativeName("Name", "WGPUTextureFormat_ASTC8x6UnormSrgb")]
        Astc8x6UnormSrgb = 0x51,
        [NativeName("Name", "WGPUTextureFormat_ASTC8x8Unorm")]
        Astc8x8Unorm = 0x52,
        [NativeName("Name", "WGPUTextureFormat_ASTC8x8UnormSrgb")]
        Astc8x8UnormSrgb = 0x53,
        [NativeName("Name", "WGPUTextureFormat_ASTC10x5Unorm")]
        Astc10x5Unorm = 0x54,
        [NativeName("Name", "WGPUTextureFormat_ASTC10x5UnormSrgb")]
        Astc10x5UnormSrgb = 0x55,
        [NativeName("Name", "WGPUTextureFormat_ASTC10x6Unorm")]
        Astc10x6Unorm = 0x56,
        [NativeName("Name", "WGPUTextureFormat_ASTC10x6UnormSrgb")]
        Astc10x6UnormSrgb = 0x57,
        [NativeName("Name", "WGPUTextureFormat_ASTC10x8Unorm")]
        Astc10x8Unorm = 0x58,
        [NativeName("Name", "WGPUTextureFormat_ASTC10x8UnormSrgb")]
        Astc10x8UnormSrgb = 0x59,
        [NativeName("Name", "WGPUTextureFormat_ASTC10x10Unorm")]
        Astc10x10Unorm = 0x5A,
        [NativeName("Name", "WGPUTextureFormat_ASTC10x10UnormSrgb")]
        Astc10x10UnormSrgb = 0x5B,
        [NativeName("Name", "WGPUTextureFormat_ASTC12x10Unorm")]
        Astc12x10Unorm = 0x5C,
        [NativeName("Name", "WGPUTextureFormat_ASTC12x10UnormSrgb")]
        Astc12x10UnormSrgb = 0x5D,
        [NativeName("Name", "WGPUTextureFormat_ASTC12x12Unorm")]
        Astc12x12Unorm = 0x5E,
        [NativeName("Name", "WGPUTextureFormat_ASTC12x12UnormSrgb")]
        Astc12x12UnormSrgb = 0x5F,
        [NativeName("Name", "WGPUTextureFormat_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
