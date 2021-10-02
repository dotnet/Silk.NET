// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoH264ProfileIdc")]
    public enum StdVideoH264ProfileIdc : int
    {
        [NativeName("Name", "std_video_h264_profile_idc_baseline")]
        StdVideoH264ProfileIdcBaseline = 0x42,
        [NativeName("Name", "std_video_h264_profile_idc_main")]
        StdVideoH264ProfileIdcMain = 0x4D,
        [NativeName("Name", "std_video_h264_profile_idc_high")]
        StdVideoH264ProfileIdcHigh = 0x64,
        [NativeName("Name", "std_video_h264_profile_idc_high_444_predictive")]
        StdVideoH264ProfileIdcHigh444Predictive = 0xF4,
        [NativeName("Name", "std_video_h264_profile_idc_invalid")]
        StdVideoH264ProfileIdcInvalid = 0x7FFFFFFF,
    }
}
