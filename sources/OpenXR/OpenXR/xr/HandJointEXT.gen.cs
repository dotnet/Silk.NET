// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHandJointEXT")]
public enum HandJointEXT : uint
{
    [NativeName("XR_HAND_JOINT_PALM_EXT")]
    Palm = 0,

    [NativeName("XR_HAND_JOINT_WRIST_EXT")]
    Wrist = 1,

    [NativeName("XR_HAND_JOINT_THUMB_METACARPAL_EXT")]
    ThumbMetacarpal = 2,

    [NativeName("XR_HAND_JOINT_THUMB_PROXIMAL_EXT")]
    ThumbProximal = 3,

    [NativeName("XR_HAND_JOINT_THUMB_DISTAL_EXT")]
    ThumbDistal = 4,

    [NativeName("XR_HAND_JOINT_THUMB_TIP_EXT")]
    ThumbTip = 5,

    [NativeName("XR_HAND_JOINT_INDEX_METACARPAL_EXT")]
    IndexMetacarpal = 6,

    [NativeName("XR_HAND_JOINT_INDEX_PROXIMAL_EXT")]
    IndexProximal = 7,

    [NativeName("XR_HAND_JOINT_INDEX_INTERMEDIATE_EXT")]
    IndexIntermediate = 8,

    [NativeName("XR_HAND_JOINT_INDEX_DISTAL_EXT")]
    IndexDistal = 9,

    [NativeName("XR_HAND_JOINT_INDEX_TIP_EXT")]
    IndexTip = 10,

    [NativeName("XR_HAND_JOINT_MIDDLE_METACARPAL_EXT")]
    MiddleMetacarpal = 11,

    [NativeName("XR_HAND_JOINT_MIDDLE_PROXIMAL_EXT")]
    MiddleProximal = 12,

    [NativeName("XR_HAND_JOINT_MIDDLE_INTERMEDIATE_EXT")]
    MiddleIntermediate = 13,

    [NativeName("XR_HAND_JOINT_MIDDLE_DISTAL_EXT")]
    MiddleDistal = 14,

    [NativeName("XR_HAND_JOINT_MIDDLE_TIP_EXT")]
    MiddleTip = 15,

    [NativeName("XR_HAND_JOINT_RING_METACARPAL_EXT")]
    RingMetacarpal = 16,

    [NativeName("XR_HAND_JOINT_RING_PROXIMAL_EXT")]
    RingProximal = 17,

    [NativeName("XR_HAND_JOINT_RING_INTERMEDIATE_EXT")]
    RingIntermediate = 18,

    [NativeName("XR_HAND_JOINT_RING_DISTAL_EXT")]
    RingDistal = 19,

    [NativeName("XR_HAND_JOINT_RING_TIP_EXT")]
    RingTip = 20,

    [NativeName("XR_HAND_JOINT_LITTLE_METACARPAL_EXT")]
    LittleMetacarpal = 21,

    [NativeName("XR_HAND_JOINT_LITTLE_PROXIMAL_EXT")]
    LittleProximal = 22,

    [NativeName("XR_HAND_JOINT_LITTLE_INTERMEDIATE_EXT")]
    LittleIntermediate = 23,

    [NativeName("XR_HAND_JOINT_LITTLE_DISTAL_EXT")]
    LittleDistal = 24,

    [NativeName("XR_HAND_JOINT_LITTLE_TIP_EXT")]
    LittleTip = 25,
}
