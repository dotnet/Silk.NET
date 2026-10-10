// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBindTransformFeedbackBuffer2InfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct BindTransformFeedbackBuffer2InfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_transform_feedback", "VK_KHR_device_address_commands"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    public StructureType SType = StructureType.BindTransformFeedbackBuffer2InfoEXT;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_transform_feedback", "VK_KHR_device_address_commands"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    public void* PNext;

    [NativeName("addressRange")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_transform_feedback", "VK_KHR_device_address_commands"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    public DeviceAddressRangeKHR AddressRange;

    [NativeName("addressFlags")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_transform_feedback", "VK_KHR_device_address_commands"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    public AddressCommandFlagsKHR AddressFlags;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_transform_feedback", "VK_KHR_device_address_commands"],
        ImpliesSets = [
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_KHR_get_physical_device_properties2",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_KHR_buffer_device_address+VK_VERSION_1_1",
            "VK_KHR_synchronization2+VK_EXT_extended_dynamic_state+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    public BindTransformFeedbackBuffer2InfoEXT() { }
}
