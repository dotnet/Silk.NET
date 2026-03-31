// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264SliceType")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH264SliceType : uint
{
    [NativeName("STD_VIDEO_H264_SLICE_TYPE_P")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264SliceTypeP = 0,

    [NativeName("STD_VIDEO_H264_SLICE_TYPE_B")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264SliceTypeB = 1,

    [NativeName("STD_VIDEO_H264_SLICE_TYPE_I")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264SliceTypeI = 2,

    [NativeName("STD_VIDEO_H264_SLICE_TYPE_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264SliceTypeInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_H264_SLICE_TYPE_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264SliceTypeMaxEnum = 0x7FFFFFFF,
}
