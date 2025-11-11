// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum PerformanceValueTypeIntel : uint
{
    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    Uint32Intel = 0,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    Uint64Intel = 1,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    FloatIntel = 2,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    BoolIntel = 3,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    StringIntel = 4,
}
