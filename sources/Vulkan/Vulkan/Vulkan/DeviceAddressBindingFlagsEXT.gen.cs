// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDeviceAddressBindingFlagBitsEXT")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum DeviceAddressBindingFlagsEXT : uint
{
    None = 0x0,

    [NativeName("VK_DEVICE_ADDRESS_BINDING_INTERNAL_OBJECT_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    InternalObjectBitEXT = 0x1,
}
