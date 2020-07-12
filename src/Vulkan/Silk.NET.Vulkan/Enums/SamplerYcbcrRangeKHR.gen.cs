// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSamplerYcbcrRangeKHR")]
    public enum SamplerYcbcrRangeKHR
    {
        [NativeName("Name", "VK_SAMPLER_YCBCR_RANGE_ITU_FULL")]
        SamplerYcbcrRangeItuFull = 0,
        [NativeName("Name", "VK_SAMPLER_YCBCR_RANGE_ITU_NARROW")]
        SamplerYcbcrRangeItuNarrow = 1,
    }
}
