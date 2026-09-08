// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyJointHTC")]
[SupportedApiProfile("openxr")]
public enum BodyJointHTC : uint
{
    [NativeName("XR_BODY_JOINT_PELVIS_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    Pelvis = 0,

    [NativeName("XR_BODY_JOINT_LEFT_HIP_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    LeftHip = 1,

    [NativeName("XR_BODY_JOINT_LEFT_KNEE_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    LeftKnee = 2,

    [NativeName("XR_BODY_JOINT_LEFT_ANKLE_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    LeftAnkle = 3,

    [NativeName("XR_BODY_JOINT_LEFT_FEET_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    LeftFeet = 4,

    [NativeName("XR_BODY_JOINT_RIGHT_HIP_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    RightHip = 5,

    [NativeName("XR_BODY_JOINT_RIGHT_KNEE_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    RightKnee = 6,

    [NativeName("XR_BODY_JOINT_RIGHT_ANKLE_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    RightAnkle = 7,

    [NativeName("XR_BODY_JOINT_RIGHT_FEET_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    RightFeet = 8,

    [NativeName("XR_BODY_JOINT_WAIST_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    Waist = 9,

    [NativeName("XR_BODY_JOINT_SPINE_LOWER_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    SpineLower = 10,

    [NativeName("XR_BODY_JOINT_SPINE_MIDDLE_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    SpineMiddle = 11,

    [NativeName("XR_BODY_JOINT_SPINE_HIGH_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    SpineHigh = 12,

    [NativeName("XR_BODY_JOINT_CHEST_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    Chest = 13,

    [NativeName("XR_BODY_JOINT_NECK_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    Neck = 14,

    [NativeName("XR_BODY_JOINT_HEAD_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    Head = 15,

    [NativeName("XR_BODY_JOINT_LEFT_CLAVICLE_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    LeftClavicle = 16,

    [NativeName("XR_BODY_JOINT_LEFT_SCAPULA_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    LeftScapula = 17,

    [NativeName("XR_BODY_JOINT_LEFT_ARM_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    LeftArm = 18,

    [NativeName("XR_BODY_JOINT_LEFT_ELBOW_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    LeftElbow = 19,

    [NativeName("XR_BODY_JOINT_LEFT_WRIST_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    LeftWrist = 20,

    [NativeName("XR_BODY_JOINT_RIGHT_CLAVICLE_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    RightClavicle = 21,

    [NativeName("XR_BODY_JOINT_RIGHT_SCAPULA_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    RightScapula = 22,

    [NativeName("XR_BODY_JOINT_RIGHT_ARM_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    RightArm = 23,

    [NativeName("XR_BODY_JOINT_RIGHT_ELBOW_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    RightElbow = 24,

    [NativeName("XR_BODY_JOINT_RIGHT_WRIST_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_body_tracking"])]
    RightWrist = 25,
}
