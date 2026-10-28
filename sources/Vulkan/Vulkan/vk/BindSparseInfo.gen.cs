// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBindSparseInfo")]
public unsafe partial struct BindSparseInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.BindSparseInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("waitSemaphoreCount")]
    public uint WaitSemaphoreCount;

    [NativeName("pWaitSemaphores")]
    public SemaphoreHandle* PWaitSemaphores;

    [NativeName("bufferBindCount")]
    public uint BufferBindCount;

    [NativeName("pBufferBinds")]
    public SparseBufferMemoryBindInfo* PBufferBinds;

    [NativeName("imageOpaqueBindCount")]
    public uint ImageOpaqueBindCount;

    [NativeName("pImageOpaqueBinds")]
    public SparseImageOpaqueMemoryBindInfo* PImageOpaqueBinds;

    [NativeName("imageBindCount")]
    public uint ImageBindCount;

    [NativeName("pImageBinds")]
    public SparseImageMemoryBindInfo* PImageBinds;

    [NativeName("signalSemaphoreCount")]
    public uint SignalSemaphoreCount;

    [NativeName("pSignalSemaphores")]
    public SemaphoreHandle* PSignalSemaphores;

    public BindSparseInfo() { }
}
