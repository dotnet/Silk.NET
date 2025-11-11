// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceMemoryDecompressionPropertiesEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_decompression"],
        ImpliesSets = ["VK_KHR_buffer_device_address", "VK_KHR_get_physical_device_properties2"]
    )]
    public StructureType SType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_decompression"],
        ImpliesSets = ["VK_KHR_buffer_device_address", "VK_KHR_get_physical_device_properties2"]
    )]
    public void* PNext;

    [NativeTypeName("VkMemoryDecompressionMethodFlagsEXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_decompression"],
        ImpliesSets = ["VK_KHR_buffer_device_address", "VK_KHR_get_physical_device_properties2"]
    )]
    public MemoryDecompressionMethodFlagsEXT DecompressionMethods;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_decompression"],
        ImpliesSets = ["VK_KHR_buffer_device_address", "VK_KHR_get_physical_device_properties2"]
    )]
    public ulong MaxDecompressionIndirectCount;
}
