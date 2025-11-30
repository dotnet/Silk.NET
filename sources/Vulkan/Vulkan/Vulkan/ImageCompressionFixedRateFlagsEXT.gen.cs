// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "EXT", 0)]
[NativeName("VkImageCompressionFixedRateFlagBitsEXT")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum ImageCompressionFixedRateFlagsEXT : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_NONE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    RateNoneEXT = 0x0,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_1BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate1BpcBitEXT = 0x1,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_2BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate2BpcBitEXT = 0x2,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_3BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate3BpcBitEXT = 0x4,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_4BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate4BpcBitEXT = 0x8,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_5BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate5BpcBitEXT = 0x10,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_6BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate6BpcBitEXT = 0x20,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_7BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate7BpcBitEXT = 0x40,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_8BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate8BpcBitEXT = 0x80,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_9BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate9BpcBitEXT = 0x100,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_10BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate10BpcBitEXT = 0x200,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_11BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate11BpcBitEXT = 0x400,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_12BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate12BpcBitEXT = 0x800,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_13BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate13BpcBitEXT = 0x1000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_14BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate14BpcBitEXT = 0x2000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_15BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate15BpcBitEXT = 0x4000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_16BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate16BpcBitEXT = 0x8000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_17BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate17BpcBitEXT = 0x10000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_18BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate18BpcBitEXT = 0x20000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_19BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate19BpcBitEXT = 0x40000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_20BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate20BpcBitEXT = 0x80000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_21BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate21BpcBitEXT = 0x100000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_22BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate22BpcBitEXT = 0x200000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_23BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate23BpcBitEXT = 0x400000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_IMAGE_COMPRESSION_FIXED_RATE_24BPC_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control"],
        ImpliesSets = [
            "VK_EXT_image_compression_control+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_compression_control+VK_VERSION_1_1",
        ]
    )]
    Rate24BpcBitEXT = 0x800000,
}
