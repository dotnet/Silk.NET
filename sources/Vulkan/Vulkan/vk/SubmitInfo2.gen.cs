// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSubmitInfo2")]
public unsafe partial struct SubmitInfo2
{
    [NativeName("sType")]
    public StructureType SType = StructureType.SubmitInfo2;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public SubmitFlags Flags;

    [NativeName("waitSemaphoreInfoCount")]
    public uint WaitSemaphoreInfoCount;

    [NativeName("pWaitSemaphoreInfos")]
    public SemaphoreSubmitInfo* PWaitSemaphoreInfos;

    [NativeName("commandBufferInfoCount")]
    public uint CommandBufferInfoCount;

    [NativeName("pCommandBufferInfos")]
    public CommandBufferSubmitInfo* PCommandBufferInfos;

    [NativeName("signalSemaphoreInfoCount")]
    public uint SignalSemaphoreInfoCount;

    [NativeName("pSignalSemaphoreInfos")]
    public SemaphoreSubmitInfo* PSignalSemaphoreInfos;

    public SubmitInfo2() { }
}
