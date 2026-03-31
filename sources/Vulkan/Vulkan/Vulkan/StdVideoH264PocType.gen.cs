// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264PocType")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH264PocType : uint
{
    [NativeName("STD_VIDEO_H264_POC_TYPE_0")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264PocType0 = 0,

    [NativeName("STD_VIDEO_H264_POC_TYPE_1")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264PocType1 = 1,

    [NativeName("STD_VIDEO_H264_POC_TYPE_2")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264PocType2 = 2,

    [NativeName("STD_VIDEO_H264_POC_TYPE_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264PocTypeInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_H264_POC_TYPE_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264PocTypeMaxEnum = 0x7FFFFFFF,
}
