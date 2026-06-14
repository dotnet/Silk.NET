// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceFaultPropertiesKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceFaultPropertiesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.PhysicalDeviceFaultPropertiesKHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("maxDeviceFaultCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    public uint MaxDeviceFaultCount;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    public PhysicalDeviceFaultPropertiesKHR() { }
}
