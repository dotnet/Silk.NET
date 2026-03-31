// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264AspectRatioIdc")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH264AspectRatioIdc : uint
{
    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_UNSPECIFIED")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdcUnspecified = 0,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_SQUARE")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdcSquare = 1,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_12_11")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdc12x11 = 2,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_10_11")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdc10x11 = 3,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_16_11")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdc16x11 = 4,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_40_33")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdc40x33 = 5,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_24_11")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdc24x11 = 6,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_20_11")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdc20x11 = 7,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_32_11")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdc32x11 = 8,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_80_33")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdc80x33 = 9,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_18_11")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdc18x11 = 10,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_15_11")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdc15x11 = 11,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_64_33")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdc64x33 = 12,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_160_99")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdc160x99 = 13,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_4_3")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdc4x3 = 14,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_3_2")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdc3x2 = 15,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_2_1")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdc2x1 = 16,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_EXTENDED_SAR")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdcExtendedSar = 255,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdcInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264AspectRatioIdcMaxEnum = 0x7FFFFFFF,
}
