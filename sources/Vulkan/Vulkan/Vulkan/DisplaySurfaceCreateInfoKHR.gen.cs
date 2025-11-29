// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkDisplaySurfaceCreateInfoKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct DisplaySurfaceCreateInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public void* PNext;

    [NativeName("flags")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public uint Flags;

    [NativeName("displayMode")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public DisplayModeKHR DisplayMode;

    [NativeName("planeIndex")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public uint PlaneIndex;

    [NativeName("planeStackIndex")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public uint PlaneStackIndex;

    [NativeName("transform")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public SurfaceTransformFlagsKHR Transform;

    [NativeName("globalAlpha")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public float GlobalAlpha;

    [NativeName("alphaMode")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public DisplayPlaneAlphaFlagsKHR AlphaMode;

    [NativeName("imageExtent")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public Extent2D ImageExtent;
}
