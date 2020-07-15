// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPerformanceOverrideTypeINTEL")]
    public enum PerformanceOverrideTypeINTEL
    {
        [NativeName("Name", "VK_PERFORMANCE_OVERRIDE_TYPE_NULL_HARDWARE_INTEL")]
        PerformanceOverrideTypeNullHardwareIntel = 0,
        [NativeName("Name", "VK_PERFORMANCE_OVERRIDE_TYPE_FLUSH_GPU_CACHES_INTEL")]
        PerformanceOverrideTypeFlushGpuCachesIntel = 1,
    }
}
