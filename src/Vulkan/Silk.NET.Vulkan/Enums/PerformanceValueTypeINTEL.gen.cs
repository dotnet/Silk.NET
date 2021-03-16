// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPerformanceValueTypeINTEL")]
    public enum PerformanceValueTypeINTEL : int
    {
        [NativeName("Name", "VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL")]
        PerformanceValueTypeUint32Intel = 0,
        [NativeName("Name", "VK_PERFORMANCE_VALUE_TYPE_UINT64_INTEL")]
        PerformanceValueTypeUint64Intel = 1,
        [NativeName("Name", "VK_PERFORMANCE_VALUE_TYPE_FLOAT_INTEL")]
        PerformanceValueTypeFloatIntel = 2,
        [NativeName("Name", "VK_PERFORMANCE_VALUE_TYPE_BOOL_INTEL")]
        PerformanceValueTypeBoolIntel = 3,
        [NativeName("Name", "VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL")]
        PerformanceValueTypeStringIntel = 4,
    }
}
