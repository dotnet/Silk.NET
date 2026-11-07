// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRenderingInfo")]
public unsafe partial struct RenderingInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.RenderingInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public RenderingFlags Flags;

    [NativeName("renderArea")]
    public Rect2D RenderArea;

    [NativeName("layerCount")]
    public uint LayerCount;

    [NativeName("viewMask")]
    public uint ViewMask;

    [NativeName("colorAttachmentCount")]
    public uint ColorAttachmentCount;

    [NativeName("pColorAttachments")]
    public RenderingAttachmentInfo* PColorAttachments;

    [NativeName("pDepthAttachment")]
    public RenderingAttachmentInfo* PDepthAttachment;

    [NativeName("pStencilAttachment")]
    public RenderingAttachmentInfo* PStencilAttachment;

    public RenderingInfo() { }
}
