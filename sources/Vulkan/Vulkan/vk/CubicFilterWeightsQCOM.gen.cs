// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCubicFilterWeightsQCOM")]
public enum CubicFilterWeightsQCOM : uint
{
    [NativeName("VK_CUBIC_FILTER_WEIGHTS_CATMULL_ROM_QCOM")]
    CatmullRom = 0,

    [NativeName("VK_CUBIC_FILTER_WEIGHTS_ZERO_TANGENT_CARDINAL_QCOM")]
    ZeroTangentCardinal = 1,

    [NativeName("VK_CUBIC_FILTER_WEIGHTS_B_SPLINE_QCOM")]
    BSpline = 2,

    [NativeName("VK_CUBIC_FILTER_WEIGHTS_MITCHELL_NETRAVALI_QCOM")]
    MitchellNetravali = 3,
}
