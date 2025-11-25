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
public enum StdVideoVP9Level : uint
{
    [NativeName("STD_VIDEO_VP9_LEVEL_1_0")]
    [SupportedApiProfile("vulkan")]
    Level1X0 = 0,

    [NativeName("STD_VIDEO_VP9_LEVEL_1_1")]
    [SupportedApiProfile("vulkan")]
    Level1X1 = 1,

    [NativeName("STD_VIDEO_VP9_LEVEL_2_0")]
    [SupportedApiProfile("vulkan")]
    Level2X0 = 2,

    [NativeName("STD_VIDEO_VP9_LEVEL_2_1")]
    [SupportedApiProfile("vulkan")]
    Level2X1 = 3,

    [NativeName("STD_VIDEO_VP9_LEVEL_3_0")]
    [SupportedApiProfile("vulkan")]
    Level3X0 = 4,

    [NativeName("STD_VIDEO_VP9_LEVEL_3_1")]
    [SupportedApiProfile("vulkan")]
    Level3X1 = 5,

    [NativeName("STD_VIDEO_VP9_LEVEL_4_0")]
    [SupportedApiProfile("vulkan")]
    Level4X0 = 6,

    [NativeName("STD_VIDEO_VP9_LEVEL_4_1")]
    [SupportedApiProfile("vulkan")]
    Level4X1 = 7,

    [NativeName("STD_VIDEO_VP9_LEVEL_5_0")]
    [SupportedApiProfile("vulkan")]
    Level5X0 = 8,

    [NativeName("STD_VIDEO_VP9_LEVEL_5_1")]
    [SupportedApiProfile("vulkan")]
    Level5X1 = 9,

    [NativeName("STD_VIDEO_VP9_LEVEL_5_2")]
    [SupportedApiProfile("vulkan")]
    Level5X2 = 10,

    [NativeName("STD_VIDEO_VP9_LEVEL_6_0")]
    [SupportedApiProfile("vulkan")]
    Level6X0 = 11,

    [NativeName("STD_VIDEO_VP9_LEVEL_6_1")]
    [SupportedApiProfile("vulkan")]
    Level6X1 = 12,

    [NativeName("STD_VIDEO_VP9_LEVEL_6_2")]
    [SupportedApiProfile("vulkan")]
    Level6X2 = 13,
}
