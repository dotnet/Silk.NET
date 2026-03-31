// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "EXT")]
[NativeName("VkDebugUtilsMessageTypeFlagBitsEXT")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkDebugUtilsMessageTypeFlagsEXT : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VkDebugUtilsMessageTypeGeneralBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VkDebugUtilsMessageTypeValidationBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VkDebugUtilsMessageTypePerformanceBit = 0x00000004,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_TYPE_DEVICE_ADDRESS_BINDING_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    VkDebugUtilsMessageTypeDeviceAddressBindingBit = 0x00000008,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_DEBUG_UTILS_MESSAGE_TYPE_FLAG_BITS_MAX_ENUM_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    VkDebugUtilsMessageTypeFlagBitsMaxEnum = 0x7FFFFFFF,
}
