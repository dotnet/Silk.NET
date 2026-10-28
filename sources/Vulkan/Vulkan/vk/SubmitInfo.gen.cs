// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSubmitInfo")]
public unsafe partial struct SubmitInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.SubmitInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("waitSemaphoreCount")]
    public uint WaitSemaphoreCount;

    [NativeName("pWaitSemaphores")]
    public SemaphoreHandle* PWaitSemaphores;

    [NativeName("pWaitDstStageMask")]
    public PipelineStageFlags* PWaitDstStageMask;

    [NativeName("commandBufferCount")]
    public uint CommandBufferCount;

    [NativeName("pCommandBuffers")]
    public CommandBufferHandle* PCommandBuffers;

    [NativeName("signalSemaphoreCount")]
    public uint SignalSemaphoreCount;

    [NativeName("pSignalSemaphores")]
    public SemaphoreHandle* PSignalSemaphores;

    public SubmitInfo() { }
}
