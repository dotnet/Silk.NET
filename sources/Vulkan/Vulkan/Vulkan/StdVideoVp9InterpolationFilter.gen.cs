// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoVP9InterpolationFilter")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoVp9InterpolationFilter : uint
{
    [NativeName("STD_VIDEO_VP9_INTERPOLATION_FILTER_EIGHTTAP")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9InterpolationFilterEighttap = 0,

    [NativeName("STD_VIDEO_VP9_INTERPOLATION_FILTER_EIGHTTAP_SMOOTH")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9InterpolationFilterEighttapSmooth = 1,

    [NativeName("STD_VIDEO_VP9_INTERPOLATION_FILTER_EIGHTTAP_SHARP")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9InterpolationFilterEighttapSharp = 2,

    [NativeName("STD_VIDEO_VP9_INTERPOLATION_FILTER_BILINEAR")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9InterpolationFilterBilinear = 3,

    [NativeName("STD_VIDEO_VP9_INTERPOLATION_FILTER_SWITCHABLE")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9InterpolationFilterSwitchable = 4,

    [NativeName("STD_VIDEO_VP9_INTERPOLATION_FILTER_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9InterpolationFilterInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_VP9_INTERPOLATION_FILTER_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9InterpolationFilterMaxEnum = 0x7FFFFFFF,
}
