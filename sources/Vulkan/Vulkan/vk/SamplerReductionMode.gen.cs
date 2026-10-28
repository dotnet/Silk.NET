// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSamplerReductionMode")]
public enum SamplerReductionMode : uint
{
    [NativeName("VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE")]
    WeightedAverage = 0,

    [NativeName("VK_SAMPLER_REDUCTION_MODE_MIN")]
    Min = 1,

    [NativeName("VK_SAMPLER_REDUCTION_MODE_MAX")]
    Max = 2,

    [NativeName("VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE_RANGECLAMP_QCOM")]
    WeightedAverageRangeclampQCOM = 1000521000,

    [NativeName("VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE_EXT")]
    WeightedAverageEXT = WeightedAverage,

    [NativeName("VK_SAMPLER_REDUCTION_MODE_MIN_EXT")]
    MinEXT = Min,

    [NativeName("VK_SAMPLER_REDUCTION_MODE_MAX_EXT")]
    MaxEXT = Max,
}
