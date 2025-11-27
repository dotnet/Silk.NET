// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("KHR", 0)]
[NativeName("VkPerformanceCounterStorageKHR")]
[SupportedApiProfile("vulkan")]
public enum PerformanceCounterStorageKHR : uint
{
    [NameSuffix("KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_STORAGE_INT32_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    Int32KHR = 0,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_STORAGE_INT64_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    Int64KHR = 1,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_STORAGE_UINT32_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    Uint32KHR = 2,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_STORAGE_UINT64_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    Uint64KHR = 3,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_STORAGE_FLOAT32_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    Float32KHR = 4,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_STORAGE_FLOAT64_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    Float64KHR = 5,
}
