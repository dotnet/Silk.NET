// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_FORMAT")]
    public enum Format : int
    {
        [NativeName("Name", "DXGI_FORMAT_UNKNOWN")]
        FormatUnknown = 0x0,
        [NativeName("Name", "DXGI_FORMAT_R32G32B32A32_TYPELESS")]
        FormatR32G32B32A32Typeless = 0x1,
        [NativeName("Name", "DXGI_FORMAT_R32G32B32A32_FLOAT")]
        FormatR32G32B32A32Float = 0x2,
        [NativeName("Name", "DXGI_FORMAT_R32G32B32A32_UINT")]
        FormatR32G32B32A32Uint = 0x3,
        [NativeName("Name", "DXGI_FORMAT_R32G32B32A32_SINT")]
        FormatR32G32B32A32Sint = 0x4,
        [NativeName("Name", "DXGI_FORMAT_R32G32B32_TYPELESS")]
        FormatR32G32B32Typeless = 0x5,
        [NativeName("Name", "DXGI_FORMAT_R32G32B32_FLOAT")]
        FormatR32G32B32Float = 0x6,
        [NativeName("Name", "DXGI_FORMAT_R32G32B32_UINT")]
        FormatR32G32B32Uint = 0x7,
        [NativeName("Name", "DXGI_FORMAT_R32G32B32_SINT")]
        FormatR32G32B32Sint = 0x8,
        [NativeName("Name", "DXGI_FORMAT_R16G16B16A16_TYPELESS")]
        FormatR16G16B16A16Typeless = 0x9,
        [NativeName("Name", "DXGI_FORMAT_R16G16B16A16_FLOAT")]
        FormatR16G16B16A16Float = 0xA,
        [NativeName("Name", "DXGI_FORMAT_R16G16B16A16_UNORM")]
        FormatR16G16B16A16Unorm = 0xB,
        [NativeName("Name", "DXGI_FORMAT_R16G16B16A16_UINT")]
        FormatR16G16B16A16Uint = 0xC,
        [NativeName("Name", "DXGI_FORMAT_R16G16B16A16_SNORM")]
        FormatR16G16B16A16SNorm = 0xD,
        [NativeName("Name", "DXGI_FORMAT_R16G16B16A16_SINT")]
        FormatR16G16B16A16Sint = 0xE,
        [NativeName("Name", "DXGI_FORMAT_R32G32_TYPELESS")]
        FormatR32G32Typeless = 0xF,
        [NativeName("Name", "DXGI_FORMAT_R32G32_FLOAT")]
        FormatR32G32Float = 0x10,
        [NativeName("Name", "DXGI_FORMAT_R32G32_UINT")]
        FormatR32G32Uint = 0x11,
        [NativeName("Name", "DXGI_FORMAT_R32G32_SINT")]
        FormatR32G32Sint = 0x12,
        [NativeName("Name", "DXGI_FORMAT_R32G8X24_TYPELESS")]
        FormatR32G8X24Typeless = 0x13,
        [NativeName("Name", "DXGI_FORMAT_D32_FLOAT_S8X24_UINT")]
        FormatD32FloatS8X24Uint = 0x14,
        [NativeName("Name", "DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS")]
        FormatR32FloatX8X24Typeless = 0x15,
        [NativeName("Name", "DXGI_FORMAT_X32_TYPELESS_G8X24_UINT")]
        FormatX32TypelessG8X24Uint = 0x16,
        [NativeName("Name", "DXGI_FORMAT_R10G10B10A2_TYPELESS")]
        FormatR10G10B10A2Typeless = 0x17,
        [NativeName("Name", "DXGI_FORMAT_R10G10B10A2_UNORM")]
        FormatR10G10B10A2Unorm = 0x18,
        [NativeName("Name", "DXGI_FORMAT_R10G10B10A2_UINT")]
        FormatR10G10B10A2Uint = 0x19,
        [NativeName("Name", "DXGI_FORMAT_R11G11B10_FLOAT")]
        FormatR11G11B10Float = 0x1A,
        [NativeName("Name", "DXGI_FORMAT_R8G8B8A8_TYPELESS")]
        FormatR8G8B8A8Typeless = 0x1B,
        [NativeName("Name", "DXGI_FORMAT_R8G8B8A8_UNORM")]
        FormatR8G8B8A8Unorm = 0x1C,
        [NativeName("Name", "DXGI_FORMAT_R8G8B8A8_UNORM_SRGB")]
        FormatR8G8B8A8UnormSrgb = 0x1D,
        [NativeName("Name", "DXGI_FORMAT_R8G8B8A8_UINT")]
        FormatR8G8B8A8Uint = 0x1E,
        [NativeName("Name", "DXGI_FORMAT_R8G8B8A8_SNORM")]
        FormatR8G8B8A8SNorm = 0x1F,
        [NativeName("Name", "DXGI_FORMAT_R8G8B8A8_SINT")]
        FormatR8G8B8A8Sint = 0x20,
        [NativeName("Name", "DXGI_FORMAT_R16G16_TYPELESS")]
        FormatR16G16Typeless = 0x21,
        [NativeName("Name", "DXGI_FORMAT_R16G16_FLOAT")]
        FormatR16G16Float = 0x22,
        [NativeName("Name", "DXGI_FORMAT_R16G16_UNORM")]
        FormatR16G16Unorm = 0x23,
        [NativeName("Name", "DXGI_FORMAT_R16G16_UINT")]
        FormatR16G16Uint = 0x24,
        [NativeName("Name", "DXGI_FORMAT_R16G16_SNORM")]
        FormatR16G16SNorm = 0x25,
        [NativeName("Name", "DXGI_FORMAT_R16G16_SINT")]
        FormatR16G16Sint = 0x26,
        [NativeName("Name", "DXGI_FORMAT_R32_TYPELESS")]
        FormatR32Typeless = 0x27,
        [NativeName("Name", "DXGI_FORMAT_D32_FLOAT")]
        FormatD32Float = 0x28,
        [NativeName("Name", "DXGI_FORMAT_R32_FLOAT")]
        FormatR32Float = 0x29,
        [NativeName("Name", "DXGI_FORMAT_R32_UINT")]
        FormatR32Uint = 0x2A,
        [NativeName("Name", "DXGI_FORMAT_R32_SINT")]
        FormatR32Sint = 0x2B,
        [NativeName("Name", "DXGI_FORMAT_R24G8_TYPELESS")]
        FormatR24G8Typeless = 0x2C,
        [NativeName("Name", "DXGI_FORMAT_D24_UNORM_S8_UINT")]
        FormatD24UnormS8Uint = 0x2D,
        [NativeName("Name", "DXGI_FORMAT_R24_UNORM_X8_TYPELESS")]
        FormatR24UnormX8Typeless = 0x2E,
        [NativeName("Name", "DXGI_FORMAT_X24_TYPELESS_G8_UINT")]
        FormatX24TypelessG8Uint = 0x2F,
        [NativeName("Name", "DXGI_FORMAT_R8G8_TYPELESS")]
        FormatR8G8Typeless = 0x30,
        [NativeName("Name", "DXGI_FORMAT_R8G8_UNORM")]
        FormatR8G8Unorm = 0x31,
        [NativeName("Name", "DXGI_FORMAT_R8G8_UINT")]
        FormatR8G8Uint = 0x32,
        [NativeName("Name", "DXGI_FORMAT_R8G8_SNORM")]
        FormatR8G8SNorm = 0x33,
        [NativeName("Name", "DXGI_FORMAT_R8G8_SINT")]
        FormatR8G8Sint = 0x34,
        [NativeName("Name", "DXGI_FORMAT_R16_TYPELESS")]
        FormatR16Typeless = 0x35,
        [NativeName("Name", "DXGI_FORMAT_R16_FLOAT")]
        FormatR16Float = 0x36,
        [NativeName("Name", "DXGI_FORMAT_D16_UNORM")]
        FormatD16Unorm = 0x37,
        [NativeName("Name", "DXGI_FORMAT_R16_UNORM")]
        FormatR16Unorm = 0x38,
        [NativeName("Name", "DXGI_FORMAT_R16_UINT")]
        FormatR16Uint = 0x39,
        [NativeName("Name", "DXGI_FORMAT_R16_SNORM")]
        FormatR16SNorm = 0x3A,
        [NativeName("Name", "DXGI_FORMAT_R16_SINT")]
        FormatR16Sint = 0x3B,
        [NativeName("Name", "DXGI_FORMAT_R8_TYPELESS")]
        FormatR8Typeless = 0x3C,
        [NativeName("Name", "DXGI_FORMAT_R8_UNORM")]
        FormatR8Unorm = 0x3D,
        [NativeName("Name", "DXGI_FORMAT_R8_UINT")]
        FormatR8Uint = 0x3E,
        [NativeName("Name", "DXGI_FORMAT_R8_SNORM")]
        FormatR8SNorm = 0x3F,
        [NativeName("Name", "DXGI_FORMAT_R8_SINT")]
        FormatR8Sint = 0x40,
        [NativeName("Name", "DXGI_FORMAT_A8_UNORM")]
        FormatA8Unorm = 0x41,
        [NativeName("Name", "DXGI_FORMAT_R1_UNORM")]
        FormatR1Unorm = 0x42,
        [NativeName("Name", "DXGI_FORMAT_R9G9B9E5_SHAREDEXP")]
        FormatR9G9B9E5Sharedexp = 0x43,
        [NativeName("Name", "DXGI_FORMAT_R8G8_B8G8_UNORM")]
        FormatR8G8B8G8Unorm = 0x44,
        [NativeName("Name", "DXGI_FORMAT_G8R8_G8B8_UNORM")]
        FormatG8R8G8B8Unorm = 0x45,
        [NativeName("Name", "DXGI_FORMAT_BC1_TYPELESS")]
        FormatBC1Typeless = 0x46,
        [NativeName("Name", "DXGI_FORMAT_BC1_UNORM")]
        FormatBC1Unorm = 0x47,
        [NativeName("Name", "DXGI_FORMAT_BC1_UNORM_SRGB")]
        FormatBC1UnormSrgb = 0x48,
        [NativeName("Name", "DXGI_FORMAT_BC2_TYPELESS")]
        FormatBC2Typeless = 0x49,
        [NativeName("Name", "DXGI_FORMAT_BC2_UNORM")]
        FormatBC2Unorm = 0x4A,
        [NativeName("Name", "DXGI_FORMAT_BC2_UNORM_SRGB")]
        FormatBC2UnormSrgb = 0x4B,
        [NativeName("Name", "DXGI_FORMAT_BC3_TYPELESS")]
        FormatBC3Typeless = 0x4C,
        [NativeName("Name", "DXGI_FORMAT_BC3_UNORM")]
        FormatBC3Unorm = 0x4D,
        [NativeName("Name", "DXGI_FORMAT_BC3_UNORM_SRGB")]
        FormatBC3UnormSrgb = 0x4E,
        [NativeName("Name", "DXGI_FORMAT_BC4_TYPELESS")]
        FormatBC4Typeless = 0x4F,
        [NativeName("Name", "DXGI_FORMAT_BC4_UNORM")]
        FormatBC4Unorm = 0x50,
        [NativeName("Name", "DXGI_FORMAT_BC4_SNORM")]
        FormatBC4SNorm = 0x51,
        [NativeName("Name", "DXGI_FORMAT_BC5_TYPELESS")]
        FormatBC5Typeless = 0x52,
        [NativeName("Name", "DXGI_FORMAT_BC5_UNORM")]
        FormatBC5Unorm = 0x53,
        [NativeName("Name", "DXGI_FORMAT_BC5_SNORM")]
        FormatBC5SNorm = 0x54,
        [NativeName("Name", "DXGI_FORMAT_B5G6R5_UNORM")]
        FormatB5G6R5Unorm = 0x55,
        [NativeName("Name", "DXGI_FORMAT_B5G5R5A1_UNORM")]
        FormatB5G5R5A1Unorm = 0x56,
        [NativeName("Name", "DXGI_FORMAT_B8G8R8A8_UNORM")]
        FormatB8G8R8A8Unorm = 0x57,
        [NativeName("Name", "DXGI_FORMAT_B8G8R8X8_UNORM")]
        FormatB8G8R8X8Unorm = 0x58,
        [NativeName("Name", "DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM")]
        FormatR10G10B10XRBiasA2Unorm = 0x59,
        [NativeName("Name", "DXGI_FORMAT_B8G8R8A8_TYPELESS")]
        FormatB8G8R8A8Typeless = 0x5A,
        [NativeName("Name", "DXGI_FORMAT_B8G8R8A8_UNORM_SRGB")]
        FormatB8G8R8A8UnormSrgb = 0x5B,
        [NativeName("Name", "DXGI_FORMAT_B8G8R8X8_TYPELESS")]
        FormatB8G8R8X8Typeless = 0x5C,
        [NativeName("Name", "DXGI_FORMAT_B8G8R8X8_UNORM_SRGB")]
        FormatB8G8R8X8UnormSrgb = 0x5D,
        [NativeName("Name", "DXGI_FORMAT_BC6H_TYPELESS")]
        FormatBC6HTypeless = 0x5E,
        [NativeName("Name", "DXGI_FORMAT_BC6H_UF16")]
        FormatBC6HUF16 = 0x5F,
        [NativeName("Name", "DXGI_FORMAT_BC6H_SF16")]
        FormatBC6HSF16 = 0x60,
        [NativeName("Name", "DXGI_FORMAT_BC7_TYPELESS")]
        FormatBC7Typeless = 0x61,
        [NativeName("Name", "DXGI_FORMAT_BC7_UNORM")]
        FormatBC7Unorm = 0x62,
        [NativeName("Name", "DXGI_FORMAT_BC7_UNORM_SRGB")]
        FormatBC7UnormSrgb = 0x63,
        [NativeName("Name", "DXGI_FORMAT_AYUV")]
        FormatAyuv = 0x64,
        [NativeName("Name", "DXGI_FORMAT_Y410")]
        FormatY410 = 0x65,
        [NativeName("Name", "DXGI_FORMAT_Y416")]
        FormatY416 = 0x66,
        [NativeName("Name", "DXGI_FORMAT_NV12")]
        FormatNV12 = 0x67,
        [NativeName("Name", "DXGI_FORMAT_P010")]
        FormatP010 = 0x68,
        [NativeName("Name", "DXGI_FORMAT_P016")]
        FormatP016 = 0x69,
        [NativeName("Name", "DXGI_FORMAT_420_OPAQUE")]
        Format420Opaque = 0x6A,
        [NativeName("Name", "DXGI_FORMAT_YUY2")]
        FormatYuy2 = 0x6B,
        [NativeName("Name", "DXGI_FORMAT_Y210")]
        FormatY210 = 0x6C,
        [NativeName("Name", "DXGI_FORMAT_Y216")]
        FormatY216 = 0x6D,
        [NativeName("Name", "DXGI_FORMAT_NV11")]
        FormatNV11 = 0x6E,
        [NativeName("Name", "DXGI_FORMAT_AI44")]
        FormatAI44 = 0x6F,
        [NativeName("Name", "DXGI_FORMAT_IA44")]
        FormatIA44 = 0x70,
        [NativeName("Name", "DXGI_FORMAT_P8")]
        FormatP8 = 0x71,
        [NativeName("Name", "DXGI_FORMAT_A8P8")]
        FormatA8P8 = 0x72,
        [NativeName("Name", "DXGI_FORMAT_B4G4R4A4_UNORM")]
        FormatB4G4R4A4Unorm = 0x73,
        [NativeName("Name", "DXGI_FORMAT_P208")]
        FormatP208 = 0x82,
        [NativeName("Name", "DXGI_FORMAT_V208")]
        FormatV208 = 0x83,
        [NativeName("Name", "DXGI_FORMAT_V408")]
        FormatV408 = 0x84,
        [NativeName("Name", "DXGI_FORMAT_SAMPLER_FEEDBACK_MIN_MIP_OPAQUE")]
        FormatSamplerFeedbackMinMipOpaque = 0xBD,
        [NativeName("Name", "DXGI_FORMAT_SAMPLER_FEEDBACK_MIP_REGION_USED_OPAQUE")]
        FormatSamplerFeedbackMipRegionUsedOpaque = 0xBE,
        [NativeName("Name", "DXGI_FORMAT_A4B4G4R4_UNORM")]
        FormatA4B4G4R4Unorm = 0xBF,
        [NativeName("Name", "DXGI_FORMAT_FORCE_UINT")]
        FormatForceUint = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
