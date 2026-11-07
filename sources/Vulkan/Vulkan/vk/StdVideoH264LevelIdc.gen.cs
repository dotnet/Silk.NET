// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264LevelIdc")]
public enum StdVideoH264LevelIdc : uint
{
    [NativeName("STD_VIDEO_H264_LEVEL_IDC_1_0")]
    Idc1x0 = 0,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_1_1")]
    Idc1x1 = 1,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_1_2")]
    Idc1x2 = 2,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_1_3")]
    Idc1x3 = 3,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_2_0")]
    Idc2x0 = 4,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_2_1")]
    Idc2x1 = 5,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_2_2")]
    Idc2x2 = 6,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_3_0")]
    Idc3x0 = 7,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_3_1")]
    Idc3x1 = 8,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_3_2")]
    Idc3x2 = 9,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_4_0")]
    Idc4x0 = 10,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_4_1")]
    Idc4x1 = 11,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_4_2")]
    Idc4x2 = 12,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_5_0")]
    Idc5x0 = 13,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_5_1")]
    Idc5x1 = 14,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_5_2")]
    Idc5x2 = 15,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_6_0")]
    Idc6x0 = 16,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_6_1")]
    Idc6x1 = 17,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_6_2")]
    Idc6x2 = 18,
}
