// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDevicePrimitiveRestartIndexFeaturesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDevicePrimitiveRestartIndexFeaturesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_primitive_restart_index"],
        ImpliesSets = [
            "VK_EXT_primitive_restart_index+VK_KHR_get_physical_device_properties2",
            "VK_EXT_primitive_restart_index+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.PhysicalDevicePrimitiveRestartIndexFeaturesEXT;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_primitive_restart_index"],
        ImpliesSets = [
            "VK_EXT_primitive_restart_index+VK_KHR_get_physical_device_properties2",
            "VK_EXT_primitive_restart_index+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("primitiveRestartIndex")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_primitive_restart_index"],
        ImpliesSets = [
            "VK_EXT_primitive_restart_index+VK_KHR_get_physical_device_properties2",
            "VK_EXT_primitive_restart_index+VK_VERSION_1_1",
        ]
    )]
    public MaybeBool<uint> PrimitiveRestartIndex;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_primitive_restart_index"],
        ImpliesSets = [
            "VK_EXT_primitive_restart_index+VK_KHR_get_physical_device_properties2",
            "VK_EXT_primitive_restart_index+VK_VERSION_1_1",
        ]
    )]
    public PhysicalDevicePrimitiveRestartIndexFeaturesEXT() { }
}
