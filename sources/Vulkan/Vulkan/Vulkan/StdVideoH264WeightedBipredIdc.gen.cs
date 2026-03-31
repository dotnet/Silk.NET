// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264WeightedBipredIdc")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH264WeightedBipredIdc : uint
{
    [NativeName("STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_DEFAULT")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264WeightedBipredIdcDefault = 0,

    [NativeName("STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_EXPLICIT")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264WeightedBipredIdcExplicit = 1,

    [NativeName("STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_IMPLICIT")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264WeightedBipredIdcImplicit = 2,

    [NativeName("STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264WeightedBipredIdcInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_H264_WEIGHTED_BIPRED_IDC_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264WeightedBipredIdcMaxEnum = 0x7FFFFFFF,
}
