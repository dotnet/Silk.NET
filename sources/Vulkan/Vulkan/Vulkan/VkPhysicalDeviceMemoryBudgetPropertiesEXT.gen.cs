// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_budget"],
        ImpliesSets = [
            "VK_EXT_memory_budget+VK_KHR_get_physical_device_properties2",
            "VK_EXT_memory_budget+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_budget"],
        ImpliesSets = [
            "VK_EXT_memory_budget+VK_KHR_get_physical_device_properties2",
            "VK_EXT_memory_budget+VK_VERSION_1_1",
        ]
    )]
    public void* pNext;

    [NativeTypeName("VkDeviceSize[16]")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_budget"],
        ImpliesSets = [
            "VK_EXT_memory_budget+VK_KHR_get_physical_device_properties2",
            "VK_EXT_memory_budget+VK_VERSION_1_1",
        ]
    )]
    public VkPhysicalDeviceMemoryBudgetPropertiesEXT_heapBudget heapBudget;

    [NativeTypeName("VkDeviceSize[16]")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_budget"],
        ImpliesSets = [
            "VK_EXT_memory_budget+VK_KHR_get_physical_device_properties2",
            "VK_EXT_memory_budget+VK_VERSION_1_1",
        ]
    )]
    public VkPhysicalDeviceMemoryBudgetPropertiesEXT_heapUsage heapUsage;
}
