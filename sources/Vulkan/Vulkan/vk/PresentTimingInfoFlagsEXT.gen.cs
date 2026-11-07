// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPresentTimingInfoFlagsEXT")]
[Flags]
public enum PresentTimingInfoFlagsEXT : uint
{
    None = 0x0,

    [NativeName("VK_PRESENT_TIMING_INFO_PRESENT_AT_RELATIVE_TIME_BIT_EXT")]
    PresentAtRelativeTimeBit = 0x1,

    [NativeName("VK_PRESENT_TIMING_INFO_PRESENT_AT_NEAREST_REFRESH_CYCLE_BIT_EXT")]
    PresentAtNearestRefreshCycleBit = 0x2,
}
