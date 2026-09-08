// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphTOSANameQualityARM")]
[SupportedApiProfile("vulkan")]
public partial struct DataGraphTosaNameQualityARM
{
    [NativeName("name")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_instruction_set_tosa"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public DataGraphTosaNameQualityARMName Name;

    [NativeName("qualityFlags")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_instruction_set_tosa"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public DataGraphTosaQualityFlagsARM QualityFlags;
}
