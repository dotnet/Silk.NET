// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "KHR")]
[NativeName("VkResolveImageFlagBitsKHR")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkResolveImageFlagsKHR : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_RESOLVE_IMAGE_SKIP_TRANSFER_FUNCTION_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10+VK_KHR_copy_commands2", "VK_KHR_maintenance10+VK_VERSION_1_3"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    VkResolveImageSkipTransferFunctionBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_RESOLVE_IMAGE_ENABLE_TRANSFER_FUNCTION_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10+VK_KHR_copy_commands2", "VK_KHR_maintenance10+VK_VERSION_1_3"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    VkResolveImageEnableTransferFunctionBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_RESOLVE_IMAGE_FLAG_BITS_MAX_ENUM_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_maintenance10"],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    VkResolveImageFlagBitsMaxEnum = 0x7FFFFFFF,
}
