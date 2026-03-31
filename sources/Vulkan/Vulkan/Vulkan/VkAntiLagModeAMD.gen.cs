// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "AMD")]
[NativeName("VkAntiLagModeAMD")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkAntiLagModeAMD : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_ANTI_LAG_MODE_DRIVER_CONTROL_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    VkAntiLagModeDriverControl = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_ANTI_LAG_MODE_ON_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    VkAntiLagModeOn = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_ANTI_LAG_MODE_OFF_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    VkAntiLagModeOff = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_ANTI_LAG_MODE_MAX_ENUM_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    VkAntiLagModeMaxEnum = 0x7FFFFFFF,
}
