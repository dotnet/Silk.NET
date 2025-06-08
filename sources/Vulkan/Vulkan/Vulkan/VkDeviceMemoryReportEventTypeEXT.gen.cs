// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkDeviceMemoryReportEventTypeEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT = 1,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT = 2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT = 3,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT = 4,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_MAX_ENUM_EXT = 0x7FFFFFFF,
}
