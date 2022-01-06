// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [Flags]
    [NativeName("Name", "StdVideoH265ProfileIdc")]
    public enum StdVideoH265ProfileIdc : int
    {
        [NativeName("Name", "std_video_h265_profile_idc_main")]
        StdVideoH265ProfileIdcMain = 0x1,
        [NativeName("Name", "std_video_h265_profile_idc_main_10")]
        StdVideoH265ProfileIdcMain10 = 0x2,
        [NativeName("Name", "std_video_h265_profile_idc_main_still_picture")]
        StdVideoH265ProfileIdcMainStillPicture = 0x3,
        [NativeName("Name", "std_video_h265_profile_idc_format_range_extensions")]
        StdVideoH265ProfileIdcFormatRangeExtensions = 0x4,
        [NativeName("Name", "std_video_h265_profile_idc_scc_extensions")]
        StdVideoH265ProfileIdcSccExtensions = 0x9,
        [NativeName("Name", "std_video_h265_profile_idc_invalid")]
        StdVideoH265ProfileIdcInvalid = 0x7FFFFFFF,
    }
}
