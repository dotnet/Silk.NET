// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NameSuffix("ARM", 0)]
[NativeName("VkDataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct DataGraphPipelineConstantTensorSemiStructuredSparsityInfoARM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph", "VK_ARM_tensors"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"],
        RequireAll = true
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph", "VK_ARM_tensors"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"],
        RequireAll = true
    )]
    public void* PNext;

    [NativeName("dimension")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph", "VK_ARM_tensors"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"],
        RequireAll = true
    )]
    public uint Dimension;

    [NativeName("zeroCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph", "VK_ARM_tensors"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"],
        RequireAll = true
    )]
    public uint ZeroCount;

    [NativeName("groupSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph", "VK_ARM_tensors"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"],
        RequireAll = true
    )]
    public uint GroupSize;
}
