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
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_OUTPUT_MODE_FRAME_BIT_EXT")]
        VideoEncodeH265OutputModeFrameBitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_OUTPUT_MODE_SLICE_BIT_EXT")]
        VideoEncodeH265OutputModeSliceBitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H265_OUTPUT_MODE_NON_VCL_BIT_EXT")]
        VideoEncodeH265OutputModeNonVclBitExt = 4,
    }
}
