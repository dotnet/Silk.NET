// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1InterpolationFilter")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAv1InterpolationFilter : uint
{
    [NativeName("STD_VIDEO_AV1_INTERPOLATION_FILTER_EIGHTTAP")]
    [SupportedApiProfile("vulkan")]
    Eighttap = 0,

    [NativeName("STD_VIDEO_AV1_INTERPOLATION_FILTER_EIGHTTAP_SMOOTH")]
    [SupportedApiProfile("vulkan")]
    EighttapSmooth = 1,

    [NativeName("STD_VIDEO_AV1_INTERPOLATION_FILTER_EIGHTTAP_SHARP")]
    [SupportedApiProfile("vulkan")]
    EighttapSharp = 2,

    [NativeName("STD_VIDEO_AV1_INTERPOLATION_FILTER_BILINEAR")]
    [SupportedApiProfile("vulkan")]
    Bilinear = 3,

    [NativeName("STD_VIDEO_AV1_INTERPOLATION_FILTER_SWITCHABLE")]
    [SupportedApiProfile("vulkan")]
    Switchable = 4,
}
