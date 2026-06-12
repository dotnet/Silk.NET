// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphOpticalFlowGridSizeFlagBitsARM")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum DataGraphOpticalFlowGridSizeFlagsARM : uint
{
    [NativeName("VK_DATA_GRAPH_OPTICAL_FLOW_GRID_SIZE_UNKNOWN_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    SizeUnknown = 0x0,

    [NativeName("VK_DATA_GRAPH_OPTICAL_FLOW_GRID_SIZE_1X1_BIT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    Size1x1Bit = 0x1,

    [NativeName("VK_DATA_GRAPH_OPTICAL_FLOW_GRID_SIZE_2X2_BIT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    Size2x2Bit = 0x2,

    [NativeName("VK_DATA_GRAPH_OPTICAL_FLOW_GRID_SIZE_4X4_BIT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    Size4x4Bit = 0x4,

    [NativeName("VK_DATA_GRAPH_OPTICAL_FLOW_GRID_SIZE_8X8_BIT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    Size8x8Bit = 0x8,
}
