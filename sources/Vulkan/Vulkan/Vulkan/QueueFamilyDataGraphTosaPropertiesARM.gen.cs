// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkQueueFamilyDataGraphTOSAPropertiesARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct QueueFamilyDataGraphTosaPropertiesARM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_instruction_set_tosa"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public StructureType SType = StructureType.QueueFamilyDataGraphTosaPropertiesARM;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_instruction_set_tosa"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public void* PNext;

    [NativeName("profileCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_instruction_set_tosa"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public uint ProfileCount;

    [NativeName("pProfiles")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_instruction_set_tosa"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public DataGraphTosaNameQualityARM* PProfiles;

    [NativeName("extensionCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_instruction_set_tosa"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public uint ExtensionCount;

    [NativeName("pExtensions")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_instruction_set_tosa"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public DataGraphTosaNameQualityARM* PExtensions;

    [NativeName("level")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_instruction_set_tosa"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public DataGraphTosaLevelARM Level;

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph_instruction_set_tosa"],
        ImpliesSets = ["VK_ARM_data_graph"]
    )]
    public QueueFamilyDataGraphTosaPropertiesARM() { }
}
