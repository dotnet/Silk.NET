// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH265OutputModeFlagsEXT")]
    public enum VideoEncodeH265OutputModeFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"FrameBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_OUTPUT_MODE_FRAME_BIT_EXT")]
        VideoEncodeH265OutputModeFrameBitExt = 1,
        [Obsolete("Deprecated in favour of \"SliceSegmentBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_OUTPUT_MODE_SLICE_SEGMENT_BIT_EXT")]
        VideoEncodeH265OutputModeSliceSegmentBitExt = 2,
        [Obsolete("Deprecated in favour of \"NonVclBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_OUTPUT_MODE_NON_VCL_BIT_EXT")]
        VideoEncodeH265OutputModeNonVclBitExt = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_OUTPUT_MODE_FRAME_BIT_EXT")]
        FrameBitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_OUTPUT_MODE_SLICE_SEGMENT_BIT_EXT")]
        SliceSegmentBitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_OUTPUT_MODE_NON_VCL_BIT_EXT")]
        NonVclBitExt = 4,
    }
}
