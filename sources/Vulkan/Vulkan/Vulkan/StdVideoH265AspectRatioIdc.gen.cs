// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265AspectRatioIdc")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH265AspectRatioIdc : uint
{
    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_UNSPECIFIED")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdcUnspecified = 0,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_SQUARE")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdcSquare = 1,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_12_11")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdc12x11 = 2,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_10_11")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdc10x11 = 3,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_16_11")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdc16x11 = 4,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_40_33")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdc40x33 = 5,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_24_11")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdc24x11 = 6,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_20_11")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdc20x11 = 7,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_32_11")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdc32x11 = 8,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_80_33")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdc80x33 = 9,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_18_11")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdc18x11 = 10,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_15_11")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdc15x11 = 11,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_64_33")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdc64x33 = 12,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_160_99")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdc160x99 = 13,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_4_3")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdc4x3 = 14,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_3_2")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdc3x2 = 15,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_2_1")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdc2x1 = 16,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_EXTENDED_SAR")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdcExtendedSar = 255,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdcInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_H265_ASPECT_RATIO_IDC_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265AspectRatioIdcMaxEnum = 0x7FFFFFFF,
}
