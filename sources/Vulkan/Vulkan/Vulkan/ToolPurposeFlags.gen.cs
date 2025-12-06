// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum ToolPurposeFlags : uint
{
    None = 0x0,

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

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_EXT_tooling_info"],
        RequireAll = true
    )]
    DebugReportingBitEXT = 0x20,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_marker", "VK_EXT_tooling_info"],
        RequireAll = true
    )]
    DebugMarkersBitEXT = 0x40,

    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    ValidationBitEXT = ValidationBit,

    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    ProfilingBitEXT = ProfilingBit,

    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    TracingBitEXT = TracingBit,

    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    AdditionalFeaturesBitEXT = AdditionalFeaturesBit,

    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    ModifyingFeaturesBitEXT = ModifyingFeaturesBit,
}
