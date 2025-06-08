// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
{
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    public VkStructureType sType;

    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    public void* pNext;

    [NativeTypeName("VkSurfaceTransformFlagBitsKHR")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    public VkSurfaceTransformFlagsKHR transform;

    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    public VkRect2D renderArea;
}
