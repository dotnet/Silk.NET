// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDecompressMemoryRegionNV")]
[SupportedApiProfile("vulkan")]
public partial struct DecompressMemoryRegionNV
{
    [NativeName("srcAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_memory_decompression"],
        ImpliesSets = [
            "VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    public ulong SrcAddress;

    [NativeName("dstAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_memory_decompression"],
        ImpliesSets = [
            "VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    public ulong DstAddress;

    [NativeName("compressedSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_memory_decompression"],
        ImpliesSets = [
            "VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    public ulong CompressedSize;

    [NativeName("decompressedSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_memory_decompression"],
        ImpliesSets = [
            "VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    public ulong DecompressedSize;

    [NativeName("decompressionMethod")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_memory_decompression"],
        ImpliesSets = [
            "VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    public ulong DecompressionMethod;
}
