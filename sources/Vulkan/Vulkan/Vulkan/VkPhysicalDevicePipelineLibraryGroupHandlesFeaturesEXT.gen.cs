// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_library_group_handles"],
        ImpliesSets = ["VK_KHR_pipeline_library", "VK_KHR_ray_tracing_pipeline"]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_library_group_handles"],
        ImpliesSets = ["VK_KHR_pipeline_library", "VK_KHR_ray_tracing_pipeline"]
    )]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_pipeline_library_group_handles"],
        ImpliesSets = ["VK_KHR_pipeline_library", "VK_KHR_ray_tracing_pipeline"]
    )]
    public uint pipelineLibraryGroupHandles;
}
