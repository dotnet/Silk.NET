// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkVideoEncodeTuningModeKHR")]
[SupportedApiProfile("vulkan")]
public enum VideoEncodeTuningModeKHR : uint
{
    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_TUNING_MODE_DEFAULT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    DefaultKHR = 0,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_TUNING_MODE_HIGH_QUALITY_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    HighQualityKHR = 1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_TUNING_MODE_LOW_LATENCY_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    LowLatencyKHR = 2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_TUNING_MODE_ULTRA_LOW_LATENCY_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    UltraLowLatencyKHR = 3,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_TUNING_MODE_LOSSLESS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    LosslessKHR = 4,
}
