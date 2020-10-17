// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSamplerReductionModeEXT")]
    public enum SamplerReductionModeEXT
    {
        [NativeName("Name", "VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE")]
        SamplerReductionModeWeightedAverage = 0,
        [NativeName("Name", "VK_SAMPLER_REDUCTION_MODE_MIN")]
        SamplerReductionModeMin = 1,
        [NativeName("Name", "VK_SAMPLER_REDUCTION_MODE_MAX")]
        SamplerReductionModeMax = 2,
    }
}
