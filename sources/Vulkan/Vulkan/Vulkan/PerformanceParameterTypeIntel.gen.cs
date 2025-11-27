// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("INTEL", 0)]
[NativeName("VkPerformanceParameterTypeINTEL")]
[SupportedApiProfile("vulkan")]
public enum PerformanceParameterTypeIntel : uint
{
    [NameSuffix("INTEL", 0)]
    [NativeName("VK_PERFORMANCE_PARAMETER_TYPE_HW_COUNTERS_SUPPORTED_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    HwCountersSupportedIntel = 0,

    [NameSuffix("INTEL", 0)]
    [NativeName("VK_PERFORMANCE_PARAMETER_TYPE_STREAM_MARKER_VALID_BITS_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    StreamMarkerValidBitsIntel = 1,
}
