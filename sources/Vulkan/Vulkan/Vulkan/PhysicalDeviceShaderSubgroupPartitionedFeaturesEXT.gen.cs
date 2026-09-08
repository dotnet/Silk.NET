// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderSubgroupPartitionedFeaturesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceShaderSubgroupPartitionedFeaturesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_subgroup_partitioned"],
        ImpliesSets = [
            "VK_EXT_shader_subgroup_partitioned+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_subgroup_partitioned+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.PhysicalDeviceShaderSubgroupPartitionedFeaturesEXT;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_subgroup_partitioned"],
        ImpliesSets = [
            "VK_EXT_shader_subgroup_partitioned+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_subgroup_partitioned+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("shaderSubgroupPartitioned")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_subgroup_partitioned"],
        ImpliesSets = [
            "VK_EXT_shader_subgroup_partitioned+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_subgroup_partitioned+VK_VERSION_1_1",
        ]
    )]
    public MaybeBool<uint> ShaderSubgroupPartitioned;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_subgroup_partitioned"],
        ImpliesSets = [
            "VK_EXT_shader_subgroup_partitioned+VK_KHR_get_physical_device_properties2",
            "VK_EXT_shader_subgroup_partitioned+VK_VERSION_1_1",
        ]
    )]
    public PhysicalDeviceShaderSubgroupPartitionedFeaturesEXT() { }
}
