// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("QCOM", 0)]
[NativeName("VkCubicFilterWeightsQCOM")]
[SupportedApiProfile("vulkan")]
public enum CubicFilterWeightsQCOM : uint
{
    [NameSuffix("QCOM", 0)]
    [NativeName("VK_CUBIC_FILTER_WEIGHTS_CATMULL_ROM_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    CatmullRomQCOM = 0,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_CUBIC_FILTER_WEIGHTS_ZERO_TANGENT_CARDINAL_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    ZeroTangentCardinalQCOM = 1,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_CUBIC_FILTER_WEIGHTS_B_SPLINE_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    BSplineQCOM = 2,

    [NameSuffix("QCOM", 0)]
    [NativeName("VK_CUBIC_FILTER_WEIGHTS_MITCHELL_NETRAVALI_QCOM")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    MitchellNetravaliQCOM = 3,
}
