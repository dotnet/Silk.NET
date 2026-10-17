// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyJointBD")]
public enum BodyJointBD : uint
{
    [NativeName("XR_BODY_JOINT_PELVIS_BD")]
    Pelvis = 0,

    [NativeName("XR_BODY_JOINT_LEFT_HIP_BD")]
    LeftHip = 1,

    [NativeName("XR_BODY_JOINT_RIGHT_HIP_BD")]
    RightHip = 2,

    [NativeName("XR_BODY_JOINT_SPINE1_BD")]
    Spine1 = 3,

    [NativeName("XR_BODY_JOINT_LEFT_KNEE_BD")]
    LeftKnee = 4,

    [NativeName("XR_BODY_JOINT_RIGHT_KNEE_BD")]
    RightKnee = 5,

    [NativeName("XR_BODY_JOINT_SPINE2_BD")]
    Spine2 = 6,

    [NativeName("XR_BODY_JOINT_LEFT_ANKLE_BD")]
    LeftAnkle = 7,

    [NativeName("XR_BODY_JOINT_RIGHT_ANKLE_BD")]
    RightAnkle = 8,

    [NativeName("XR_BODY_JOINT_SPINE3_BD")]
    Spine3 = 9,

    [NativeName("XR_BODY_JOINT_LEFT_FOOT_BD")]
    LeftFoot = 10,

    [NativeName("XR_BODY_JOINT_RIGHT_FOOT_BD")]
    RightFoot = 11,

    [NativeName("XR_BODY_JOINT_NECK_BD")]
    Neck = 12,

    [NativeName("XR_BODY_JOINT_LEFT_COLLAR_BD")]
    LeftCollar = 13,

    [NativeName("XR_BODY_JOINT_RIGHT_COLLAR_BD")]
    RightCollar = 14,

    [NativeName("XR_BODY_JOINT_HEAD_BD")]
    Head = 15,

    [NativeName("XR_BODY_JOINT_LEFT_SHOULDER_BD")]
    LeftShoulder = 16,

    [NativeName("XR_BODY_JOINT_RIGHT_SHOULDER_BD")]
    RightShoulder = 17,

    [NativeName("XR_BODY_JOINT_LEFT_ELBOW_BD")]
    LeftElbow = 18,

    [NativeName("XR_BODY_JOINT_RIGHT_ELBOW_BD")]
    RightElbow = 19,

    [NativeName("XR_BODY_JOINT_LEFT_WRIST_BD")]
    LeftWrist = 20,

    [NativeName("XR_BODY_JOINT_RIGHT_WRIST_BD")]
    RightWrist = 21,

    [NativeName("XR_BODY_JOINT_LEFT_HAND_BD")]
    LeftHand = 22,

    [NativeName("XR_BODY_JOINT_RIGHT_HAND_BD")]
    RightHand = 23,
}
