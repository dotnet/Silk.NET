// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSwapchainPresentModesCreateInfoKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct SwapchainPresentModesCreateInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.SwapchainPresentModesCreateInfoKHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("presentModeCount")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    public uint PresentModeCount;

    [NativeName("pPresentModes")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    public PresentModeKHR* PPresentModes;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain_maintenance1"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_surface_maintenance1+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_KHR_surface_maintenance1+VK_VERSION_1_1",
        ]
    )]
    public SwapchainPresentModesCreateInfoKHR() { }
}
