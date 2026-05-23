// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1ColorPrimaries")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAv1ColorPrimaries : uint
{
    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_709")]
    [SupportedApiProfile("vulkan")]
    Bt709 = 1,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_UNSPECIFIED")]
    [SupportedApiProfile("vulkan")]
    Unspecified = 2,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_470_M")]
    [SupportedApiProfile("vulkan")]
    Bt470M = 4,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_470_B_G")]
    [SupportedApiProfile("vulkan")]
    Bt470BG = 5,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_601")]
    [SupportedApiProfile("vulkan")]
    Bt601 = 6,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_240")]
    [SupportedApiProfile("vulkan")]
    Smpte240 = 7,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_GENERIC_FILM")]
    [SupportedApiProfile("vulkan")]
    GenericFilm = 8,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_2020")]
    [SupportedApiProfile("vulkan")]
    Bt2020 = 9,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_XYZ")]
    [SupportedApiProfile("vulkan")]
    Xyz = 10,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_431")]
    [SupportedApiProfile("vulkan")]
    Smpte431 = 11,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_432")]
    [SupportedApiProfile("vulkan")]
    Smpte432 = 12,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_EBU_3213")]
    [SupportedApiProfile("vulkan")]
    Ebu3213 = 22,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_UNSPECIFIED")]
    [SupportedApiProfile("vulkan")]
    BtUnspecified = Unspecified,
}
