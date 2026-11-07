// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264LevelIdc")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH264LevelIdc : uint
{
    [NativeName("STD_VIDEO_H264_LEVEL_IDC_1_0")]
    [SupportedApiProfile("vulkan")]
    Idc1x0 = 0,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_1_1")]
    [SupportedApiProfile("vulkan")]
    Idc1x1 = 1,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_1_2")]
    [SupportedApiProfile("vulkan")]
    Idc1x2 = 2,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_1_3")]
    [SupportedApiProfile("vulkan")]
    Idc1x3 = 3,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_2_0")]
    [SupportedApiProfile("vulkan")]
    Idc2x0 = 4,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_2_1")]
    [SupportedApiProfile("vulkan")]
    Idc2x1 = 5,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_2_2")]
    [SupportedApiProfile("vulkan")]
    Idc2x2 = 6,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_3_0")]
    [SupportedApiProfile("vulkan")]
    Idc3x0 = 7,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_3_1")]
    [SupportedApiProfile("vulkan")]
    Idc3x1 = 8,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_3_2")]
    [SupportedApiProfile("vulkan")]
    Idc3x2 = 9,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_4_0")]
    [SupportedApiProfile("vulkan")]
    Idc4x0 = 10,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_4_1")]
    [SupportedApiProfile("vulkan")]
    Idc4x1 = 11,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_4_2")]
    [SupportedApiProfile("vulkan")]
    Idc4x2 = 12,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_5_0")]
    [SupportedApiProfile("vulkan")]
    Idc5x0 = 13,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_5_1")]
    [SupportedApiProfile("vulkan")]
    Idc5x1 = 14,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_5_2")]
    [SupportedApiProfile("vulkan")]
    Idc5x2 = 15,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_6_0")]
    [SupportedApiProfile("vulkan")]
    Idc6x0 = 16,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_6_1")]
    [SupportedApiProfile("vulkan")]
    Idc6x1 = 17,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_6_2")]
    [SupportedApiProfile("vulkan")]
    Idc6x2 = 18,
}
