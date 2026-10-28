// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyJointBD")]
[SupportedApiProfile("openxr")]
public enum BodyJointBD : uint
{
    [NativeName("XR_BODY_JOINT_PELVIS_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    Pelvis = 0,

    [NativeName("XR_BODY_JOINT_LEFT_HIP_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    LeftHip = 1,

    [NativeName("XR_BODY_JOINT_RIGHT_HIP_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    RightHip = 2,

    [NativeName("XR_BODY_JOINT_SPINE1_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    Spine1 = 3,

    [NativeName("XR_BODY_JOINT_LEFT_KNEE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    LeftKnee = 4,

    [NativeName("XR_BODY_JOINT_RIGHT_KNEE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    RightKnee = 5,

    [NativeName("XR_BODY_JOINT_SPINE2_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    Spine2 = 6,

    [NativeName("XR_BODY_JOINT_LEFT_ANKLE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    LeftAnkle = 7,

    [NativeName("XR_BODY_JOINT_RIGHT_ANKLE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    RightAnkle = 8,

    [NativeName("XR_BODY_JOINT_SPINE3_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    Spine3 = 9,

    [NativeName("XR_BODY_JOINT_LEFT_FOOT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    LeftFoot = 10,

    [NativeName("XR_BODY_JOINT_RIGHT_FOOT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    RightFoot = 11,

    [NativeName("XR_BODY_JOINT_NECK_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    Neck = 12,

    [NativeName("XR_BODY_JOINT_LEFT_COLLAR_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    LeftCollar = 13,

    [NativeName("XR_BODY_JOINT_RIGHT_COLLAR_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    RightCollar = 14,

    [NativeName("XR_BODY_JOINT_HEAD_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    Head = 15,

    [NativeName("XR_BODY_JOINT_LEFT_SHOULDER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    LeftShoulder = 16,

    [NativeName("XR_BODY_JOINT_RIGHT_SHOULDER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    RightShoulder = 17,

    [NativeName("XR_BODY_JOINT_LEFT_ELBOW_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    LeftElbow = 18,

    [NativeName("XR_BODY_JOINT_RIGHT_ELBOW_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    RightElbow = 19,

    [NativeName("XR_BODY_JOINT_LEFT_WRIST_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    LeftWrist = 20,

    [NativeName("XR_BODY_JOINT_RIGHT_WRIST_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    RightWrist = 21,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    LeftHand = 22,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_body_tracking"])]
    RightHand = 23,
}
