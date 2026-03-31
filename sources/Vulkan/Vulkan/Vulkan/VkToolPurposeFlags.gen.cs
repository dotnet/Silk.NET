// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkToolPurposeFlagBits")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkToolPurposeFlags : uint
{
    [NativeName("VK_TOOL_PURPOSE_VALIDATION_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkToolPurposeValidationBit = 0x00000001,

    [NativeName("VK_TOOL_PURPOSE_PROFILING_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkToolPurposeProfilingBit = 0x00000002,

    [NativeName("VK_TOOL_PURPOSE_TRACING_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkToolPurposeTracingBit = 0x00000004,

    [NativeName("VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkToolPurposeAdditionalFeaturesBit = 0x00000008,

    [NativeName("VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkToolPurposeModifyingFeaturesBit = 0x00000010,

    [NativeName("VK_TOOL_PURPOSE_DEBUG_REPORTING_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_EXT_tooling_info"],
        RequireAll = true
    )]
    VkToolPurposeDebugReportingBitEXT = 0x00000020,

    [NativeName("VK_TOOL_PURPOSE_DEBUG_MARKERS_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_marker", "VK_EXT_tooling_info"],
        RequireAll = true
    )]
    VkToolPurposeDebugMarkersBitEXT = 0x00000040,

    [NativeName("VK_TOOL_PURPOSE_VALIDATION_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    VkToolPurposeValidationBitEXT = VkToolPurposeValidationBit,

    [NativeName("VK_TOOL_PURPOSE_PROFILING_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    VkToolPurposeProfilingBitEXT = VkToolPurposeProfilingBit,

    [NativeName("VK_TOOL_PURPOSE_TRACING_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    VkToolPurposeTracingBitEXT = VkToolPurposeTracingBit,

    [NativeName("VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    VkToolPurposeAdditionalFeaturesBitEXT = VkToolPurposeAdditionalFeaturesBit,

    [NativeName("VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    VkToolPurposeModifyingFeaturesBitEXT = VkToolPurposeModifyingFeaturesBit,

    [NativeName("VK_TOOL_PURPOSE_FLAG_BITS_MAX_ENUM")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    VkToolPurposeFlagBitsMaxEnum = 0x7FFFFFFF,
}
