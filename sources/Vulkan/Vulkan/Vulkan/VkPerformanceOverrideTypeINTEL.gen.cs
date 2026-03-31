// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "INTEL")]
[NativeName("VkPerformanceOverrideTypeINTEL")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkPerformanceOverrideTypeINTEL : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "INTEL")]
    [NativeName("VK_PERFORMANCE_OVERRIDE_TYPE_NULL_HARDWARE_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VkPerformanceOverrideTypeNullHardware = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "INTEL")]
    [NativeName("VK_PERFORMANCE_OVERRIDE_TYPE_FLUSH_GPU_CACHES_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VkPerformanceOverrideTypeFlushGpuCaches = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "INTEL")]
    [NativeName("VK_PERFORMANCE_OVERRIDE_TYPE_MAX_ENUM_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    VkPerformanceOverrideTypeMaxEnum = 0x7FFFFFFF,
}
