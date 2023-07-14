// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoDecodeH264PictureLayoutFlagsKHR")]
    public enum VideoDecodeH264PictureLayoutFlagsKHR : int
    {
        [Obsolete("Deprecated in favour of \"ProgressiveKhr\"")]
        [NativeName("Name", "VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_PROGRESSIVE_KHR")]
        VideoDecodeH264PictureLayoutProgressiveKhr = 0,
        [Obsolete("Deprecated in favour of \"InterlacedInterleavedLinesBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_INTERLEAVED_LINES_BIT_KHR")]
        VideoDecodeH264PictureLayoutInterlacedInterleavedLinesBitKhr = 1,
        [Obsolete("Deprecated in favour of \"InterlacedSeparatePlanesBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_SEPARATE_PLANES_BIT_KHR")]
        VideoDecodeH264PictureLayoutInterlacedSeparatePlanesBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_PROGRESSIVE_KHR")]
        ProgressiveKhr = 0,
        [NativeName("Name", "VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_INTERLEAVED_LINES_BIT_KHR")]
        InterlacedInterleavedLinesBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_SEPARATE_PLANES_BIT_KHR")]
        InterlacedSeparatePlanesBitKhr = 2,
    }
}
