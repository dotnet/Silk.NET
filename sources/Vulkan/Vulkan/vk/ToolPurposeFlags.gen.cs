// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkToolPurposeFlags")]
[Flags]
public enum ToolPurposeFlags : uint
{
    None = 0x0,

    [NativeName("VK_TOOL_PURPOSE_VALIDATION_BIT")]
    ValidationBit = 0x1,

    [NativeName("VK_TOOL_PURPOSE_PROFILING_BIT")]
    ProfilingBit = 0x2,

    [NativeName("VK_TOOL_PURPOSE_TRACING_BIT")]
    TracingBit = 0x4,

    [NativeName("VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT")]
    AdditionalFeaturesBit = 0x8,

    [NativeName("VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT")]
    ModifyingFeaturesBit = 0x10,

    [NativeName("VK_TOOL_PURPOSE_DEBUG_REPORTING_BIT_EXT")]
    DebugReportingBitEXT = 0x20,

    [NativeName("VK_TOOL_PURPOSE_DEBUG_MARKERS_BIT_EXT")]
    DebugMarkersBitEXT = 0x40,

    [NativeName("VK_TOOL_PURPOSE_VALIDATION_BIT_EXT")]
    ValidationBitEXT = ValidationBit,

    [NativeName("VK_TOOL_PURPOSE_PROFILING_BIT_EXT")]
    ProfilingBitEXT = ProfilingBit,

    [NativeName("VK_TOOL_PURPOSE_TRACING_BIT_EXT")]
    TracingBitEXT = TracingBit,

    [NativeName("VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT_EXT")]
    AdditionalFeaturesBitEXT = AdditionalFeaturesBit,

    [NativeName("VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT_EXT")]
    ModifyingFeaturesBitEXT = ModifyingFeaturesBit,
}
