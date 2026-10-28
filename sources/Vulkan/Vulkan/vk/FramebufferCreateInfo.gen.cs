// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFramebufferCreateInfo")]
public unsafe partial struct FramebufferCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.FramebufferCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public FramebufferCreateFlags Flags;

    [NativeName("renderPass")]
    public RenderPassHandle RenderPass;

    [NativeName("attachmentCount")]
    public uint AttachmentCount;

    [NativeName("pAttachments")]
    public ImageViewHandle* PAttachments;

    [NativeName("width")]
    public uint Width;

    [NativeName("height")]
    public uint Height;

    [NativeName("layers")]
    public uint Layers;

    public FramebufferCreateInfo() { }
}
