// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "KHR")]
[NativeName("VkVideoEncodeTuningModeKHR")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkVideoEncodeTuningModeKHR : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_VIDEO_ENCODE_TUNING_MODE_DEFAULT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkVideoEncodeTuningModeDefault = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_VIDEO_ENCODE_TUNING_MODE_HIGH_QUALITY_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkVideoEncodeTuningModeHighQuality = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_VIDEO_ENCODE_TUNING_MODE_LOW_LATENCY_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkVideoEncodeTuningModeLowLatency = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_VIDEO_ENCODE_TUNING_MODE_ULTRA_LOW_LATENCY_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkVideoEncodeTuningModeUltraLowLatency = 3,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_VIDEO_ENCODE_TUNING_MODE_LOSSLESS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkVideoEncodeTuningModeLossless = 4,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_VIDEO_ENCODE_TUNING_MODE_MAX_ENUM_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VkVideoEncodeTuningModeMaxEnum = 0x7FFFFFFF,
}
