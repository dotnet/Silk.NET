// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPerformanceValueTypeINTEL")]
public enum PerformanceValueTypeINTEL : uint
{
    [NativeName("VK_PERFORMANCE_VALUE_TYPE_UINT32_INTEL")]
    Uint32 = 0,

    [NativeName("VK_PERFORMANCE_VALUE_TYPE_UINT64_INTEL")]
    Uint64 = 1,

    [NativeName("VK_PERFORMANCE_VALUE_TYPE_FLOAT_INTEL")]
    Float = 2,

    [NativeName("VK_PERFORMANCE_VALUE_TYPE_BOOL_INTEL")]
    Bool = 3,

    [NativeName("VK_PERFORMANCE_VALUE_TYPE_STRING_INTEL")]
    String = 4,
}
