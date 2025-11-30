// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "INTEL", 0)]
[NativeName("VkPerformanceValueTypeINTEL")]
[SupportedApiProfile("vulkan")]
public enum PerformanceValueTypeINTEL : uint
{
    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    Uint32INTEL = 0,

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("VK_PERFORMANCE_VALUE_TYPE_UINT64_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    Uint64INTEL = 1,

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("VK_PERFORMANCE_VALUE_TYPE_FLOAT_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    FloatINTEL = 2,

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("VK_PERFORMANCE_VALUE_TYPE_BOOL_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    BoolINTEL = 3,

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL")]
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    StringINTEL = 4,
}
