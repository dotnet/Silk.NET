// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPerformanceParameterTypeINTEL")]
    public enum PerformanceParameterTypeINTEL : int
    {
        [Obsolete("Deprecated in favour of \"HWCountersSupportedIntel\"")]
        [NativeName("Name", "VK_PERFORMANCE_PARAMETER_TYPE_HW_COUNTERS_SUPPORTED_INTEL")]
        PerformanceParameterTypeHWCountersSupportedIntel = 0,
        [Obsolete("Deprecated in favour of \"StreamMarkerValidBitsIntel\"")]
        [NativeName("Name", "VK_PERFORMANCE_PARAMETER_TYPE_STREAM_MARKER_VALID_BITS_INTEL")]
        PerformanceParameterTypeStreamMarkerValidBitsIntel = 1,
        [NativeName("Name", "VK_PERFORMANCE_PARAMETER_TYPE_HW_COUNTERS_SUPPORTED_INTEL")]
        HWCountersSupportedIntel = 0,
        [NativeName("Name", "VK_PERFORMANCE_PARAMETER_TYPE_STREAM_MARKER_VALID_BITS_INTEL")]
        StreamMarkerValidBitsIntel = 1,
    }
}
