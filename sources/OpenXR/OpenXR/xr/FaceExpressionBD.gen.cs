// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceExpressionBD")]
public enum FaceExpressionBD : uint
{
    [NativeName("XR_FACE_EXPRESSION_BROW_DROP_L_BD")]
    BrowDropL = 0,

    [NativeName("XR_FACE_EXPRESSION_BROW_DROP_R_BD")]
    BrowDropR = 1,

    [NativeName("XR_FACE_EXPRESSION_BROW_INNER_UPWARDS_BD")]
    BrowInnerUpwards = 2,

    [NativeName("XR_FACE_EXPRESSION_BROW_OUTER_UPWARDS_L_BD")]
    BrowOuterUpwardsL = 3,

    [NativeName("XR_FACE_EXPRESSION_BROW_OUTER_UPWARDS_R_BD")]
    BrowOuterUpwardsR = 4,

    [NativeName("XR_FACE_EXPRESSION_EYE_BLINK_L_BD")]
    EyeBlinkL = 5,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_DROP_L_BD")]
    EyeLookDropL = 6,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_IN_L_BD")]
    EyeLookInL = 7,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_OUT_L_BD")]
    EyeLookOutL = 8,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_UPWARDS_L_BD")]
    EyeLookUpwardsL = 9,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_SQUINT_L_BD")]
    EyeLookSquintL = 10,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_WIDE_L_BD")]
    EyeLookWideL = 11,

    [NativeName("XR_FACE_EXPRESSION_EYE_BLINK_R_BD")]
    EyeBlinkR = 12,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_DROP_R_BD")]
    EyeLookDropR = 13,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_IN_R_BD")]
    EyeLookInR = 14,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_OUT_R_BD")]
    EyeLookOutR = 15,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_UPWARDS_R_BD")]
    EyeLookUpwardsR = 16,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_SQUINT_R_BD")]
    EyeLookSquintR = 17,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_WIDE_R_BD")]
    EyeLookWideR = 18,

    [NativeName("XR_FACE_EXPRESSION_NOSE_SNEER_L_BD")]
    NoseSneerL = 19,

    [NativeName("XR_FACE_EXPRESSION_NOSE_SNEER_R_BD")]
    NoseSneerR = 20,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_PUFF_BD")]
    CheekPuff = 21,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_SQUINT_L_BD")]
    CheekSquintL = 22,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_SQUINT_R_BD")]
    CheekSquintR = 23,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_CLOSE_BD")]
    MouthClose = 24,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_FUNNEL_BD")]
    MouthFunnel = 25,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_PUCKER_BD")]
    MouthPucker = 26,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_L_BD")]
    MouthL = 27,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_R_BD")]
    MouthR = 28,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_SMILE_L_BD")]
    MouthSmileL = 29,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_SMILE_R_BD")]
    MouthSmileR = 30,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_FROWN_L_BD")]
    MouthFrownL = 31,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_FROWN_R_BD")]
    MouthFrownR = 32,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_DIMPLE_L_BD")]
    MouthDimpleL = 33,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_DIMPLE_R_BD")]
    MouthDimpleR = 34,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_STRETCH_L_BD")]
    MouthStretchL = 35,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_STRETCH_R_BD")]
    MouthStretchR = 36,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_ROLL_LOWER_BD")]
    MouthRollLower = 37,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_ROLL_UPPER_BD")]
    MouthRollUpper = 38,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_SHRUG_LOWER_BD")]
    MouthShrugLower = 39,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_SHRUG_UPPER_BD")]
    MouthShrugUpper = 40,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_PRESS_L_BD")]
    MouthPressL = 41,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_PRESS_R_BD")]
    MouthPressR = 42,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_LOWER_DROP_L_BD")]
    MouthLowerDropL = 43,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_LOWER_DROP_R_BD")]
    MouthLowerDropR = 44,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_UPPER_UPWARDS_L_BD")]
    MouthUpperUpwardsL = 45,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_UPPER_UPWARDS_R_BD")]
    MouthUpperUpwardsR = 46,

    [NativeName("XR_FACE_EXPRESSION_JAW_FORWARD_BD")]
    JawForward = 47,

    [NativeName("XR_FACE_EXPRESSION_JAW_L_BD")]
    JawL = 48,

    [NativeName("XR_FACE_EXPRESSION_JAW_R_BD")]
    JawR = 49,

    [NativeName("XR_FACE_EXPRESSION_JAW_OPEN_BD")]
    JawOpen = 50,

    [NativeName("XR_FACE_EXPRESSION_TONGUE_OUT_BD")]
    TongueOut = 51,
}
