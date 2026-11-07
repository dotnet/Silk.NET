// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAddressCommandFlagsKHR")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum AddressCommandFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_ADDRESS_COMMAND_PROTECTED_BIT_KHR")]
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
    ProtectedBit = 0x1,

    [NativeName("VK_ADDRESS_COMMAND_FULLY_BOUND_BIT_KHR")]
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
    FullyBoundBit = 0x2,

    [NativeName("VK_ADDRESS_COMMAND_STORAGE_BUFFER_USAGE_BIT_KHR")]
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
    StorageBufferUsageBit = 0x4,

    [NativeName("VK_ADDRESS_COMMAND_UNKNOWN_STORAGE_BUFFER_USAGE_BIT_KHR")]
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
    UnknownStorageBufferUsageBit = 0x8,

    [NativeName("VK_ADDRESS_COMMAND_TRANSFORM_FEEDBACK_BUFFER_USAGE_BIT_KHR")]
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
    TransformFeedbackBufferUsageBit = 0x10,

    [NativeName("VK_ADDRESS_COMMAND_UNKNOWN_TRANSFORM_FEEDBACK_BUFFER_USAGE_BIT_KHR")]
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
    UnknownTransformFeedbackBufferUsageBit = 0x20,
}
