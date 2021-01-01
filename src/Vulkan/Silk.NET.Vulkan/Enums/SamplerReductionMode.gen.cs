// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    }
}
