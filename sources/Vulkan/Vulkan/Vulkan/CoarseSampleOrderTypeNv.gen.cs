// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkCoarseSampleOrderTypeNV")]
[SupportedApiProfile("vulkan")]
public enum CoarseSampleOrderTypeNv : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    Defaultnv = 0,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COARSE_SAMPLE_ORDER_TYPE_CUSTOM_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    Customnv = 1,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COARSE_SAMPLE_ORDER_TYPE_PIXEL_MAJOR_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    PixelMajornv = 2,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_shading_rate_image"],
        ImpliesSets = [
            "VK_NV_shading_rate_image+VK_KHR_get_physical_device_properties2",
            "VK_NV_shading_rate_image+VK_VERSION_1_1",
        ]
    )]
    SampleMajornv = 3,
}
