// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkOpticalFlowPerformanceLevelNV")]
public enum OpticalFlowPerformanceLevelNV : uint
{
    [NativeName("VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_UNKNOWN_NV")]
    Unknown = 0,

    [NativeName("VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_SLOW_NV")]
    Slow = 1,

    [NativeName("VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_MEDIUM_NV")]
    Medium = 2,

    [NativeName("VK_OPTICAL_FLOW_PERFORMANCE_LEVEL_FAST_NV")]
    Fast = 3,
}
