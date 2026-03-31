// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "VALVE")]
[NativeName("VkVideoEncodeRgbModelConversionFlagBitsVALVE")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkVideoEncodeRgbModelConversionFlagsVALVE : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "VALVE")]
    [NativeName("VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_RGB_IDENTITY_BIT_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VkVideoEncodeRgbModelConversionRgbIdentityBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "VALVE")]
    [NativeName("VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_YCBCR_IDENTITY_BIT_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VkVideoEncodeRgbModelConversionYcbcrIdentityBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "VALVE")]
    [NativeName("VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_YCBCR_709_BIT_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VkVideoEncodeRgbModelConversionYcbcr709Bit = 0x00000004,

    [NameAffix("Suffix", "KhronosImpliedVendor", "VALVE")]
    [NativeName("VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_YCBCR_601_BIT_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VkVideoEncodeRgbModelConversionYcbcr601Bit = 0x00000008,

    [NameAffix("Suffix", "KhronosImpliedVendor", "VALVE")]
    [NativeName("VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_YCBCR_2020_BIT_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VkVideoEncodeRgbModelConversionYcbcr2020Bit = 0x00000010,

    [NameAffix("Suffix", "KhronosImpliedVendor", "VALVE")]
    [NativeName("VK_VIDEO_ENCODE_RGB_MODEL_CONVERSION_FLAG_BITS_MAX_ENUM_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VkVideoEncodeRgbModelConversionFlagBitsMaxEnum = 0x7FFFFFFF,
}
