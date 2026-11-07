// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRenderPassBeginInfo")]
public unsafe partial struct RenderPassBeginInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.RenderPassBeginInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("renderPass")]
    public RenderPassHandle RenderPass;

    [NativeName("framebuffer")]
    public FramebufferHandle Framebuffer;

    [NativeName("renderArea")]
    public Rect2D RenderArea;

    [NativeName("clearValueCount")]
    public uint ClearValueCount;

    [NativeName("pClearValues")]
    public ClearValue* PClearValues;

    public RenderPassBeginInfo() { }
}
