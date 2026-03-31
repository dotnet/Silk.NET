// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265LevelIdc")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH265LevelIdc : uint
{
    [NativeName("STD_VIDEO_H265_LEVEL_IDC_1_0")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265LevelIdc1x0 = 0,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_2_0")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265LevelIdc2x0 = 1,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_2_1")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265LevelIdc2x1 = 2,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_3_0")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265LevelIdc3x0 = 3,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_3_1")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265LevelIdc3x1 = 4,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_4_0")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265LevelIdc4x0 = 5,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_4_1")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265LevelIdc4x1 = 6,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_5_0")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265LevelIdc5x0 = 7,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_5_1")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265LevelIdc5x1 = 8,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_5_2")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265LevelIdc5x2 = 9,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_6_0")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265LevelIdc6x0 = 10,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_6_1")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265LevelIdc6x1 = 11,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_6_2")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265LevelIdc6x2 = 12,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265LevelIdcInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_H265_LEVEL_IDC_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265LevelIdcMaxEnum = 0x7FFFFFFF,
}
