// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1ReferenceName")]
public enum StdVideoAv1ReferenceName : uint
{
    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_INTRA_FRAME")]
    IntraFrame = 0,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_LAST_FRAME")]
    LastFrame = 1,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_LAST2_FRAME")]
    Last2Frame = 2,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_LAST3_FRAME")]
    Last3Frame = 3,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_GOLDEN_FRAME")]
    GoldenFrame = 4,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_BWDREF_FRAME")]
    BwdrefFrame = 5,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_ALTREF2_FRAME")]
    Altref2Frame = 6,

    [NativeName("STD_VIDEO_AV1_REFERENCE_NAME_ALTREF_FRAME")]
    AltrefFrame = 7,
}
