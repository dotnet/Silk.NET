// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkCoarseSampleOrderTypeNV")]
    public enum CoarseSampleOrderTypeNV : int
    {
        [Obsolete("Deprecated in favour of \"DefaultNV\"")]
        [NativeName("Name", "VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV")]
        CoarseSampleOrderTypeDefaultNV = 0,
        [Obsolete("Deprecated in favour of \"CustomNV\"")]
        [NativeName("Name", "VK_COARSE_SAMPLE_ORDER_TYPE_CUSTOM_NV")]
        CoarseSampleOrderTypeCustomNV = 1,
        [Obsolete("Deprecated in favour of \"PixelMajorNV\"")]
        [NativeName("Name", "VK_COARSE_SAMPLE_ORDER_TYPE_PIXEL_MAJOR_NV")]
        CoarseSampleOrderTypePixelMajorNV = 2,
        [Obsolete("Deprecated in favour of \"SampleMajorNV\"")]
        [NativeName("Name", "VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV")]
        CoarseSampleOrderTypeSampleMajorNV = 3,
        [NativeName("Name", "VK_COARSE_SAMPLE_ORDER_TYPE_DEFAULT_NV")]
        DefaultNV = 0,
        [NativeName("Name", "VK_COARSE_SAMPLE_ORDER_TYPE_CUSTOM_NV")]
        CustomNV = 1,
        [NativeName("Name", "VK_COARSE_SAMPLE_ORDER_TYPE_PIXEL_MAJOR_NV")]
        PixelMajorNV = 2,
        [NativeName("Name", "VK_COARSE_SAMPLE_ORDER_TYPE_SAMPLE_MAJOR_NV")]
        SampleMajorNV = 3,
    }
}
