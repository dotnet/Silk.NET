// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeFeedbackFlagsKHR")]
    public enum VideoEncodeFeedbackFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"BufferOffsetBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_BUFFER_OFFSET_BIT_KHR")]
        VideoEncodeFeedbackBitstreamBufferOffsetBitKhr = 1,
        [Obsolete("Deprecated in favour of \"BytesWrittenBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_BYTES_WRITTEN_BIT_KHR")]
        VideoEncodeFeedbackBitstreamBytesWrittenBitKhr = 2,
        [Obsolete("Deprecated in favour of \"HasOverridesBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_HAS_OVERRIDES_BIT_KHR")]
        VideoEncodeFeedbackBitstreamHasOverridesBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_BUFFER_OFFSET_BIT_KHR")]
        BufferOffsetBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_BYTES_WRITTEN_BIT_KHR")]
        BytesWrittenBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_FEEDBACK_BITSTREAM_HAS_OVERRIDES_BIT_KHR")]
        HasOverridesBitKhr = 4,
    }
}
