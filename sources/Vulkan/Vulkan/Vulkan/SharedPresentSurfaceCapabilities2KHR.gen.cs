// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSharedPresentSurfaceCapabilities2KHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct SharedPresentSurfaceCapabilities2KHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_extended_flags", "VK_KHR_shared_presentable_image"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    public StructureType SType = StructureType.SharedPresentSurfaceCapabilities2KHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_extended_flags", "VK_KHR_shared_presentable_image"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    public void* PNext;

    [NativeName("sharedPresentSupportedUsageFlags")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_extended_flags", "VK_KHR_shared_presentable_image"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    public ImageUsageFlags2KHR SharedPresentSupportedUsageFlags;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_extended_flags", "VK_KHR_shared_presentable_image"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    public SharedPresentSurfaceCapabilities2KHR() { }
}
