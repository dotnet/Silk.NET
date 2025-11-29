// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkDebugUtilsMessageTypeFlagBitsEXT")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum DebugUtilsMessageTypeFlagsEXT : uint
{
    None = 0x0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    GeneralBitEXT = 0x1,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    ValidationBitEXT = 0x2,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    PerformanceBitEXT = 0x4,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_TYPE_DEVICE_ADDRESS_BINDING_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    DeviceAddressBindingBitEXT = 0x8,
}
