// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkRenderingFlags
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT = 0x00000001,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_RENDERING_SUSPENDING_BIT = 0x00000002,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_RENDERING_RESUMING_BIT = 0x00000004,

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
    VK_RENDERING_ENABLE_LEGACY_DITHERING_BIT_EXT = 0x00000008,

    [SupportedApiProfile("vulkan", ["VK_KHR_maintenance7"], ImpliesSets = ["VK_VERSION_1_1"])]
    VK_RENDERING_CONTENTS_INLINE_BIT_KHR = 0x00000010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT_KHR =
        VK_RENDERING_CONTENTS_SECONDARY_COMMAND_BUFFERS_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_RENDERING_SUSPENDING_BIT_KHR = VK_RENDERING_SUSPENDING_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_dynamic_rendering"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_get_physical_device_properties2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    VK_RENDERING_RESUMING_BIT_KHR = VK_RENDERING_RESUMING_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_nested_command_buffer"],
        ImpliesSets = [
            "VK_EXT_nested_command_buffer+VK_KHR_get_physical_device_properties2",
            "VK_EXT_nested_command_buffer+VK_VERSION_1_1",
        ]
    )]
    VK_RENDERING_CONTENTS_INLINE_BIT_EXT = VK_RENDERING_CONTENTS_INLINE_BIT_KHR,

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    VK_RENDERING_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}
