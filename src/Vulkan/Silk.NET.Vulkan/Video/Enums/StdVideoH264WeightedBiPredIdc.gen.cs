// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [Flags]
    [NativeName("Name", "StdVideoH264WeightedBipredIdc")]
    public enum StdVideoH264WeightedBipredIdc : int
    {
        [NativeName("Name", "STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_DEFAULT")]
        StdVideoH264WeightedBipredIdcDefault = 0x0,
        [NativeName("Name", "STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_EXPLICIT")]
        StdVideoH264WeightedBipredIdcExplicit = 0x1,
        [NativeName("Name", "STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_IMPLICIT")]
        StdVideoH264WeightedBipredIdcImplicit = 0x2,
        [NativeName("Name", "STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_INVALID")]
        StdVideoH264WeightedBipredIdcInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_MAX_ENUM")]
        StdVideoH264WeightedBipredIdcMaxEnum = 0x7FFFFFFF,
    }
}
