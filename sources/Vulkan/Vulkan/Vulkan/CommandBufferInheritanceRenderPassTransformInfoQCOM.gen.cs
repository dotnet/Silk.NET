// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct CommandBufferInheritanceRenderPassTransformInfoQCOM
{
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    public void* PNext;

    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    public SurfaceTransformFlagsKHR Transform;

    [SupportedApiProfile("vulkan", ["VK_QCOM_render_pass_transform"])]
    public Rect2D RenderArea;
}
