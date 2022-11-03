// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH265InputModeFlagsEXT")]
    public enum VideoEncodeH265InputModeFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"FrameBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_INPUT_MODE_FRAME_BIT_EXT")]
        VideoEncodeH265InputModeFrameBitExt = 1,
        [Obsolete("Deprecated in favour of \"SliceSegmentBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_INPUT_MODE_SLICE_SEGMENT_BIT_EXT")]
        VideoEncodeH265InputModeSliceSegmentBitExt = 2,
        [Obsolete("Deprecated in favour of \"NonVclBitExt\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_INPUT_MODE_NON_VCL_BIT_EXT")]
        VideoEncodeH265InputModeNonVclBitExt = 4,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_INPUT_MODE_FRAME_BIT_EXT")]
        FrameBitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_INPUT_MODE_SLICE_SEGMENT_BIT_EXT")]
        SliceSegmentBitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_INPUT_MODE_NON_VCL_BIT_EXT")]
        NonVclBitExt = 4,
    }
}
