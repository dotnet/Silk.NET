// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoVP9InterpolationFilter")]
public enum StdVideoVp9InterpolationFilter : uint
{
    [NativeName("STD_VIDEO_VP9_INTERPOLATION_FILTER_EIGHTTAP")]
    Eighttap = 0,

    [NativeName("STD_VIDEO_VP9_INTERPOLATION_FILTER_EIGHTTAP_SMOOTH")]
    EighttapSmooth = 1,

    [NativeName("STD_VIDEO_VP9_INTERPOLATION_FILTER_EIGHTTAP_SHARP")]
    EighttapSharp = 2,

    [NativeName("STD_VIDEO_VP9_INTERPOLATION_FILTER_BILINEAR")]
    Bilinear = 3,

    [NativeName("STD_VIDEO_VP9_INTERPOLATION_FILTER_SWITCHABLE")]
    Switchable = 4,
}
