// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkFormatProperties4KHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct FormatProperties4KHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_extended_flags"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.FormatProperties4KHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_extended_flags"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("linearTilingFeatures")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_extended_flags"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ]
    )]
    public FormatFeatureFlags4KHR LinearTilingFeatures;

    [NativeName("optimalTilingFeatures")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_extended_flags"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ]
    )]
    public FormatFeatureFlags4KHR OptimalTilingFeatures;

    [NativeName("bufferFeatures")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_extended_flags"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ]
    )]
    public FormatFeatureFlags4KHR BufferFeatures;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_extended_flags"],
        ImpliesSets = [
            "VK_KHR_extended_flags+VK_KHR_get_physical_device_properties2",
            "VK_KHR_extended_flags+VK_VERSION_1_1",
        ]
    )]
    public FormatProperties4KHR() { }
}
