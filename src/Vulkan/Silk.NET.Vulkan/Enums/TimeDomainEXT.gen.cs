// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkTimeDomainEXT")]
    public enum TimeDomainEXT : int
    {
        [Obsolete("Deprecated in favour of \"DeviceExt\"")]
        [NativeName("Name", "VK_TIME_DOMAIN_DEVICE_EXT")]
        TimeDomainDeviceExt = 0,
        [Obsolete("Deprecated in favour of \"ClockMonotonicExt\"")]
        [NativeName("Name", "VK_TIME_DOMAIN_CLOCK_MONOTONIC_EXT")]
        TimeDomainClockMonotonicExt = 1,
        [Obsolete("Deprecated in favour of \"ClockMonotonicRawExt\"")]
        [NativeName("Name", "VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_EXT")]
        TimeDomainClockMonotonicRawExt = 2,
        [Obsolete("Deprecated in favour of \"QueryPerformanceCounterExt\"")]
        [NativeName("Name", "VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT")]
        TimeDomainQueryPerformanceCounterExt = 3,
        [NativeName("Name", "VK_TIME_DOMAIN_DEVICE_EXT")]
        DeviceExt = 0,
        [NativeName("Name", "VK_TIME_DOMAIN_CLOCK_MONOTONIC_EXT")]
        ClockMonotonicExt = 1,
        [NativeName("Name", "VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_EXT")]
        ClockMonotonicRawExt = 2,
        [NativeName("Name", "VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT")]
        QueryPerformanceCounterExt = 3,
    }
}
