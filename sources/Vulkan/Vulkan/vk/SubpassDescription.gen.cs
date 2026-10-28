// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSubpassDescription")]
public unsafe partial struct SubpassDescription
{
    [NativeName("flags")]
    public SubpassDescriptionFlags Flags;

    [NativeName("pipelineBindPoint")]
    public PipelineBindPoint PipelineBindPoint;

    [NativeName("inputAttachmentCount")]
    public uint InputAttachmentCount;

    [NativeName("pInputAttachments")]
    public AttachmentReference* PInputAttachments;

    [NativeName("colorAttachmentCount")]
    public uint ColorAttachmentCount;

    [NativeName("pColorAttachments")]
    public AttachmentReference* PColorAttachments;

    [NativeName("pResolveAttachments")]
    public AttachmentReference* PResolveAttachments;

    [NativeName("pDepthStencilAttachment")]
    public AttachmentReference* PDepthStencilAttachment;

    [NativeName("preserveAttachmentCount")]
    public uint PreserveAttachmentCount;

    [NativeName("pPreserveAttachments")]
    public uint* PPreserveAttachments;
}
