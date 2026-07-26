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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ValidationBit\"")]
        [NativeName("Name", "VK_TOOL_PURPOSE_VALIDATION_BIT")]
        ToolPurposeValidationBit = 1,
        [Obsolete("Deprecated in favour of \"ProfilingBit\"")]
        [NativeName("Name", "VK_TOOL_PURPOSE_PROFILING_BIT")]
        ToolPurposeProfilingBit = 2,
        [Obsolete("Deprecated in favour of \"TracingBit\"")]
        [NativeName("Name", "VK_TOOL_PURPOSE_TRACING_BIT")]
        ToolPurposeTracingBit = 4,
        [Obsolete("Deprecated in favour of \"AdditionalFeaturesBit\"")]
        [NativeName("Name", "VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT")]
        ToolPurposeAdditionalFeaturesBit = 8,
        [Obsolete("Deprecated in favour of \"ModifyingFeaturesBit\"")]
        [NativeName("Name", "VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT")]
        ToolPurposeModifyingFeaturesBit = 16,
        [NativeName("Name", "VK_TOOL_PURPOSE_VALIDATION_BIT")]
        ValidationBit = 1,
        [NativeName("Name", "VK_TOOL_PURPOSE_PROFILING_BIT")]
        ProfilingBit = 2,
        [NativeName("Name", "VK_TOOL_PURPOSE_TRACING_BIT")]
        TracingBit = 4,
        [NativeName("Name", "VK_TOOL_PURPOSE_ADDITIONAL_FEATURES_BIT")]
        AdditionalFeaturesBit = 8,
        [NativeName("Name", "VK_TOOL_PURPOSE_MODIFYING_FEATURES_BIT")]
        ModifyingFeaturesBit = 16,
    }
}
