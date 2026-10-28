// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRenderingAttachmentInfo")]
public unsafe partial struct RenderingAttachmentInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.RenderingAttachmentInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("imageView")]
    public ImageViewHandle ImageView;

    [NativeName("imageLayout")]
    public ImageLayout ImageLayout;

    [NativeName("resolveMode")]
    public ResolveModeFlags ResolveMode;

    [NativeName("resolveImageView")]
    public ImageViewHandle ResolveImageView;

    [NativeName("resolveImageLayout")]
    public ImageLayout ResolveImageLayout;

    [NativeName("loadOp")]
    public AttachmentLoadOp LoadOp;

    [NativeName("storeOp")]
    public AttachmentStoreOp StoreOp;

    [NativeName("clearValue")]
    public ClearValue ClearValue;

    public RenderingAttachmentInfo() { }
}
