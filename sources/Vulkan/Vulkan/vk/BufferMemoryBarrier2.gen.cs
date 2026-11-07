// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBufferMemoryBarrier2")]
public unsafe partial struct BufferMemoryBarrier2
{
    [NativeName("sType")]
    public StructureType SType = StructureType.BufferMemoryBarrier2;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("srcStageMask")]
    public PipelineStageFlags2 SrcStageMask;

    [NativeName("srcAccessMask")]
    public AccessFlags2 SrcAccessMask;

    [NativeName("dstStageMask")]
    public PipelineStageFlags2 DstStageMask;

    [NativeName("dstAccessMask")]
    public AccessFlags2 DstAccessMask;

    [NativeName("srcQueueFamilyIndex")]
    public uint SrcQueueFamilyIndex;

    [NativeName("dstQueueFamilyIndex")]
    public uint DstQueueFamilyIndex;

    [NativeName("buffer")]
    public BufferHandle Buffer;

    [NativeName("offset")]
    public ulong Offset;

    [NativeName("size")]
    public ulong Size;

    public BufferMemoryBarrier2() { }
}
