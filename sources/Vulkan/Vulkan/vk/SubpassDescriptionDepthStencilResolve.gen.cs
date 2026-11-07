// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSubpassDescriptionDepthStencilResolve")]
public unsafe partial struct SubpassDescriptionDepthStencilResolve
{
    [NativeName("sType")]
    public StructureType SType = StructureType.SubpassDescriptionDepthStencilResolve;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("depthResolveMode")]
    public ResolveModeFlags DepthResolveMode;

    [NativeName("stencilResolveMode")]
    public ResolveModeFlags StencilResolveMode;

    [NativeName("pDepthStencilResolveAttachment")]
    public AttachmentReference2* PDepthStencilResolveAttachment;

    public SubpassDescriptionDepthStencilResolve() { }
}
