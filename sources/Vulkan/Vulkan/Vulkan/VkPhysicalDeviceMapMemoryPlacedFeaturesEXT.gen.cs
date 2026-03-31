// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceMapMemoryPlacedFeaturesEXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceMapMemoryPlacedFeaturesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    public void* PNext;

    [NativeName("memoryMapPlaced")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    public uint MemoryMapPlaced;

    [NativeName("memoryMapRangePlaced")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    public uint MemoryMapRangePlaced;

    [NativeName("memoryUnmapReserve")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_map_memory_placed"],
        ImpliesSets = [
            "VK_EXT_map_memory_placed+VK_KHR_map_memory2",
            "VK_EXT_map_memory_placed+VK_VERSION_1_4",
        ]
    )]
    public uint MemoryUnmapReserve;
}
