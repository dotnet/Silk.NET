// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoVP9ColorSpace")]
public enum StdVideoVp9ColorSpace : uint
{
    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_UNKNOWN")]
    Unknown = 0,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_BT_601")]
    Bt601 = 1,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_BT_709")]
    Bt709 = 2,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_SMPTE_170")]
    Smpte170 = 3,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_SMPTE_240")]
    Smpte240 = 4,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_BT_2020")]
    Bt2020 = 5,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_RESERVED")]
    Reserved = 6,

    [NativeName("STD_VIDEO_VP9_COLOR_SPACE_RGB")]
    Rgb = 7,
}
