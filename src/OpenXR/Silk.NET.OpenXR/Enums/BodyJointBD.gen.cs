// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrBodyJointBD")]
    public enum BodyJointBD : int
    {
        [Obsolete("Deprecated in favour of \"PelvisBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_PELVIS_BD")]
        BodyJointPelvisBD = 0,
        [Obsolete("Deprecated in favour of \"LeftHipBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HIP_BD")]
        BodyJointLeftHipBD = 1,
        [Obsolete("Deprecated in favour of \"RightHipBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HIP_BD")]
        BodyJointRightHipBD = 2,
        [Obsolete("Deprecated in favour of \"Spine1BD\"")]
        [NativeName("Name", "XR_BODY_JOINT_SPINE1_BD")]
        BodyJointSpine1BD = 3,
        [Obsolete("Deprecated in favour of \"LeftKneeBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_KNEE_BD")]
        BodyJointLeftKneeBD = 4,
        [Obsolete("Deprecated in favour of \"RightKneeBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_KNEE_BD")]
        BodyJointRightKneeBD = 5,
        [Obsolete("Deprecated in favour of \"Spine2BD\"")]
        [NativeName("Name", "XR_BODY_JOINT_SPINE2_BD")]
        BodyJointSpine2BD = 6,
        [Obsolete("Deprecated in favour of \"LeftAnkleBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_ANKLE_BD")]
        BodyJointLeftAnkleBD = 7,
        [Obsolete("Deprecated in favour of \"RightAnkleBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_ANKLE_BD")]
        BodyJointRightAnkleBD = 8,
        [Obsolete("Deprecated in favour of \"Spine3BD\"")]
        [NativeName("Name", "XR_BODY_JOINT_SPINE3_BD")]
        BodyJointSpine3BD = 9,
        [Obsolete("Deprecated in favour of \"LeftFootBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_FOOT_BD")]
        BodyJointLeftFootBD = 10,
        [Obsolete("Deprecated in favour of \"RightFootBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_FOOT_BD")]
        BodyJointRightFootBD = 11,
        [Obsolete("Deprecated in favour of \"NeckBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_NECK_BD")]
        BodyJointNeckBD = 12,
        [Obsolete("Deprecated in favour of \"LeftCollarBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_COLLAR_BD")]
        BodyJointLeftCollarBD = 13,
        [Obsolete("Deprecated in favour of \"RightCollarBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_COLLAR_BD")]
        BodyJointRightCollarBD = 14,
        [Obsolete("Deprecated in favour of \"HeadBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_HEAD_BD")]
        BodyJointHeadBD = 15,
        [Obsolete("Deprecated in favour of \"LeftShoulderBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_SHOULDER_BD")]
        BodyJointLeftShoulderBD = 16,
        [Obsolete("Deprecated in favour of \"RightShoulderBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_SHOULDER_BD")]
        BodyJointRightShoulderBD = 17,
        [Obsolete("Deprecated in favour of \"LeftElbowBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_ELBOW_BD")]
        BodyJointLeftElbowBD = 18,
        [Obsolete("Deprecated in favour of \"RightElbowBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_ELBOW_BD")]
        BodyJointRightElbowBD = 19,
        [Obsolete("Deprecated in favour of \"LeftWristBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_WRIST_BD")]
        BodyJointLeftWristBD = 20,
        [Obsolete("Deprecated in favour of \"RightWristBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_WRIST_BD")]
        BodyJointRightWristBD = 21,
        [Obsolete("Deprecated in favour of \"LeftHandBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_BD")]
        BodyJointLeftHandBD = 22,
        [Obsolete("Deprecated in favour of \"RightHandBD\"")]
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_BD")]
        BodyJointRightHandBD = 23,
        [NativeName("Name", "XR_BODY_JOINT_PELVIS_BD")]
        PelvisBD = 0,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HIP_BD")]
        LeftHipBD = 1,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HIP_BD")]
        RightHipBD = 2,
        [NativeName("Name", "XR_BODY_JOINT_SPINE1_BD")]
        Spine1BD = 3,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_KNEE_BD")]
        LeftKneeBD = 4,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_KNEE_BD")]
        RightKneeBD = 5,
        [NativeName("Name", "XR_BODY_JOINT_SPINE2_BD")]
        Spine2BD = 6,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_ANKLE_BD")]
        LeftAnkleBD = 7,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_ANKLE_BD")]
        RightAnkleBD = 8,
        [NativeName("Name", "XR_BODY_JOINT_SPINE3_BD")]
        Spine3BD = 9,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_FOOT_BD")]
        LeftFootBD = 10,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_FOOT_BD")]
        RightFootBD = 11,
        [NativeName("Name", "XR_BODY_JOINT_NECK_BD")]
        NeckBD = 12,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_COLLAR_BD")]
        LeftCollarBD = 13,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_COLLAR_BD")]
        RightCollarBD = 14,
        [NativeName("Name", "XR_BODY_JOINT_HEAD_BD")]
        HeadBD = 15,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_SHOULDER_BD")]
        LeftShoulderBD = 16,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_SHOULDER_BD")]
        RightShoulderBD = 17,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_ELBOW_BD")]
        LeftElbowBD = 18,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_ELBOW_BD")]
        RightElbowBD = 19,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_WRIST_BD")]
        LeftWristBD = 20,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_WRIST_BD")]
        RightWristBD = 21,
        [NativeName("Name", "XR_BODY_JOINT_LEFT_HAND_BD")]
        LeftHandBD = 22,
        [NativeName("Name", "XR_BODY_JOINT_RIGHT_HAND_BD")]
        RightHandBD = 23,
    }
}
