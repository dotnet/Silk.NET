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
        [Obsolete("Deprecated in favour of \"Baseline\"")]
        [NativeName("Name", "STD_VIDEO_H264_PROFILE_IDC_BASELINE")]
        StdVideoH264ProfileIdcBaseline = 0x42,
        [Obsolete("Deprecated in favour of \"Main\"")]
        [NativeName("Name", "STD_VIDEO_H264_PROFILE_IDC_MAIN")]
        StdVideoH264ProfileIdcMain = 0x4D,
        [Obsolete("Deprecated in favour of \"High\"")]
        [NativeName("Name", "STD_VIDEO_H264_PROFILE_IDC_HIGH")]
        StdVideoH264ProfileIdcHigh = 0x64,
        [Obsolete("Deprecated in favour of \"High444Predictive\"")]
        [NativeName("Name", "STD_VIDEO_H264_PROFILE_IDC_HIGH_444_PREDICTIVE")]
        StdVideoH264ProfileIdcHigh444Predictive = 0xF4,
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "STD_VIDEO_H264_PROFILE_IDC_INVALID")]
        StdVideoH264ProfileIdcInvalid = 0x7FFFFFFF,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "STD_VIDEO_H264_PROFILE_IDC_MAX_ENUM")]
        StdVideoH264ProfileIdcMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_PROFILE_IDC_BASELINE")]
        Baseline = 0x42,
        [NativeName("Name", "STD_VIDEO_H264_PROFILE_IDC_MAIN")]
        Main = 0x4D,
        [NativeName("Name", "STD_VIDEO_H264_PROFILE_IDC_HIGH")]
        High = 0x64,
        [NativeName("Name", "STD_VIDEO_H264_PROFILE_IDC_HIGH_444_PREDICTIVE")]
        High444Predictive = 0xF4,
        [NativeName("Name", "STD_VIDEO_H264_PROFILE_IDC_INVALID")]
        Invalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_PROFILE_IDC_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
