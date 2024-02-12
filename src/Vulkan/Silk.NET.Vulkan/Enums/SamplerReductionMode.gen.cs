// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSamplerReductionMode")]
    public enum SamplerReductionMode : int
    {
        [NativeName("Name", "VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE")]
        WeightedAverage = 0,
        [NativeName("Name", "VK_SAMPLER_REDUCTION_MODE_MIN")]
        Min = 1,
        [NativeName("Name", "VK_SAMPLER_REDUCTION_MODE_MAX")]
        Max = 2,
        [NativeName("Name", "VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE_RANGECLAMP_QCOM")]
        WeightedAverageRangeclampQCom = 1000521000,
    }
}
