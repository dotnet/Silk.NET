// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkMemoryRangeBarrierKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct MemoryRangeBarrierKHR
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
    public StructureType SType = StructureType.MemoryRangeBarrierKHR;

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

    [NativeName("srcStageMask")]
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
    public PipelineStageFlags2 SrcStageMask;

    [NativeName("srcAccessMask")]
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
    public AccessFlags2 SrcAccessMask;

    [NativeName("dstStageMask")]
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
    public PipelineStageFlags2 DstStageMask;

    [NativeName("dstAccessMask")]
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
    public AccessFlags2 DstAccessMask;

    [NativeName("srcQueueFamilyIndex")]
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
    public uint SrcQueueFamilyIndex;

    [NativeName("dstQueueFamilyIndex")]
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
    public uint DstQueueFamilyIndex;

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
    public MemoryRangeBarrierKHR() { }
}
