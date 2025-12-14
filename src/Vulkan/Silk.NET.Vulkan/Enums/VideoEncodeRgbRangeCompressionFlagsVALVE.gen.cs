// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeRgbRangeCompressionFlagsVALVE")]
    public enum VideoEncodeRgbRangeCompressionFlagsVALVE : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"FullRangeBitValve\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_RANGE_COMPRESSION_FULL_RANGE_BIT_VALVE")]
        VideoEncodeRgbRangeCompressionFullRangeBitValve = 1,
        [Obsolete("Deprecated in favour of \"NarrowRangeBitValve\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_RANGE_COMPRESSION_NARROW_RANGE_BIT_VALVE")]
        VideoEncodeRgbRangeCompressionNarrowRangeBitValve = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_RANGE_COMPRESSION_FULL_RANGE_BIT_VALVE")]
        FullRangeBitValve = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_RGB_RANGE_COMPRESSION_NARROW_RANGE_BIT_VALVE")]
        NarrowRangeBitValve = 2,
    }
}
