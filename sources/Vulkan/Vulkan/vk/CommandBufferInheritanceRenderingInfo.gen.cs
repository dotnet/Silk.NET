// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCommandBufferInheritanceRenderingInfo")]
public unsafe partial struct CommandBufferInheritanceRenderingInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.CommandBufferInheritanceRenderingInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public RenderingFlags Flags;

    [NativeName("viewMask")]
    public uint ViewMask;

    [NativeName("colorAttachmentCount")]
    public uint ColorAttachmentCount;

    [NativeName("pColorAttachmentFormats")]
    public Format* PColorAttachmentFormats;

    [NativeName("depthAttachmentFormat")]
    public Format DepthAttachmentFormat;

    [NativeName("stencilAttachmentFormat")]
    public Format StencilAttachmentFormat;

    [NativeName("rasterizationSamples")]
    public SampleCountFlags RasterizationSamples;

    public CommandBufferInheritanceRenderingInfo() { }
}
