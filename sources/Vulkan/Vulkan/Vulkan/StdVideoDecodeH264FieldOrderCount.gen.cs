// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoDecodeH264FieldOrderCount")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoDecodeH264FieldOrderCount : uint
{
    [NativeName("STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_TOP")]
    [SupportedApiProfile("vulkan")]
    StdVideoDecodeH264FieldOrderCountTop = 0,

    [NativeName("STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_BOTTOM")]
    [SupportedApiProfile("vulkan")]
    StdVideoDecodeH264FieldOrderCountBottom = 1,

    [NativeName("STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoDecodeH264FieldOrderCountInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_DECODE_H264_FIELD_ORDER_COUNT_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoDecodeH264FieldOrderCountMaxEnum = 0x7FFFFFFF,
}
