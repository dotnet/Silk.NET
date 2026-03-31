// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1Level")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAv1Level : uint
{
    [NativeName("STD_VIDEO_AV1_LEVEL_2_0")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level2x0 = 0,

    [NativeName("STD_VIDEO_AV1_LEVEL_2_1")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level2x1 = 1,

    [NativeName("STD_VIDEO_AV1_LEVEL_2_2")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level2x2 = 2,

    [NativeName("STD_VIDEO_AV1_LEVEL_2_3")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level2x3 = 3,

    [NativeName("STD_VIDEO_AV1_LEVEL_3_0")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level3x0 = 4,

    [NativeName("STD_VIDEO_AV1_LEVEL_3_1")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level3x1 = 5,

    [NativeName("STD_VIDEO_AV1_LEVEL_3_2")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level3x2 = 6,

    [NativeName("STD_VIDEO_AV1_LEVEL_3_3")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level3x3 = 7,

    [NativeName("STD_VIDEO_AV1_LEVEL_4_0")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level4x0 = 8,

    [NativeName("STD_VIDEO_AV1_LEVEL_4_1")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level4x1 = 9,

    [NativeName("STD_VIDEO_AV1_LEVEL_4_2")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level4x2 = 10,

    [NativeName("STD_VIDEO_AV1_LEVEL_4_3")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level4x3 = 11,

    [NativeName("STD_VIDEO_AV1_LEVEL_5_0")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level5x0 = 12,

    [NativeName("STD_VIDEO_AV1_LEVEL_5_1")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level5x1 = 13,

    [NativeName("STD_VIDEO_AV1_LEVEL_5_2")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level5x2 = 14,

    [NativeName("STD_VIDEO_AV1_LEVEL_5_3")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level5x3 = 15,

    [NativeName("STD_VIDEO_AV1_LEVEL_6_0")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level6x0 = 16,

    [NativeName("STD_VIDEO_AV1_LEVEL_6_1")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level6x1 = 17,

    [NativeName("STD_VIDEO_AV1_LEVEL_6_2")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level6x2 = 18,

    [NativeName("STD_VIDEO_AV1_LEVEL_6_3")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level6x3 = 19,

    [NativeName("STD_VIDEO_AV1_LEVEL_7_0")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level7x0 = 20,

    [NativeName("STD_VIDEO_AV1_LEVEL_7_1")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level7x1 = 21,

    [NativeName("STD_VIDEO_AV1_LEVEL_7_2")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level7x2 = 22,

    [NativeName("STD_VIDEO_AV1_LEVEL_7_3")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1Level7x3 = 23,

    [NativeName("STD_VIDEO_AV1_LEVEL_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1LevelInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_AV1_LEVEL_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1LevelMaxEnum = 0x7FFFFFFF,
}
