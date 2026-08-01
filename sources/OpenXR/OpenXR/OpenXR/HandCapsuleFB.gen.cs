// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandCapsuleFB")]
[SupportedApiProfile("openxr")]
public partial struct HandCapsuleFB
{
    [NativeName("points")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_capsules"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public HandCapsuleFBPoints Points;

    [NativeName("radius")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_capsules"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public float Radius;

    [NativeName("joint")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_hand_tracking_capsules"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public HandJointEXT Joint;
}
