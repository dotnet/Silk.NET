// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264ProfileIdc")]
public enum StdVideoH264ProfileIdc : uint
{
    [NativeName("STD_VIDEO_H264_PROFILE_IDC_BASELINE")]
    Baseline = 66,

    [NativeName("STD_VIDEO_H264_PROFILE_IDC_MAIN")]
    Main = 77,

    [NativeName("STD_VIDEO_H264_PROFILE_IDC_HIGH")]
    High = 100,

    [NativeName("STD_VIDEO_H264_PROFILE_IDC_HIGH_444_PREDICTIVE")]
    High444Predictive = 244,
}
