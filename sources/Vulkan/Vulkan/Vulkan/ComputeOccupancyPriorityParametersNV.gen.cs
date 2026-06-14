// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkComputeOccupancyPriorityParametersNV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ComputeOccupancyPriorityParametersNV
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_compute_occupancy_priority"],
        ImpliesSets = [
            "VK_NV_compute_occupancy_priority+VK_KHR_get_physical_device_properties2",
            "VK_NV_compute_occupancy_priority+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.ComputeOccupancyPriorityParametersNV;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_compute_occupancy_priority"],
        ImpliesSets = [
            "VK_NV_compute_occupancy_priority+VK_KHR_get_physical_device_properties2",
            "VK_NV_compute_occupancy_priority+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("occupancyPriority")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_compute_occupancy_priority"],
        ImpliesSets = [
            "VK_NV_compute_occupancy_priority+VK_KHR_get_physical_device_properties2",
            "VK_NV_compute_occupancy_priority+VK_VERSION_1_1",
        ]
    )]
    public float OccupancyPriority;

    [NativeName("occupancyThrottling")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_compute_occupancy_priority"],
        ImpliesSets = [
            "VK_NV_compute_occupancy_priority+VK_KHR_get_physical_device_properties2",
            "VK_NV_compute_occupancy_priority+VK_VERSION_1_1",
        ]
    )]
    public float OccupancyThrottling;

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_compute_occupancy_priority"],
        ImpliesSets = [
            "VK_NV_compute_occupancy_priority+VK_KHR_get_physical_device_properties2",
            "VK_NV_compute_occupancy_priority+VK_VERSION_1_1",
        ]
    )]
    public ComputeOccupancyPriorityParametersNV() { }
}
