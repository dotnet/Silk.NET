// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSwapchainPresentScalingCreateInfoKHR")]
public unsafe partial struct SwapchainPresentScalingCreateInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.SwapchainPresentScalingCreateInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("scalingBehavior")]
    public PresentScalingFlagsKHR ScalingBehavior;

    [NativeName("presentGravityX")]
    public PresentGravityFlagsKHR PresentGravityX;

    [NativeName("presentGravityY")]
    public PresentGravityFlagsKHR PresentGravityY;

    public SwapchainPresentScalingCreateInfoKHR() { }
}
