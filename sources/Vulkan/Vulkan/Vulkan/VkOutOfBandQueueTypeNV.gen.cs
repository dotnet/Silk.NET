// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkOutOfBandQueueTypeNV : uint
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_OUT_OF_BAND_QUEUE_TYPE_RENDER_NV = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_OUT_OF_BAND_QUEUE_TYPE_PRESENT_NV = 1,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_low_latency2"],
        ImpliesSets = [
            "VK_NV_low_latency2+VK_KHR_timeline_semaphore",
            "VK_NV_low_latency2+VK_VERSION_1_2",
        ]
    )]
    VK_OUT_OF_BAND_QUEUE_TYPE_MAX_ENUM_NV = 0x7FFFFFFF,
}
