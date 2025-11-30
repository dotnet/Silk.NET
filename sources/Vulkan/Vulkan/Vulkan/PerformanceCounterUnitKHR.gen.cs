// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkPerformanceCounterUnitKHR")]
[SupportedApiProfile("vulkan")]
public enum PerformanceCounterUnitKHR : uint
{
    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_GENERIC_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    Generickhr = 0,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_PERCENTAGE_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    Percentagekhr = 1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_NANOSECONDS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    Nanosecondskhr = 2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_BYTES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    Byteskhr = 3,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_BYTES_PER_SECOND_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    BytesPerSecondkhr = 4,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_KELVIN_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    Kelvinkhr = 5,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_WATTS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    Wattskhr = 6,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_VOLTS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    Voltskhr = 7,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_AMPS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    Ampskhr = 8,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_HERTZ_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    Hertzkhr = 9,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_UNIT_CYCLES_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    Cycleskhr = 10,
}
