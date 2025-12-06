// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUTextureFormat")]
public enum GPUTextureFormat : uint
{
    [NativeName("SDL_GPU_TEXTUREFORMAT_INVALID")]
    Invalid = 0,

    [NativeName("SDL_GPU_TEXTUREFORMAT_A8_UNORM")]
    A8Unorm = 1,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8_UNORM")]
    R8Unorm = 2,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8_UNORM")]
    R8G8Unorm = 3,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8B8A8_UNORM")]
    R8G8B8A8Unorm = 4,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16_UNORM")]
    R16Unorm = 5,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16_UNORM")]
    R16G16Unorm = 6,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16B16A16_UNORM")]
    R16G16B16A16Unorm = 7,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R10G10B10A2_UNORM")]
    R10G10B10A2Unorm = 8,

    [NativeName("SDL_GPU_TEXTUREFORMAT_B5G6R5_UNORM")]
    B5G6R5Unorm = 9,

    [NativeName("SDL_GPU_TEXTUREFORMAT_B5G5R5A1_UNORM")]
    B5G5R5A1Unorm = 10,

    [NativeName("SDL_GPU_TEXTUREFORMAT_B4G4R4A4_UNORM")]
    B4G4R4A4Unorm = 11,

    [NativeName("SDL_GPU_TEXTUREFORMAT_B8G8R8A8_UNORM")]
    B8G8R8A8Unorm = 12,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC1_RGBA_UNORM")]
    Bc1RgbaUnorm = 13,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC2_RGBA_UNORM")]
    Bc2RgbaUnorm = 14,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC3_RGBA_UNORM")]
    Bc3RgbaUnorm = 15,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC4_R_UNORM")]
    Bc4RUnorm = 16,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC5_RG_UNORM")]
    Bc5RgUnorm = 17,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC7_RGBA_UNORM")]
    Bc7RgbaUnorm = 18,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC6H_RGB_FLOAT")]
    Bc6HRgbFloat = 19,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC6H_RGB_UFLOAT")]
    Bc6HRgbUfloat = 20,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8_SNORM")]
    R8Snorm = 21,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8_SNORM")]
    R8G8Snorm = 22,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8B8A8_SNORM")]
    R8G8B8A8Snorm = 23,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16_SNORM")]
    R16Snorm = 24,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16_SNORM")]
    R16G16Snorm = 25,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16B16A16_SNORM")]
    R16G16B16A16Snorm = 26,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16_FLOAT")]
    R16Float = 27,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16_FLOAT")]
    R16G16Float = 28,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16B16A16_FLOAT")]
    R16G16B16A16Float = 29,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32_FLOAT")]
    R32Float = 30,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32G32_FLOAT")]
    R32G32Float = 31,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32G32B32A32_FLOAT")]
    R32G32B32A32Float = 32,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R11G11B10_UFLOAT")]
    R11G11B10Ufloat = 33,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8_UINT")]
    R8Uint = 34,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8_UINT")]
    R8G8Uint = 35,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8B8A8_UINT")]
    R8G8B8A8Uint = 36,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16_UINT")]
    R16Uint = 37,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16_UINT")]
    R16G16Uint = 38,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16B16A16_UINT")]
    R16G16B16A16Uint = 39,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32_UINT")]
    R32Uint = 40,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32G32_UINT")]
    R32G32Uint = 41,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32G32B32A32_UINT")]
    R32G32B32A32Uint = 42,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8_INT")]
    R8Int = 43,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8_INT")]
    R8G8Int = 44,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8B8A8_INT")]
    R8G8B8A8Int = 45,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16_INT")]
    R16Int = 46,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16_INT")]
    R16G16Int = 47,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16B16A16_INT")]
    R16G16B16A16Int = 48,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32_INT")]
    R32Int = 49,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32G32_INT")]
    R32G32Int = 50,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32G32B32A32_INT")]
    R32G32B32A32Int = 51,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8B8A8_UNORM_SRGB")]
    R8G8B8A8UnormSrgb = 52,

