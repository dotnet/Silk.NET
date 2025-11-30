// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkPhysicalDeviceUnifiedImageLayoutsFeaturesKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceUnifiedImageLayoutsFeaturesKhr
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_unified_image_layouts"],
        ImpliesSets = [
            "VK_KHR_unified_image_layouts+VK_KHR_get_physical_device_properties2",
            "VK_KHR_unified_image_layouts+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_unified_image_layouts"],
        ImpliesSets = [
            "VK_KHR_unified_image_layouts+VK_KHR_get_physical_device_properties2",
            "VK_KHR_unified_image_layouts+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("unifiedImageLayouts")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_unified_image_layouts"],
        ImpliesSets = [
            "VK_KHR_unified_image_layouts+VK_KHR_get_physical_device_properties2",
            "VK_KHR_unified_image_layouts+VK_VERSION_1_1",
        ]
    )]
    public uint UnifiedImageLayouts;

    [NativeName("unifiedImageLayoutsVideo")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_unified_image_layouts"],
        ImpliesSets = [
            "VK_KHR_unified_image_layouts+VK_KHR_get_physical_device_properties2",
            "VK_KHR_unified_image_layouts+VK_VERSION_1_1",
        ]
    )]
    public uint UnifiedImageLayoutsVideo;
}
