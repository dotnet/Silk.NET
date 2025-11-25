// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoChromaSubsamplingFlagsKHR")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum VideoChromaSubsamplingFlagsKHR : uint
{
    [NativeName("VK_VIDEO_CHROMA_SUBSAMPLING_INVALID_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    SubsamplingInvalidKHR = 0x0,

    [NativeName("VK_VIDEO_CHROMA_SUBSAMPLING_MONOCHROME_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    SubsamplingMonochromeBitKHR = 0x1,

    [NativeName("VK_VIDEO_CHROMA_SUBSAMPLING_420_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    Subsampling420BitKHR = 0x2,

    [NativeName("VK_VIDEO_CHROMA_SUBSAMPLING_422_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    Subsampling422BitKHR = 0x4,

    [NativeName("VK_VIDEO_CHROMA_SUBSAMPLING_444_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    Subsampling444BitKHR = 0x8,
}
