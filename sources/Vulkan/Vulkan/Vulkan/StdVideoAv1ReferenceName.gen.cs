// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1ReferenceName")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAv1ReferenceName : uint
{
    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_INTRA_FRAME")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ReferenceNameIntraFrame = 0,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_LAST_FRAME")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ReferenceNameLastFrame = 1,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_LAST2_FRAME")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ReferenceNameLast2Frame = 2,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_LAST3_FRAME")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ReferenceNameLast3Frame = 3,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_GOLDEN_FRAME")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ReferenceNameGoldenFrame = 4,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_BWDREF_FRAME")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ReferenceNameBwdrefFrame = 5,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_ALTREF2_FRAME")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ReferenceNameAltref2Frame = 6,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_ALTREF_FRAME")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ReferenceNameAltrefFrame = 7,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ReferenceNameInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1ReferenceNameMaxEnum = 0x7FFFFFFF,
}
