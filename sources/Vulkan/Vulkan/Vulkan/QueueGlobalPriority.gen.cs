// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum QueueGlobalPriority : uint
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    QueueGlobalPriorityLow = 128,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    QueueGlobalPriorityMedium = 256,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    QueueGlobalPriorityHigh = 512,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    QueueGlobalPriorityRealtime = 1024,

    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    QueueGlobalPriorityLowEXT = QueueGlobalPriorityLow,

    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    QueueGlobalPriorityMediumEXT = QueueGlobalPriorityMedium,

    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    QueueGlobalPriorityHighEXT = QueueGlobalPriorityHigh,

    [SupportedApiProfile("vulkan", ["VK_EXT_global_priority"])]
    QueueGlobalPriorityRealtimeEXT = QueueGlobalPriorityRealtime,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    QueueGlobalPriorityLowKHR = QueueGlobalPriorityLow,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    QueueGlobalPriorityMediumKHR = QueueGlobalPriorityMedium,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    QueueGlobalPriorityHighKHR = QueueGlobalPriorityHigh,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_global_priority"],
        ImpliesSets = [
            "VK_KHR_global_priority+VK_KHR_get_physical_device_properties2",
            "VK_KHR_global_priority+VK_VERSION_1_1",
        ]
    )]
    QueueGlobalPriorityRealtimeKHR = QueueGlobalPriorityRealtime,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_4"], MinVersion = "1.4")]
    QueueGlobalPriorityMaxEnum = 0x7FFFFFFF,
}
