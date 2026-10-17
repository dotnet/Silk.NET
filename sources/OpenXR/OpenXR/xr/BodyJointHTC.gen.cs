// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyJointHTC")]
public enum BodyJointHTC : uint
{
    [NativeName("XR_BODY_JOINT_PELVIS_HTC")]
    Pelvis = 0,

    [NativeName("XR_BODY_JOINT_LEFT_HIP_HTC")]
    LeftHip = 1,

    [NativeName("XR_BODY_JOINT_LEFT_KNEE_HTC")]
    LeftKnee = 2,

    [NativeName("XR_BODY_JOINT_LEFT_ANKLE_HTC")]
    LeftAnkle = 3,

    [NativeName("XR_BODY_JOINT_LEFT_FEET_HTC")]
    LeftFeet = 4,

    [NativeName("XR_BODY_JOINT_RIGHT_HIP_HTC")]
    RightHip = 5,

    [NativeName("XR_BODY_JOINT_RIGHT_KNEE_HTC")]
    RightKnee = 6,

    [NativeName("XR_BODY_JOINT_RIGHT_ANKLE_HTC")]
    RightAnkle = 7,

    [NativeName("XR_BODY_JOINT_RIGHT_FEET_HTC")]
    RightFeet = 8,

    [NativeName("XR_BODY_JOINT_WAIST_HTC")]
    Waist = 9,

    [NativeName("XR_BODY_JOINT_SPINE_LOWER_HTC")]
    SpineLower = 10,

    [NativeName("XR_BODY_JOINT_SPINE_MIDDLE_HTC")]
    SpineMiddle = 11,

    [NativeName("XR_BODY_JOINT_SPINE_HIGH_HTC")]
    SpineHigh = 12,

    [NativeName("XR_BODY_JOINT_CHEST_HTC")]
    Chest = 13,

    [NativeName("XR_BODY_JOINT_NECK_HTC")]
    Neck = 14,

    [NativeName("XR_BODY_JOINT_HEAD_HTC")]
    Head = 15,

    [NativeName("XR_BODY_JOINT_LEFT_CLAVICLE_HTC")]
    LeftClavicle = 16,

    [NativeName("XR_BODY_JOINT_LEFT_SCAPULA_HTC")]
    LeftScapula = 17,

    [NativeName("XR_BODY_JOINT_LEFT_ARM_HTC")]
    LeftArm = 18,

    [NativeName("XR_BODY_JOINT_LEFT_ELBOW_HTC")]
    LeftElbow = 19,

    [NativeName("XR_BODY_JOINT_LEFT_WRIST_HTC")]
    LeftWrist = 20,

    [NativeName("XR_BODY_JOINT_RIGHT_CLAVICLE_HTC")]
    RightClavicle = 21,

    [NativeName("XR_BODY_JOINT_RIGHT_SCAPULA_HTC")]
    RightScapula = 22,

    [NativeName("XR_BODY_JOINT_RIGHT_ARM_HTC")]
    RightArm = 23,

    [NativeName("XR_BODY_JOINT_RIGHT_ELBOW_HTC")]
    RightElbow = 24,

    [NativeName("XR_BODY_JOINT_RIGHT_WRIST_HTC")]
    RightWrist = 25,
}
