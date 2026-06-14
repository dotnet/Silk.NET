// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDeviceFaultFlagBitsKHR")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum DeviceFaultFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_DEVICE_FAULT_FLAG_DEVICE_LOST_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    DeviceLost = 0x1,

    [NativeName("VK_DEVICE_FAULT_FLAG_MEMORY_ADDRESS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    MemoryAddress = 0x2,

    [NativeName("VK_DEVICE_FAULT_FLAG_INSTRUCTION_ADDRESS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    InstructionAddress = 0x4,

    [NativeName("VK_DEVICE_FAULT_FLAG_VENDOR_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    Vendor = 0x8,

    [NativeName("VK_DEVICE_FAULT_FLAG_WATCHDOG_TIMEOUT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    WatchdogTimeout = 0x10,

    [NativeName("VK_DEVICE_FAULT_FLAG_OVERFLOW_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    Overflow = 0x20,
}
