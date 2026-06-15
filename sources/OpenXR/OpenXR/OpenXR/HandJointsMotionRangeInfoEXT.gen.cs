// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandJointsMotionRangeInfoEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct HandJointsMotionRangeInfoEXT
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_hand_joints_motion_range"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.TypeHandJointsMotionRangeInfoEXT;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_hand_joints_motion_range"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("handJointsMotionRange")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_hand_joints_motion_range"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public HandJointsMotionRangeEXT HandJointsMotionRange;

    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_hand_joints_motion_range"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public HandJointsMotionRangeInfoEXT() { }
}
