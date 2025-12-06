// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1FrameRestorationType")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAV1FrameRestorationType : uint
{
    [NativeName("STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_NONE")]
    [SupportedApiProfile("vulkan")]
    None = 0,

    [NativeName("STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_WIENER")]
    [SupportedApiProfile("vulkan")]
    Wiener = 1,

    [NativeName("STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_SGRPROJ")]
    [SupportedApiProfile("vulkan")]
    Sgrproj = 2,

    [NativeName("STD_VIDEO_AV1_FRAME_RESTORATION_TYPE_SWITCHABLE")]
    [SupportedApiProfile("vulkan")]
    Switchable = 3,
}
