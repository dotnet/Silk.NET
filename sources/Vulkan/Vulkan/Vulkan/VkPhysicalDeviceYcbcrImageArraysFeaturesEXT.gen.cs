// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceYcbcrImageArraysFeaturesEXT")]
[NameAffix("Suffix", "KhronosVendor", "EXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ycbcr_image_arrays"],
        ImpliesSets = [
            "VK_EXT_ycbcr_image_arrays+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_ycbcr_image_arrays+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ycbcr_image_arrays"],
        ImpliesSets = [
            "VK_EXT_ycbcr_image_arrays+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_ycbcr_image_arrays+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("ycbcrImageArrays")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_ycbcr_image_arrays"],
        ImpliesSets = [
            "VK_EXT_ycbcr_image_arrays+VK_KHR_sampler_ycbcr_conversion",
            "VK_EXT_ycbcr_image_arrays+VK_VERSION_1_1",
        ]
    )]
    public uint YcbcrImageArrays;
}
