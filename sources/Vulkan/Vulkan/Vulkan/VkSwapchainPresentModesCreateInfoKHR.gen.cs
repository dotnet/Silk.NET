// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSwapchainPresentModesCreateInfoKHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkSwapchainPresentModesCreateInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    public void* PNext;

    [NativeName("presentModeCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    public uint PresentModeCount;

    [NativeName("pPresentModes")]
    [NativeTypeName("const VkPresentModeKHR *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain_maintenance1+VK_KHR_surface_maintenance1",
            "VK_KHR_swapchain_maintenance1+VK_KHR_swapchain",
        ]
    )]
    public VkPresentModeKHR* PPresentModes;
}
