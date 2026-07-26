// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkTimeDomainKHR")]
    public enum TimeDomainKHR : int
    {
        [Obsolete("Deprecated in favour of \"DeviceKhr\"")]
        [NativeName("Name", "VK_TIME_DOMAIN_DEVICE_KHR")]
        TimeDomainDeviceKhr = 0,
        [Obsolete("Deprecated in favour of \"ClockMonotonicKhr\"")]
        [NativeName("Name", "VK_TIME_DOMAIN_CLOCK_MONOTONIC_KHR")]
        TimeDomainClockMonotonicKhr = 1,
        [Obsolete("Deprecated in favour of \"ClockMonotonicRawKhr\"")]
        [NativeName("Name", "VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_KHR")]
        TimeDomainClockMonotonicRawKhr = 2,
        [Obsolete("Deprecated in favour of \"QueryPerformanceCounterKhr\"")]
        [NativeName("Name", "VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_KHR")]
        TimeDomainQueryPerformanceCounterKhr = 3,
        [Obsolete("Deprecated in favour of \"PresentStageLocalExt\"")]
        [NativeName("Name", "VK_TIME_DOMAIN_PRESENT_STAGE_LOCAL_EXT")]
        TimeDomainPresentStageLocalExt = 1000208000,
        [Obsolete("Deprecated in favour of \"SwapchainLocalExt\"")]
        [NativeName("Name", "VK_TIME_DOMAIN_SWAPCHAIN_LOCAL_EXT")]
        TimeDomainSwapchainLocalExt = 1000208001,
        [NativeName("Name", "VK_TIME_DOMAIN_DEVICE_KHR")]
        DeviceKhr = 0,
        [NativeName("Name", "VK_TIME_DOMAIN_CLOCK_MONOTONIC_KHR")]
        ClockMonotonicKhr = 1,
        [NativeName("Name", "VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_KHR")]
        ClockMonotonicRawKhr = 2,
        [NativeName("Name", "VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_KHR")]
        QueryPerformanceCounterKhr = 3,
        [NativeName("Name", "VK_TIME_DOMAIN_PRESENT_STAGE_LOCAL_EXT")]
        PresentStageLocalExt = 1000208000,
        [NativeName("Name", "VK_TIME_DOMAIN_SWAPCHAIN_LOCAL_EXT")]
        SwapchainLocalExt = 1000208001,
    }
}
