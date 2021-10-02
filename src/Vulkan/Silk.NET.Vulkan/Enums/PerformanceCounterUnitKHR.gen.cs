// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPerformanceCounterUnitKHR")]
    public enum PerformanceCounterUnitKHR : int
    {
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_GENERIC_KHR")]
        PerformanceCounterUnitGenericKhr = 0,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_PERCENTAGE_KHR")]
        PerformanceCounterUnitPercentageKhr = 1,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_NANOSECONDS_KHR")]
        PerformanceCounterUnitNanosecondsKhr = 2,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_BYTES_KHR")]
        PerformanceCounterUnitBytesKhr = 3,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_BYTES_PER_SECOND_KHR")]
        PerformanceCounterUnitBytesPerSecondKhr = 4,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_KELVIN_KHR")]
        PerformanceCounterUnitKelvinKhr = 5,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_WATTS_KHR")]
        PerformanceCounterUnitWattsKhr = 6,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_VOLTS_KHR")]
        PerformanceCounterUnitVoltsKhr = 7,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_AMPS_KHR")]
        PerformanceCounterUnitAmpsKhr = 8,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_HERTZ_KHR")]
        PerformanceCounterUnitHertzKhr = 9,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_CYCLES_KHR")]
        PerformanceCounterUnitCyclesKhr = 10,
    }
}
