// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUTextureFormat")]
public enum GpuTextureFormat : uint
{
    [NativeName("SDL_GPU_TEXTUREFORMAT_INVALID")]
    Invalid,

    [NativeName("SDL_GPU_TEXTUREFORMAT_A8_UNORM")]
    A8Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8_UNORM")]
    R8Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8_UNORM")]
    R8G8Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8B8A8_UNORM")]
    R8G8B8A8Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16_UNORM")]
    R16Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16_UNORM")]
    R16G16Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16B16A16_UNORM")]
    R16G16B16A16Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R10G10B10A2_UNORM")]
    R10G10B10A2Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_B5G6R5_UNORM")]
    B5G6R5Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_B5G5R5A1_UNORM")]
    B5G5R5A1Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_B4G4R4A4_UNORM")]
    B4G4R4A4Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_B8G8R8A8_UNORM")]
    B8G8R8A8Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC1_RGBA_UNORM")]
    Bc1RgbaUnorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC2_RGBA_UNORM")]
    Bc2RgbaUnorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC3_RGBA_UNORM")]
    Bc3RgbaUnorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC4_R_UNORM")]
    Bc4RUnorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC5_RG_UNORM")]
    Bc5RgUnorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC7_RGBA_UNORM")]
    Bc7RgbaUnorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC6H_RGB_FLOAT")]
    Bc6HRgbFloat,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC6H_RGB_UFLOAT")]
    Bc6HRgbUfloat,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8_SNORM")]
    R8Snorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8_SNORM")]
    R8G8Snorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8B8A8_SNORM")]
    R8G8B8A8Snorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16_SNORM")]
    R16Snorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16_SNORM")]
    R16G16Snorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16B16A16_SNORM")]
    R16G16B16A16Snorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16_FLOAT")]
    R16Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16_FLOAT")]
    R16G16Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16B16A16_FLOAT")]
    R16G16B16A16Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32_FLOAT")]
    R32Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32G32_FLOAT")]
    R32G32Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32G32B32A32_FLOAT")]
    R32G32B32A32Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R11G11B10_UFLOAT")]
    R11G11B10Ufloat,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8_UINT")]
    R8Uint,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8_UINT")]
    R8G8Uint,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8B8A8_UINT")]
    R8G8B8A8Uint,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16_UINT")]
    R16Uint,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16_UINT")]
    R16G16Uint,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16B16A16_UINT")]
    R16G16B16A16Uint,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32_UINT")]
    R32Uint,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32G32_UINT")]
    R32G32Uint,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32G32B32A32_UINT")]
    R32G32B32A32Uint,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8_INT")]
    R8Int,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8_INT")]
    R8G8Int,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8B8A8_INT")]
    R8G8B8A8Int,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16_INT")]
    R16Int,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16_INT")]
    R16G16Int,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R16G16B16A16_INT")]
    R16G16B16A16Int,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32_INT")]
    R32Int,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32G32_INT")]
    R32G32Int,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R32G32B32A32_INT")]
    R32G32B32A32Int,

    [NativeName("SDL_GPU_TEXTUREFORMAT_R8G8B8A8_UNORM_SRGB")]
    R8G8B8A8UnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_B8G8R8A8_UNORM_SRGB")]
    B8G8R8A8UnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC1_RGBA_UNORM_SRGB")]
    Bc1RgbaUnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC2_RGBA_UNORM_SRGB")]
    Bc2RgbaUnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC3_RGBA_UNORM_SRGB")]
    Bc3RgbaUnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_BC7_RGBA_UNORM_SRGB")]
    Bc7RgbaUnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_D16_UNORM")]
    D16Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_D24_UNORM")]
    D24Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_D32_FLOAT")]
    D32Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_D24_UNORM_S8_UINT")]
    D24UnormS8Uint,

    [NativeName("SDL_GPU_TEXTUREFORMAT_D32_FLOAT_S8_UINT")]
    D32FloatS8Uint,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_4x4_UNORM")]
    Astc4X4Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_5x4_UNORM")]
    Astc5X4Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_5x5_UNORM")]
    Astc5X5Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_6x5_UNORM")]
    Astc6X5Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_6x6_UNORM")]
    Astc6X6Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x5_UNORM")]
    Astc8X5Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x6_UNORM")]
    Astc8X6Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x8_UNORM")]
    Astc8X8Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x5_UNORM")]
    Astc10X5Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x6_UNORM")]
    Astc10X6Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x8_UNORM")]
    Astc10X8Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x10_UNORM")]
    Astc10X10Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_12x10_UNORM")]
    Astc12X10Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_12x12_UNORM")]
    Astc12X12Unorm,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_4x4_UNORM_SRGB")]
    Astc4X4UnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_5x4_UNORM_SRGB")]
    Astc5X4UnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_5x5_UNORM_SRGB")]
    Astc5X5UnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_6x5_UNORM_SRGB")]
    Astc6X5UnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_6x6_UNORM_SRGB")]
    Astc6X6UnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x5_UNORM_SRGB")]
    Astc8X5UnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x6_UNORM_SRGB")]
    Astc8X6UnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x8_UNORM_SRGB")]
    Astc8X8UnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x5_UNORM_SRGB")]
    Astc10X5UnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x6_UNORM_SRGB")]
    Astc10X6UnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x8_UNORM_SRGB")]
    Astc10X8UnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x10_UNORM_SRGB")]
    Astc10X10UnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_12x10_UNORM_SRGB")]
    Astc12X10UnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_12x12_UNORM_SRGB")]
    Astc12X12UnormSrgb,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_4x4_FLOAT")]
    Astc4X4Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_5x4_FLOAT")]
    Astc5X4Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_5x5_FLOAT")]
    Astc5X5Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_6x5_FLOAT")]
    Astc6X5Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_6x6_FLOAT")]
    Astc6X6Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x5_FLOAT")]
    Astc8X5Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x6_FLOAT")]
    Astc8X6Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_8x8_FLOAT")]
    Astc8X8Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x5_FLOAT")]
    Astc10X5Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x6_FLOAT")]
    Astc10X6Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x8_FLOAT")]
    Astc10X8Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_10x10_FLOAT")]
    Astc10X10Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_12x10_FLOAT")]
    Astc12X10Float,

    [NativeName("SDL_GPU_TEXTUREFORMAT_ASTC_12x12_FLOAT")]
    Astc12X12Float,
}
