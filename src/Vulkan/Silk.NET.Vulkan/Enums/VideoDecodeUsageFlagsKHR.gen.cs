// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoDecodeUsageFlagsKHR")]
    public enum VideoDecodeUsageFlagsKHR : int
    {
        [Obsolete("Deprecated in favour of \"DefaultKhr\"")]
        [NativeName("Name", "VK_VIDEO_DECODE_USAGE_DEFAULT_KHR")]
        VideoDecodeUsageDefaultKhr = 0,
        [Obsolete("Deprecated in favour of \"TranscodingBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_DECODE_USAGE_TRANSCODING_BIT_KHR")]
        VideoDecodeUsageTranscodingBitKhr = 1,
        [Obsolete("Deprecated in favour of \"OfflineBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_DECODE_USAGE_OFFLINE_BIT_KHR")]
        VideoDecodeUsageOfflineBitKhr = 2,
        [Obsolete("Deprecated in favour of \"StreamingBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_DECODE_USAGE_STREAMING_BIT_KHR")]
        VideoDecodeUsageStreamingBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_DECODE_USAGE_DEFAULT_KHR")]
        DefaultKhr = 0,
        [NativeName("Name", "VK_VIDEO_DECODE_USAGE_TRANSCODING_BIT_KHR")]
        TranscodingBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_DECODE_USAGE_OFFLINE_BIT_KHR")]
        OfflineBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_DECODE_USAGE_STREAMING_BIT_KHR")]
        StreamingBitKhr = 4,
    }
}
