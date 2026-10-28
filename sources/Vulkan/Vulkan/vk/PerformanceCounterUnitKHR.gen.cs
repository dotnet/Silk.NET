// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPerformanceCounterUnitKHR")]
public enum PerformanceCounterUnitKHR : uint
{
    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_GENERIC_KHR")]
    Generic = 0,

    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_PERCENTAGE_KHR")]
    Percentage = 1,

    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_NANOSECONDS_KHR")]
    Nanoseconds = 2,

    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_BYTES_KHR")]
    Bytes = 3,

    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_BYTES_PER_SECOND_KHR")]
    BytesPerSecond = 4,

    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_KELVIN_KHR")]
    Kelvin = 5,

    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_WATTS_KHR")]
    Watts = 6,

    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_VOLTS_KHR")]
    Volts = 7,

    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_AMPS_KHR")]
    Amps = 8,

    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_HERTZ_KHR")]
    Hertz = 9,

    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_CYCLES_KHR")]
    Cycles = 10,
}
