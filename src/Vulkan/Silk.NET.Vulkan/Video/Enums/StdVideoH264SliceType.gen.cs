// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [Flags]
    [NativeName("Name", "StdVideoH264SliceType")]
    public enum StdVideoH264SliceType : int
    {
        [NativeName("Name", "std_video_h264_slice_type_i")]
        StdVideoH264SliceTypeI = 0x0,
        [NativeName("Name", "std_video_h264_slice_type_p")]
        StdVideoH264SliceTypeP = 0x1,
        [NativeName("Name", "std_video_h264_slice_type_b")]
        StdVideoH264SliceTypeB = 0x2,
        [NativeName("Name", "std_video_h264_slice_type_invalid")]
        StdVideoH264SliceTypeInvalid = 0x7FFFFFFF,
    }
}
