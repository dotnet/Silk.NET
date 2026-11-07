// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPresentInfoKHR")]
public unsafe partial struct PresentInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PresentInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("waitSemaphoreCount")]
    public uint WaitSemaphoreCount;

    [NativeName("pWaitSemaphores")]
    public SemaphoreHandle* PWaitSemaphores;

    [NativeName("swapchainCount")]
    public uint SwapchainCount;

    [NativeName("pSwapchains")]
    public SwapchainHandleKHR* PSwapchains;

    [NativeName("pImageIndices")]
    public uint* PImageIndices;

    [NativeName("pResults")]
    public Result* PResults;

    public PresentInfoKHR() { }
}
