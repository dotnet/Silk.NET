// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1ColorPrimaries")]
public enum StdVideoAv1ColorPrimaries : uint
{
    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_709")]
    Bt709 = 1,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_UNSPECIFIED")]
    Unspecified = 2,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_470_M")]
    Bt470M = 4,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_470_B_G")]
    Bt470BG = 5,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_601")]
    Bt601 = 6,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_240")]
    Smpte240 = 7,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_GENERIC_FILM")]
    GenericFilm = 8,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_2020")]
    Bt2020 = 9,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_XYZ")]
    Xyz = 10,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_431")]
    Smpte431 = 11,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_432")]
    Smpte432 = 12,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_EBU_3213")]
    Ebu3213 = 22,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_UNSPECIFIED")]
    BtUnspecified = Unspecified,
}
