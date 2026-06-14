// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphTOSAQualityFlagBitsARM")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum DataGraphTosaQualityFlagsARM : uint
{
    None = 0x0,

    [NativeName("VK_DATA_GRAPH_TOSA_QUALITY_ACCELERATED_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_instruction_set_tosa"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    TosaQualityAccelerated = 0x1,

    [NativeName("VK_DATA_GRAPH_TOSA_QUALITY_CONFORMANT_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_instruction_set_tosa"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    TosaQualityConformant = 0x2,

    [NativeName("VK_DATA_GRAPH_TOSA_QUALITY_EXPERIMENTAL_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_instruction_set_tosa"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    TosaQualityExperimental = 0x4,

    [NativeName("VK_DATA_GRAPH_TOSA_QUALITY_DEPRECATED_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_instruction_set_tosa"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    TosaQualityDeprecated = 0x8,
}
