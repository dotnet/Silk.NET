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
        [Obsolete("Deprecated in favour of \"GenericKhr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_GENERIC_KHR")]
        PerformanceCounterUnitGenericKhr = 0,
        [Obsolete("Deprecated in favour of \"PercentageKhr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_PERCENTAGE_KHR")]
        PerformanceCounterUnitPercentageKhr = 1,
        [Obsolete("Deprecated in favour of \"NanosecondsKhr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_NANOSECONDS_KHR")]
        PerformanceCounterUnitNanosecondsKhr = 2,
        [Obsolete("Deprecated in favour of \"BytesKhr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_BYTES_KHR")]
        PerformanceCounterUnitBytesKhr = 3,
        [Obsolete("Deprecated in favour of \"BytesPerSecondKhr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_BYTES_PER_SECOND_KHR")]
        PerformanceCounterUnitBytesPerSecondKhr = 4,
        [Obsolete("Deprecated in favour of \"KelvinKhr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_KELVIN_KHR")]
        PerformanceCounterUnitKelvinKhr = 5,
        [Obsolete("Deprecated in favour of \"WattsKhr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_WATTS_KHR")]
        PerformanceCounterUnitWattsKhr = 6,
        [Obsolete("Deprecated in favour of \"VoltsKhr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_VOLTS_KHR")]
        PerformanceCounterUnitVoltsKhr = 7,
        [Obsolete("Deprecated in favour of \"AmpsKhr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_AMPS_KHR")]
        PerformanceCounterUnitAmpsKhr = 8,
        [Obsolete("Deprecated in favour of \"HertzKhr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_HERTZ_KHR")]
        PerformanceCounterUnitHertzKhr = 9,
        [Obsolete("Deprecated in favour of \"CyclesKhr\"")]
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_CYCLES_KHR")]
        PerformanceCounterUnitCyclesKhr = 10,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_GENERIC_KHR")]
        GenericKhr = 0,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_PERCENTAGE_KHR")]
        PercentageKhr = 1,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_NANOSECONDS_KHR")]
        NanosecondsKhr = 2,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_BYTES_KHR")]
        BytesKhr = 3,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_BYTES_PER_SECOND_KHR")]
        BytesPerSecondKhr = 4,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_KELVIN_KHR")]
        KelvinKhr = 5,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_WATTS_KHR")]
        WattsKhr = 6,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_VOLTS_KHR")]
        VoltsKhr = 7,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_AMPS_KHR")]
        AmpsKhr = 8,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_HERTZ_KHR")]
        HertzKhr = 9,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_UNIT_CYCLES_KHR")]
        CyclesKhr = 10,
    }
}
