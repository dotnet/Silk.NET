// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCopyDeviceMemoryImageInfoKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct CopyDeviceMemoryImageInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_address_commands"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public StructureType SType = StructureType.CopyDeviceMemoryImageInfoKHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_address_commands"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public void* PNext;

    [NativeName("image")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_address_commands"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public ImageHandle Image;

    [NativeName("regionCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_address_commands"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public uint RegionCount;

    [NativeName("pRegions")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_address_commands"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public DeviceMemoryImageCopyKHR* PRegions;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_address_commands"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    public CopyDeviceMemoryImageInfoKHR() { }
}
