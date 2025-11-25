// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoVP9FrameType")]
[SupportedApiProfile("vulkan")]
public enum StdVideoVP9FrameType : uint
{
    [NativeName("STD_VIDEO_VP9_FRAME_TYPE_KEY")]
    [SupportedApiProfile("vulkan")]
    Key = 0,

    [NativeName("STD_VIDEO_VP9_FRAME_TYPE_NON_KEY")]
    [SupportedApiProfile("vulkan")]
    NonKey = 1,
}
