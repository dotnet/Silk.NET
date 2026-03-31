// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1FrameRestorationType")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAv1FrameRestorationType : uint
{
    [NativeName("STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_NONE")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1FrameRestorationTypeNone = 0,

    [NativeName("STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_WIENER")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1FrameRestorationTypeWiener = 1,

    [NativeName("STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_SGRPROJ")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1FrameRestorationTypeSgrproj = 2,

    [NativeName("STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_SWITCHABLE")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1FrameRestorationTypeSwitchable = 3,

    [NativeName("STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1FrameRestorationTypeInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1FrameRestorationTypeMaxEnum = 0x7FFFFFFF,
}
