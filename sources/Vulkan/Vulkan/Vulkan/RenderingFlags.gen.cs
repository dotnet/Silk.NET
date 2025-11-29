// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkRenderingFlagBits")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum RenderingFlags : uint
{
    None = 0x0,

    [NativeName("VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    ContentsSecondaryCommandBuffersBit = 0x1,

    [NativeName("VK_RENDERING_SUSPENDING_BIT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    SuspendingBit = 0x2,

    [NativeName("VK_RENDERING_RESUMING_BIT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GRAPHICS_VERSION_1_3", "VK_GRAPHICS_VERSION_1_4", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.3"
    )]
    ResumingBit = 0x4,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_RENDERING_ENABLE_LEGACY_DITHERING_BIT_EXT")]
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
    EnableLegacyDitheringBitEXT = 0x8,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_RENDERING_CONTENTS_INLINE_BIT_KHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    ContentsInlineBitKHR = 0x10,

    [NameAffix("Suffix", "VALVE", 0)]
    [NativeName("VK_RENDERING_PER_LAYER_FRAGMENT_DENSITY_BIT_VALVE")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_VALVE_fragment_density_map_layered"],
        ImpliesSets = [
            "VK_EXT_fragment_density_map+VK_KHR_maintenance5",
            "VK_EXT_fragment_density_map+VK_VERSION_1_4",
        ]
    )]
    PerLayerFragmentDensityBitValve = 0x20,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_RENDERING_LOCAL_READ_CONCURRENT_ACCESS_CONTROL_BIT_KHR")]
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
    LocalReadConcurrentAccessControlBitKHR = 0x100,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    ContentsSecondaryCommandBuffersBitKHR = ContentsSecondaryCommandBuffersBit,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_RENDERING_SUSPENDING_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    SuspendingBitKHR = SuspendingBit,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_RENDERING_RESUMING_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    ResumingBitKHR = ResumingBit,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_RENDERING_CONTENTS_INLINE_BIT_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_nested_command_buffer"],
        ImpliesSets = [
            "VK_EXT_nested_command_buffer+VK_KHR_get_physical_device_properties2",
            "VK_EXT_nested_command_buffer+VK_VERSION_1_1",
        ]
    )]
    ContentsInlineBitEXT = ContentsInlineBitKHR,
}
