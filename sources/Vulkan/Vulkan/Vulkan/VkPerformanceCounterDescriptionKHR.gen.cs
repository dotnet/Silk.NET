// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPerformanceCounterDescriptionKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    public void* pNext;

    [NativeTypeName("VkPerformanceCounterDescriptionFlagsKHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    public uint flags;

    [NativeTypeName("char[256]")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    public VkPerformanceCounterDescriptionKHR_name name;

    [NativeTypeName("char[256]")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    public VkPerformanceCounterDescriptionKHR_category category;

    [NativeTypeName("char[256]")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    public VkPerformanceCounterDescriptionKHR_description description;
}
