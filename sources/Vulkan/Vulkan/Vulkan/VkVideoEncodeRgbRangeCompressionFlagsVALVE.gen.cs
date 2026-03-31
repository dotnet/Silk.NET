// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "VALVE")]
[NativeName("VkVideoEncodeRgbRangeCompressionFlagBitsVALVE")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkVideoEncodeRgbRangeCompressionFlagsVALVE : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "VALVE")]
    [NativeName("VK_VIDEO_ENCODE_RGB_RANGE_COMPRESSION_FULL_RANGE_BIT_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VkVideoEncodeRgbRangeCompressionFullRangeBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "VALVE")]
    [NativeName("VK_VIDEO_ENCODE_RGB_RANGE_COMPRESSION_NARROW_RANGE_BIT_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VkVideoEncodeRgbRangeCompressionNarrowRangeBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "VALVE")]
    [NativeName("VK_VIDEO_ENCODE_RGB_RANGE_COMPRESSION_FLAG_BITS_MAX_ENUM_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    VkVideoEncodeRgbRangeCompressionFlagBitsMaxEnum = 0x7FFFFFFF,
}
