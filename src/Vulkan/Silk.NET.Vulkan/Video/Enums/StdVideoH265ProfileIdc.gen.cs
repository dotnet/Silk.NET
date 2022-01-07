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
        [NativeName("Name", "STD_VIDEO_H265_PROFILE_IDC_MAIN")]
        StdVideoH265ProfileIdcMain = 0x1,
        [NativeName("Name", "STD_VIDEO_H265_PROFILE_IDC_MAIN_10")]
        StdVideoH265ProfileIdcMain10 = 0x2,
        [NativeName("Name", "STD_VIDEO_H265_PROFILE_IDC_MAIN_STILL_PICTURE")]
        StdVideoH265ProfileIdcMainStillPicture = 0x3,
        [NativeName("Name", "STD_VIDEO_H265_PROFILE_IDC_FORMAT_RANGE_EXTENSIONS")]
        StdVideoH265ProfileIdcFormatRangeExtensions = 0x4,
        [NativeName("Name", "STD_VIDEO_H265_PROFILE_IDC_SCC_EXTENSIONS")]
        StdVideoH265ProfileIdcSccExtensions = 0x9,
        [NativeName("Name", "STD_VIDEO_H265_PROFILE_IDC_INVALID")]
        StdVideoH265ProfileIdcInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H265_PROFILE_IDC_MAX_ENUM")]
        StdVideoH265ProfileIdcMaxEnum = 0x7FFFFFFF,
    }
}
