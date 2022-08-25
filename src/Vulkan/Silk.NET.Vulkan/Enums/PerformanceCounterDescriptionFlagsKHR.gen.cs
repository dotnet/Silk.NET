// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPerformanceCounterDescriptionFlagsKHR")]
    public enum PerformanceCounterDescriptionFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"PerformanceImpactingBitKhr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_BIT_KHR")]
        PerformanceCounterDescriptionPerformanceImpactingBitKhr = 1,
        [Obsolete("Deprecated in favour of \"PerformanceImpactingKhr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_KHR")]
        PerformanceCounterDescriptionPerformanceImpactingKhr = 1,
        [Obsolete("Deprecated in favour of \"ConcurrentlyImpactedBitKhr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_BIT_KHR")]
        PerformanceCounterDescriptionConcurrentlyImpactedBitKhr = 2,
        [Obsolete("Deprecated in favour of \"ConcurrentlyImpactedKhr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_KHR")]
        PerformanceCounterDescriptionConcurrentlyImpactedKhr = 2,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_BIT_KHR")]
        PerformanceImpactingBitKhr = 1,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_DESCRIPTION_PERFORMANCE_IMPACTING_KHR")]
        PerformanceImpactingKhr = 1,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_BIT_KHR")]
        ConcurrentlyImpactedBitKhr = 2,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_DESCRIPTION_CONCURRENTLY_IMPACTED_KHR")]
        ConcurrentlyImpactedKhr = 2,
    }
}
