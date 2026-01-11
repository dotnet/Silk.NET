// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoVP9Level")]
[SupportedApiProfile("vulkan")]
public enum StdVideoVp9Level : uint
{
    [NativeName("STD_VIDEO_VP9_LEVEL_1_0")]
    [SupportedApiProfile("vulkan")]
    Level1x0 = 0,

    [NativeName("STD_VIDEO_VP9_LEVEL_1_1")]
    [SupportedApiProfile("vulkan")]
    Level1x1 = 1,

    [NativeName("STD_VIDEO_VP9_LEVEL_2_0")]
    [SupportedApiProfile("vulkan")]
    Level2x0 = 2,

    [NativeName("STD_VIDEO_VP9_LEVEL_2_1")]
    [SupportedApiProfile("vulkan")]
    Level2x1 = 3,

    [NativeName("STD_VIDEO_VP9_LEVEL_3_0")]
    [SupportedApiProfile("vulkan")]
    Level3x0 = 4,

    [NativeName("STD_VIDEO_VP9_LEVEL_3_1")]
    [SupportedApiProfile("vulkan")]
    Level3x1 = 5,

    [NativeName("STD_VIDEO_VP9_LEVEL_4_0")]
    [SupportedApiProfile("vulkan")]
    Level4x0 = 6,

    [NativeName("STD_VIDEO_VP9_LEVEL_4_1")]
    [SupportedApiProfile("vulkan")]
    Level4x1 = 7,

    [NativeName("STD_VIDEO_VP9_LEVEL_5_0")]
    [SupportedApiProfile("vulkan")]
    Level5x0 = 8,

    [NativeName("STD_VIDEO_VP9_LEVEL_5_1")]
    [SupportedApiProfile("vulkan")]
    Level5x1 = 9,

    [NativeName("STD_VIDEO_VP9_LEVEL_5_2")]
    [SupportedApiProfile("vulkan")]
    Level5x2 = 10,

    [NativeName("STD_VIDEO_VP9_LEVEL_6_0")]
    [SupportedApiProfile("vulkan")]
    Level6x0 = 11,

    [NativeName("STD_VIDEO_VP9_LEVEL_6_1")]
    [SupportedApiProfile("vulkan")]
    Level6x1 = 12,

    [NativeName("STD_VIDEO_VP9_LEVEL_6_2")]
    [SupportedApiProfile("vulkan")]
    Level6x2 = 13,
}
