// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDisplayProperties2KHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    public void* pNext;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_get_display_properties2"],
        ImpliesSets = ["VK_KHR_display"]
    )]
    public VkDisplayPropertiesKHR displayProperties;
}
