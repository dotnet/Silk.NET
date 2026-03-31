// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1InterpolationFilter")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAv1InterpolationFilter : uint
{
    [NativeName("STD_VIDEO_AV1_INTERPOLATION_FILTER_EIGHTTAP")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1InterpolationFilterEighttap = 0,

    [NativeName("STD_VIDEO_AV1_INTERPOLATION_FILTER_EIGHTTAP_SMOOTH")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1InterpolationFilterEighttapSmooth = 1,

    [NativeName("STD_VIDEO_AV1_INTERPOLATION_FILTER_EIGHTTAP_SHARP")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1InterpolationFilterEighttapSharp = 2,

    [NativeName("STD_VIDEO_AV1_INTERPOLATION_FILTER_BILINEAR")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1InterpolationFilterBilinear = 3,

    [NativeName("STD_VIDEO_AV1_INTERPOLATION_FILTER_SWITCHABLE")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1InterpolationFilterSwitchable = 4,

    [NativeName("STD_VIDEO_AV1_INTERPOLATION_FILTER_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1InterpolationFilterInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_AV1_INTERPOLATION_FILTER_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1InterpolationFilterMaxEnum = 0x7FFFFFFF,
}
