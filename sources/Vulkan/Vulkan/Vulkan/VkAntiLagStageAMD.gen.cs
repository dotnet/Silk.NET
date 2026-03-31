// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "AMD")]
[NativeName("VkAntiLagStageAMD")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkAntiLagStageAMD : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_ANTI_LAG_STAGE_INPUT_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    VkAntiLagStageInput = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_ANTI_LAG_STAGE_PRESENT_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    VkAntiLagStagePresent = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "AMD")]
    [NativeName("VK_ANTI_LAG_STAGE_MAX_ENUM_AMD")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_AMD_anti_lag"],
        ImpliesSets = [
            "VK_AMD_anti_lag+VK_KHR_get_physical_device_properties2",
            "VK_AMD_anti_lag+VK_VERSION_1_1",
        ]
    )]
    VkAntiLagStageMaxEnum = 0x7FFFFFFF,
}
