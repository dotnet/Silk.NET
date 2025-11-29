// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "VALVE", 0)]
[NativeName("VkVideoEncodeRgbChromaOffsetFlagBitsVALVE")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VideoEncodeRgbChromaOffsetFlagsValve : uint
{
    None = 0x0,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_VIDEO_ENCODE_RGB_CHROMA_OFFSET_COSITED_EVEN_BIT_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    CositedEvenBitValve = 0x1,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_VIDEO_ENCODE_RGB_CHROMA_OFFSET_MIDPOINT_BIT_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_video_encode_rgb_conversion"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_video_encode_queue+VK_VERSION_1_1",
        ]
    )]
    MidpointBitValve = 0x2,
}
