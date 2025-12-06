// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoVP9ColorSpace")]
[SupportedApiProfile("vulkan")]
public enum StdVideoVP9ColorSpace : uint
{
    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_UNKNOWN")]
    [SupportedApiProfile("vulkan")]
    Unknown = 0,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_BT_601")]
    [SupportedApiProfile("vulkan")]
    Bt601 = 1,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_BT_709")]
    [SupportedApiProfile("vulkan")]
    Bt709 = 2,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_SMPTE_170")]
    [SupportedApiProfile("vulkan")]
    Smpte170 = 3,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_SMPTE_240")]
    [SupportedApiProfile("vulkan")]
    Smpte240 = 4,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_BT_2020")]
    [SupportedApiProfile("vulkan")]
    Bt2020 = 5,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_RESERVED")]
    [SupportedApiProfile("vulkan")]
    Reserved = 6,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_RGB")]
    [SupportedApiProfile("vulkan")]
    Rgb = 7,
}
