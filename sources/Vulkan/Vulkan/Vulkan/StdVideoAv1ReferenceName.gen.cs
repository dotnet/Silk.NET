// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1ReferenceName")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAv1ReferenceName : uint
{
    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_INTRA_FRAME")]
    [SupportedApiProfile("vulkan")]
    IntraFrame = 0,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_LAST_FRAME")]
    [SupportedApiProfile("vulkan")]
    LastFrame = 1,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_LAST2_FRAME")]
    [SupportedApiProfile("vulkan")]
    Last2Frame = 2,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_LAST3_FRAME")]
    [SupportedApiProfile("vulkan")]
    Last3Frame = 3,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_GOLDEN_FRAME")]
    [SupportedApiProfile("vulkan")]
    GoldenFrame = 4,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_BWDREF_FRAME")]
    [SupportedApiProfile("vulkan")]
    BwdrefFrame = 5,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_ALTREF2_FRAME")]
    [SupportedApiProfile("vulkan")]
    Altref2Frame = 6,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_ALTREF_FRAME")]
    [SupportedApiProfile("vulkan")]
    AltrefFrame = 7,
}
