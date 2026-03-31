// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDataGraphPipelineSessionBindPointRequirementARM")]
[NameAffix("Suffix", "KhronosVendor", "ARM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDataGraphPipelineSessionBindPointRequirementARM
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    public void* PNext;

    [NativeName("bindPoint")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    public VkDataGraphPipelineSessionBindPointARM BindPoint;

    [NativeName("bindPointType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    public VkDataGraphPipelineSessionBindPointTypeARM BindPointType;

    [NativeName("numObjects")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    public uint NumObjects;
}
