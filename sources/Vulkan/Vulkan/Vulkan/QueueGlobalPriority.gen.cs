// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkQueueGlobalPriority")]
[SupportedApiProfile("vulkan")]
public enum QueueGlobalPriority : uint
{
    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_LOW")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    Low = 128,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_MEDIUM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    Medium = 256,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_HIGH")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    High = 512,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_REALTIME")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.4"
    )]
    Realtime = 1024,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_LOW_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    LowEXT = Low,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    MediumEXT = Medium,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_HIGH_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    HighEXT = High,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_REALTIME_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    RealtimeEXT = Realtime,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_LOW_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    LowKHR = Low,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    MediumKHR = Medium,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_HIGH_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    HighKHR = High,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_REALTIME_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    RealtimeKHR = Realtime,
}
