// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct SurfacePresentScalingCapabilitiesKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkPresentScalingFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public PresentScalingFlagsKHR SupportedPresentScaling;

    [NativeTypeName("VkPresentGravityFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public PresentGravityFlagsKHR SupportedPresentGravityX;

    [NativeTypeName("VkPresentGravityFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public PresentGravityFlagsKHR SupportedPresentGravityY;

    [SupportedApiProfile("vulkan")]
    public Extent2D MinScaledImageExtent;

    [SupportedApiProfile("vulkan")]
    public Extent2D MaxScaledImageExtent;
}
