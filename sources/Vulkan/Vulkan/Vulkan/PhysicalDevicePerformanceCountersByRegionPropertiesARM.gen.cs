// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDevicePerformanceCountersByRegionPropertiesARM
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    public uint MaxPerRegionPerformanceCounters;

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    public Extent2D PerformanceCounterRegionSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    public uint RowStrideAlignment;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    public uint RegionAlignment;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    public uint IdentityTransformOrder;
}
