// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPerformanceParameterTypeINTEL")]
[SupportedApiProfile("vulkan")]
public enum PerformanceParameterTypeINTEL : uint
{
    [NativeName("VK_PERFORMANCE_PARAMETER_TYPE_HW_COUNTERS_SUPPORTED_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    HwCountersSupported = 0,

    [NativeName("VK_PERFORMANCE_PARAMETER_TYPE_STREAM_MARKER_VALID_BITS_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    StreamMarkerValidBits = 1,
}
