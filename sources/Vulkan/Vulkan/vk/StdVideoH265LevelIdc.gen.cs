// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265LevelIdc")]
public enum StdVideoH265LevelIdc : uint
{
    [NativeName("STD_VIDEO_H265_LEVEL_IDC_1_0")]
    Idc1x0 = 0,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_2_0")]
    Idc2x0 = 1,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_2_1")]
    Idc2x1 = 2,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_3_0")]
    Idc3x0 = 3,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_3_1")]
    Idc3x1 = 4,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_4_0")]
    Idc4x0 = 5,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_4_1")]
    Idc4x1 = 6,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_5_0")]
    Idc5x0 = 7,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_5_1")]
    Idc5x1 = 8,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_5_2")]
    Idc5x2 = 9,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_6_0")]
    Idc6x0 = 10,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_6_1")]
    Idc6x1 = 11,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_6_2")]
    Idc6x2 = 12,
}
