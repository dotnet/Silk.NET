// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1FrameType")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAv1FrameType : uint
{
    [NativeName("STD_VIDEO_AV1_FRAME_TYPE_KEY")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1FrameTypeKey = 0,

    [NativeName("STD_VIDEO_AV1_FRAME_TYPE_INTER")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1FrameTypeInter = 1,

    [NativeName("STD_VIDEO_AV1_FRAME_TYPE_INTRA_ONLY")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1FrameTypeIntraOnly = 2,

    [NativeName("STD_VIDEO_AV1_FRAME_TYPE_SWITCH")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1FrameTypeSwitch = 3,

    [NativeName("STD_VIDEO_AV1_FRAME_TYPE_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1FrameTypeInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_AV1_FRAME_TYPE_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1FrameTypeMaxEnum = 0x7FFFFFFF,
}
