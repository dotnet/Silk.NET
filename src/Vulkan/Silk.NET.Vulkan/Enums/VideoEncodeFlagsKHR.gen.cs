// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeFlagsKHR")]
    public enum VideoEncodeFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"IntraRefreshBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_INTRA_REFRESH_BIT_KHR")]
        VideoEncodeIntraRefreshBitKhr = 4,
        [Obsolete("Deprecated in favour of \"WithQuantizationDeltaMapBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_WITH_QUANTIZATION_DELTA_MAP_BIT_KHR")]
        VideoEncodeWithQuantizationDeltaMapBitKhr = 1,
        [Obsolete("Deprecated in favour of \"WithEmphasisMapBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_WITH_EMPHASIS_MAP_BIT_KHR")]
        VideoEncodeWithEmphasisMapBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_INTRA_REFRESH_BIT_KHR")]
        IntraRefreshBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_WITH_QUANTIZATION_DELTA_MAP_BIT_KHR")]
        WithQuantizationDeltaMapBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_WITH_EMPHASIS_MAP_BIT_KHR")]
        WithEmphasisMapBitKhr = 2,
    }
}
