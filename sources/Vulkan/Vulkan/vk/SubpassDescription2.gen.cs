// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSubpassDescription2")]
public unsafe partial struct SubpassDescription2
{
    [NativeName("sType")]
    public StructureType SType = StructureType.SubpassDescription2;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public SubpassDescriptionFlags Flags;

    [NativeName("pipelineBindPoint")]
    public PipelineBindPoint PipelineBindPoint;

    [NativeName("viewMask")]
    public uint ViewMask;

    [NativeName("inputAttachmentCount")]
    public uint InputAttachmentCount;

    [NativeName("pInputAttachments")]
    public AttachmentReference2* PInputAttachments;

    [NativeName("colorAttachmentCount")]
    public uint ColorAttachmentCount;

    [NativeName("pColorAttachments")]
    public AttachmentReference2* PColorAttachments;

    [NativeName("pResolveAttachments")]
    public AttachmentReference2* PResolveAttachments;

    [NativeName("pDepthStencilAttachment")]
    public AttachmentReference2* PDepthStencilAttachment;

    [NativeName("preserveAttachmentCount")]
    public uint PreserveAttachmentCount;

    [NativeName("pPreserveAttachments")]
    public uint* PPreserveAttachments;

    public SubpassDescription2() { }
}
