// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkFormat")]
    public enum Format : int
    {
        [NativeName("Name", "VK_FORMAT_UNDEFINED")]
        Undefined = 0,
        [NativeName("Name", "VK_FORMAT_R4G4_UNORM_PACK8")]
        R4G4UnormPack8 = 1,
        [NativeName("Name", "VK_FORMAT_R4G4B4A4_UNORM_PACK16")]
        R4G4B4A4UnormPack16 = 2,
        [NativeName("Name", "VK_FORMAT_B4G4R4A4_UNORM_PACK16")]
        B4G4R4A4UnormPack16 = 3,
        [NativeName("Name", "VK_FORMAT_R5G6B5_UNORM_PACK16")]
        R5G6B5UnormPack16 = 4,
        [NativeName("Name", "VK_FORMAT_B5G6R5_UNORM_PACK16")]
        B5G6R5UnormPack16 = 5,
        [NativeName("Name", "VK_FORMAT_R5G5B5A1_UNORM_PACK16")]
        R5G5B5A1UnormPack16 = 6,
        [NativeName("Name", "VK_FORMAT_B5G5R5A1_UNORM_PACK16")]
        B5G5R5A1UnormPack16 = 7,
        [NativeName("Name", "VK_FORMAT_A1R5G5B5_UNORM_PACK16")]
        A1R5G5B5UnormPack16 = 8,
        [NativeName("Name", "VK_FORMAT_R8_UNORM")]
        R8Unorm = 9,
        [NativeName("Name", "VK_FORMAT_R8_SNORM")]
        R8SNorm = 10,
        [NativeName("Name", "VK_FORMAT_R8_USCALED")]
        R8Uscaled = 11,
        [NativeName("Name", "VK_FORMAT_R8_SSCALED")]
        R8Sscaled = 12,
        [NativeName("Name", "VK_FORMAT_R8_UINT")]
        R8Uint = 13,
        [NativeName("Name", "VK_FORMAT_R8_SINT")]
        R8Sint = 14,
        [NativeName("Name", "VK_FORMAT_R8_SRGB")]
        R8Srgb = 15,
        [NativeName("Name", "VK_FORMAT_R8G8_UNORM")]
        R8G8Unorm = 16,
        [NativeName("Name", "VK_FORMAT_R8G8_SNORM")]
        R8G8SNorm = 17,
        [NativeName("Name", "VK_FORMAT_R8G8_USCALED")]
        R8G8Uscaled = 18,
        [NativeName("Name", "VK_FORMAT_R8G8_SSCALED")]
        R8G8Sscaled = 19,
        [NativeName("Name", "VK_FORMAT_R8G8_UINT")]
        R8G8Uint = 20,
        [NativeName("Name", "VK_FORMAT_R8G8_SINT")]
        R8G8Sint = 21,
        [NativeName("Name", "VK_FORMAT_R8G8_SRGB")]
        R8G8Srgb = 22,
        [NativeName("Name", "VK_FORMAT_R8G8B8_UNORM")]
        R8G8B8Unorm = 23,
        [NativeName("Name", "VK_FORMAT_R8G8B8_SNORM")]
        R8G8B8SNorm = 24,
        [NativeName("Name", "VK_FORMAT_R8G8B8_USCALED")]
        R8G8B8Uscaled = 25,
        [NativeName("Name", "VK_FORMAT_R8G8B8_SSCALED")]
        R8G8B8Sscaled = 26,
        [NativeName("Name", "VK_FORMAT_R8G8B8_UINT")]
        R8G8B8Uint = 27,
        [NativeName("Name", "VK_FORMAT_R8G8B8_SINT")]
        R8G8B8Sint = 28,
        [NativeName("Name", "VK_FORMAT_R8G8B8_SRGB")]
        R8G8B8Srgb = 29,
        [NativeName("Name", "VK_FORMAT_B8G8R8_UNORM")]
        B8G8R8Unorm = 30,
        [NativeName("Name", "VK_FORMAT_B8G8R8_SNORM")]
        B8G8R8SNorm = 31,
        [NativeName("Name", "VK_FORMAT_B8G8R8_USCALED")]
        B8G8R8Uscaled = 32,
        [NativeName("Name", "VK_FORMAT_B8G8R8_SSCALED")]
        B8G8R8Sscaled = 33,
        [NativeName("Name", "VK_FORMAT_B8G8R8_UINT")]
        B8G8R8Uint = 34,
        [NativeName("Name", "VK_FORMAT_B8G8R8_SINT")]
        B8G8R8Sint = 35,
        [NativeName("Name", "VK_FORMAT_B8G8R8_SRGB")]
        B8G8R8Srgb = 36,
        [NativeName("Name", "VK_FORMAT_R8G8B8A8_UNORM")]
        R8G8B8A8Unorm = 37,
        [NativeName("Name", "VK_FORMAT_R8G8B8A8_SNORM")]
        R8G8B8A8SNorm = 38,
        [NativeName("Name", "VK_FORMAT_R8G8B8A8_USCALED")]
        R8G8B8A8Uscaled = 39,
        [NativeName("Name", "VK_FORMAT_R8G8B8A8_SSCALED")]
        R8G8B8A8Sscaled = 40,
        [NativeName("Name", "VK_FORMAT_R8G8B8A8_UINT")]
        R8G8B8A8Uint = 41,
        [NativeName("Name", "VK_FORMAT_R8G8B8A8_SINT")]
        R8G8B8A8Sint = 42,
        [NativeName("Name", "VK_FORMAT_R8G8B8A8_SRGB")]
        R8G8B8A8Srgb = 43,
        [NativeName("Name", "VK_FORMAT_B8G8R8A8_UNORM")]
        B8G8R8A8Unorm = 44,
        [NativeName("Name", "VK_FORMAT_B8G8R8A8_SNORM")]
        B8G8R8A8SNorm = 45,
        [NativeName("Name", "VK_FORMAT_B8G8R8A8_USCALED")]
        B8G8R8A8Uscaled = 46,
        [NativeName("Name", "VK_FORMAT_B8G8R8A8_SSCALED")]
        B8G8R8A8Sscaled = 47,
        [NativeName("Name", "VK_FORMAT_B8G8R8A8_UINT")]
        B8G8R8A8Uint = 48,
        [NativeName("Name", "VK_FORMAT_B8G8R8A8_SINT")]
        B8G8R8A8Sint = 49,
        [NativeName("Name", "VK_FORMAT_B8G8R8A8_SRGB")]
        B8G8R8A8Srgb = 50,
        [NativeName("Name", "VK_FORMAT_A8B8G8R8_UNORM_PACK32")]
        A8B8G8R8UnormPack32 = 51,
        [NativeName("Name", "VK_FORMAT_A8B8G8R8_SNORM_PACK32")]
        A8B8G8R8SNormPack32 = 52,
        [NativeName("Name", "VK_FORMAT_A8B8G8R8_USCALED_PACK32")]
        A8B8G8R8UscaledPack32 = 53,
        [NativeName("Name", "VK_FORMAT_A8B8G8R8_SSCALED_PACK32")]
        A8B8G8R8SscaledPack32 = 54,
        [NativeName("Name", "VK_FORMAT_A8B8G8R8_UINT_PACK32")]
        A8B8G8R8UintPack32 = 55,
        [NativeName("Name", "VK_FORMAT_A8B8G8R8_SINT_PACK32")]
        A8B8G8R8SintPack32 = 56,
        [NativeName("Name", "VK_FORMAT_A8B8G8R8_SRGB_PACK32")]
        A8B8G8R8SrgbPack32 = 57,
        [NativeName("Name", "VK_FORMAT_A2R10G10B10_UNORM_PACK32")]
        A2R10G10B10UnormPack32 = 58,
        [NativeName("Name", "VK_FORMAT_A2R10G10B10_SNORM_PACK32")]
        A2R10G10B10SNormPack32 = 59,
        [NativeName("Name", "VK_FORMAT_A2R10G10B10_USCALED_PACK32")]
        A2R10G10B10UscaledPack32 = 60,
        [NativeName("Name", "VK_FORMAT_A2R10G10B10_SSCALED_PACK32")]
        A2R10G10B10SscaledPack32 = 61,
        [NativeName("Name", "VK_FORMAT_A2R10G10B10_UINT_PACK32")]
        A2R10G10B10UintPack32 = 62,
        [NativeName("Name", "VK_FORMAT_A2R10G10B10_SINT_PACK32")]
        A2R10G10B10SintPack32 = 63,
        [NativeName("Name", "VK_FORMAT_A2B10G10R10_UNORM_PACK32")]
        A2B10G10R10UnormPack32 = 64,
        [NativeName("Name", "VK_FORMAT_A2B10G10R10_SNORM_PACK32")]
        A2B10G10R10SNormPack32 = 65,
        [NativeName("Name", "VK_FORMAT_A2B10G10R10_USCALED_PACK32")]
        A2B10G10R10UscaledPack32 = 66,
        [NativeName("Name", "VK_FORMAT_A2B10G10R10_SSCALED_PACK32")]
        A2B10G10R10SscaledPack32 = 67,
        [NativeName("Name", "VK_FORMAT_A2B10G10R10_UINT_PACK32")]
        A2B10G10R10UintPack32 = 68,
        [NativeName("Name", "VK_FORMAT_A2B10G10R10_SINT_PACK32")]
        A2B10G10R10SintPack32 = 69,
        [NativeName("Name", "VK_FORMAT_R16_UNORM")]
        R16Unorm = 70,
        [NativeName("Name", "VK_FORMAT_R16_SNORM")]
        R16SNorm = 71,
        [NativeName("Name", "VK_FORMAT_R16_USCALED")]
        R16Uscaled = 72,
        [NativeName("Name", "VK_FORMAT_R16_SSCALED")]
        R16Sscaled = 73,
        [NativeName("Name", "VK_FORMAT_R16_UINT")]
        R16Uint = 74,
        [NativeName("Name", "VK_FORMAT_R16_SINT")]
        R16Sint = 75,
        [NativeName("Name", "VK_FORMAT_R16_SFLOAT")]
        R16Sfloat = 76,
        [NativeName("Name", "VK_FORMAT_R16G16_UNORM")]
        R16G16Unorm = 77,
        [NativeName("Name", "VK_FORMAT_R16G16_SNORM")]
        R16G16SNorm = 78,
        [NativeName("Name", "VK_FORMAT_R16G16_USCALED")]
        R16G16Uscaled = 79,
        [NativeName("Name", "VK_FORMAT_R16G16_SSCALED")]
        R16G16Sscaled = 80,
        [NativeName("Name", "VK_FORMAT_R16G16_UINT")]
        R16G16Uint = 81,
        [NativeName("Name", "VK_FORMAT_R16G16_SINT")]
        R16G16Sint = 82,
        [NativeName("Name", "VK_FORMAT_R16G16_SFLOAT")]
        R16G16Sfloat = 83,
        [NativeName("Name", "VK_FORMAT_R16G16B16_UNORM")]
        R16G16B16Unorm = 84,
        [NativeName("Name", "VK_FORMAT_R16G16B16_SNORM")]
        R16G16B16SNorm = 85,
        [NativeName("Name", "VK_FORMAT_R16G16B16_USCALED")]
        R16G16B16Uscaled = 86,
        [NativeName("Name", "VK_FORMAT_R16G16B16_SSCALED")]
        R16G16B16Sscaled = 87,
        [NativeName("Name", "VK_FORMAT_R16G16B16_UINT")]
        R16G16B16Uint = 88,
        [NativeName("Name", "VK_FORMAT_R16G16B16_SINT")]
        R16G16B16Sint = 89,
        [NativeName("Name", "VK_FORMAT_R16G16B16_SFLOAT")]
        R16G16B16Sfloat = 90,
        [NativeName("Name", "VK_FORMAT_R16G16B16A16_UNORM")]
        R16G16B16A16Unorm = 91,
        [NativeName("Name", "VK_FORMAT_R16G16B16A16_SNORM")]
        R16G16B16A16SNorm = 92,
        [NativeName("Name", "VK_FORMAT_R16G16B16A16_USCALED")]
        R16G16B16A16Uscaled = 93,
        [NativeName("Name", "VK_FORMAT_R16G16B16A16_SSCALED")]
        R16G16B16A16Sscaled = 94,
        [NativeName("Name", "VK_FORMAT_R16G16B16A16_UINT")]
        R16G16B16A16Uint = 95,
        [NativeName("Name", "VK_FORMAT_R16G16B16A16_SINT")]
        R16G16B16A16Sint = 96,
        [NativeName("Name", "VK_FORMAT_R16G16B16A16_SFLOAT")]
        R16G16B16A16Sfloat = 97,
        [NativeName("Name", "VK_FORMAT_R32_UINT")]
        R32Uint = 98,
        [NativeName("Name", "VK_FORMAT_R32_SINT")]
        R32Sint = 99,
        [NativeName("Name", "VK_FORMAT_R32_SFLOAT")]
        R32Sfloat = 100,
        [NativeName("Name", "VK_FORMAT_R32G32_UINT")]
        R32G32Uint = 101,
        [NativeName("Name", "VK_FORMAT_R32G32_SINT")]
        R32G32Sint = 102,
        [NativeName("Name", "VK_FORMAT_R32G32_SFLOAT")]
        R32G32Sfloat = 103,
        [NativeName("Name", "VK_FORMAT_R32G32B32_UINT")]
        R32G32B32Uint = 104,
        [NativeName("Name", "VK_FORMAT_R32G32B32_SINT")]
        R32G32B32Sint = 105,
        [NativeName("Name", "VK_FORMAT_R32G32B32_SFLOAT")]
        R32G32B32Sfloat = 106,
        [NativeName("Name", "VK_FORMAT_R32G32B32A32_UINT")]
        R32G32B32A32Uint = 107,
        [NativeName("Name", "VK_FORMAT_R32G32B32A32_SINT")]
        R32G32B32A32Sint = 108,
        [NativeName("Name", "VK_FORMAT_R32G32B32A32_SFLOAT")]
        R32G32B32A32Sfloat = 109,
        [NativeName("Name", "VK_FORMAT_R64_UINT")]
        R64Uint = 110,
        [NativeName("Name", "VK_FORMAT_R64_SINT")]
        R64Sint = 111,
        [NativeName("Name", "VK_FORMAT_R64_SFLOAT")]
        R64Sfloat = 112,
        [NativeName("Name", "VK_FORMAT_R64G64_UINT")]
        R64G64Uint = 113,
        [NativeName("Name", "VK_FORMAT_R64G64_SINT")]
        R64G64Sint = 114,
        [NativeName("Name", "VK_FORMAT_R64G64_SFLOAT")]
        R64G64Sfloat = 115,
        [NativeName("Name", "VK_FORMAT_R64G64B64_UINT")]
        R64G64B64Uint = 116,
        [NativeName("Name", "VK_FORMAT_R64G64B64_SINT")]
        R64G64B64Sint = 117,
        [NativeName("Name", "VK_FORMAT_R64G64B64_SFLOAT")]
        R64G64B64Sfloat = 118,
        [NativeName("Name", "VK_FORMAT_R64G64B64A64_UINT")]
        R64G64B64A64Uint = 119,
        [NativeName("Name", "VK_FORMAT_R64G64B64A64_SINT")]
        R64G64B64A64Sint = 120,
        [NativeName("Name", "VK_FORMAT_R64G64B64A64_SFLOAT")]
        R64G64B64A64Sfloat = 121,
        [NativeName("Name", "VK_FORMAT_B10G11R11_UFLOAT_PACK32")]
        B10G11R11UfloatPack32 = 122,
        [NativeName("Name", "VK_FORMAT_E5B9G9R9_UFLOAT_PACK32")]
        E5B9G9R9UfloatPack32 = 123,
        [NativeName("Name", "VK_FORMAT_D16_UNORM")]
        D16Unorm = 124,
        [NativeName("Name", "VK_FORMAT_X8_D24_UNORM_PACK32")]
        X8D24UnormPack32 = 125,
        [NativeName("Name", "VK_FORMAT_D32_SFLOAT")]
        D32Sfloat = 126,
        [NativeName("Name", "VK_FORMAT_S8_UINT")]
        S8Uint = 127,
        [NativeName("Name", "VK_FORMAT_D16_UNORM_S8_UINT")]
        D16UnormS8Uint = 128,
        [NativeName("Name", "VK_FORMAT_D24_UNORM_S8_UINT")]
        D24UnormS8Uint = 129,
        [NativeName("Name", "VK_FORMAT_D32_SFLOAT_S8_UINT")]
        D32SfloatS8Uint = 130,
        [NativeName("Name", "VK_FORMAT_BC1_RGB_UNORM_BLOCK")]
        BC1RgbUnormBlock = 131,
        [NativeName("Name", "VK_FORMAT_BC1_RGB_SRGB_BLOCK")]
        BC1RgbSrgbBlock = 132,
        [NativeName("Name", "VK_FORMAT_BC1_RGBA_UNORM_BLOCK")]
        BC1RgbaUnormBlock = 133,
        [NativeName("Name", "VK_FORMAT_BC1_RGBA_SRGB_BLOCK")]
        BC1RgbaSrgbBlock = 134,
        [NativeName("Name", "VK_FORMAT_BC2_UNORM_BLOCK")]
        BC2UnormBlock = 135,
        [NativeName("Name", "VK_FORMAT_BC2_SRGB_BLOCK")]
        BC2SrgbBlock = 136,
        [NativeName("Name", "VK_FORMAT_BC3_UNORM_BLOCK")]
        BC3UnormBlock = 137,
        [NativeName("Name", "VK_FORMAT_BC3_SRGB_BLOCK")]
        BC3SrgbBlock = 138,
        [NativeName("Name", "VK_FORMAT_BC4_UNORM_BLOCK")]
        BC4UnormBlock = 139,
        [NativeName("Name", "VK_FORMAT_BC4_SNORM_BLOCK")]
        BC4SNormBlock = 140,
        [NativeName("Name", "VK_FORMAT_BC5_UNORM_BLOCK")]
        BC5UnormBlock = 141,
        [NativeName("Name", "VK_FORMAT_BC5_SNORM_BLOCK")]
        BC5SNormBlock = 142,
        [NativeName("Name", "VK_FORMAT_BC6H_UFLOAT_BLOCK")]
        BC6HUfloatBlock = 143,
        [NativeName("Name", "VK_FORMAT_BC6H_SFLOAT_BLOCK")]
        BC6HSfloatBlock = 144,
        [NativeName("Name", "VK_FORMAT_BC7_UNORM_BLOCK")]
        BC7UnormBlock = 145,
        [NativeName("Name", "VK_FORMAT_BC7_SRGB_BLOCK")]
        BC7SrgbBlock = 146,
        [NativeName("Name", "VK_FORMAT_ETC2_R8G8B8_UNORM_BLOCK")]
        Etc2R8G8B8UnormBlock = 147,
        [NativeName("Name", "VK_FORMAT_ETC2_R8G8B8_SRGB_BLOCK")]
        Etc2R8G8B8SrgbBlock = 148,
        [NativeName("Name", "VK_FORMAT_ETC2_R8G8B8A1_UNORM_BLOCK")]
        Etc2R8G8B8A1UnormBlock = 149,
        [NativeName("Name", "VK_FORMAT_ETC2_R8G8B8A1_SRGB_BLOCK")]
        Etc2R8G8B8A1SrgbBlock = 150,
        [NativeName("Name", "VK_FORMAT_ETC2_R8G8B8A8_UNORM_BLOCK")]
        Etc2R8G8B8A8UnormBlock = 151,
        [NativeName("Name", "VK_FORMAT_ETC2_R8G8B8A8_SRGB_BLOCK")]
        Etc2R8G8B8A8SrgbBlock = 152,
        [NativeName("Name", "VK_FORMAT_EAC_R11_UNORM_BLOCK")]
        EacR11UnormBlock = 153,
        [NativeName("Name", "VK_FORMAT_EAC_R11_SNORM_BLOCK")]
        EacR11SNormBlock = 154,
        [NativeName("Name", "VK_FORMAT_EAC_R11G11_UNORM_BLOCK")]
        EacR11G11UnormBlock = 155,
        [NativeName("Name", "VK_FORMAT_EAC_R11G11_SNORM_BLOCK")]
        EacR11G11SNormBlock = 156,
        [NativeName("Name", "VK_FORMAT_ASTC_4x4_UNORM_BLOCK")]
        Astc4x4UnormBlock = 157,
        [NativeName("Name", "VK_FORMAT_ASTC_4x4_SRGB_BLOCK")]
        Astc4x4SrgbBlock = 158,
        [NativeName("Name", "VK_FORMAT_ASTC_5x4_UNORM_BLOCK")]
        Astc5x4UnormBlock = 159,
        [NativeName("Name", "VK_FORMAT_ASTC_5x4_SRGB_BLOCK")]
        Astc5x4SrgbBlock = 160,
        [NativeName("Name", "VK_FORMAT_ASTC_5x5_UNORM_BLOCK")]
        Astc5x5UnormBlock = 161,
        [NativeName("Name", "VK_FORMAT_ASTC_5x5_SRGB_BLOCK")]
        Astc5x5SrgbBlock = 162,
        [NativeName("Name", "VK_FORMAT_ASTC_6x5_UNORM_BLOCK")]
        Astc6x5UnormBlock = 163,
        [NativeName("Name", "VK_FORMAT_ASTC_6x5_SRGB_BLOCK")]
        Astc6x5SrgbBlock = 164,
        [NativeName("Name", "VK_FORMAT_ASTC_6x6_UNORM_BLOCK")]
        Astc6x6UnormBlock = 165,
        [NativeName("Name", "VK_FORMAT_ASTC_6x6_SRGB_BLOCK")]
        Astc6x6SrgbBlock = 166,
        [NativeName("Name", "VK_FORMAT_ASTC_8x5_UNORM_BLOCK")]
        Astc8x5UnormBlock = 167,
        [NativeName("Name", "VK_FORMAT_ASTC_8x5_SRGB_BLOCK")]
        Astc8x5SrgbBlock = 168,
        [NativeName("Name", "VK_FORMAT_ASTC_8x6_UNORM_BLOCK")]
        Astc8x6UnormBlock = 169,
        [NativeName("Name", "VK_FORMAT_ASTC_8x6_SRGB_BLOCK")]
        Astc8x6SrgbBlock = 170,
        [NativeName("Name", "VK_FORMAT_ASTC_8x8_UNORM_BLOCK")]
        Astc8x8UnormBlock = 171,
        [NativeName("Name", "VK_FORMAT_ASTC_8x8_SRGB_BLOCK")]
        Astc8x8SrgbBlock = 172,
        [NativeName("Name", "VK_FORMAT_ASTC_10x5_UNORM_BLOCK")]
        Astc10x5UnormBlock = 173,
        [NativeName("Name", "VK_FORMAT_ASTC_10x5_SRGB_BLOCK")]
        Astc10x5SrgbBlock = 174,
        [NativeName("Name", "VK_FORMAT_ASTC_10x6_UNORM_BLOCK")]
        Astc10x6UnormBlock = 175,
        [NativeName("Name", "VK_FORMAT_ASTC_10x6_SRGB_BLOCK")]
        Astc10x6SrgbBlock = 176,
        [NativeName("Name", "VK_FORMAT_ASTC_10x8_UNORM_BLOCK")]
        Astc10x8UnormBlock = 177,
        [NativeName("Name", "VK_FORMAT_ASTC_10x8_SRGB_BLOCK")]
        Astc10x8SrgbBlock = 178,
        [NativeName("Name", "VK_FORMAT_ASTC_10x10_UNORM_BLOCK")]
        Astc10x10UnormBlock = 179,
        [NativeName("Name", "VK_FORMAT_ASTC_10x10_SRGB_BLOCK")]
        Astc10x10SrgbBlock = 180,
        [NativeName("Name", "VK_FORMAT_ASTC_12x10_UNORM_BLOCK")]
        Astc12x10UnormBlock = 181,
        [NativeName("Name", "VK_FORMAT_ASTC_12x10_SRGB_BLOCK")]
        Astc12x10SrgbBlock = 182,
        [NativeName("Name", "VK_FORMAT_ASTC_12x12_UNORM_BLOCK")]
        Astc12x12UnormBlock = 183,
        [NativeName("Name", "VK_FORMAT_ASTC_12x12_SRGB_BLOCK")]
        Astc12x12SrgbBlock = 184,
        [NativeName("Name", "VK_FORMAT_PVRTC1_2BPP_UNORM_BLOCK_IMG")]
        Pvrtc12BppUnormBlockImg = 1000054000,
        [NativeName("Name", "VK_FORMAT_PVRTC1_4BPP_UNORM_BLOCK_IMG")]
        Pvrtc14BppUnormBlockImg = 1000054001,
        [NativeName("Name", "VK_FORMAT_PVRTC2_2BPP_UNORM_BLOCK_IMG")]
        Pvrtc22BppUnormBlockImg = 1000054002,
        [NativeName("Name", "VK_FORMAT_PVRTC2_4BPP_UNORM_BLOCK_IMG")]
        Pvrtc24BppUnormBlockImg = 1000054003,
        [NativeName("Name", "VK_FORMAT_PVRTC1_2BPP_SRGB_BLOCK_IMG")]
        Pvrtc12BppSrgbBlockImg = 1000054004,
        [NativeName("Name", "VK_FORMAT_PVRTC1_4BPP_SRGB_BLOCK_IMG")]
        Pvrtc14BppSrgbBlockImg = 1000054005,
        [NativeName("Name", "VK_FORMAT_PVRTC2_2BPP_SRGB_BLOCK_IMG")]
        Pvrtc22BppSrgbBlockImg = 1000054006,
        [NativeName("Name", "VK_FORMAT_PVRTC2_4BPP_SRGB_BLOCK_IMG")]
        Pvrtc24BppSrgbBlockImg = 1000054007,
        [NativeName("Name", "VK_FORMAT_ASTC_4x4_SFLOAT_BLOCK_EXT")]
        Astc4x4SfloatBlockExt = 1000066000,
        [NativeName("Name", "VK_FORMAT_ASTC_5x4_SFLOAT_BLOCK_EXT")]
        Astc5x4SfloatBlockExt = 1000066001,
        [NativeName("Name", "VK_FORMAT_ASTC_5x5_SFLOAT_BLOCK_EXT")]
        Astc5x5SfloatBlockExt = 1000066002,
        [NativeName("Name", "VK_FORMAT_ASTC_6x5_SFLOAT_BLOCK_EXT")]
        Astc6x5SfloatBlockExt = 1000066003,
        [NativeName("Name", "VK_FORMAT_ASTC_6x6_SFLOAT_BLOCK_EXT")]
        Astc6x6SfloatBlockExt = 1000066004,
        [NativeName("Name", "VK_FORMAT_ASTC_8x5_SFLOAT_BLOCK_EXT")]
        Astc8x5SfloatBlockExt = 1000066005,
        [NativeName("Name", "VK_FORMAT_ASTC_8x6_SFLOAT_BLOCK_EXT")]
        Astc8x6SfloatBlockExt = 1000066006,
        [NativeName("Name", "VK_FORMAT_ASTC_8x8_SFLOAT_BLOCK_EXT")]
        Astc8x8SfloatBlockExt = 1000066007,
        [NativeName("Name", "VK_FORMAT_ASTC_10x5_SFLOAT_BLOCK_EXT")]
        Astc10x5SfloatBlockExt = 1000066008,
        [NativeName("Name", "VK_FORMAT_ASTC_10x6_SFLOAT_BLOCK_EXT")]
        Astc10x6SfloatBlockExt = 1000066009,
        [NativeName("Name", "VK_FORMAT_ASTC_10x8_SFLOAT_BLOCK_EXT")]
        Astc10x8SfloatBlockExt = 1000066010,
        [NativeName("Name", "VK_FORMAT_ASTC_10x10_SFLOAT_BLOCK_EXT")]
        Astc10x10SfloatBlockExt = 1000066011,
        [NativeName("Name", "VK_FORMAT_ASTC_12x10_SFLOAT_BLOCK_EXT")]
        Astc12x10SfloatBlockExt = 1000066012,
        [NativeName("Name", "VK_FORMAT_ASTC_12x12_SFLOAT_BLOCK_EXT")]
        Astc12x12SfloatBlockExt = 1000066013,
        [NativeName("Name", "VK_FORMAT_G8B8G8R8_422_UNORM_KHR")]
        G8B8G8R8422UnormKhr = 1000156000,
        [NativeName("Name", "VK_FORMAT_B8G8R8G8_422_UNORM_KHR")]
        B8G8R8G8422UnormKhr = 1000156001,
        [NativeName("Name", "VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM_KHR")]
        G8B8R83Plane420UnormKhr = 1000156002,
        [NativeName("Name", "VK_FORMAT_G8_B8R8_2PLANE_420_UNORM_KHR")]
        G8B8R82Plane420UnormKhr = 1000156003,
        [NativeName("Name", "VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM_KHR")]
        G8B8R83Plane422UnormKhr = 1000156004,
        [NativeName("Name", "VK_FORMAT_G8_B8R8_2PLANE_422_UNORM_KHR")]
        G8B8R82Plane422UnormKhr = 1000156005,
        [NativeName("Name", "VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM_KHR")]
        G8B8R83Plane444UnormKhr = 1000156006,
        [NativeName("Name", "VK_FORMAT_R10X6_UNORM_PACK16_KHR")]
        R10X6UnormPack16Khr = 1000156007,
        [NativeName("Name", "VK_FORMAT_R10X6G10X6_UNORM_2PACK16_KHR")]
        R10X6G10X6Unorm2Pack16Khr = 1000156008,
        [NativeName("Name", "VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16_KHR")]
        R10X6G10X6B10X6A10X6Unorm4Pack16Khr = 1000156009,
        [NativeName("Name", "VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16_KHR")]
        G10X6B10X6G10X6R10X6422Unorm4Pack16Khr = 1000156010,
        [NativeName("Name", "VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16_KHR")]
        B10X6G10X6R10X6G10X6422Unorm4Pack16Khr = 1000156011,
        [NativeName("Name", "VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16_KHR")]
        G10X6B10X6R10X63Plane420Unorm3Pack16Khr = 1000156012,
        [NativeName("Name", "VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16_KHR")]
        G10X6B10X6R10X62Plane420Unorm3Pack16Khr = 1000156013,
        [NativeName("Name", "VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16_KHR")]
        G10X6B10X6R10X63Plane422Unorm3Pack16Khr = 1000156014,
        [NativeName("Name", "VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16_KHR")]
        G10X6B10X6R10X62Plane422Unorm3Pack16Khr = 1000156015,
        [NativeName("Name", "VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16_KHR")]
        G10X6B10X6R10X63Plane444Unorm3Pack16Khr = 1000156016,
        [NativeName("Name", "VK_FORMAT_R12X4_UNORM_PACK16_KHR")]
        R12X4UnormPack16Khr = 1000156017,
        [NativeName("Name", "VK_FORMAT_R12X4G12X4_UNORM_2PACK16_KHR")]
        R12X4G12X4Unorm2Pack16Khr = 1000156018,
        [NativeName("Name", "VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16_KHR")]
        R12X4G12X4B12X4A12X4Unorm4Pack16Khr = 1000156019,
        [NativeName("Name", "VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16_KHR")]
        G12X4B12X4G12X4R12X4422Unorm4Pack16Khr = 1000156020,
        [NativeName("Name", "VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16_KHR")]
        B12X4G12X4R12X4G12X4422Unorm4Pack16Khr = 1000156021,
        [NativeName("Name", "VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16_KHR")]
        G12X4B12X4R12X43Plane420Unorm3Pack16Khr = 1000156022,
        [NativeName("Name", "VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16_KHR")]
        G12X4B12X4R12X42Plane420Unorm3Pack16Khr = 1000156023,
        [NativeName("Name", "VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16_KHR")]
        G12X4B12X4R12X43Plane422Unorm3Pack16Khr = 1000156024,
        [NativeName("Name", "VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16_KHR")]
        G12X4B12X4R12X42Plane422Unorm3Pack16Khr = 1000156025,
        [NativeName("Name", "VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16_KHR")]
        G12X4B12X4R12X43Plane444Unorm3Pack16Khr = 1000156026,
        [NativeName("Name", "VK_FORMAT_G16B16G16R16_422_UNORM_KHR")]
        G16B16G16R16422UnormKhr = 1000156027,
        [NativeName("Name", "VK_FORMAT_B16G16R16G16_422_UNORM_KHR")]
        B16G16R16G16422UnormKhr = 1000156028,
        [NativeName("Name", "VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM_KHR")]
        G16B16R163Plane420UnormKhr = 1000156029,
        [NativeName("Name", "VK_FORMAT_G16_B16R16_2PLANE_420_UNORM_KHR")]
        G16B16R162Plane420UnormKhr = 1000156030,
        [NativeName("Name", "VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM_KHR")]
        G16B16R163Plane422UnormKhr = 1000156031,
        [NativeName("Name", "VK_FORMAT_G16_B16R16_2PLANE_422_UNORM_KHR")]
        G16B16R162Plane422UnormKhr = 1000156032,
        [NativeName("Name", "VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM_KHR")]
        G16B16R163Plane444UnormKhr = 1000156033,
        [NativeName("Name", "VK_FORMAT_G8_B8R8_2PLANE_444_UNORM_EXT")]
        G8B8R82Plane444UnormExt = 1000330000,
        [NativeName("Name", "VK_FORMAT_G10X6_B10X6R10X6_2PLANE_444_UNORM_3PACK16_EXT")]
        G10X6B10X6R10X62Plane444Unorm3Pack16Ext = 1000330001,
        [NativeName("Name", "VK_FORMAT_G12X4_B12X4R12X4_2PLANE_444_UNORM_3PACK16_EXT")]
        G12X4B12X4R12X42Plane444Unorm3Pack16Ext = 1000330002,
        [NativeName("Name", "VK_FORMAT_G16_B16R16_2PLANE_444_UNORM_EXT")]
        G16B16R162Plane444UnormExt = 1000330003,
        [NativeName("Name", "VK_FORMAT_A4R4G4B4_UNORM_PACK16_EXT")]
        A4R4G4B4UnormPack16Ext = 1000340000,
        [NativeName("Name", "VK_FORMAT_A4B4G4R4_UNORM_PACK16_EXT")]
        A4B4G4R4UnormPack16Ext = 1000340001,
        [NativeName("Name", "VK_FORMAT_R16G16_SFIXED5_NV")]
        R16G16Sfixed5NV = 1000464000,
        [NativeName("Name", "VK_FORMAT_R16G16_S10_5_NV")]
        R16G16S105NV = 1000464000,
        [NativeName("Name", "VK_FORMAT_A1B5G5R5_UNORM_PACK16_KHR")]
        A1B5G5R5UnormPack16Khr = 1000470000,
        [NativeName("Name", "VK_FORMAT_A8_UNORM_KHR")]
        A8UnormKhr = 1000470001,
        [NativeName("Name", "VK_FORMAT_G8B8G8R8_422_UNORM")]
        G8B8G8R8422Unorm = 1000156000,
        [NativeName("Name", "VK_FORMAT_B8G8R8G8_422_UNORM")]
        B8G8R8G8422Unorm = 1000156001,
        [NativeName("Name", "VK_FORMAT_G8_B8_R8_3PLANE_420_UNORM")]
        G8B8R83Plane420Unorm = 1000156002,
        [NativeName("Name", "VK_FORMAT_G8_B8R8_2PLANE_420_UNORM")]
        G8B8R82Plane420Unorm = 1000156003,
        [NativeName("Name", "VK_FORMAT_G8_B8_R8_3PLANE_422_UNORM")]
        G8B8R83Plane422Unorm = 1000156004,
        [NativeName("Name", "VK_FORMAT_G8_B8R8_2PLANE_422_UNORM")]
        G8B8R82Plane422Unorm = 1000156005,
        [NativeName("Name", "VK_FORMAT_G8_B8_R8_3PLANE_444_UNORM")]
        G8B8R83Plane444Unorm = 1000156006,
        [NativeName("Name", "VK_FORMAT_R10X6_UNORM_PACK16")]
        R10X6UnormPack16 = 1000156007,
        [NativeName("Name", "VK_FORMAT_R10X6G10X6_UNORM_2PACK16")]
        R10X6G10X6Unorm2Pack16 = 1000156008,
        [NativeName("Name", "VK_FORMAT_R10X6G10X6B10X6A10X6_UNORM_4PACK16")]
        R10X6G10X6B10X6A10X6Unorm4Pack16 = 1000156009,
        [NativeName("Name", "VK_FORMAT_G10X6B10X6G10X6R10X6_422_UNORM_4PACK16")]
        G10X6B10X6G10X6R10X6422Unorm4Pack16 = 1000156010,
        [NativeName("Name", "VK_FORMAT_B10X6G10X6R10X6G10X6_422_UNORM_4PACK16")]
        B10X6G10X6R10X6G10X6422Unorm4Pack16 = 1000156011,
        [NativeName("Name", "VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_420_UNORM_3PACK16")]
        G10X6B10X6R10X63Plane420Unorm3Pack16 = 1000156012,
        [NativeName("Name", "VK_FORMAT_G10X6_B10X6R10X6_2PLANE_420_UNORM_3PACK16")]
        G10X6B10X6R10X62Plane420Unorm3Pack16 = 1000156013,
        [NativeName("Name", "VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_422_UNORM_3PACK16")]
        G10X6B10X6R10X63Plane422Unorm3Pack16 = 1000156014,
        [NativeName("Name", "VK_FORMAT_G10X6_B10X6R10X6_2PLANE_422_UNORM_3PACK16")]
        G10X6B10X6R10X62Plane422Unorm3Pack16 = 1000156015,
        [NativeName("Name", "VK_FORMAT_G10X6_B10X6_R10X6_3PLANE_444_UNORM_3PACK16")]
        G10X6B10X6R10X63Plane444Unorm3Pack16 = 1000156016,
        [NativeName("Name", "VK_FORMAT_R12X4_UNORM_PACK16")]
        R12X4UnormPack16 = 1000156017,
        [NativeName("Name", "VK_FORMAT_R12X4G12X4_UNORM_2PACK16")]
        R12X4G12X4Unorm2Pack16 = 1000156018,
        [NativeName("Name", "VK_FORMAT_R12X4G12X4B12X4A12X4_UNORM_4PACK16")]
        R12X4G12X4B12X4A12X4Unorm4Pack16 = 1000156019,
        [NativeName("Name", "VK_FORMAT_G12X4B12X4G12X4R12X4_422_UNORM_4PACK16")]
        G12X4B12X4G12X4R12X4422Unorm4Pack16 = 1000156020,
        [NativeName("Name", "VK_FORMAT_B12X4G12X4R12X4G12X4_422_UNORM_4PACK16")]
        B12X4G12X4R12X4G12X4422Unorm4Pack16 = 1000156021,
        [NativeName("Name", "VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_420_UNORM_3PACK16")]
        G12X4B12X4R12X43Plane420Unorm3Pack16 = 1000156022,
        [NativeName("Name", "VK_FORMAT_G12X4_B12X4R12X4_2PLANE_420_UNORM_3PACK16")]
        G12X4B12X4R12X42Plane420Unorm3Pack16 = 1000156023,
        [NativeName("Name", "VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_422_UNORM_3PACK16")]
        G12X4B12X4R12X43Plane422Unorm3Pack16 = 1000156024,
        [NativeName("Name", "VK_FORMAT_G12X4_B12X4R12X4_2PLANE_422_UNORM_3PACK16")]
        G12X4B12X4R12X42Plane422Unorm3Pack16 = 1000156025,
        [NativeName("Name", "VK_FORMAT_G12X4_B12X4_R12X4_3PLANE_444_UNORM_3PACK16")]
        G12X4B12X4R12X43Plane444Unorm3Pack16 = 1000156026,
        [NativeName("Name", "VK_FORMAT_G16B16G16R16_422_UNORM")]
        G16B16G16R16422Unorm = 1000156027,
        [NativeName("Name", "VK_FORMAT_B16G16R16G16_422_UNORM")]
        B16G16R16G16422Unorm = 1000156028,
        [NativeName("Name", "VK_FORMAT_G16_B16_R16_3PLANE_420_UNORM")]
        G16B16R163Plane420Unorm = 1000156029,
        [NativeName("Name", "VK_FORMAT_G16_B16R16_2PLANE_420_UNORM")]
        G16B16R162Plane420Unorm = 1000156030,
        [NativeName("Name", "VK_FORMAT_G16_B16_R16_3PLANE_422_UNORM")]
        G16B16R163Plane422Unorm = 1000156031,
        [NativeName("Name", "VK_FORMAT_G16_B16R16_2PLANE_422_UNORM")]
        G16B16R162Plane422Unorm = 1000156032,
        [NativeName("Name", "VK_FORMAT_G16_B16_R16_3PLANE_444_UNORM")]
        G16B16R163Plane444Unorm = 1000156033,
        [NativeName("Name", "VK_FORMAT_G8_B8R8_2PLANE_444_UNORM")]
        G8B8R82Plane444Unorm = 1000330000,
        [NativeName("Name", "VK_FORMAT_G10X6_B10X6R10X6_2PLANE_444_UNORM_3PACK16")]
        G10X6B10X6R10X62Plane444Unorm3Pack16 = 1000330001,
        [NativeName("Name", "VK_FORMAT_G12X4_B12X4R12X4_2PLANE_444_UNORM_3PACK16")]
        G12X4B12X4R12X42Plane444Unorm3Pack16 = 1000330002,
        [NativeName("Name", "VK_FORMAT_G16_B16R16_2PLANE_444_UNORM")]
        G16B16R162Plane444Unorm = 1000330003,
        [NativeName("Name", "VK_FORMAT_A4R4G4B4_UNORM_PACK16")]
        A4R4G4B4UnormPack16 = 1000340000,
        [NativeName("Name", "VK_FORMAT_A4B4G4R4_UNORM_PACK16")]
        A4B4G4R4UnormPack16 = 1000340001,
        [NativeName("Name", "VK_FORMAT_ASTC_4x4_SFLOAT_BLOCK")]
        Astc4x4SfloatBlock = 1000066000,
        [NativeName("Name", "VK_FORMAT_ASTC_5x4_SFLOAT_BLOCK")]
        Astc5x4SfloatBlock = 1000066001,
        [NativeName("Name", "VK_FORMAT_ASTC_5x5_SFLOAT_BLOCK")]
        Astc5x5SfloatBlock = 1000066002,
        [NativeName("Name", "VK_FORMAT_ASTC_6x5_SFLOAT_BLOCK")]
        Astc6x5SfloatBlock = 1000066003,
        [NativeName("Name", "VK_FORMAT_ASTC_6x6_SFLOAT_BLOCK")]
        Astc6x6SfloatBlock = 1000066004,
        [NativeName("Name", "VK_FORMAT_ASTC_8x5_SFLOAT_BLOCK")]
        Astc8x5SfloatBlock = 1000066005,
        [NativeName("Name", "VK_FORMAT_ASTC_8x6_SFLOAT_BLOCK")]
        Astc8x6SfloatBlock = 1000066006,
        [NativeName("Name", "VK_FORMAT_ASTC_8x8_SFLOAT_BLOCK")]
        Astc8x8SfloatBlock = 1000066007,
        [NativeName("Name", "VK_FORMAT_ASTC_10x5_SFLOAT_BLOCK")]
        Astc10x5SfloatBlock = 1000066008,
        [NativeName("Name", "VK_FORMAT_ASTC_10x6_SFLOAT_BLOCK")]
        Astc10x6SfloatBlock = 1000066009,
        [NativeName("Name", "VK_FORMAT_ASTC_10x8_SFLOAT_BLOCK")]
        Astc10x8SfloatBlock = 1000066010,
        [NativeName("Name", "VK_FORMAT_ASTC_10x10_SFLOAT_BLOCK")]
        Astc10x10SfloatBlock = 1000066011,
        [NativeName("Name", "VK_FORMAT_ASTC_12x10_SFLOAT_BLOCK")]
        Astc12x10SfloatBlock = 1000066012,
        [NativeName("Name", "VK_FORMAT_ASTC_12x12_SFLOAT_BLOCK")]
        Astc12x12SfloatBlock = 1000066013,
    }
}
