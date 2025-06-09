// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkQueueGlobalPriority : uint
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_QUEUE_GLOBAL_PRIORITY_LOW = 128,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_QUEUE_GLOBAL_PRIORITY_MEDIUM = 256,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_QUEUE_GLOBAL_PRIORITY_HIGH = 512,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_QUEUE_GLOBAL_PRIORITY_REALTIME = 1024,

    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    VK_QUEUE_GLOBAL_PRIORITY_LOW_EXT = VK_QUEUE_GLOBAL_PRIORITY_LOW,

    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_EXT = VK_QUEUE_GLOBAL_PRIORITY_MEDIUM,

    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    VK_QUEUE_GLOBAL_PRIORITY_HIGH_EXT = VK_QUEUE_GLOBAL_PRIORITY_HIGH,

    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    VK_QUEUE_GLOBAL_PRIORITY_REALTIME_EXT = VK_QUEUE_GLOBAL_PRIORITY_REALTIME,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    VK_QUEUE_GLOBAL_PRIORITY_LOW_KHR = VK_QUEUE_GLOBAL_PRIORITY_LOW,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    VK_QUEUE_GLOBAL_PRIORITY_MEDIUM_KHR = VK_QUEUE_GLOBAL_PRIORITY_MEDIUM,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    VK_QUEUE_GLOBAL_PRIORITY_HIGH_KHR = VK_QUEUE_GLOBAL_PRIORITY_HIGH,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    VK_QUEUE_GLOBAL_PRIORITY_REALTIME_KHR = VK_QUEUE_GLOBAL_PRIORITY_REALTIME,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    VK_QUEUE_GLOBAL_PRIORITY_MAX_ENUM = 0x7FFFFFFF,
}
