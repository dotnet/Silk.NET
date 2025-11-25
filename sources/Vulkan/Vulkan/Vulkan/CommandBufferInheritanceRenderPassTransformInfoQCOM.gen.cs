// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCommandBufferInheritanceRenderPassTransformInfoQCOM")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct CommandBufferInheritanceRenderPassTransformInfoQCOM
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    public void* PNext;

    [NativeName("transform")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    public SurfaceTransformFlagsKHR Transform;

    [NativeName("renderArea")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    public Rect2D RenderArea;
}
