// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum MemoryAllocateFlags : uint
{
    None = 0x0,

    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_1",
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    DeviceMaskBit = 0x1,

    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    DeviceAddressBit = 0x2,

    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_2",
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    DeviceAddressCaptureReplayBit = 0x4,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_zero_initialize_device_memory"],
        ImpliesSets = [
            "VK_EXT_zero_initialize_device_memory+VK_KHR_get_physical_device_properties2",
            "VK_EXT_zero_initialize_device_memory+VK_VERSION_1_1",
        ]
    )]
    ZeroInitializeBitEXT = 0x8,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_group"],
        ImpliesSets = ["VK_KHR_device_group_creation"]
    )]
    DeviceMaskBitKHR = DeviceMaskBit,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    DeviceAddressBitKHR = DeviceAddressBit,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_buffer_device_address"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_device_group",
            "VK_VERSION_1_1",
        ]
    )]
    DeviceAddressCaptureReplayBitKHR = DeviceAddressCaptureReplayBit,
}
