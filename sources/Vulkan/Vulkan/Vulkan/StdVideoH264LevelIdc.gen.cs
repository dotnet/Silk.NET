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
    Idc1X0 = 0,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_1_1")]
    [SupportedApiProfile("vulkan")]
    Idc1X1 = 1,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_1_2")]
    [SupportedApiProfile("vulkan")]
    Idc1X2 = 2,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_1_3")]
    [SupportedApiProfile("vulkan")]
    Idc1X3 = 3,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_2_0")]
    [SupportedApiProfile("vulkan")]
    Idc2X0 = 4,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_2_1")]
    [SupportedApiProfile("vulkan")]
    Idc2X1 = 5,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_2_2")]
    [SupportedApiProfile("vulkan")]
    Idc2X2 = 6,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_3_0")]
    [SupportedApiProfile("vulkan")]
    Idc3X0 = 7,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_3_1")]
    [SupportedApiProfile("vulkan")]
    Idc3X1 = 8,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_3_2")]
    [SupportedApiProfile("vulkan")]
    Idc3X2 = 9,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_4_0")]
    [SupportedApiProfile("vulkan")]
    Idc4X0 = 10,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_4_1")]
    [SupportedApiProfile("vulkan")]
    Idc4X1 = 11,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_4_2")]
    [SupportedApiProfile("vulkan")]
    Idc4X2 = 12,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_5_0")]
    [SupportedApiProfile("vulkan")]
    Idc5X0 = 13,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_5_1")]
    [SupportedApiProfile("vulkan")]
    Idc5X1 = 14,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_5_2")]
    [SupportedApiProfile("vulkan")]
    Idc5X2 = 15,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_6_0")]
    [SupportedApiProfile("vulkan")]
    Idc6X0 = 16,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_6_1")]
    [SupportedApiProfile("vulkan")]
    Idc6X1 = 17,

    [NativeName("STD_VIDEO_H264_LEVEL_IDC_6_2")]
    [SupportedApiProfile("vulkan")]
    Idc6X2 = 18,
}
