// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkQueryPoolSamplingModeINTEL")]
[SupportedApiProfile("vulkan")]
public enum QueryPoolSamplingModeIntel : uint
{
    [NativeName("VK_QUERY_POOL_SAMPLING_MODE_MANUAL_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    ManualIntel = 0,
}
