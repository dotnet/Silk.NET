// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPipelineViewportWScalingStateCreateInfoNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public uint viewportWScalingEnable;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public uint viewportCount;

    [NativeTypeName("const VkViewportWScalingNV *")]
    [SupportedApiProfile("vulkan", ["VK_NV_clip_space_w_scaling"])]
    public VkViewportWScalingNV* pViewportWScalings;
}
