// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoVP9ColorSpace")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoVp9ColorSpace : uint
{
    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_UNKNOWN")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ColorSpaceUnknown = 0,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_BT_601")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ColorSpaceBt601 = 1,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_BT_709")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ColorSpaceBt709 = 2,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_SMPTE_170")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ColorSpaceSmpte170 = 3,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_SMPTE_240")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ColorSpaceSmpte240 = 4,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_BT_2020")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ColorSpaceBt2020 = 5,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_RESERVED")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ColorSpaceReserved = 6,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_RGB")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ColorSpaceRgb = 7,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ColorSpaceInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ColorSpaceMaxEnum = 0x7FFFFFFF,
}
