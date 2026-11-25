// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSurfaceFullScreenExclusiveWin32InfoEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct SurfaceFullScreenExclusiveWin32InfoEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_full_screen_exclusive", "VK_KHR_win32_surface"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    public StructureType SType = StructureType.SurfaceFullScreenExclusiveWin32InfoEXT;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_full_screen_exclusive", "VK_KHR_win32_surface"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    public void* PNext;

    [NativeName("hmonitor")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_full_screen_exclusive", "VK_KHR_win32_surface"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    public HmonitorHandle Hmonitor;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_full_screen_exclusive", "VK_KHR_win32_surface"],
        ImpliesSets = [
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_surface+VK_KHR_get_surface_capabilities2+VK_KHR_swapchain+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    public SurfaceFullScreenExclusiveWin32InfoEXT() { }
}
