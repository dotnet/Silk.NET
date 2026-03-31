// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoVP9Profile")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoVp9Profile : uint
{
    [NativeName("STD_VIDEO_VP9_PROFILE_0")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9Profile0 = 0,

    [NativeName("STD_VIDEO_VP9_PROFILE_1")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9Profile1 = 1,

    [NativeName("STD_VIDEO_VP9_PROFILE_2")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9Profile2 = 2,

    [NativeName("STD_VIDEO_VP9_PROFILE_3")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9Profile3 = 3,

    [NativeName("STD_VIDEO_VP9_PROFILE_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ProfileInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_VP9_PROFILE_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoVp9ProfileMaxEnum = 0x7FFFFFFF,
}
