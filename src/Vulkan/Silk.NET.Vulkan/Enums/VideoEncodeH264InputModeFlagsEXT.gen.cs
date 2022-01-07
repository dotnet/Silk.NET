// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeH264InputModeFlagsEXT")]
    public enum VideoEncodeH264InputModeFlagsEXT : int
    {
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_INPUT_MODE_FRAME_BIT_EXT")]
        VideoEncodeH264InputModeFrameBitExt = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_INPUT_MODE_SLICE_BIT_EXT")]
        VideoEncodeH264InputModeSliceBitExt = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_H264_INPUT_MODE_NON_VCL_BIT_EXT")]
        VideoEncodeH264InputModeNonVclBitExt = 4,
    }
}
