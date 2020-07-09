// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPerformanceParameterTypeINTEL")]
    public enum PerformanceParameterTypeINTEL
    {
        [NativeName("Name", "VK_PERFORMANCE_PARAMETER_TYPE_HW_COUNTERS_SUPPORTED_INTEL")]
        PerformanceParameterTypeHWCountersSupportedIntel = 0,
        [NativeName("Name", "VK_PERFORMANCE_PARAMETER_TYPE_STREAM_MARKER_VALID_BITS_INTEL")]
        PerformanceParameterTypeStreamMarkerValidBitsIntel = 1,
    }
}
