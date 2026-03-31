// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1ColorPrimaries")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAv1ColorPrimaries : uint
{
    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_709")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ColorPrimariesBt709 = 1,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_UNSPECIFIED")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ColorPrimariesUnspecified = 2,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_470_M")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ColorPrimariesBt470M = 4,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_470_B_G")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ColorPrimariesBt470BG = 5,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_601")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ColorPrimariesBt601 = 6,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_240")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ColorPrimariesSmpte240 = 7,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_GENERIC_FILM")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ColorPrimariesGenericFilm = 8,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_2020")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ColorPrimariesBt2020 = 9,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_XYZ")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ColorPrimariesXyz = 10,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_431")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ColorPrimariesSmpte431 = 11,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_SMPTE_432")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ColorPrimariesSmpte432 = 12,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_EBU_3213")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ColorPrimariesEbu3213 = 22,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ColorPrimariesInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_BT_UNSPECIFIED")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ColorPrimariesBtUnspecified = StdVideoAv1ColorPrimariesUnspecified,

    [NativeName("STD_VIDEO_AV1_COLOR_PRIMARIES_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ColorPrimariesMaxEnum = 0x7FFFFFFF,
}
