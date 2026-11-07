// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264NonVclNaluType")]
public enum StdVideoH264NonVclNaluType : uint
{
    [NativeName("STD_VIDEO_H264_NON_VCL_NALU_TYPE_SPS")]
    Sps = 0,

    [NativeName("STD_VIDEO_H264_NON_VCL_NALU_TYPE_PPS")]
    Pps = 1,

    [NativeName("STD_VIDEO_H264_NON_VCL_NALU_TYPE_AUD")]
    Aud = 2,

    [NativeName("STD_VIDEO_H264_NON_VCL_NALU_TYPE_PREFIX")]
    Prefix = 3,

    [NativeName("STD_VIDEO_H264_NON_VCL_NALU_TYPE_END_OF_SEQUENCE")]
    EndOfSequence = 4,

    [NativeName("STD_VIDEO_H264_NON_VCL_NALU_TYPE_END_OF_STREAM")]
    EndOfStream = 5,

    [NativeName("STD_VIDEO_H264_NON_VCL_NALU_TYPE_PRECODED")]
    Precoded = 6,
}
