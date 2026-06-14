// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphOpticalFlowImageFormatInfoARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct DataGraphOpticalFlowImageFormatInfoARM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public StructureType SType = StructureType.DataGraphOpticalFlowImageFormatInfoARM;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public void* PNext;

    [NativeName("usage")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public DataGraphOpticalFlowImageUsageFlagsARM Usage;

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_optical_flow"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public DataGraphOpticalFlowImageFormatInfoARM() { }
}
