// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkRayTracingPipelineClusterAccelerationStructureCreateInfoNV
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline", "VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline", "VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_ray_tracing_pipeline", "VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    public uint allowClusterAccelerationStructure;
}
