// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPipelineViewportSwizzleStateCreateInfoNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public void* pNext;

    [NativeTypeName("VkPipelineViewportSwizzleStateCreateFlagsNV")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public uint flags;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public uint viewportCount;

    [NativeTypeName("const VkViewportSwizzleNV *")]
    [SupportedApiProfile("vulkan", ["VK_NV_viewport_swizzle"])]
    public VkViewportSwizzleNV* pViewportSwizzles;
}
