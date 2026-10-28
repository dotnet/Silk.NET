// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandJointEXT")]
[SupportedApiProfile("openxr")]
public enum HandJointEXT : uint
{
    [NativeName("XR_HAND_JOINT_PALM_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    Palm = 0,

    [NativeName("XR_HAND_JOINT_WRIST_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    Wrist = 1,

    [NativeName("XR_HAND_JOINT_THUMB_METACARPAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    ThumbMetacarpal = 2,

    [NativeName("XR_HAND_JOINT_THUMB_PROXIMAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    ThumbProximal = 3,

    [NativeName("XR_HAND_JOINT_THUMB_DISTAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    ThumbDistal = 4,

    [NativeName("XR_HAND_JOINT_THUMB_TIP_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    ThumbTip = 5,

    [NativeName("XR_HAND_JOINT_INDEX_METACARPAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    IndexMetacarpal = 6,

    [NativeName("XR_HAND_JOINT_INDEX_PROXIMAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    IndexProximal = 7,

    [NativeName("XR_HAND_JOINT_INDEX_INTERMEDIATE_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    IndexIntermediate = 8,

    [NativeName("XR_HAND_JOINT_INDEX_DISTAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    IndexDistal = 9,

    [NativeName("XR_HAND_JOINT_INDEX_TIP_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    IndexTip = 10,

    [NativeName("XR_HAND_JOINT_MIDDLE_METACARPAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    MiddleMetacarpal = 11,

    [NativeName("XR_HAND_JOINT_MIDDLE_PROXIMAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    MiddleProximal = 12,

    [NativeName("XR_HAND_JOINT_MIDDLE_INTERMEDIATE_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    MiddleIntermediate = 13,

    [NativeName("XR_HAND_JOINT_MIDDLE_DISTAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    MiddleDistal = 14,

    [NativeName("XR_HAND_JOINT_MIDDLE_TIP_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    MiddleTip = 15,

    [NativeName("XR_HAND_JOINT_RING_METACARPAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    RingMetacarpal = 16,

    [NativeName("XR_HAND_JOINT_RING_PROXIMAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    RingProximal = 17,

    [NativeName("XR_HAND_JOINT_RING_INTERMEDIATE_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    RingIntermediate = 18,

    [NativeName("XR_HAND_JOINT_RING_DISTAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    RingDistal = 19,

    [NativeName("XR_HAND_JOINT_RING_TIP_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    RingTip = 20,

    [NativeName("XR_HAND_JOINT_LITTLE_METACARPAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    LittleMetacarpal = 21,

    [NativeName("XR_HAND_JOINT_LITTLE_PROXIMAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    LittleProximal = 22,

    [NativeName("XR_HAND_JOINT_LITTLE_INTERMEDIATE_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    LittleIntermediate = 23,

    [NativeName("XR_HAND_JOINT_LITTLE_DISTAL_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    LittleDistal = 24,

    [NativeName("XR_HAND_JOINT_LITTLE_TIP_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_hand_tracking"])]
    LittleTip = 25,
}
