// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "HUAWEI", 0)]
[NativeName("VkHdrVividDynamicMetadataHUAWEI")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct HdrVividDynamicMetadataHuawei
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_hdr_vivid"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_hdr_vivid"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("dynamicMetadataSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_hdr_vivid"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_VERSION_1_1",
        ]
    )]
    public nuint DynamicMetadataSize;

    [NativeName("pDynamicMetadata")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_HUAWEI_hdr_vivid"],
        ImpliesSets = [
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_KHR_get_physical_device_properties2",
            "VK_KHR_swapchain+VK_EXT_hdr_metadata+VK_VERSION_1_1",
        ]
    )]
    public void* PDynamicMetadata;
}
