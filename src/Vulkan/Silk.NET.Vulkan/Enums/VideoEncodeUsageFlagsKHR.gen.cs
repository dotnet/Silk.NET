// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeUsageFlagsKHR")]
    public enum VideoEncodeUsageFlagsKHR : int
    {
        [Obsolete("Deprecated in favour of \"DefaultKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_USAGE_DEFAULT_KHR")]
        VideoEncodeUsageDefaultKhr = 0,
        [Obsolete("Deprecated in favour of \"TranscodingBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_USAGE_TRANSCODING_BIT_KHR")]
        VideoEncodeUsageTranscodingBitKhr = 1,
        [Obsolete("Deprecated in favour of \"StreamingBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_USAGE_STREAMING_BIT_KHR")]
        VideoEncodeUsageStreamingBitKhr = 2,
        [Obsolete("Deprecated in favour of \"RecordingBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_USAGE_RECORDING_BIT_KHR")]
        VideoEncodeUsageRecordingBitKhr = 4,
        [Obsolete("Deprecated in favour of \"ConferencingBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_USAGE_CONFERENCING_BIT_KHR")]
        VideoEncodeUsageConferencingBitKhr = 8,
        [NativeName("Name", "VK_VIDEO_ENCODE_USAGE_DEFAULT_KHR")]
        DefaultKhr = 0,
        [NativeName("Name", "VK_VIDEO_ENCODE_USAGE_TRANSCODING_BIT_KHR")]
        TranscodingBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_USAGE_STREAMING_BIT_KHR")]
        StreamingBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_USAGE_RECORDING_BIT_KHR")]
        RecordingBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_USAGE_CONFERENCING_BIT_KHR")]
        ConferencingBitKhr = 8,
    }
}
