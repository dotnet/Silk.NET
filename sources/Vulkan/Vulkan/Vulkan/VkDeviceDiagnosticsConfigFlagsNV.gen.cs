// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "NV")]
[NativeName("VkDeviceDiagnosticsConfigFlagBitsNV")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkDeviceDiagnosticsConfigFlagsNV : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_DEBUG_INFO_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostics_config"],
        ImpliesSets = [
            "VK_NV_device_diagnostics_config+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostics_config+VK_VERSION_1_1",
        ]
    )]
    VkDeviceDiagnosticsConfigEnableShaderDebugInfoBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_RESOURCE_TRACKING_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostics_config"],
        ImpliesSets = [
            "VK_NV_device_diagnostics_config+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostics_config+VK_VERSION_1_1",
        ]
    )]
    VkDeviceDiagnosticsConfigEnableResourceTrackingBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_AUTOMATIC_CHECKPOINTS_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostics_config"],
        ImpliesSets = [
            "VK_NV_device_diagnostics_config+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostics_config+VK_VERSION_1_1",
        ]
    )]
    VkDeviceDiagnosticsConfigEnableAutomaticCheckpointsBit = 0x00000004,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_DEVICE_DIAGNOSTICS_CONFIG_ENABLE_SHADER_ERROR_REPORTING_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostics_config"],
        ImpliesSets = [
            "VK_NV_device_diagnostics_config+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostics_config+VK_VERSION_1_1",
        ]
    )]
    VkDeviceDiagnosticsConfigEnableShaderErrorReportingBit = 0x00000008,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_DEVICE_DIAGNOSTICS_CONFIG_FLAG_BITS_MAX_ENUM_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_diagnostics_config"],
        ImpliesSets = [
            "VK_NV_device_diagnostics_config+VK_KHR_get_physical_device_properties2",
            "VK_NV_device_diagnostics_config+VK_VERSION_1_1",
        ]
    )]
    VkDeviceDiagnosticsConfigFlagBitsMaxEnum = 0x7FFFFFFF,
}
