// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkToolPurposeFlagBits")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum ToolPurposeFlags : uint
{
    None = 0x0,

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
    ValidationBit = 0x1,

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
    ProfilingBit = 0x2,

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
    TracingBit = 0x4,

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
    AdditionalFeaturesBit = 0x8,

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
    ModifyingFeaturesBit = 0x10,

    [NativeName("VK_TOOL_PURPOSE_DEBUG_REPORTING_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_EXT_tooling_info"],
        RequireAll = true
    )]
    DebugReportingBitEXT = 0x20,

    [NativeName("VK_TOOL_PURPOSE_DEBUG_MARKERS_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_marker", "VK_EXT_tooling_info"],
        RequireAll = true
    )]
    DebugMarkersBitEXT = 0x40,

    [NativeName("VK_TOOL_PURPOSE_VALIDATION_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    ValidationBitEXT = ValidationBit,

    [NativeName("VK_TOOL_PURPOSE_PROFILING_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    ProfilingBitEXT = ProfilingBit,

    [NativeName("VK_TOOL_PURPOSE_TRACING_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    TracingBitEXT = TracingBit,

    [NativeName("VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    AdditionalFeaturesBitEXT = AdditionalFeaturesBit,

    [NativeName("VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    ModifyingFeaturesBitEXT = ModifyingFeaturesBit,
}
