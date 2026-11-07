// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPerformanceOverrideTypeINTEL")]
[SupportedApiProfile("vulkan")]
public enum PerformanceOverrideTypeINTEL : uint
{
    [NativeName("VK_PERFORMANCE_OVERRIDE_TYPE_NULL_HARDWARE_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    NullHardware = 0,

    [NativeName("VK_PERFORMANCE_OVERRIDE_TYPE_FLUSH_GPU_CACHES_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    FlushGpuCaches = 1,
}
