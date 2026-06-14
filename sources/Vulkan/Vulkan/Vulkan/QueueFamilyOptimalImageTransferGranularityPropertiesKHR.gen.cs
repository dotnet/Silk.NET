// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkQueueFamilyOptimalImageTransferGranularityPropertiesKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct QueueFamilyOptimalImageTransferGranularityPropertiesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance11"],
        ImpliesSets = [
            "VK_KHR_maintenance11+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance11+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType =
        StructureType.QueueFamilyOptimalImageTransferGranularityPropertiesKHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance11"],
        ImpliesSets = [
            "VK_KHR_maintenance11+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance11+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("optimalImageTransferGranularity")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance11"],
        ImpliesSets = [
            "VK_KHR_maintenance11+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance11+VK_VERSION_1_1",
        ]
    )]
    public Extent3D OptimalImageTransferGranularity;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance11"],
        ImpliesSets = [
            "VK_KHR_maintenance11+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance11+VK_VERSION_1_1",
        ]
    )]
    public QueueFamilyOptimalImageTransferGranularityPropertiesKHR() { }
}
