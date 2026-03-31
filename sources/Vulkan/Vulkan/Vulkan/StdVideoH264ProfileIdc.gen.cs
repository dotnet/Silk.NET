// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264ProfileIdc")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH264ProfileIdc : uint
{
    [NativeName("STD_VIDEO_H264_PROFILE_IDC_BASELINE")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ProfileIdcBaseline = 66,

    [NativeName("STD_VIDEO_H264_PROFILE_IDC_MAIN")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ProfileIdcMain = 77,

    [NativeName("STD_VIDEO_H264_PROFILE_IDC_HIGH")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ProfileIdcHigh = 100,

    [NativeName("STD_VIDEO_H264_PROFILE_IDC_HIGH_444_PREDICTIVE")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ProfileIdcHigh444Predictive = 244,

    [NativeName("STD_VIDEO_H264_PROFILE_IDC_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ProfileIdcInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_H264_PROFILE_IDC_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ProfileIdcMaxEnum = 0x7FFFFFFF,
}
