// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkImageCompressionFlagBitsEXT")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum ImageCompressionFlagsExt : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_DEFAULT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Defaultext = 0x0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_DEFAULT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    FixedRateDefaultext = 0x1,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_EXPLICIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    FixedRateExplicitext = 0x2,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_DISABLED_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Disabledext = 0x4,
}
