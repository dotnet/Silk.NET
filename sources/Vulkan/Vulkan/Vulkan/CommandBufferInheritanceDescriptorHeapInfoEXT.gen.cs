// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCommandBufferInheritanceDescriptorHeapInfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct CommandBufferInheritanceDescriptorHeapInfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    public StructureType SType = StructureType.CommandBufferInheritanceDescriptorHeapInfoEXT;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    public void* PNext;

    [NativeName("pSamplerHeapBindInfo")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    public BindHeapInfoEXT* PSamplerHeapBindInfo;

    [NativeName("pResourceHeapBindInfo")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    public BindHeapInfoEXT* PResourceHeapBindInfo;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_descriptor_heap"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_buffer_device_address",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_4",
        ]
    )]
    public CommandBufferInheritanceDescriptorHeapInfoEXT() { }
}
