// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkTimeDomainEXT")]
    public enum TimeDomainEXT : int
    {
        [NativeName("Name", "VK_TIME_DOMAIN_DEVICE_EXT")]
        TimeDomainDeviceExt = 0,
        [NativeName("Name", "VK_TIME_DOMAIN_CLOCK_MONOTONIC_EXT")]
        TimeDomainClockMonotonicExt = 1,
        [NativeName("Name", "VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_EXT")]
        TimeDomainClockMonotonicRawExt = 2,
        [NativeName("Name", "VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT")]
        TimeDomainQueryPerformanceCounterExt = 3,
    }
}
