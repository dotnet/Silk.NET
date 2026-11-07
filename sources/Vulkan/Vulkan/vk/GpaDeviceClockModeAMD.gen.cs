// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGpaDeviceClockModeAMD")]
public enum GpaDeviceClockModeAMD : uint
{
    [NativeName("VK_GPA_DEVICE_CLOCK_MODE_DEFAULT_AMD")]
    Default = 0,

    [NativeName("VK_GPA_DEVICE_CLOCK_MODE_QUERY_AMD")]
    Query = 1,

    [NativeName("VK_GPA_DEVICE_CLOCK_MODE_PROFILING_AMD")]
    Profiling = 2,

    [NativeName("VK_GPA_DEVICE_CLOCK_MODE_MIN_MEMORY_AMD")]
    MinMemory = 3,

    [NativeName("VK_GPA_DEVICE_CLOCK_MODE_MIN_ENGINE_AMD")]
    MinEngine = 4,

    [NativeName("VK_GPA_DEVICE_CLOCK_MODE_PEAK_AMD")]
    Peak = 5,
}
