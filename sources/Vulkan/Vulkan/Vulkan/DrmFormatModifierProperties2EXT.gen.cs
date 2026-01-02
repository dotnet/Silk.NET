// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct DrmFormatModifierProperties2EXT
{
    [NativeTypeName("uint64_t")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_image_drm_format_modifier+VK_KHR_format_feature_flags2",
            "VK_EXT_image_drm_format_modifier+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    public ulong DrmFormatModifier;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_image_drm_format_modifier+VK_KHR_format_feature_flags2",
            "VK_EXT_image_drm_format_modifier+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    public uint DrmFormatModifierPlaneCount;

    [NativeTypeName("VkFormatFeatureFlags2")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_EXT_image_drm_format_modifier+VK_KHR_format_feature_flags2",
            "VK_EXT_image_drm_format_modifier+VK_VERSION_1_3",
        ],
        ImpliesSets = [
            "VK_KHR_image_format_list+VK_KHR_bind_memory2+VK_KHR_get_physical_device_properties2+VK_KHR_sampler_ycbcr_conversion",
            "VK_KHR_image_format_list+VK_VERSION_1_1",
            "VK_VERSION_1_2",
        ]
    )]
    public FormatFeatureFlags2 DrmFormatModifierTilingFeatures;
}
