// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageAlignmentControlCreateInfoMESA")]
[NameAffix("Suffix", "KhronosVendor", "MESA")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkImageAlignmentControlCreateInfoMESA
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_MESA_image_alignment_control"],
        ImpliesSets = [
            "VK_MESA_image_alignment_control+VK_KHR_get_physical_device_properties2",
            "VK_MESA_image_alignment_control+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_MESA_image_alignment_control"],
        ImpliesSets = [
            "VK_MESA_image_alignment_control+VK_KHR_get_physical_device_properties2",
            "VK_MESA_image_alignment_control+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("maximumRequestedAlignment")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_MESA_image_alignment_control"],
        ImpliesSets = [
            "VK_MESA_image_alignment_control+VK_KHR_get_physical_device_properties2",
            "VK_MESA_image_alignment_control+VK_VERSION_1_1",
        ]
    )]
    public uint MaximumRequestedAlignment;
}
