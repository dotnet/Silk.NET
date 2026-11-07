// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkOpticalFlowUsageFlagsNV")]
[Flags]
public enum OpticalFlowUsageFlagsNV : uint
{
    [NativeName("VK_OPTICAL_FLOW_USAGE_UNKNOWN_NV")]
    Unknown = 0x0,

    [NativeName("VK_OPTICAL_FLOW_USAGE_INPUT_BIT_NV")]
    InputBit = 0x1,

    [NativeName("VK_OPTICAL_FLOW_USAGE_OUTPUT_BIT_NV")]
    OutputBit = 0x2,

    [NativeName("VK_OPTICAL_FLOW_USAGE_HINT_BIT_NV")]
    HintBit = 0x4,

    [NativeName("VK_OPTICAL_FLOW_USAGE_COST_BIT_NV")]
    CostBit = 0x8,

    [NativeName("VK_OPTICAL_FLOW_USAGE_GLOBAL_FLOW_BIT_NV")]
    GlobalFlowBit = 0x10,
}
