// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDecompressMemoryRegionEXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public partial struct VkDecompressMemoryRegionEXT
{
    [NativeName("srcAddress")]
    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_decompression"],
        ImpliesSets = ["VK_KHR_buffer_device_address", "VK_KHR_get_physical_device_properties2"]
    )]
    public ulong SrcAddress;

    [NativeName("dstAddress")]
    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_decompression"],
        ImpliesSets = ["VK_KHR_buffer_device_address", "VK_KHR_get_physical_device_properties2"]
    )]
    public ulong DstAddress;

    [NativeName("compressedSize")]
    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_decompression"],
        ImpliesSets = ["VK_KHR_buffer_device_address", "VK_KHR_get_physical_device_properties2"]
    )]
    public ulong CompressedSize;

    [NativeName("decompressedSize")]
    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_memory_decompression"],
        ImpliesSets = ["VK_KHR_buffer_device_address", "VK_KHR_get_physical_device_properties2"]
    )]
    public ulong DecompressedSize;
}
