// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "EXT")]
[NativeName("VkConservativeRasterizationModeEXT")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkConservativeRasterizationModeEXT : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_CONSERVATIVE_RASTERIZATION_MODE_DISABLED_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkConservativeRasterizationModeDisabled = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_CONSERVATIVE_RASTERIZATION_MODE_OVERESTIMATE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkConservativeRasterizationModeOverestimate = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_CONSERVATIVE_RASTERIZATION_MODE_UNDERESTIMATE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkConservativeRasterizationModeUnderestimate = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "EXT")]
    [NativeName("VK_CONSERVATIVE_RASTERIZATION_MODE_MAX_ENUM_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_conservative_rasterization"],
        ImpliesSets = [
            "VK_EXT_conservative_rasterization+VK_KHR_get_physical_device_properties2",
            "VK_EXT_conservative_rasterization+VK_VERSION_1_1",
        ]
    )]
    VkConservativeRasterizationModeMaxEnum = 0x7FFFFFFF,
}
