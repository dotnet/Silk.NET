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
        [NativeName("Name", "STD_VIDEO_H264_NON_VCL_NALU_TYPE_SPS")]
        StdVideoH264NonVclNaluTypeSps = 0x0,
        [NativeName("Name", "STD_VIDEO_H264_NON_VCL_NALU_TYPE_PPS")]
        StdVideoH264NonVclNaluTypePps = 0x1,
        [NativeName("Name", "STD_VIDEO_H264_NON_VCL_NALU_TYPE_AUD")]
        StdVideoH264NonVclNaluTypeAud = 0x2,
        [NativeName("Name", "STD_VIDEO_H264_NON_VCL_NALU_TYPE_PREFIX")]
        StdVideoH264NonVclNaluTypePrefix = 0x3,
        [NativeName("Name", "STD_VIDEO_H264_NON_VCL_NALU_TYPE_END_OF_SEQUENCE")]
        StdVideoH264NonVclNaluTypeEndOfSequence = 0x4,
        [NativeName("Name", "STD_VIDEO_H264_NON_VCL_NALU_TYPE_END_OF_STREAM")]
        StdVideoH264NonVclNaluTypeEndOfStream = 0x5,
        [NativeName("Name", "STD_VIDEO_H264_NON_VCL_NALU_TYPE_PRECODED")]
        StdVideoH264NonVclNaluTypePrecoded = 0x6,
        [NativeName("Name", "STD_VIDEO_H264_NON_VCL_NALU_TYPE_INVALID")]
        StdVideoH264NonVclNaluTypeInvalid = 0x7FFFFFFF,
        [NativeName("Name", "STD_VIDEO_H264_NON_VCL_NALU_TYPE_MAX_ENUM")]
        StdVideoH264NonVclNaluTypeMaxEnum = 0x7FFFFFFF,
    }
}
