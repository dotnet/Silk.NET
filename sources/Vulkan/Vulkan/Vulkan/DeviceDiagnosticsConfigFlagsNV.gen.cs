// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkDeviceDiagnosticsConfigFlagBitsNV")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum DeviceDiagnosticsConfigFlagsNV : uint
{
    None = 0x0,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_DEBUG_INFO_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostics_config"],
        ImpliesSets = [
            "VK_NV_device_diagnostics_config+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostics_config+VK_VERSION_1_1",
        ]
    )]
    EnableShaderDebugInfoBitnv = 0x1,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_RESOURCE_TRACKING_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostics_config"],
        ImpliesSets = [
            "VK_NV_device_diagnostics_config+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostics_config+VK_VERSION_1_1",
        ]
    )]
    EnableResourceTrackingBitnv = 0x2,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_AUTOMATIC_CHECKPOINTS_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostics_config"],
        ImpliesSets = [
            "VK_NV_device_diagnostics_config+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostics_config+VK_VERSION_1_1",
        ]
    )]
    EnableAutomaticCheckpointsBitnv = 0x4,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_ERROR_REPORTING_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostics_config"],
        ImpliesSets = [
            "VK_NV_device_diagnostics_config+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostics_config+VK_VERSION_1_1",
        ]
    )]
    EnableShaderErrorReportingBitnv = 0x8,
}
