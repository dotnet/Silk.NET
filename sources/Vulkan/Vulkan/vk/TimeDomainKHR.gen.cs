// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkTimeDomainKHR")]
public enum TimeDomainKHR : uint
{
    [NativeName("VK_TIME_DOMAIN_DEVICE_KHR")]
    Device = 0,

    [NativeName("VK_TIME_DOMAIN_CLOCK_MONOTONIC_KHR")]
    ClockMonotonic = 1,

    [NativeName("VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_KHR")]
    ClockMonotonicRaw = 2,

    [NativeName("VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_KHR")]
    QueryPerformanceCounter = 3,

    [NativeName("VK_TIME_DOMAIN_PRESENT_STAGE_LOCAL_EXT")]
    PresentStageLocalEXT = 1000208000,

    [NativeName("VK_TIME_DOMAIN_SWAPCHAIN_LOCAL_EXT")]
    SwapchainLocalEXT = 1000208001,

    [NativeName("VK_TIME_DOMAIN_DEVICE_EXT")]
    DeviceEXT = Device,

    [NativeName("VK_TIME_DOMAIN_CLOCK_MONOTONIC_EXT")]
    ClockMonotonicEXT = ClockMonotonic,

    [NativeName("VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_EXT")]
    ClockMonotonicRawEXT = ClockMonotonicRaw,

    [NativeName("VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT")]
    QueryPerformanceCounterEXT = QueryPerformanceCounter,
}
