// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoDecodeH264PictureLayoutFlagsEXT")]
    public enum VideoDecodeH264PictureLayoutFlagsEXT : int
    {
        [NativeName("Name", "VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_PROGRESSIVE_EXT")]
        VideoDecodeH264PictureLayoutProgressiveExt = 0,
        [NativeName("Name", "VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_INTERLEAVED_LINES_BIT_EXT")]
        VideoDecodeH264PictureLayoutInterlacedInterleavedLinesBitExt = 1,
        [NativeName("Name", "VK_VIDEO_DECODE_H264_PICTURE_LAYOUT_INTERLACED_SEPARATE_PLANES_BIT_EXT")]
        VideoDecodeH264PictureLayoutInterlacedSeparatePlanesBitExt = 2,
    }
}
