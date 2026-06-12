// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageStencilUsage2CreateInfoKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ImageStencilUsage2CreateInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_KHR_extended_flags+VK_EXT_separate_stencil_usage",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
        ],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.ImageStencilUsage2CreateInfoKHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_KHR_extended_flags+VK_EXT_separate_stencil_usage",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
        ],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("stencilUsage")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_KHR_extended_flags+VK_EXT_separate_stencil_usage",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
        ],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ]
    )]
    public ImageUsageFlags2KHR StencilUsage;

    [SupportedApiProfile(
        "vulkan",
        [
            "VK_KHR_extended_flags+VK_EXT_separate_stencil_usage",
            "VK_KHR_extended_flags+VK_VERSION_1_2",
        ],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ]
    )]
    public ImageStencilUsage2CreateInfoKHR() { }
}
