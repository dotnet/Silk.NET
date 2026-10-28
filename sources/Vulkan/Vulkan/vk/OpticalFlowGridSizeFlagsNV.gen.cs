// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkOpticalFlowGridSizeFlagsNV")]
[Flags]
public enum OpticalFlowGridSizeFlagsNV : uint
{
    [NativeName("VK_OPTICAL_FLOW_GRID_SIZE_UNKNOWN_NV")]
    SizeUnknown = 0x0,

    [NativeName("VK_OPTICAL_FLOW_GRID_SIZE_1X1_BIT_NV")]
    Size1x1Bit = 0x1,

    [NativeName("VK_OPTICAL_FLOW_GRID_SIZE_2X2_BIT_NV")]
    Size2x2Bit = 0x2,

    [NativeName("VK_OPTICAL_FLOW_GRID_SIZE_4X4_BIT_NV")]
    Size4x4Bit = 0x4,

    [NativeName("VK_OPTICAL_FLOW_GRID_SIZE_8X8_BIT_NV")]
    Size8x8Bit = 0x8,
}
