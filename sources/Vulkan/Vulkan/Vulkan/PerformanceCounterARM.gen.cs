// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPerformanceCounterARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PerformanceCounterARM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("counterID")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_performance_counters_by_region"],
        ImpliesSets = [
            "VK_ARM_performance_counters_by_region+VK_KHR_get_physical_device_properties2",
            "VK_ARM_performance_counters_by_region+VK_VERSION_1_1",
        ]
    )]
    public uint CounterID;
}
