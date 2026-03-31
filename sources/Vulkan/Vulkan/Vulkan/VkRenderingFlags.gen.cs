// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRenderingFlagBits")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkRenderingFlags : uint
{
    [NativeName("VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkRenderingContentsSecondaryCommandBuffersBit = 0x00000001,

    [NativeName("VK_RENDERING_SUSPENDING_BIT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkRenderingSuspendingBit = 0x00000002,

    [NativeName("VK_RENDERING_RESUMING_BIT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkRenderingResumingBit = 0x00000004,

    [NativeName("VK_RENDERING_ENABLE_LEGACY_DITHERING_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_legacy_dithering+VK_KHR_dynamic_rendering+VK_KHR_maintenance5",
            "VK_EXT_legacy_dithering+VK_KHR_dynamic_rendering+VK_VERSION_1_4",
            "VK_EXT_legacy_dithering+VK_VERSION_1_3+VK_KHR_maintenance5",
            "VK_EXT_legacy_dithering+VK_VERSION_1_3+VK_VERSION_1_4",
        ],
        ImpliesSets = [
            "VK_EXT_legacy_dithering+VK_KHR_get_physical_device_properties2",
            "VK_EXT_legacy_dithering+VK_VERSION_1_1",
        ]
    )]
    VkRenderingEnableLegacyDitheringBitEXT = 0x00000008,

    [NativeName("VK_RENDERING_CONTENTS_INLINE_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VkRenderingContentsInlineBitKHR = 0x00000010,

    [NativeName("VK_RENDERING_PER_LAYER_FRAGMENT_DENSITY_BIT_VALVE")]
    [NameAffix("Suffix", "KhronosVendor", "VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_fragment_density_map_layered"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_maintenance5",
            "VK_EXT_fragment_density_map+VK_VERSION_1_4",
        ]
    )]
    VkRenderingPerLayerFragmentDensityBitVALVE = 0x00000020,

    [NativeName("VK_RENDERING_LOCAL_READ_CONCURRENT_ACCESS_CONTROL_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_KHR_maintenance10+VK_KHR_dynamic_rendering_local_read+VK_KHR_dynamic_rendering",
            "VK_KHR_maintenance10+VK_KHR_dynamic_rendering_local_read+VK_VERSION_1_3",
            "VK_KHR_maintenance10+VK_VERSION_1_4+VK_KHR_dynamic_rendering",
            "VK_KHR_maintenance10+VK_VERSION_1_4+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_KHR_maintenance10+VK_KHR_get_physical_device_properties2",
            "VK_KHR_maintenance10+VK_VERSION_1_1",
        ]
    )]
    VkRenderingLocalReadConcurrentAccessControlBitKHR = 0x00000100,

    [NativeName("VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkRenderingContentsSecondaryCommandBuffersBitKHR =
        VkRenderingContentsSecondaryCommandBuffersBit,

    [NativeName("VK_RENDERING_SUSPENDING_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkRenderingSuspendingBitKHR = VkRenderingSuspendingBit,

    [NativeName("VK_RENDERING_RESUMING_BIT_KHR")]
    [NameAffix("Suffix", "KhronosVendor", "KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VkRenderingResumingBitKHR = VkRenderingResumingBit,

    [NativeName("VK_RENDERING_CONTENTS_INLINE_BIT_EXT")]
    [NameAffix("Suffix", "KhronosVendor", "EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_nested_command_buffer"],
        ImpliesSets = [
            "VK_EXT_nested_command_buffer+VK_KHR_get_physical_device_properties2",
            "VK_EXT_nested_command_buffer+VK_VERSION_1_1",
        ]
    )]
    VkRenderingContentsInlineBitEXT = VkRenderingContentsInlineBitKHR,

    [NativeName("VK_RENDERING_FLAG_BITS_MAX_ENUM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    VkRenderingFlagBitsMaxEnum = 0x7FFFFFFF,
}
