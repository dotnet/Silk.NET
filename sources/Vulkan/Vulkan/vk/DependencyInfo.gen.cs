// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDependencyInfo")]
public unsafe partial struct DependencyInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DependencyInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("dependencyFlags")]
    public DependencyFlags DependencyFlags;

    [NativeName("memoryBarrierCount")]
    public uint MemoryBarrierCount;

    [NativeName("pMemoryBarriers")]
    public MemoryBarrier2* PMemoryBarriers;

    [NativeName("bufferMemoryBarrierCount")]
    public uint BufferMemoryBarrierCount;

    [NativeName("pBufferMemoryBarriers")]
    public BufferMemoryBarrier2* PBufferMemoryBarriers;

    [NativeName("imageMemoryBarrierCount")]
    public uint ImageMemoryBarrierCount;

    [NativeName("pImageMemoryBarriers")]
    public ImageMemoryBarrier2* PImageMemoryBarriers;

    public DependencyInfo() { }
}
