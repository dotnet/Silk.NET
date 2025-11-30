// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkDeviceMemoryReportEventTypeEXT")]
[SupportedApiProfile("vulkan")]
public enum DeviceMemoryReportEventTypeExt : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    Allocateext = 0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_FREE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    Freeext = 1,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_IMPORT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    Importext = 2,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_UNIMPORT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    Unimportext = 3,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEVICE_MEMORY_REPORT_EVENT_TYPE_ALLOCATION_FAILED_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    AllocationFailedext = 4,
}
