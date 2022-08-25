// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHandForearmJointULTRALEAP")]
    public enum HandForearmJointULTRALEAP : int
    {
        [Obsolete("Deprecated in favour of \"PalmUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_PALM_ULTRALEAP")]
        HandForearmJointPalmUltraleap = 0,
        [Obsolete("Deprecated in favour of \"WristUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_WRIST_ULTRALEAP")]
        HandForearmJointWristUltraleap = 1,
        [Obsolete("Deprecated in favour of \"ThumbMetacarpalUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_THUMB_METACARPAL_ULTRALEAP")]
        HandForearmJointThumbMetacarpalUltraleap = 2,
        [Obsolete("Deprecated in favour of \"ThumbProximalUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_THUMB_PROXIMAL_ULTRALEAP")]
        HandForearmJointThumbProximalUltraleap = 3,
        [Obsolete("Deprecated in favour of \"ThumbDistalUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_THUMB_DISTAL_ULTRALEAP")]
        HandForearmJointThumbDistalUltraleap = 4,
        [Obsolete("Deprecated in favour of \"ThumbTipUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_THUMB_TIP_ULTRALEAP")]
        HandForearmJointThumbTipUltraleap = 5,
        [Obsolete("Deprecated in favour of \"IndexMetacarpalUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_INDEX_METACARPAL_ULTRALEAP")]
        HandForearmJointIndexMetacarpalUltraleap = 6,
        [Obsolete("Deprecated in favour of \"IndexProximalUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_INDEX_PROXIMAL_ULTRALEAP")]
        HandForearmJointIndexProximalUltraleap = 7,
        [Obsolete("Deprecated in favour of \"IndexIntermediateUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_INDEX_INTERMEDIATE_ULTRALEAP")]
        HandForearmJointIndexIntermediateUltraleap = 8,
        [Obsolete("Deprecated in favour of \"IndexDistalUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_INDEX_DISTAL_ULTRALEAP")]
        HandForearmJointIndexDistalUltraleap = 9,
        [Obsolete("Deprecated in favour of \"IndexTipUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_INDEX_TIP_ULTRALEAP")]
        HandForearmJointIndexTipUltraleap = 10,
        [Obsolete("Deprecated in favour of \"MiddleMetacarpalUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_MIDDLE_METACARPAL_ULTRALEAP")]
        HandForearmJointMiddleMetacarpalUltraleap = 11,
        [Obsolete("Deprecated in favour of \"MiddleProximalUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_MIDDLE_PROXIMAL_ULTRALEAP")]
        HandForearmJointMiddleProximalUltraleap = 12,
        [Obsolete("Deprecated in favour of \"MiddleIntermediateUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_MIDDLE_INTERMEDIATE_ULTRALEAP")]
        HandForearmJointMiddleIntermediateUltraleap = 13,
        [Obsolete("Deprecated in favour of \"MiddleDistalUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_MIDDLE_DISTAL_ULTRALEAP")]
        HandForearmJointMiddleDistalUltraleap = 14,
        [Obsolete("Deprecated in favour of \"MiddleTipUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_MIDDLE_TIP_ULTRALEAP")]
        HandForearmJointMiddleTipUltraleap = 15,
        [Obsolete("Deprecated in favour of \"RingMetacarpalUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_RING_METACARPAL_ULTRALEAP")]
        HandForearmJointRingMetacarpalUltraleap = 16,
        [Obsolete("Deprecated in favour of \"RingProximalUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_RING_PROXIMAL_ULTRALEAP")]
        HandForearmJointRingProximalUltraleap = 17,
        [Obsolete("Deprecated in favour of \"RingIntermediateUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_RING_INTERMEDIATE_ULTRALEAP")]
        HandForearmJointRingIntermediateUltraleap = 18,
        [Obsolete("Deprecated in favour of \"RingDistalUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_RING_DISTAL_ULTRALEAP")]
        HandForearmJointRingDistalUltraleap = 19,
        [Obsolete("Deprecated in favour of \"RingTipUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_RING_TIP_ULTRALEAP")]
        HandForearmJointRingTipUltraleap = 20,
        [Obsolete("Deprecated in favour of \"LittleMetacarpalUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_LITTLE_METACARPAL_ULTRALEAP")]
        HandForearmJointLittleMetacarpalUltraleap = 21,
        [Obsolete("Deprecated in favour of \"LittleProximalUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_LITTLE_PROXIMAL_ULTRALEAP")]
        HandForearmJointLittleProximalUltraleap = 22,
        [Obsolete("Deprecated in favour of \"LittleIntermediateUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_LITTLE_INTERMEDIATE_ULTRALEAP")]
        HandForearmJointLittleIntermediateUltraleap = 23,
        [Obsolete("Deprecated in favour of \"LittleDistalUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_LITTLE_DISTAL_ULTRALEAP")]
        HandForearmJointLittleDistalUltraleap = 24,
        [Obsolete("Deprecated in favour of \"LittleTipUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_LITTLE_TIP_ULTRALEAP")]
        HandForearmJointLittleTipUltraleap = 25,
        [Obsolete("Deprecated in favour of \"ElbowUltraleap\"")]
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_ELBOW_ULTRALEAP")]
        HandForearmJointElbowUltraleap = 26,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_PALM_ULTRALEAP")]
        PalmUltraleap = 0,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_WRIST_ULTRALEAP")]
        WristUltraleap = 1,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_THUMB_METACARPAL_ULTRALEAP")]
        ThumbMetacarpalUltraleap = 2,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_THUMB_PROXIMAL_ULTRALEAP")]
        ThumbProximalUltraleap = 3,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_THUMB_DISTAL_ULTRALEAP")]
        ThumbDistalUltraleap = 4,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_THUMB_TIP_ULTRALEAP")]
        ThumbTipUltraleap = 5,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_INDEX_METACARPAL_ULTRALEAP")]
        IndexMetacarpalUltraleap = 6,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_INDEX_PROXIMAL_ULTRALEAP")]
        IndexProximalUltraleap = 7,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_INDEX_INTERMEDIATE_ULTRALEAP")]
        IndexIntermediateUltraleap = 8,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_INDEX_DISTAL_ULTRALEAP")]
        IndexDistalUltraleap = 9,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_INDEX_TIP_ULTRALEAP")]
        IndexTipUltraleap = 10,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_MIDDLE_METACARPAL_ULTRALEAP")]
        MiddleMetacarpalUltraleap = 11,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_MIDDLE_PROXIMAL_ULTRALEAP")]
        MiddleProximalUltraleap = 12,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_MIDDLE_INTERMEDIATE_ULTRALEAP")]
        MiddleIntermediateUltraleap = 13,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_MIDDLE_DISTAL_ULTRALEAP")]
        MiddleDistalUltraleap = 14,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_MIDDLE_TIP_ULTRALEAP")]
        MiddleTipUltraleap = 15,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_RING_METACARPAL_ULTRALEAP")]
        RingMetacarpalUltraleap = 16,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_RING_PROXIMAL_ULTRALEAP")]
        RingProximalUltraleap = 17,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_RING_INTERMEDIATE_ULTRALEAP")]
        RingIntermediateUltraleap = 18,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_RING_DISTAL_ULTRALEAP")]
        RingDistalUltraleap = 19,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_RING_TIP_ULTRALEAP")]
        RingTipUltraleap = 20,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_LITTLE_METACARPAL_ULTRALEAP")]
        LittleMetacarpalUltraleap = 21,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_LITTLE_PROXIMAL_ULTRALEAP")]
        LittleProximalUltraleap = 22,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_LITTLE_INTERMEDIATE_ULTRALEAP")]
        LittleIntermediateUltraleap = 23,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_LITTLE_DISTAL_ULTRALEAP")]
        LittleDistalUltraleap = 24,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_LITTLE_TIP_ULTRALEAP")]
        LittleTipUltraleap = 25,
        [NativeName("Name", "XR_HAND_FOREARM_JOINT_ELBOW_ULTRALEAP")]
        ElbowUltraleap = 26,
    }
}
