// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageMemoryBarrier")]
public unsafe partial struct ImageMemoryBarrier
{
    [NativeName("sType")]
    public StructureType SType = StructureType.ImageMemoryBarrier;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("srcAccessMask")]
    public AccessFlags SrcAccessMask;

    [NativeName("dstAccessMask")]
    public AccessFlags DstAccessMask;

    [NativeName("oldLayout")]
    public ImageLayout OldLayout;

    [NativeName("newLayout")]
    public ImageLayout NewLayout;

    [NativeName("srcQueueFamilyIndex")]
    public uint SrcQueueFamilyIndex;

    [NativeName("dstQueueFamilyIndex")]
    public uint DstQueueFamilyIndex;

    [NativeName("image")]
    public ImageHandle Image;

    [NativeName("subresourceRange")]
    public ImageSubresourceRange SubresourceRange;

    public ImageMemoryBarrier() { }
}
