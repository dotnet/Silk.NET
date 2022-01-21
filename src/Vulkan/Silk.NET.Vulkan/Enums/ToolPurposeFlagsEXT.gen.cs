// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkToolPurposeFlagsEXT")]
    public enum ToolPurposeFlagsEXT : int
    {
        [NativeName("Name", "VK_TOOL_PURPOSE_VALIDATION_BIT_EXT")]
        ToolPurposeValidationBitExt = 1,
        [NativeName("Name", "VK_TOOL_PURPOSE_PROFILING_BIT_EXT")]
        ToolPurposeProfilingBitExt = 2,
        [NativeName("Name", "VK_TOOL_PURPOSE_TRACING_BIT_EXT")]
        ToolPurposeTracingBitExt = 4,
        [NativeName("Name", "VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT_EXT")]
        ToolPurposeAdditionalFeaturesBitExt = 8,
        [NativeName("Name", "VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT_EXT")]
        ToolPurposeModifyingFeaturesBitExt = 16,
        [NativeName("Name", "VK_TOOL_PURPOSE_DEBUG_REPORTING_BIT_EXT")]
        ToolPurposeDebugReportingBitExt = 32,
        [NativeName("Name", "VK_TOOL_PURPOSE_DEBUG_MARKERS_BIT_EXT")]
        ToolPurposeDebugMarkersBitExt = 64,
    }
}
