// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1Profile")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAv1Profile : uint
{
    [NativeName("STD_VIDEO_AV1_PROFILE_MAIN")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ProfileMain = 0,

    [NativeName("STD_VIDEO_AV1_PROFILE_HIGH")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ProfileHigh = 1,

    [NativeName("STD_VIDEO_AV1_PROFILE_PROFESSIONAL")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ProfileProfessional = 2,

    [NativeName("STD_VIDEO_AV1_PROFILE_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ProfileInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_AV1_PROFILE_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ProfileMaxEnum = 0x7FFFFFFF,
}
