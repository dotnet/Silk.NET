// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkToolPurposeFlags")]
    public enum ToolPurposeFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ValidationBit\"")]
        [NativeName("Name", "VK_TOOL_PURPOSE_VALIDATION_BIT")]
        ToolPurposeValidationBit = 1,
        [Obsolete("Deprecated in favour of \"ValidationBitExt\"")]
        [NativeName("Name", "VK_TOOL_PURPOSE_VALIDATION_BIT_EXT")]
        ToolPurposeValidationBitExt = 1,
        [Obsolete("Deprecated in favour of \"ProfilingBit\"")]
        [NativeName("Name", "VK_TOOL_PURPOSE_PROFILING_BIT")]
        ToolPurposeProfilingBit = 2,
        [Obsolete("Deprecated in favour of \"ProfilingBitExt\"")]
        [NativeName("Name", "VK_TOOL_PURPOSE_PROFILING_BIT_EXT")]
        ToolPurposeProfilingBitExt = 2,
        [Obsolete("Deprecated in favour of \"TracingBit\"")]
        [NativeName("Name", "VK_TOOL_PURPOSE_TRACING_BIT")]
        ToolPurposeTracingBit = 4,
        [Obsolete("Deprecated in favour of \"TracingBitExt\"")]
        [NativeName("Name", "VK_TOOL_PURPOSE_TRACING_BIT_EXT")]
        ToolPurposeTracingBitExt = 4,
        [Obsolete("Deprecated in favour of \"AdditionalFeaturesBit\"")]
        [NativeName("Name", "VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT")]
        ToolPurposeAdditionalFeaturesBit = 8,
        [Obsolete("Deprecated in favour of \"AdditionalFeaturesBitExt\"")]
        [NativeName("Name", "VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT_EXT")]
        ToolPurposeAdditionalFeaturesBitExt = 8,
        [Obsolete("Deprecated in favour of \"ModifyingFeaturesBit\"")]
        [NativeName("Name", "VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT")]
        ToolPurposeModifyingFeaturesBit = 16,
        [Obsolete("Deprecated in favour of \"ModifyingFeaturesBitExt\"")]
        [NativeName("Name", "VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT_EXT")]
        ToolPurposeModifyingFeaturesBitExt = 16,
        [Obsolete("Deprecated in favour of \"DebugReportingBitExt\"")]
        [NativeName("Name", "VK_TOOL_PURPOSE_DEBUG_REPORTING_BIT_EXT")]
        ToolPurposeDebugReportingBitExt = 32,
        [Obsolete("Deprecated in favour of \"DebugMarkersBitExt\"")]
        [NativeName("Name", "VK_TOOL_PURPOSE_DEBUG_MARKERS_BIT_EXT")]
        ToolPurposeDebugMarkersBitExt = 64,
        [NativeName("Name", "VK_TOOL_PURPOSE_VALIDATION_BIT")]
        ValidationBit = 1,
        [NativeName("Name", "VK_TOOL_PURPOSE_VALIDATION_BIT_EXT")]
        ValidationBitExt = 1,
        [NativeName("Name", "VK_TOOL_PURPOSE_PROFILING_BIT")]
        ProfilingBit = 2,
        [NativeName("Name", "VK_TOOL_PURPOSE_PROFILING_BIT_EXT")]
        ProfilingBitExt = 2,
        [NativeName("Name", "VK_TOOL_PURPOSE_TRACING_BIT")]
        TracingBit = 4,
        [NativeName("Name", "VK_TOOL_PURPOSE_TRACING_BIT_EXT")]
        TracingBitExt = 4,
        [NativeName("Name", "VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT")]
        AdditionalFeaturesBit = 8,
        [NativeName("Name", "VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT_EXT")]
        AdditionalFeaturesBitExt = 8,
        [NativeName("Name", "VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT")]
        ModifyingFeaturesBit = 16,
        [NativeName("Name", "VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT_EXT")]
        ModifyingFeaturesBitExt = 16,
        [NativeName("Name", "VK_TOOL_PURPOSE_DEBUG_REPORTING_BIT_EXT")]
        DebugReportingBitExt = 32,
        [NativeName("Name", "VK_TOOL_PURPOSE_DEBUG_MARKERS_BIT_EXT")]
        DebugMarkersBitExt = 64,
    }
}
