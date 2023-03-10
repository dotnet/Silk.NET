// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSamplerYcbcrRange")]
    public enum SamplerYcbcrRange : int
    {
        [Obsolete("Deprecated in favour of \"Full\"")]
        [NativeName("Name", "VK_SAMPLER_YCBCR_RANGE_ITU_FULL")]
        ItuFull = 0,
        [Obsolete("Deprecated in favour of \"Narrow\"")]
        [NativeName("Name", "VK_SAMPLER_YCBCR_RANGE_ITU_NARROW")]
        ItuNarrow = 1,
        [NativeName("Name", "VK_SAMPLER_YCBCR_RANGE_ITU_FULL")]
        Full = 0,
        [NativeName("Name", "VK_SAMPLER_YCBCR_RANGE_ITU_NARROW")]
        Narrow = 1,
    }
}
