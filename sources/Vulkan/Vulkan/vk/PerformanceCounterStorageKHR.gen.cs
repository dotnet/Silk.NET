// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPerformanceCounterStorageKHR")]
public enum PerformanceCounterStorageKHR : uint
{
    [NativeName("VK_PERFORMANCE_COUNTER_STORAGE_INT32_KHR")]
    Int32 = 0,

    [NativeName("VK_PERFORMANCE_COUNTER_STORAGE_INT64_KHR")]
    Int64 = 1,

    [NativeName("VK_PERFORMANCE_COUNTER_STORAGE_UINT32_KHR")]
    Uint32 = 2,

    [NativeName("VK_PERFORMANCE_COUNTER_STORAGE_UINT64_KHR")]
    Uint64 = 3,

    [NativeName("VK_PERFORMANCE_COUNTER_STORAGE_FLOAT32_KHR")]
    Float32 = 4,

    [NativeName("VK_PERFORMANCE_COUNTER_STORAGE_FLOAT64_KHR")]
    Float64 = 5,
}
