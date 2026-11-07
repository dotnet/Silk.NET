// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRenderPassCreateInfo2")]
public unsafe partial struct RenderPassCreateInfo2
{
    [NativeName("sType")]
    public StructureType SType = StructureType.RenderPassCreateInfo2;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public RenderPassCreateFlags Flags;

    [NativeName("attachmentCount")]
    public uint AttachmentCount;

    [NativeName("pAttachments")]
    public AttachmentDescription2* PAttachments;

    [NativeName("subpassCount")]
    public uint SubpassCount;

    [NativeName("pSubpasses")]
    public SubpassDescription2* PSubpasses;

    [NativeName("dependencyCount")]
    public uint DependencyCount;

    [NativeName("pDependencies")]
    public SubpassDependency2* PDependencies;

    [NativeName("correlatedViewMaskCount")]
    public uint CorrelatedViewMaskCount;

    [NativeName("pCorrelatedViewMasks")]
    public uint* PCorrelatedViewMasks;

    public RenderPassCreateInfo2() { }
}
