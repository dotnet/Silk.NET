// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("KHR", 0)]
[NativeName("VkVideoEncodeRateControlModeFlagBitsKHR")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VideoEncodeRateControlModeFlagsKHR : uint
{
    [NameSuffix("KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DEFAULT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    DefaultKHR = 0x0,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    DisabledBitKHR = 0x1,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_RATE_CONTROL_MODE_CBR_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    CbrBitKHR = 0x2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_RATE_CONTROL_MODE_VBR_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_queue"],
        ImpliesSets = [
            "VK_KHR_video_queue+VK_KHR_synchronization2",
            "VK_KHR_video_queue+VK_VERSION_1_3",
        ]
    )]
    VbrBitKHR = 0x4,
}
