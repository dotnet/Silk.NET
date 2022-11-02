// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUTextureFormat")]
    public enum TextureFormat : int
    {
        [Obsolete("Deprecated in favour of \"Undefined\"")]
        [NativeName("Name", "WGPUTextureFormat_Undefined")]
        TextureFormatUndefined = 0x0,
        [Obsolete("Deprecated in favour of \"R8Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_R8Unorm")]
        TextureFormatR8Unorm = 0x1,
        [Obsolete("Deprecated in favour of \"R8Snorm\"")]
        [NativeName("Name", "WGPUTextureFormat_R8Snorm")]
        TextureFormatR8Snorm = 0x2,
        [Obsolete("Deprecated in favour of \"R8Uint\"")]
        [NativeName("Name", "WGPUTextureFormat_R8Uint")]
        TextureFormatR8Uint = 0x3,
        [Obsolete("Deprecated in favour of \"R8Sint\"")]
        [NativeName("Name", "WGPUTextureFormat_R8Sint")]
        TextureFormatR8Sint = 0x4,
        [Obsolete("Deprecated in favour of \"R16Uint\"")]
        [NativeName("Name", "WGPUTextureFormat_R16Uint")]
        TextureFormatR16Uint = 0x5,
        [Obsolete("Deprecated in favour of \"R16Sint\"")]
        [NativeName("Name", "WGPUTextureFormat_R16Sint")]
        TextureFormatR16Sint = 0x6,
        [Obsolete("Deprecated in favour of \"R16float\"")]
        [NativeName("Name", "WGPUTextureFormat_R16Float")]
        TextureFormatR16float = 0x7,
        [Obsolete("Deprecated in favour of \"RG8Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_RG8Unorm")]
        TextureFormatRG8Unorm = 0x8,
        [Obsolete("Deprecated in favour of \"RG8Snorm\"")]
        [NativeName("Name", "WGPUTextureFormat_RG8Snorm")]
        TextureFormatRG8Snorm = 0x9,
        [Obsolete("Deprecated in favour of \"RG8Uint\"")]
        [NativeName("Name", "WGPUTextureFormat_RG8Uint")]
        TextureFormatRG8Uint = 0xA,
        [Obsolete("Deprecated in favour of \"RG8Sint\"")]
        [NativeName("Name", "WGPUTextureFormat_RG8Sint")]
        TextureFormatRG8Sint = 0xB,
        [Obsolete("Deprecated in favour of \"R32float\"")]
        [NativeName("Name", "WGPUTextureFormat_R32Float")]
        TextureFormatR32float = 0xC,
        [Obsolete("Deprecated in favour of \"R32Uint\"")]
        [NativeName("Name", "WGPUTextureFormat_R32Uint")]
        TextureFormatR32Uint = 0xD,
        [Obsolete("Deprecated in favour of \"R32Sint\"")]
        [NativeName("Name", "WGPUTextureFormat_R32Sint")]
        TextureFormatR32Sint = 0xE,
        [Obsolete("Deprecated in favour of \"RG16Uint\"")]
        [NativeName("Name", "WGPUTextureFormat_RG16Uint")]
        TextureFormatRG16Uint = 0xF,
        [Obsolete("Deprecated in favour of \"RG16Sint\"")]
        [NativeName("Name", "WGPUTextureFormat_RG16Sint")]
        TextureFormatRG16Sint = 0x10,
        [Obsolete("Deprecated in favour of \"RG16float\"")]
        [NativeName("Name", "WGPUTextureFormat_RG16Float")]
        TextureFormatRG16float = 0x11,
        [Obsolete("Deprecated in favour of \"Rgba8Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_RGBA8Unorm")]
        TextureFormatRgba8Unorm = 0x12,
        [Obsolete("Deprecated in favour of \"Rgba8UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_RGBA8UnormSrgb")]
        TextureFormatRgba8UnormSrgb = 0x13,
        [Obsolete("Deprecated in favour of \"Rgba8Snorm\"")]
        [NativeName("Name", "WGPUTextureFormat_RGBA8Snorm")]
        TextureFormatRgba8Snorm = 0x14,
        [Obsolete("Deprecated in favour of \"Rgba8Uint\"")]
        [NativeName("Name", "WGPUTextureFormat_RGBA8Uint")]
        TextureFormatRgba8Uint = 0x15,
        [Obsolete("Deprecated in favour of \"Rgba8Sint\"")]
        [NativeName("Name", "WGPUTextureFormat_RGBA8Sint")]
        TextureFormatRgba8Sint = 0x16,
        [Obsolete("Deprecated in favour of \"Bgra8Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_BGRA8Unorm")]
        TextureFormatBgra8Unorm = 0x17,
        [Obsolete("Deprecated in favour of \"Bgra8UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_BGRA8UnormSrgb")]
        TextureFormatBgra8UnormSrgb = 0x18,
        [Obsolete("Deprecated in favour of \"Rgb10A2Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_RGB10A2Unorm")]
        TextureFormatRgb10A2Unorm = 0x19,
        [Obsolete("Deprecated in favour of \"RG11B10Ufloat\"")]
        [NativeName("Name", "WGPUTextureFormat_RG11B10Ufloat")]
        TextureFormatRG11B10Ufloat = 0x1A,
        [Obsolete("Deprecated in favour of \"Rgb9E5Ufloat\"")]
        [NativeName("Name", "WGPUTextureFormat_RGB9E5Ufloat")]
        TextureFormatRgb9E5Ufloat = 0x1B,
        [Obsolete("Deprecated in favour of \"RG32float\"")]
        [NativeName("Name", "WGPUTextureFormat_RG32Float")]
        TextureFormatRG32float = 0x1C,
        [Obsolete("Deprecated in favour of \"RG32Uint\"")]
        [NativeName("Name", "WGPUTextureFormat_RG32Uint")]
        TextureFormatRG32Uint = 0x1D,
        [Obsolete("Deprecated in favour of \"RG32Sint\"")]
        [NativeName("Name", "WGPUTextureFormat_RG32Sint")]
        TextureFormatRG32Sint = 0x1E,
        [Obsolete("Deprecated in favour of \"Rgba16Uint\"")]
        [NativeName("Name", "WGPUTextureFormat_RGBA16Uint")]
        TextureFormatRgba16Uint = 0x1F,
        [Obsolete("Deprecated in favour of \"Rgba16Sint\"")]
        [NativeName("Name", "WGPUTextureFormat_RGBA16Sint")]
        TextureFormatRgba16Sint = 0x20,
        [Obsolete("Deprecated in favour of \"Rgba16float\"")]
        [NativeName("Name", "WGPUTextureFormat_RGBA16Float")]
        TextureFormatRgba16float = 0x21,
        [Obsolete("Deprecated in favour of \"Rgba32float\"")]
        [NativeName("Name", "WGPUTextureFormat_RGBA32Float")]
        TextureFormatRgba32float = 0x22,
        [Obsolete("Deprecated in favour of \"Rgba32Uint\"")]
        [NativeName("Name", "WGPUTextureFormat_RGBA32Uint")]
        TextureFormatRgba32Uint = 0x23,
        [Obsolete("Deprecated in favour of \"Rgba32Sint\"")]
        [NativeName("Name", "WGPUTextureFormat_RGBA32Sint")]
        TextureFormatRgba32Sint = 0x24,
        [Obsolete("Deprecated in favour of \"Stencil8\"")]
        [NativeName("Name", "WGPUTextureFormat_Stencil8")]
        TextureFormatStencil8 = 0x25,
        [Obsolete("Deprecated in favour of \"Depth16Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_Depth16Unorm")]
        TextureFormatDepth16Unorm = 0x26,
        [Obsolete("Deprecated in favour of \"Depth24Plus\"")]
        [NativeName("Name", "WGPUTextureFormat_Depth24Plus")]
        TextureFormatDepth24Plus = 0x27,
        [Obsolete("Deprecated in favour of \"Depth24PlusStencil8\"")]
        [NativeName("Name", "WGPUTextureFormat_Depth24PlusStencil8")]
        TextureFormatDepth24PlusStencil8 = 0x28,
        [Obsolete("Deprecated in favour of \"Depth32float\"")]
        [NativeName("Name", "WGPUTextureFormat_Depth32Float")]
        TextureFormatDepth32float = 0x29,
        [Obsolete("Deprecated in favour of \"Depth32floatStencil8\"")]
        [NativeName("Name", "WGPUTextureFormat_Depth32FloatStencil8")]
        TextureFormatDepth32floatStencil8 = 0x2A,
        [Obsolete("Deprecated in favour of \"BC1Rgbaunorm\"")]
        [NativeName("Name", "WGPUTextureFormat_BC1RGBAUnorm")]
        TextureFormatBC1Rgbaunorm = 0x2B,
        [Obsolete("Deprecated in favour of \"BC1RgbaunormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_BC1RGBAUnormSrgb")]
        TextureFormatBC1RgbaunormSrgb = 0x2C,
        [Obsolete("Deprecated in favour of \"BC2Rgbaunorm\"")]
        [NativeName("Name", "WGPUTextureFormat_BC2RGBAUnorm")]
        TextureFormatBC2Rgbaunorm = 0x2D,
        [Obsolete("Deprecated in favour of \"BC2RgbaunormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_BC2RGBAUnormSrgb")]
        TextureFormatBC2RgbaunormSrgb = 0x2E,
        [Obsolete("Deprecated in favour of \"BC3Rgbaunorm\"")]
        [NativeName("Name", "WGPUTextureFormat_BC3RGBAUnorm")]
        TextureFormatBC3Rgbaunorm = 0x2F,
        [Obsolete("Deprecated in favour of \"BC3RgbaunormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_BC3RGBAUnormSrgb")]
        TextureFormatBC3RgbaunormSrgb = 0x30,
        [Obsolete("Deprecated in favour of \"BC4RUnorm\"")]
        [NativeName("Name", "WGPUTextureFormat_BC4RUnorm")]
        TextureFormatBC4RUnorm = 0x31,
        [Obsolete("Deprecated in favour of \"BC4RSnorm\"")]
        [NativeName("Name", "WGPUTextureFormat_BC4RSnorm")]
        TextureFormatBC4RSnorm = 0x32,
        [Obsolete("Deprecated in favour of \"BC5Rgunorm\"")]
        [NativeName("Name", "WGPUTextureFormat_BC5RGUnorm")]
        TextureFormatBC5Rgunorm = 0x33,
        [Obsolete("Deprecated in favour of \"BC5Rgsnorm\"")]
        [NativeName("Name", "WGPUTextureFormat_BC5RGSnorm")]
        TextureFormatBC5Rgsnorm = 0x34,
        [Obsolete("Deprecated in favour of \"BC6Hrgbufloat\"")]
        [NativeName("Name", "WGPUTextureFormat_BC6HRGBUfloat")]
        TextureFormatBC6Hrgbufloat = 0x35,
        [Obsolete("Deprecated in favour of \"BC6Hrgbfloat\"")]
        [NativeName("Name", "WGPUTextureFormat_BC6HRGBFloat")]
        TextureFormatBC6Hrgbfloat = 0x36,
        [Obsolete("Deprecated in favour of \"BC7Rgbaunorm\"")]
        [NativeName("Name", "WGPUTextureFormat_BC7RGBAUnorm")]
        TextureFormatBC7Rgbaunorm = 0x37,
        [Obsolete("Deprecated in favour of \"BC7RgbaunormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_BC7RGBAUnormSrgb")]
        TextureFormatBC7RgbaunormSrgb = 0x38,
        [Obsolete("Deprecated in favour of \"Etc2Rgb8Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_ETC2RGB8Unorm")]
        TextureFormatEtc2Rgb8Unorm = 0x39,
        [Obsolete("Deprecated in favour of \"Etc2Rgb8UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_ETC2RGB8UnormSrgb")]
        TextureFormatEtc2Rgb8UnormSrgb = 0x3A,
        [Obsolete("Deprecated in favour of \"Etc2Rgb8A1Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_ETC2RGB8A1Unorm")]
        TextureFormatEtc2Rgb8A1Unorm = 0x3B,
        [Obsolete("Deprecated in favour of \"Etc2Rgb8A1UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_ETC2RGB8A1UnormSrgb")]
        TextureFormatEtc2Rgb8A1UnormSrgb = 0x3C,
        [Obsolete("Deprecated in favour of \"Etc2Rgba8Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_ETC2RGBA8Unorm")]
        TextureFormatEtc2Rgba8Unorm = 0x3D,
        [Obsolete("Deprecated in favour of \"Etc2Rgba8UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_ETC2RGBA8UnormSrgb")]
        TextureFormatEtc2Rgba8UnormSrgb = 0x3E,
        [Obsolete("Deprecated in favour of \"Eacr11Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_EACR11Unorm")]
        TextureFormatEacr11Unorm = 0x3F,
        [Obsolete("Deprecated in favour of \"Eacr11Snorm\"")]
        [NativeName("Name", "WGPUTextureFormat_EACR11Snorm")]
        TextureFormatEacr11Snorm = 0x40,
        [Obsolete("Deprecated in favour of \"Eacrg11Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_EACRG11Unorm")]
        TextureFormatEacrg11Unorm = 0x41,
        [Obsolete("Deprecated in favour of \"Eacrg11Snorm\"")]
        [NativeName("Name", "WGPUTextureFormat_EACRG11Snorm")]
        TextureFormatEacrg11Snorm = 0x42,
        [Obsolete("Deprecated in favour of \"Astc4x4Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC4x4Unorm")]
        TextureFormatAstc4x4Unorm = 0x43,
        [Obsolete("Deprecated in favour of \"Astc4x4UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC4x4UnormSrgb")]
        TextureFormatAstc4x4UnormSrgb = 0x44,
        [Obsolete("Deprecated in favour of \"Astc5x4Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC5x4Unorm")]
        TextureFormatAstc5x4Unorm = 0x45,
        [Obsolete("Deprecated in favour of \"Astc5x4UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC5x4UnormSrgb")]
        TextureFormatAstc5x4UnormSrgb = 0x46,
        [Obsolete("Deprecated in favour of \"Astc5x5Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC5x5Unorm")]
        TextureFormatAstc5x5Unorm = 0x47,
        [Obsolete("Deprecated in favour of \"Astc5x5UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC5x5UnormSrgb")]
        TextureFormatAstc5x5UnormSrgb = 0x48,
        [Obsolete("Deprecated in favour of \"Astc6x5Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC6x5Unorm")]
        TextureFormatAstc6x5Unorm = 0x49,
        [Obsolete("Deprecated in favour of \"Astc6x5UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC6x5UnormSrgb")]
        TextureFormatAstc6x5UnormSrgb = 0x4A,
        [Obsolete("Deprecated in favour of \"Astc6x6Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC6x6Unorm")]
        TextureFormatAstc6x6Unorm = 0x4B,
        [Obsolete("Deprecated in favour of \"Astc6x6UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC6x6UnormSrgb")]
        TextureFormatAstc6x6UnormSrgb = 0x4C,
        [Obsolete("Deprecated in favour of \"Astc8x5Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC8x5Unorm")]
        TextureFormatAstc8x5Unorm = 0x4D,
        [Obsolete("Deprecated in favour of \"Astc8x5UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC8x5UnormSrgb")]
        TextureFormatAstc8x5UnormSrgb = 0x4E,
        [Obsolete("Deprecated in favour of \"Astc8x6Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC8x6Unorm")]
        TextureFormatAstc8x6Unorm = 0x4F,
        [Obsolete("Deprecated in favour of \"Astc8x6UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC8x6UnormSrgb")]
        TextureFormatAstc8x6UnormSrgb = 0x50,
        [Obsolete("Deprecated in favour of \"Astc8x8Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC8x8Unorm")]
        TextureFormatAstc8x8Unorm = 0x51,
        [Obsolete("Deprecated in favour of \"Astc8x8UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC8x8UnormSrgb")]
        TextureFormatAstc8x8UnormSrgb = 0x52,
        [Obsolete("Deprecated in favour of \"Astc10x5Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC10x5Unorm")]
        TextureFormatAstc10x5Unorm = 0x53,
        [Obsolete("Deprecated in favour of \"Astc10x5UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC10x5UnormSrgb")]
        TextureFormatAstc10x5UnormSrgb = 0x54,
        [Obsolete("Deprecated in favour of \"Astc10x6Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC10x6Unorm")]
        TextureFormatAstc10x6Unorm = 0x55,
        [Obsolete("Deprecated in favour of \"Astc10x6UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC10x6UnormSrgb")]
        TextureFormatAstc10x6UnormSrgb = 0x56,
        [Obsolete("Deprecated in favour of \"Astc10x8Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC10x8Unorm")]
        TextureFormatAstc10x8Unorm = 0x57,
        [Obsolete("Deprecated in favour of \"Astc10x8UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC10x8UnormSrgb")]
        TextureFormatAstc10x8UnormSrgb = 0x58,
        [Obsolete("Deprecated in favour of \"Astc10x10Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC10x10Unorm")]
        TextureFormatAstc10x10Unorm = 0x59,
        [Obsolete("Deprecated in favour of \"Astc10x10UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC10x10UnormSrgb")]
        TextureFormatAstc10x10UnormSrgb = 0x5A,
        [Obsolete("Deprecated in favour of \"Astc12x10Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC12x10Unorm")]
        TextureFormatAstc12x10Unorm = 0x5B,
        [Obsolete("Deprecated in favour of \"Astc12x10UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC12x10UnormSrgb")]
        TextureFormatAstc12x10UnormSrgb = 0x5C,
        [Obsolete("Deprecated in favour of \"Astc12x12Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC12x12Unorm")]
        TextureFormatAstc12x12Unorm = 0x5D,
        [Obsolete("Deprecated in favour of \"Astc12x12UnormSrgb\"")]
        [NativeName("Name", "WGPUTextureFormat_ASTC12x12UnormSrgb")]
        TextureFormatAstc12x12UnormSrgb = 0x5E,
        [Obsolete("Deprecated in favour of \"R8BG8Biplanar420Unorm\"")]
        [NativeName("Name", "WGPUTextureFormat_R8BG8Biplanar420Unorm")]
        TextureFormatR8BG8Biplanar420Unorm = 0x5F,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUTextureFormat_Force32")]
        TextureFormatForce32 = 0x7FFFFFFF,
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
        [NativeName("Name", "WGPUTextureFormat_RGB10A2Unorm")]
        Rgb10A2Unorm = 0x19,
        [NativeName("Name", "WGPUTextureFormat_RG11B10Ufloat")]
        RG11B10Ufloat = 0x1A,
        [NativeName("Name", "WGPUTextureFormat_RGB9E5Ufloat")]
        Rgb9E5Ufloat = 0x1B,
        [NativeName("Name", "WGPUTextureFormat_RG32Float")]
        RG32float = 0x1C,
        [NativeName("Name", "WGPUTextureFormat_RG32Uint")]
        RG32Uint = 0x1D,
        [NativeName("Name", "WGPUTextureFormat_RG32Sint")]
        RG32Sint = 0x1E,
        [NativeName("Name", "WGPUTextureFormat_RGBA16Uint")]
        Rgba16Uint = 0x1F,
        [NativeName("Name", "WGPUTextureFormat_RGBA16Sint")]
        Rgba16Sint = 0x20,
        [NativeName("Name", "WGPUTextureFormat_RGBA16Float")]
        Rgba16float = 0x21,
        [NativeName("Name", "WGPUTextureFormat_RGBA32Float")]
        Rgba32float = 0x22,
        [NativeName("Name", "WGPUTextureFormat_RGBA32Uint")]
        Rgba32Uint = 0x23,
        [NativeName("Name", "WGPUTextureFormat_RGBA32Sint")]
        Rgba32Sint = 0x24,
        [NativeName("Name", "WGPUTextureFormat_Stencil8")]
        Stencil8 = 0x25,
        [NativeName("Name", "WGPUTextureFormat_Depth16Unorm")]
        Depth16Unorm = 0x26,
        [NativeName("Name", "WGPUTextureFormat_Depth24Plus")]
        Depth24Plus = 0x27,
        [NativeName("Name", "WGPUTextureFormat_Depth24PlusStencil8")]
        Depth24PlusStencil8 = 0x28,
        [NativeName("Name", "WGPUTextureFormat_Depth32Float")]
        Depth32float = 0x29,
        [NativeName("Name", "WGPUTextureFormat_Depth32FloatStencil8")]
        Depth32floatStencil8 = 0x2A,
        [NativeName("Name", "WGPUTextureFormat_BC1RGBAUnorm")]
        BC1Rgbaunorm = 0x2B,
        [NativeName("Name", "WGPUTextureFormat_BC1RGBAUnormSrgb")]
        BC1RgbaunormSrgb = 0x2C,
        [NativeName("Name", "WGPUTextureFormat_BC2RGBAUnorm")]
        BC2Rgbaunorm = 0x2D,
        [NativeName("Name", "WGPUTextureFormat_BC2RGBAUnormSrgb")]
        BC2RgbaunormSrgb = 0x2E,
        [NativeName("Name", "WGPUTextureFormat_BC3RGBAUnorm")]
        BC3Rgbaunorm = 0x2F,
        [NativeName("Name", "WGPUTextureFormat_BC3RGBAUnormSrgb")]
        BC3RgbaunormSrgb = 0x30,
        [NativeName("Name", "WGPUTextureFormat_BC4RUnorm")]
        BC4RUnorm = 0x31,
        [NativeName("Name", "WGPUTextureFormat_BC4RSnorm")]
        BC4RSnorm = 0x32,
        [NativeName("Name", "WGPUTextureFormat_BC5RGUnorm")]
        BC5Rgunorm = 0x33,
        [NativeName("Name", "WGPUTextureFormat_BC5RGSnorm")]
        BC5Rgsnorm = 0x34,
        [NativeName("Name", "WGPUTextureFormat_BC6HRGBUfloat")]
        BC6Hrgbufloat = 0x35,
        [NativeName("Name", "WGPUTextureFormat_BC6HRGBFloat")]
        BC6Hrgbfloat = 0x36,
        [NativeName("Name", "WGPUTextureFormat_BC7RGBAUnorm")]
        BC7Rgbaunorm = 0x37,
        [NativeName("Name", "WGPUTextureFormat_BC7RGBAUnormSrgb")]
        BC7RgbaunormSrgb = 0x38,
        [NativeName("Name", "WGPUTextureFormat_ETC2RGB8Unorm")]
        Etc2Rgb8Unorm = 0x39,
        [NativeName("Name", "WGPUTextureFormat_ETC2RGB8UnormSrgb")]
        Etc2Rgb8UnormSrgb = 0x3A,
        [NativeName("Name", "WGPUTextureFormat_ETC2RGB8A1Unorm")]
        Etc2Rgb8A1Unorm = 0x3B,
        [NativeName("Name", "WGPUTextureFormat_ETC2RGB8A1UnormSrgb")]
        Etc2Rgb8A1UnormSrgb = 0x3C,
        [NativeName("Name", "WGPUTextureFormat_ETC2RGBA8Unorm")]
        Etc2Rgba8Unorm = 0x3D,
        [NativeName("Name", "WGPUTextureFormat_ETC2RGBA8UnormSrgb")]
        Etc2Rgba8UnormSrgb = 0x3E,
        [NativeName("Name", "WGPUTextureFormat_EACR11Unorm")]
        Eacr11Unorm = 0x3F,
        [NativeName("Name", "WGPUTextureFormat_EACR11Snorm")]
        Eacr11Snorm = 0x40,
        [NativeName("Name", "WGPUTextureFormat_EACRG11Unorm")]
        Eacrg11Unorm = 0x41,
        [NativeName("Name", "WGPUTextureFormat_EACRG11Snorm")]
        Eacrg11Snorm = 0x42,
        [NativeName("Name", "WGPUTextureFormat_ASTC4x4Unorm")]
        Astc4x4Unorm = 0x43,
        [NativeName("Name", "WGPUTextureFormat_ASTC4x4UnormSrgb")]
        Astc4x4UnormSrgb = 0x44,
        [NativeName("Name", "WGPUTextureFormat_ASTC5x4Unorm")]
        Astc5x4Unorm = 0x45,
        [NativeName("Name", "WGPUTextureFormat_ASTC5x4UnormSrgb")]
        Astc5x4UnormSrgb = 0x46,
        [NativeName("Name", "WGPUTextureFormat_ASTC5x5Unorm")]
        Astc5x5Unorm = 0x47,
        [NativeName("Name", "WGPUTextureFormat_ASTC5x5UnormSrgb")]
        Astc5x5UnormSrgb = 0x48,
        [NativeName("Name", "WGPUTextureFormat_ASTC6x5Unorm")]
        Astc6x5Unorm = 0x49,
        [NativeName("Name", "WGPUTextureFormat_ASTC6x5UnormSrgb")]
        Astc6x5UnormSrgb = 0x4A,
        [NativeName("Name", "WGPUTextureFormat_ASTC6x6Unorm")]
        Astc6x6Unorm = 0x4B,
        [NativeName("Name", "WGPUTextureFormat_ASTC6x6UnormSrgb")]
        Astc6x6UnormSrgb = 0x4C,
        [NativeName("Name", "WGPUTextureFormat_ASTC8x5Unorm")]
        Astc8x5Unorm = 0x4D,
        [NativeName("Name", "WGPUTextureFormat_ASTC8x5UnormSrgb")]
        Astc8x5UnormSrgb = 0x4E,
        [NativeName("Name", "WGPUTextureFormat_ASTC8x6Unorm")]
        Astc8x6Unorm = 0x4F,
        [NativeName("Name", "WGPUTextureFormat_ASTC8x6UnormSrgb")]
        Astc8x6UnormSrgb = 0x50,
        [NativeName("Name", "WGPUTextureFormat_ASTC8x8Unorm")]
        Astc8x8Unorm = 0x51,
        [NativeName("Name", "WGPUTextureFormat_ASTC8x8UnormSrgb")]
        Astc8x8UnormSrgb = 0x52,
        [NativeName("Name", "WGPUTextureFormat_ASTC10x5Unorm")]
        Astc10x5Unorm = 0x53,
        [NativeName("Name", "WGPUTextureFormat_ASTC10x5UnormSrgb")]
        Astc10x5UnormSrgb = 0x54,
        [NativeName("Name", "WGPUTextureFormat_ASTC10x6Unorm")]
        Astc10x6Unorm = 0x55,
        [NativeName("Name", "WGPUTextureFormat_ASTC10x6UnormSrgb")]
        Astc10x6UnormSrgb = 0x56,
        [NativeName("Name", "WGPUTextureFormat_ASTC10x8Unorm")]
        Astc10x8Unorm = 0x57,
        [NativeName("Name", "WGPUTextureFormat_ASTC10x8UnormSrgb")]
        Astc10x8UnormSrgb = 0x58,
        [NativeName("Name", "WGPUTextureFormat_ASTC10x10Unorm")]
        Astc10x10Unorm = 0x59,
        [NativeName("Name", "WGPUTextureFormat_ASTC10x10UnormSrgb")]
        Astc10x10UnormSrgb = 0x5A,
        [NativeName("Name", "WGPUTextureFormat_ASTC12x10Unorm")]
        Astc12x10Unorm = 0x5B,
        [NativeName("Name", "WGPUTextureFormat_ASTC12x10UnormSrgb")]
        Astc12x10UnormSrgb = 0x5C,
        [NativeName("Name", "WGPUTextureFormat_ASTC12x12Unorm")]
        Astc12x12Unorm = 0x5D,
        [NativeName("Name", "WGPUTextureFormat_ASTC12x12UnormSrgb")]
        Astc12x12UnormSrgb = 0x5E,
        [NativeName("Name", "WGPUTextureFormat_R8BG8Biplanar420Unorm")]
        R8BG8Biplanar420Unorm = 0x5F,
        [NativeName("Name", "WGPUTextureFormat_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
