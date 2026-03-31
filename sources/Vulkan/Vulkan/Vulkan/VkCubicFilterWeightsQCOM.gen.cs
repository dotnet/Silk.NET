// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "QCOM")]
[NativeName("VkCubicFilterWeightsQCOM")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum VkCubicFilterWeightsQCOM : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "QCOM")]
    [NativeName("VK_CUBIC_FILTER_WEIGHTS_CATMULL_ROM_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    VkCubicFilterWeightsCatmullRom = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "QCOM")]
    [NativeName("VK_CUBIC_FILTER_WEIGHTS_ZERO_TANGENT_CARDINAL_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    VkCubicFilterWeightsZeroTangentCardinal = 1,

    [NameAffix("Suffix", "KhronosImpliedVendor", "QCOM")]
    [NativeName("VK_CUBIC_FILTER_WEIGHTS_B_SPLINE_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    VkCubicFilterWeightsBSpline = 2,

    [NameAffix("Suffix", "KhronosImpliedVendor", "QCOM")]
    [NativeName("VK_CUBIC_FILTER_WEIGHTS_MITCHELL_NETRAVALI_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    VkCubicFilterWeightsMitchellNetravali = 3,

    [NameAffix("Suffix", "KhronosImpliedVendor", "QCOM")]
    [NativeName("VK_CUBIC_FILTER_WEIGHTS_MAX_ENUM_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    VkCubicFilterWeightsMaxEnum = 0x7FFFFFFF,
}
