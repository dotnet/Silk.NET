// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandPoseTypeMSFT")]
[SupportedApiProfile("openxr")]
public enum HandPoseTypeMSFT : uint
{
    [NativeName("XR_HAND_POSE_TYPE_TRACKED_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    Tracked = 0,

    [NativeName("XR_HAND_POSE_TYPE_REFERENCE_OPEN_PALM_MSFT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_hand_tracking_mesh"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    ReferenceOpenPalm = 1,
}
