// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkDeviceFaultAddressTypeEXT")]
[SupportedApiProfile("vulkan")]
public enum DeviceFaultAddressTypeEXT : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_NONE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    NoneEXT = 0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_READ_INVALID_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    ReadInvalidEXT = 1,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_WRITE_INVALID_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    WriteInvalidEXT = 2,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_EXECUTE_INVALID_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    ExecuteInvalidEXT = 3,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_UNKNOWN_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    InstructionPointerUnknownEXT = 4,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_INVALID_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    InstructionPointerInvalidEXT = 5,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEVICE_FAULT_ADDRESS_TYPE_INSTRUCTION_POINTER_FAULT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    InstructionPointerFaultEXT = 6,
}
