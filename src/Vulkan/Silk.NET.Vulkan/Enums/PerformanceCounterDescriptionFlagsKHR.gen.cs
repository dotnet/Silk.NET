// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkPerformanceCounterDescriptionFlagsKHR")]
    public enum PerformanceCounterDescriptionFlagsKHR : int
    {
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_BIT_KHR")]
        PerformanceCounterDescriptionPerformanceImpactingBitKhr = 1,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_KHR")]
        PerformanceCounterDescriptionPerformanceImpactingKhr = 1,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_BIT_KHR")]
        PerformanceCounterDescriptionConcurrentlyImpactedBitKhr = 2,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_KHR")]
        PerformanceCounterDescriptionConcurrentlyImpactedKhr = 2,
    }
}
