// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum ToolPurposeFlags : uint
{
    None = 0,

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
    ValidationBit = 0x00000001,

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
    ProfilingBit = 0x00000002,

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
    TracingBit = 0x00000004,

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
    AdditionalFeaturesBit = 0x00000008,

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
    ModifyingFeaturesBit = 0x00000010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_EXT_tooling_info"],
        RequireAll = true
    )]
    DebugReportingBitEXT = 0x00000020,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_marker", "VK_EXT_tooling_info"],
        RequireAll = true
    )]
    DebugMarkersBitEXT = 0x00000040,

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
