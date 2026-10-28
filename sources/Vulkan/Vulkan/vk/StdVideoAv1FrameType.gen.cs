// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1FrameType")]
public enum StdVideoAv1FrameType : uint
{
    [NativeName("STD_VIDEO_AV1_FRAME_TYPE_KEY")]
    Key = 0,

    [NativeName("STD_VIDEO_AV1_FRAME_TYPE_INTER")]
    Inter = 1,

    [NativeName("STD_VIDEO_AV1_FRAME_TYPE_INTRA_ONLY")]
    IntraOnly = 2,

    [NativeName("STD_VIDEO_AV1_FRAME_TYPE_SWITCH")]
    Switch = 3,
}
