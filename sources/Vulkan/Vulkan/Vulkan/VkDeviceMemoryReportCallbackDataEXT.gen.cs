// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDeviceMemoryReportCallbackDataEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    public void* pNext;

    [NativeTypeName("VkDeviceMemoryReportFlagsEXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    public uint flags;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    public VkDeviceMemoryReportEventTypeEXT type;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    public ulong memoryObjectId;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    public ulong size;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    public VkObjectType objectType;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    public ulong objectHandle;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_memory_report"],
        ImpliesSets = [
            "VK_EXT_device_memory_report+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_memory_report+VK_VERSION_1_1",
        ]
    )]
    public uint heapIndex;
}
