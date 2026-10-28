// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAttachmentDescription2")]
public unsafe partial struct AttachmentDescription2
{
    [NativeName("sType")]
    public StructureType SType = StructureType.AttachmentDescription2;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public AttachmentDescriptionFlags Flags;

    [NativeName("format")]
    public Format Format;

    [NativeName("samples")]
    public SampleCountFlags Samples;

    [NativeName("loadOp")]
    public AttachmentLoadOp LoadOp;

    [NativeName("storeOp")]
    public AttachmentStoreOp StoreOp;

    [NativeName("stencilLoadOp")]
    public AttachmentLoadOp StencilLoadOp;

    [NativeName("stencilStoreOp")]
    public AttachmentStoreOp StencilStoreOp;

    [NativeName("initialLayout")]
    public ImageLayout InitialLayout;

    [NativeName("finalLayout")]
    public ImageLayout FinalLayout;

    public AttachmentDescription2() { }
}
