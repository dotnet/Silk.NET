// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkQueueGlobalPriority")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkQueueGlobalPriority : uint
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
    VkQueueGlobalPriorityLow = 128,

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
    VkQueueGlobalPriorityMedium = 256,

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
    VkQueueGlobalPriorityHigh = 512,

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
    VkQueueGlobalPriorityRealtime = 1024,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_LOW_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    VkQueueGlobalPriorityLowEXT = VkQueueGlobalPriorityLow,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    VkQueueGlobalPriorityMediumEXT = VkQueueGlobalPriorityMedium,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_HIGH_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    VkQueueGlobalPriorityHighEXT = VkQueueGlobalPriorityHigh,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_REALTIME_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    VkQueueGlobalPriorityRealtimeEXT = VkQueueGlobalPriorityRealtime,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_LOW_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    VkQueueGlobalPriorityLowKHR = VkQueueGlobalPriorityLow,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    VkQueueGlobalPriorityMediumKHR = VkQueueGlobalPriorityMedium,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_HIGH_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    VkQueueGlobalPriorityHighKHR = VkQueueGlobalPriorityHigh,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_REALTIME_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    VkQueueGlobalPriorityRealtimeKHR = VkQueueGlobalPriorityRealtime,

    [NativeName("VK_QUEUE_GLOBAL_PRIORITY_MAX_ENUM")]
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
    VkQueueGlobalPriorityMaxEnum = 0x7FFFFFFF,
}