    [NativeName("SDL_GPU_TEXTUREFORMAT_B8G8R8A8_UNORM_SRGB")]
    B8G8R8A8UnormSrgb = 53,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC1_RGBA_UNORM_SRGB")]
    Bc1RgbaUnormSrgb = 54,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC2_RGBA_UNORM_SRGB")]
    Bc2RgbaUnormSrgb = 55,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC3_RGBA_UNORM_SRGB")]
    Bc3RgbaUnormSrgb = 56,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC7_RGBA_UNORM_SRGB")]
    Bc7RgbaUnormSrgb = 57,

    [NativeName("SDL_GPU_TEXTUREFORMAT_D16_UNORM")]
    D16Unorm = 58,

    [NativeName("SDL_GPU_TEXTUREFORMAT_D24_UNORM")]
    D24Unorm = 59,

    [NativeName("SDL_GPU_TEXTUREFORMAT_D32_FLOAT")]
    D32Float = 60,

    [NativeName("SDL_GPU_TEXTUREFORMAT_D24_UNORM_S8_UINT")]
    D24UnormS8Uint = 61,

    [NativeName("SDL_GPU_TEXTUREFORMAT_D32_FLOAT_S8_UINT")]
    D32FloatS8Uint = 62,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_4x4_UNORM")]
    Astc4X4Unorm = 63,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_5x4_UNORM")]
    Astc5X4Unorm = 64,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_5x5_UNORM")]
    Astc5X5Unorm = 65,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_6x5_UNORM")]
    Astc6X5Unorm = 66,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_6x6_UNORM")]
    Astc6X6Unorm = 67,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x5_UNORM")]
    Astc8X5Unorm = 68,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x6_UNORM")]
    Astc8X6Unorm = 69,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x8_UNORM")]
    Astc8X8Unorm = 70,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x5_UNORM")]
    Astc10X5Unorm = 71,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x6_UNORM")]
    Astc10X6Unorm = 72,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x8_UNORM")]
    Astc10X8Unorm = 73,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x10_UNORM")]
    Astc10X10Unorm = 74,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_12x10_UNORM")]
    Astc12X10Unorm = 75,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_12x12_UNORM")]
    Astc12X12Unorm = 76,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_4x4_UNORM_SRGB")]
    Astc4X4UnormSrgb = 77,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_5x4_UNORM_SRGB")]
    Astc5X4UnormSrgb = 78,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_5x5_UNORM_SRGB")]
    Astc5X5UnormSrgb = 79,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_6x5_UNORM_SRGB")]
    Astc6X5UnormSrgb = 80,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_6x6_UNORM_SRGB")]
    Astc6X6UnormSrgb = 81,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x5_UNORM_SRGB")]
    Astc8X5UnormSrgb = 82,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x6_UNORM_SRGB")]
    Astc8X6UnormSrgb = 83,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x8_UNORM_SRGB")]
    Astc8X8UnormSrgb = 84,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x5_UNORM_SRGB")]
    Astc10X5UnormSrgb = 85,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x6_UNORM_SRGB")]
    Astc10X6UnormSrgb = 86,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x8_UNORM_SRGB")]
    Astc10X8UnormSrgb = 87,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x10_UNORM_SRGB")]
    Astc10X10UnormSrgb = 88,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_12x10_UNORM_SRGB")]
    Astc12X10UnormSrgb = 89,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_12x12_UNORM_SRGB")]
    Astc12X12UnormSrgb = 90,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_4x4_FLOAT")]
    Astc4X4Float = 91,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_5x4_FLOAT")]
    Astc5X4Float = 92,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_5x5_FLOAT")]
    Astc5X5Float = 93,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_6x5_FLOAT")]
    Astc6X5Float = 94,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_6x6_FLOAT")]
    Astc6X6Float = 95,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x5_FLOAT")]
    Astc8X5Float = 96,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x6_FLOAT")]
    Astc8X6Float = 97,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x8_FLOAT")]
    Astc8X8Float = 98,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x5_FLOAT")]
    Astc10X5Float = 99,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x6_FLOAT")]
    Astc10X6Float = 100,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x8_FLOAT")]
    Astc10X8Float = 101,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x10_FLOAT")]
    Astc10X10Float = 102,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_12x10_FLOAT")]
    Astc12X10Float = 103,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_12x12_FLOAT")]
    Astc12X12Float = 104,
}
