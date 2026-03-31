// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1ChromaSamplePosition")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAv1ChromaSamplePosition : uint
{
    [NativeName("STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_UNKNOWN")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ChromaSamplePositionUnknown = 0,

    [NativeName("STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_VERTICAL")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ChromaSamplePositionVertical = 1,

    [NativeName("STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_COLOCATED")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ChromaSamplePositionColocated = 2,

    [NativeName("STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_RESERVED")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ChromaSamplePositionReserved = 3,

    [NativeName("STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ChromaSamplePositionInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ChromaSamplePositionMaxEnum = 0x7FFFFFFF,
}
