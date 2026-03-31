// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265SliceType")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH265SliceType : uint
{
    [NativeName("STD_VIDEO_H265_SLICE_TYPE_B")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265SliceTypeB = 0,

    [NativeName("STD_VIDEO_H265_SLICE_TYPE_P")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265SliceTypeP = 1,

    [NativeName("STD_VIDEO_H265_SLICE_TYPE_I")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265SliceTypeI = 2,

    [NativeName("STD_VIDEO_H265_SLICE_TYPE_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265SliceTypeInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_H265_SLICE_TYPE_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265SliceTypeMaxEnum = 0x7FFFFFFF,
}
