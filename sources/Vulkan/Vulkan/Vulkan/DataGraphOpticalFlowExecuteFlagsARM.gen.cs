// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphOpticalFlowExecuteFlagBitsARM")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum DataGraphOpticalFlowExecuteFlagsARM : uint
{
    None = 0x0,

    [NativeName("VK_DATA_GRAPH_OPTICAL_FLOW_EXECUTE_DISABLE_TEMPORAL_HINTS_BIT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    DisableTemporalHintsBit = 0x1,

    [NativeName("VK_DATA_GRAPH_OPTICAL_FLOW_EXECUTE_INPUT_UNCHANGED_BIT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    InputUnchangedBit = 0x2,

    [NativeName("VK_DATA_GRAPH_OPTICAL_FLOW_EXECUTE_REFERENCE_UNCHANGED_BIT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    ReferenceUnchangedBit = 0x4,

    [NativeName("VK_DATA_GRAPH_OPTICAL_FLOW_EXECUTE_INPUT_IS_PREVIOUS_REFERENCE_BIT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    InputIsPreviousReferenceBit = 0x8,

    [NativeName("VK_DATA_GRAPH_OPTICAL_FLOW_EXECUTE_REFERENCE_IS_PREVIOUS_INPUT_BIT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    ReferenceIsPreviousInputBit = 0x10,
}
