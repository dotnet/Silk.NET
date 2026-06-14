// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceExtendedFlagsFeaturesKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceExtendedFlagsFeaturesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_extended_flags"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.PhysicalDeviceExtendedFlagsFeaturesKHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_extended_flags"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("extendedFlags")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_extended_flags"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ]
    )]
    public MaybeBool<uint> ExtendedFlags;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_extended_flags"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ]
    )]
    public PhysicalDeviceExtendedFlagsFeaturesKHR() { }
}
