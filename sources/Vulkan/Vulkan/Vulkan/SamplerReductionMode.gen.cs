// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSamplerReductionMode")]
[SupportedApiProfile("vulkan")]
public enum SamplerReductionMode : uint
{
    [NativeName("VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    WeightedAverage = 0,

    [NativeName("VK_SAMPLER_REDUCTION_MODE_MIN")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    Min = 1,

    [NativeName("VK_SAMPLER_REDUCTION_MODE_MAX")]
    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.2"
    )]
    Max = 2,

    [NameAffix("Suffix", "QCOM", 0)]
    [NativeName("VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE_RANGECLAMP_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_clamp"],
        ImpliesSets = [
            "VK_EXT_filter_cubic+VK_EXT_sampler_filter_minmax",
            "VK_EXT_filter_cubic+VK_VERSION_1_2",
        ]
    )]
    WeightedAverageRangeclampqcom = 1000521000,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sampler_filter_minmax"],
        ImpliesSets = [
            "VK_EXT_sampler_filter_minmax+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sampler_filter_minmax+VK_VERSION_1_1",
        ]
    )]
    WeightedAverageext = WeightedAverage,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SAMPLER_REDUCTION_MODE_MIN_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sampler_filter_minmax"],
        ImpliesSets = [
            "VK_EXT_sampler_filter_minmax+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sampler_filter_minmax+VK_VERSION_1_1",
        ]
    )]
    Minext = Min,

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("VK_SAMPLER_REDUCTION_MODE_MAX_EXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_sampler_filter_minmax"],
        ImpliesSets = [
            "VK_EXT_sampler_filter_minmax+VK_KHR_get_physical_device_properties2",
            "VK_EXT_sampler_filter_minmax+VK_VERSION_1_1",
        ]
    )]
    Maxext = Max,
}
