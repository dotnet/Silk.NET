// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PresentIdKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    public uint SwapchainCount;

    [NativeTypeName("const uint64_t *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_id"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_VERSION_1_1",
        ]
    )]
    public ulong* PPresentIds;
}
