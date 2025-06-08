// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkToolPurposeFlags
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_TOOL_PURPOSE_VALIDATION_BIT = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_TOOL_PURPOSE_PROFILING_BIT = 0x00000002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_TOOL_PURPOSE_TRACING_BIT = 0x00000004,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT = 0x00000008,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT = 0x00000010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_EXT_tooling_info"],
        RequireAll = true
    )]
    VK_TOOL_PURPOSE_DEBUG_REPORTING_BIT_EXT = 0x00000020,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_marker", "VK_EXT_tooling_info"],
        RequireAll = true
    )]
    VK_TOOL_PURPOSE_DEBUG_MARKERS_BIT_EXT = 0x00000040,

    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    VK_TOOL_PURPOSE_VALIDATION_BIT_EXT = VK_TOOL_PURPOSE_VALIDATION_BIT,

    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    VK_TOOL_PURPOSE_PROFILING_BIT_EXT = VK_TOOL_PURPOSE_PROFILING_BIT,

    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    VK_TOOL_PURPOSE_TRACING_BIT_EXT = VK_TOOL_PURPOSE_TRACING_BIT,

    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT_EXT = VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT,

    [SupportedApiProfile("vulkan", ["VK_EXT_tooling_info"])]
    VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT_EXT = VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_TOOL_PURPOSE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}
