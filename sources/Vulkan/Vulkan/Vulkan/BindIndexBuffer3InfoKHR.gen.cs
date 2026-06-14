// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBindIndexBuffer3InfoKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct BindIndexBuffer3InfoKHR
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
    public StructureType SType = StructureType.BindIndexBuffer3InfoKHR;

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

    [NativeName("addressRange")]
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
    public DeviceAddressRangeKHR AddressRange;

    [NativeName("addressFlags")]
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
    public AddressCommandFlagsKHR AddressFlags;

    [NativeName("indexType")]
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
    public IndexType IndexType;

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
    public BindIndexBuffer3InfoKHR() { }
}
