// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoH264NonVclNaluType")]
    public enum StdVideoH264NonVclNaluType : int
    {
        [NativeName("Name", "std_video_h264_non_vcl_nalu_type_sps")]
        StdVideoH264NonVclNaluTypeSps = 0x0,
        [NativeName("Name", "std_video_h264_non_vcl_nalu_type_pps")]
        StdVideoH264NonVclNaluTypePps = 0x1,
        [NativeName("Name", "std_video_h264_non_vcl_nalu_type_aud")]
        StdVideoH264NonVclNaluTypeAud = 0x2,
        [NativeName("Name", "std_video_h264_non_vcl_nalu_type_prefix")]
        StdVideoH264NonVclNaluTypePrefix = 0x3,
        [NativeName("Name", "std_video_h264_non_vcl_nalu_type_end_of_sequence")]
        StdVideoH264NonVclNaluTypeEndOfSequence = 0x4,
        [NativeName("Name", "std_video_h264_non_vcl_nalu_type_end_of_stream")]
        StdVideoH264NonVclNaluTypeEndOfStream = 0x5,
        [NativeName("Name", "std_video_h264_non_vcl_nalu_type_precoded")]
        StdVideoH264NonVclNaluTypePrecoded = 0x6,
        [NativeName("Name", "std_video_h264_non_vcl_nalu_type_invalid")]
        StdVideoH264NonVclNaluTypeInvalid = 0x7FFFFFFF,
    }
}
