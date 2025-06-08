// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkSurfacePresentModeEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    public void* pNext;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_surface_maintenance1"],
        ImpliesSets = ["VK_KHR_get_surface_capabilities2", "VK_KHR_surface"]
    )]
    public VkPresentModeKHR presentMode;
}
