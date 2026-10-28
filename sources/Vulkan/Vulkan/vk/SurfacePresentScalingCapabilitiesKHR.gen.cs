// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSurfacePresentScalingCapabilitiesKHR")]
public unsafe partial struct SurfacePresentScalingCapabilitiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.SurfacePresentScalingCapabilitiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("supportedPresentScaling")]
    public PresentScalingFlagsKHR SupportedPresentScaling;

    [NativeName("supportedPresentGravityX")]
    public PresentGravityFlagsKHR SupportedPresentGravityX;

    [NativeName("supportedPresentGravityY")]
    public PresentGravityFlagsKHR SupportedPresentGravityY;

    [NativeName("minScaledImageExtent")]
    public Extent2D MinScaledImageExtent;

    [NativeName("maxScaledImageExtent")]
    public Extent2D MaxScaledImageExtent;

    public SurfacePresentScalingCapabilitiesKHR() { }
}
