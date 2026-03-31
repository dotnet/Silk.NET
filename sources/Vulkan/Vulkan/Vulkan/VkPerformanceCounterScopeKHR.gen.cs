// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "KHR")]
[NativeName("VkPerformanceCounterScopeKHR")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkPerformanceCounterScopeKHR : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_BUFFER_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VkPerformanceCounterScopeCommandBuffer = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PERFORMANCE_COUNTER_SCOPE_RENDER_PASS_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VkPerformanceCounterScopeRenderPass = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VkPerformanceCounterScopeCommand = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "KHR")]
    [NativeName("VK_PERFORMANCE_COUNTER_SCOPE_MAX_ENUM_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_performance_query"],
        ImpliesSets = [
            "VK_KHR_performance_query+VK_KHR_get_physical_device_properties2",
            "VK_KHR_performance_query+VK_VERSION_1_1",
        ]
    )]
    VkPerformanceCounterScopeMaxEnum = 0x7FFFFFFF,
}
