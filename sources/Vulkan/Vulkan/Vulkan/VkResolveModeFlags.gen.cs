// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkResolveModeFlags : uint
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_RESOLVE_MODE_NONE = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_RESOLVE_MODE_SAMPLE_ZERO_BIT = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_RESOLVE_MODE_AVERAGE_BIT = 0x00000002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_RESOLVE_MODE_MIN_BIT = 0x00000004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_RESOLVE_MODE_MAX_BIT = 0x00000008,

    [SupportedApiProfile(
        "vulkan",
        [
            "VK_ANDROID_external_format_resolve+VK_KHR_dynamic_rendering",
            "VK_ANDROID_external_format_resolve+VK_VERSION_1_3",
        ],
        ImpliesSets = ["VK_ANDROID_external_memory_android_hardware_buffer"]
    )]
    VK_RESOLVE_MODE_EXTERNAL_FORMAT_DOWNSAMPLE_ANDROID = 0x00000010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    VK_RESOLVE_MODE_NONE_KHR = VK_RESOLVE_MODE_NONE,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    VK_RESOLVE_MODE_SAMPLE_ZERO_BIT_KHR = VK_RESOLVE_MODE_SAMPLE_ZERO_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    VK_RESOLVE_MODE_AVERAGE_BIT_KHR = VK_RESOLVE_MODE_AVERAGE_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    VK_RESOLVE_MODE_MIN_BIT_KHR = VK_RESOLVE_MODE_MIN_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_depth_stencil_resolve"],
        ImpliesSets = [
            "VK_KHR_depth_stencil_resolve+VK_KHR_create_renderpass2",
            "VK_KHR_depth_stencil_resolve+VK_VERSION_1_2",
        ]
    )]
    VK_RESOLVE_MODE_MAX_BIT_KHR = VK_RESOLVE_MODE_MAX_BIT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.2"
    )]
    VK_RESOLVE_MODE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
}
