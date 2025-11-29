// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum CubicFilterWeightsQCOM : uint
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    CatmullRomQCOM = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    ZeroTangentCardinalQCOM = 1,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    BSplineQCOM = 2,

    [SupportedApiProfile(
        "vulkan",
        ["VK_QCOM_filter_cubic_weights"],
        ImpliesSets = ["VK_EXT_filter_cubic"]
    )]
    MitchellNetravaliQCOM = 3,
}
