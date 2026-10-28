// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264AspectRatioIdc")]
public enum StdVideoH264AspectRatioIdc : uint
{
    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_UNSPECIFIED")]
    IdcUnspecified = 0,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_SQUARE")]
    IdcSquare = 1,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_12_11")]
    Idc12x11 = 2,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_10_11")]
    Idc10x11 = 3,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_16_11")]
    Idc16x11 = 4,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_40_33")]
    Idc40x33 = 5,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_24_11")]
    Idc24x11 = 6,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_20_11")]
    Idc20x11 = 7,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_32_11")]
    Idc32x11 = 8,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_80_33")]
    Idc80x33 = 9,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_18_11")]
    Idc18x11 = 10,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_15_11")]
    Idc15x11 = 11,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_64_33")]
    Idc64x33 = 12,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_160_99")]
    Idc160x99 = 13,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_4_3")]
    Idc4x3 = 14,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_3_2")]
    Idc3x2 = 15,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_2_1")]
    Idc2x1 = 16,

    [NativeName("STD_VIDEO_H264_ASPECT_RATIO_IDC_EXTENDED_SAR")]
    IdcExtendedSar = 255,
}
