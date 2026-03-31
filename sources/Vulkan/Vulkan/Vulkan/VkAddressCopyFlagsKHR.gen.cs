// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "KHR")]
[NativeName("VkAddressCopyFlagBitsKHR")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkAddressCopyFlagsKHR : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_ADDRESS_COPY_DEVICE_LOCAL_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_buffer_device_address",
            "VK_VERSION_1_2",
        ]
    )]
    VkAddressCopyDeviceLocalBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_ADDRESS_COPY_SPARSE_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_buffer_device_address",
            "VK_VERSION_1_2",
        ]
    )]
    VkAddressCopySparseBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_ADDRESS_COPY_PROTECTED_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_buffer_device_address",
            "VK_VERSION_1_2",
        ]
    )]
    VkAddressCopyProtectedBit = 0x00000004,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_ADDRESS_COPY_FLAG_BITS_MAX_ENUM_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_copy_memory_indirect"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_buffer_device_address",
            "VK_VERSION_1_2",
        ]
    )]
    VkAddressCopyFlagBitsMaxEnum = 0x7FFFFFFF,
}
