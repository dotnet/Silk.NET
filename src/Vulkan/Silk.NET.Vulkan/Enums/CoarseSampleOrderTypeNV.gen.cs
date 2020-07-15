// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkCoarseSampleOrderTypeNV")]
    public enum CoarseSampleOrderTypeNV
    {
        [NativeName("Name", "VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV")]
        CoarseSampleOrderTypeDefaultNV = 0,
        [NativeName("Name", "VK_COARSE_SAMPLE_ORDER_TYPE_CUSTOM_NV")]
        CoarseSampleOrderTypeCustomNV = 1,
        [NativeName("Name", "VK_COARSE_SAMPLE_ORDER_TYPE_PIXEL_MAJOR_NV")]
        CoarseSampleOrderTypePixelMajorNV = 2,
        [NativeName("Name", "VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV")]
        CoarseSampleOrderTypeSampleMajorNV = 3,
    }
}
