// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1Level")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAv1Level : uint
{
    [NativeName("STD_VIDEO_AV1_LEVEL_2_0")]
    [SupportedApiProfile("vulkan")]
    Level2X0 = 0,

    [NativeName("STD_VIDEO_AV1_LEVEL_2_1")]
    [SupportedApiProfile("vulkan")]
    Level2X1 = 1,

    [NativeName("STD_VIDEO_AV1_LEVEL_2_2")]
    [SupportedApiProfile("vulkan")]
    Level2X2 = 2,

    [NativeName("STD_VIDEO_AV1_LEVEL_2_3")]
    [SupportedApiProfile("vulkan")]
    Level2X3 = 3,

    [NativeName("STD_VIDEO_AV1_LEVEL_3_0")]
    [SupportedApiProfile("vulkan")]
    Level3X0 = 4,

    [NativeName("STD_VIDEO_AV1_LEVEL_3_1")]
    [SupportedApiProfile("vulkan")]
    Level3X1 = 5,

    [NativeName("STD_VIDEO_AV1_LEVEL_3_2")]
    [SupportedApiProfile("vulkan")]
    Level3X2 = 6,

    [NativeName("STD_VIDEO_AV1_LEVEL_3_3")]
    [SupportedApiProfile("vulkan")]
    Level3X3 = 7,

    [NativeName("STD_VIDEO_AV1_LEVEL_4_0")]
    [SupportedApiProfile("vulkan")]
    Level4X0 = 8,

    [NativeName("STD_VIDEO_AV1_LEVEL_4_1")]
    [SupportedApiProfile("vulkan")]
    Level4X1 = 9,

    [NativeName("STD_VIDEO_AV1_LEVEL_4_2")]
    [SupportedApiProfile("vulkan")]
    Level4X2 = 10,

    [NativeName("STD_VIDEO_AV1_LEVEL_4_3")]
    [SupportedApiProfile("vulkan")]
    Level4X3 = 11,

    [NativeName("STD_VIDEO_AV1_LEVEL_5_0")]
    [SupportedApiProfile("vulkan")]
    Level5X0 = 12,

    [NativeName("STD_VIDEO_AV1_LEVEL_5_1")]
    [SupportedApiProfile("vulkan")]
    Level5X1 = 13,

    [NativeName("STD_VIDEO_AV1_LEVEL_5_2")]
    [SupportedApiProfile("vulkan")]
    Level5X2 = 14,

    [NativeName("STD_VIDEO_AV1_LEVEL_5_3")]
    [SupportedApiProfile("vulkan")]
    Level5X3 = 15,

    [NativeName("STD_VIDEO_AV1_LEVEL_6_0")]
    [SupportedApiProfile("vulkan")]
    Level6X0 = 16,

    [NativeName("STD_VIDEO_AV1_LEVEL_6_1")]
    [SupportedApiProfile("vulkan")]
    Level6X1 = 17,

    [NativeName("STD_VIDEO_AV1_LEVEL_6_2")]
    [SupportedApiProfile("vulkan")]
    Level6X2 = 18,

    [NativeName("STD_VIDEO_AV1_LEVEL_6_3")]
    [SupportedApiProfile("vulkan")]
    Level6X3 = 19,

    [NativeName("STD_VIDEO_AV1_LEVEL_7_0")]
    [SupportedApiProfile("vulkan")]
    Level7X0 = 20,

    [NativeName("STD_VIDEO_AV1_LEVEL_7_1")]
    [SupportedApiProfile("vulkan")]
    Level7X1 = 21,

    [NativeName("STD_VIDEO_AV1_LEVEL_7_2")]
    [SupportedApiProfile("vulkan")]
    Level7X2 = 22,

    [NativeName("STD_VIDEO_AV1_LEVEL_7_3")]
    [SupportedApiProfile("vulkan")]
    Level7X3 = 23,
}
