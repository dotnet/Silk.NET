// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkTimeDomainKHR")]
[SupportedApiProfile("vulkan")]
public enum TimeDomainKHR : uint
{
    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_TIME_DOMAIN_DEVICE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_calibrated_timestamps"],
        ImpliesSets = [
            "VK_KHR_calibrated_timestamps+VK_KHR_get_physical_device_properties2",
            "VK_KHR_calibrated_timestamps+VK_VERSION_1_1",
        ]
    )]
    DeviceKHR = 0,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_TIME_DOMAIN_CLOCK_MONOTONIC_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_calibrated_timestamps"],
        ImpliesSets = [
            "VK_KHR_calibrated_timestamps+VK_KHR_get_physical_device_properties2",
            "VK_KHR_calibrated_timestamps+VK_VERSION_1_1",
        ]
    )]
    ClockMonotonicKHR = 1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_calibrated_timestamps"],
        ImpliesSets = [
            "VK_KHR_calibrated_timestamps+VK_KHR_get_physical_device_properties2",
            "VK_KHR_calibrated_timestamps+VK_VERSION_1_1",
        ]
    )]
    ClockMonotonicRawKHR = 2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_calibrated_timestamps"],
        ImpliesSets = [
            "VK_KHR_calibrated_timestamps+VK_KHR_get_physical_device_properties2",
            "VK_KHR_calibrated_timestamps+VK_VERSION_1_1",
        ]
    )]
    QueryPerformanceCounterKHR = 3,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_TIME_DOMAIN_DEVICE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_calibrated_timestamps"],
        ImpliesSets = [
            "VK_EXT_calibrated_timestamps+VK_KHR_get_physical_device_properties2",
            "VK_EXT_calibrated_timestamps+VK_VERSION_1_1",
        ]
    )]
    DeviceEXT = DeviceKHR,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_TIME_DOMAIN_CLOCK_MONOTONIC_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_calibrated_timestamps"],
        ImpliesSets = [
            "VK_EXT_calibrated_timestamps+VK_KHR_get_physical_device_properties2",
            "VK_EXT_calibrated_timestamps+VK_VERSION_1_1",
        ]
    )]
    ClockMonotonicEXT = ClockMonotonicKHR,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_TIME_DOMAIN_CLOCK_MONOTONIC_RAW_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_calibrated_timestamps"],
        ImpliesSets = [
            "VK_EXT_calibrated_timestamps+VK_KHR_get_physical_device_properties2",
            "VK_EXT_calibrated_timestamps+VK_VERSION_1_1",
        ]
    )]
    ClockMonotonicRawEXT = ClockMonotonicRawKHR,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_TIME_DOMAIN_QUERY_PERFORMANCE_COUNTER_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_calibrated_timestamps"],
        ImpliesSets = [
            "VK_EXT_calibrated_timestamps+VK_KHR_get_physical_device_properties2",
            "VK_EXT_calibrated_timestamps+VK_VERSION_1_1",
        ]
    )]
    QueryPerformanceCounterEXT = QueryPerformanceCounterKHR,
}
