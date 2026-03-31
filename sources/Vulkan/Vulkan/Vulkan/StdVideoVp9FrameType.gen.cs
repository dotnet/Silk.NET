// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoVP9FrameType")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoVp9FrameType : uint
{
    [NativeName("STD_VIDEO_VP9_FRAME_TYPE_KEY")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9FrameTypeKey = 0,

    [NativeName("STD_VIDEO_VP9_FRAME_TYPE_NON_KEY")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9FrameTypeNonKey = 1,

    [NativeName("STD_VIDEO_VP9_FRAME_TYPE_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9FrameTypeInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_VP9_FRAME_TYPE_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9FrameTypeMaxEnum = 0x7FFFFFFF,
}
