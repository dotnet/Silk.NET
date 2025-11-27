// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("KHR", 0)]
[NativeName("VkVideoEncodeAV1SuperblockSizeFlagBitsKHR")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VideoEncodeAV1SuperblockSizeFlagsKHR : uint
{
    None = 0x0,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_AV1_SUPERBLOCK_SIZE_64_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    Size64BitKHR = 0x1,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_VIDEO_ENCODE_AV1_SUPERBLOCK_SIZE_128_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_av1"],
        ImpliesSets = ["VK_KHR_video_encode_queue"]
    )]
    Size128BitKHR = 0x2,
}
