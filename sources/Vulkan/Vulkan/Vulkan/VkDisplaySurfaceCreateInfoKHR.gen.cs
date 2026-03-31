// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDisplaySurfaceCreateInfoKHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDisplaySurfaceCreateInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public void* PNext;

    [NativeName("flags")]
    [NativeTypeName("VkDisplaySurfaceCreateFlagsKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public uint Flags;

    [NativeName("displayMode")]
    [NativeTypeName("VkDisplayModeKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkDisplayModeHandleKHR DisplayMode;

    [NativeName("planeIndex")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public uint PlaneIndex;

    [NativeName("planeStackIndex")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public uint PlaneStackIndex;

    [NativeName("transform")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkSurfaceTransformFlagsKHR Transform;

    [NativeName("globalAlpha")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public float GlobalAlpha;

    [NativeName("alphaMode")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkDisplayPlaneAlphaFlagsKHR AlphaMode;

    [NativeName("imageExtent")]
    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    public VkExtent2D ImageExtent;
}
