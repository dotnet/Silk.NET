// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceOpacityMicromapPropertiesKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceOpacityMicromapPropertiesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public StructureType SType = StructureType.PhysicalDeviceOpacityMicromapPropertiesKHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public void* PNext;

    [NativeName("maxOpacity2StateSubdivisionLevel")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public uint MaxOpacity2StateSubdivisionLevel;

    [NativeName("maxOpacity4StateSubdivisionLevel")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public uint MaxOpacity4StateSubdivisionLevel;

    [NativeName("maxOpacityLossy4StateSubdivisionLevel")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public uint MaxOpacityLossy4StateSubdivisionLevel;

    [NativeName("maxMicromapTriangles")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public ulong MaxMicromapTriangles;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_opacity_micromap"],
        ImpliesSets = ["VK_KHR_acceleration_structure", "VK_KHR_device_address_commands"]
    )]
    public PhysicalDeviceOpacityMicromapPropertiesKHR() { }
}
