// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkVideoDecodeH264FieldLayoutFlagsEXT")]
    public enum VideoDecodeH264FieldLayoutFlagsEXT : int
    {
        [NativeName("Name", "VK_VIDEO_DECODE_H264_PROGRESSIVE_PICTURES_ONLY_EXT")]
        VideoDecodeH264ProgressivePicturesOnlyExt = 0,
        [NativeName("Name", "VK_VIDEO_DECODE_H264_FIELD_LAYOUT_LINE_INTERLACED_PLANE_BIT_EXT")]
        VideoDecodeH264FieldLayoutLineInterlacedPlaneBitExt = 1,
        [NativeName("Name", "VK_VIDEO_DECODE_H264_FIELD_LAYOUT_SEPARATE_INTERLACED_PLANE_BIT_EXT")]
        VideoDecodeH264FieldLayoutSeparateInterlacedPlaneBitExt = 2,
    }
}
