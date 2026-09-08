// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDeviceFaultVendorBinaryHeaderVersionKHR")]
[SupportedApiProfile("vulkan")]
public enum DeviceFaultVendorBinaryHeaderVersionKHR : uint
{
    [NativeName("VK_DEVICE_FAULT_VENDOR_BINARY_HEADER_VERSION_ONE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    One = 1,

    [NativeName("VK_DEVICE_FAULT_VENDOR_BINARY_HEADER_VERSION_ONE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    OneEXT = One,
}
