// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSamplerYcbcrRangeKHR")]
    public enum SamplerYcbcrRangeKHR : int
    {
        [Obsolete("Deprecated in favour of \"Full\"")]
        [NativeName("Name", "VK_SAMPLER_YCBCR_RANGE_ITU_FULL")]
        SamplerYcbcrRangeItuFull = 0,
        [Obsolete("Deprecated in favour of \"Narrow\"")]
        [NativeName("Name", "VK_SAMPLER_YCBCR_RANGE_ITU_NARROW")]
        SamplerYcbcrRangeItuNarrow = 1,
        [NativeName("Name", "VK_SAMPLER_YCBCR_RANGE_ITU_FULL")]
        Full = 0,
        [NativeName("Name", "VK_SAMPLER_YCBCR_RANGE_ITU_NARROW")]
        Narrow = 1,
    }
}
