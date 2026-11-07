// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphOpticalFlowImageUsageFlagsARM")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum DataGraphOpticalFlowImageUsageFlagsARM : uint
{
    [NativeName("VK_DATA_GRAPH_OPTICAL_FLOW_IMAGE_USAGE_UNKNOWN_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    Unknown = 0x0,

    [NativeName("VK_DATA_GRAPH_OPTICAL_FLOW_IMAGE_USAGE_INPUT_BIT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    InputBit = 0x1,

    [NativeName("VK_DATA_GRAPH_OPTICAL_FLOW_IMAGE_USAGE_OUTPUT_BIT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    OutputBit = 0x2,

    [NativeName("VK_DATA_GRAPH_OPTICAL_FLOW_IMAGE_USAGE_HINT_BIT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    HintBit = 0x4,

    [NativeName("VK_DATA_GRAPH_OPTICAL_FLOW_IMAGE_USAGE_COST_BIT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    CostBit = 0x8,
}
