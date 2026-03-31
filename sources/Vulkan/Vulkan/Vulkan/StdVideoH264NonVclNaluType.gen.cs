// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264NonVclNaluType")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH264NonVclNaluType : uint
{
    [NativeName("STD_VIDEO_H264_NON_VCL_NALU_TYPE_SPS")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264NonVclNaluTypeSps = 0,

    [NativeName("STD_VIDEO_H264_NON_VCL_NALU_TYPE_PPS")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264NonVclNaluTypePps = 1,

    [NativeName("STD_VIDEO_H264_NON_VCL_NALU_TYPE_AUD")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264NonVclNaluTypeAud = 2,

    [NativeName("STD_VIDEO_H264_NON_VCL_NALU_TYPE_PREFIX")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264NonVclNaluTypePrefix = 3,

    [NativeName("STD_VIDEO_H264_NON_VCL_NALU_TYPE_END_OF_SEQUENCE")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264NonVclNaluTypeEndOfSequence = 4,

    [NativeName("STD_VIDEO_H264_NON_VCL_NALU_TYPE_END_OF_STREAM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264NonVclNaluTypeEndOfStream = 5,

    [NativeName("STD_VIDEO_H264_NON_VCL_NALU_TYPE_PRECODED")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264NonVclNaluTypePrecoded = 6,

    [NativeName("STD_VIDEO_H264_NON_VCL_NALU_TYPE_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264NonVclNaluTypeInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_H264_NON_VCL_NALU_TYPE_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264NonVclNaluTypeMaxEnum = 0x7FFFFFFF,
}
