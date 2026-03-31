// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceSurfaceInfo2KHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceSurfaceInfo2KHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_surface_capabilities2"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_surface_capabilities2"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    public void* PNext;

    [NativeName("surface")]
    [NativeTypeName("VkSurfaceKHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_surface_capabilities2"],
        ImpliesSets = ["VK_KHR_surface"]
    )]
    public VkSurfaceHandleKHR Surface;
}
