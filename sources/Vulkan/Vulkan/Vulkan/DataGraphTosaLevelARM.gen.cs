// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphTOSALevelARM")]
[SupportedApiProfile("vulkan")]
public enum DataGraphTosaLevelARM : uint
{
    [NativeName("VK_DATA_GRAPH_TOSA_LEVEL_NONE_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_instruction_set_tosa"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    TosaLevelNone = 0,

    [NativeName("VK_DATA_GRAPH_TOSA_LEVEL_8K_ARM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_instruction_set_tosa"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    TosaLevel8K = 1,
}
