// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("KHR", 0)]
[NativeName("VkPerformanceCounterScopeKHR")]
[SupportedApiProfile("vulkan")]
public enum PerformanceCounterScopeKHR : uint
{
    [NameSuffix("KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_BUFFER_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    CommandBufferKHR = 0,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_SCOPE_RENDER_PASS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    RenderPassKHR = 1,

    [NameSuffix("KHR", 0)]
    [NativeName("VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    CommandKHR = 2,
}
