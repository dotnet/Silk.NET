// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_subgroup_uniform_control_flow"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_subgroup_uniform_control_flow"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_shader_subgroup_uniform_control_flow"],
        ImpliesSets = ["VK_VERSION_1_1"]
    )]
    public uint shaderSubgroupUniformControlFlow;
}
