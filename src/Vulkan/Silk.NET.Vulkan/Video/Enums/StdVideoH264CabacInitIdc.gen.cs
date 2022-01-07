// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [Flags]
    [NativeName("Name", "StdVideoH264CabacInitIdc")]
    public enum StdVideoH264CabacInitIdc : int
    {
        [NativeName("Name", "STD_VIDEO_H264_CABAC_INIT_IDC_0")]
        StdVideoH264CabacInitIdc0 = 0x0,
        [NativeName("Name", "STD_VIDEO_H264_CABAC_INIT_IDC_1")]
        StdVideoH264CabacInitIdc1 = 0x1,
        [NativeName("Name", "STD_VIDEO_H264_CABAC_INIT_IDC_2")]
        StdVideoH264CabacInitIdc2 = 0x2,
        [NativeName("Name", "STD_VIDEO_H264_CABAC_INIT_IDC_INVALID")]
        StdVideoH264CabacInitIdcInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_CABAC_INIT_IDC_MAX_ENUM")]
        StdVideoH264CabacInitIdcMaxEnum = 0x7FFFFFFF,
    }
}
