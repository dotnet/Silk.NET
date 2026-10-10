// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceExpressionBD")]
[SupportedApiProfile("openxr")]
public enum FaceExpressionBD : uint
{
    [NativeName("XR_FACE_EXPRESSION_BROW_DROP_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    BrowDropL = 0,

    [NativeName("XR_FACE_EXPRESSION_BROW_DROP_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    BrowDropR = 1,

    [NativeName("XR_FACE_EXPRESSION_BROW_INNER_UPWARDS_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    BrowInnerUpwards = 2,

    [NativeName("XR_FACE_EXPRESSION_BROW_OUTER_UPWARDS_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    BrowOuterUpwardsL = 3,

    [NativeName("XR_FACE_EXPRESSION_BROW_OUTER_UPWARDS_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    BrowOuterUpwardsR = 4,

    [NativeName("XR_FACE_EXPRESSION_EYE_BLINK_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    EyeBlinkL = 5,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_DROP_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    EyeLookDropL = 6,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_IN_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    EyeLookInL = 7,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_OUT_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    EyeLookOutL = 8,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_UPWARDS_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    EyeLookUpwardsL = 9,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_SQUINT_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    EyeLookSquintL = 10,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_WIDE_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    EyeLookWideL = 11,

    [NativeName("XR_FACE_EXPRESSION_EYE_BLINK_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    EyeBlinkR = 12,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_DROP_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    EyeLookDropR = 13,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_IN_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    EyeLookInR = 14,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_OUT_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    EyeLookOutR = 15,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_UPWARDS_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    EyeLookUpwardsR = 16,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_SQUINT_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    EyeLookSquintR = 17,

    [NativeName("XR_FACE_EXPRESSION_EYE_LOOK_WIDE_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    EyeLookWideR = 18,

    [NativeName("XR_FACE_EXPRESSION_NOSE_SNEER_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    NoseSneerL = 19,

    [NativeName("XR_FACE_EXPRESSION_NOSE_SNEER_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    NoseSneerR = 20,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_PUFF_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    CheekPuff = 21,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_SQUINT_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    CheekSquintL = 22,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_SQUINT_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    CheekSquintR = 23,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_CLOSE_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthClose = 24,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_FUNNEL_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthFunnel = 25,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_PUCKER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthPucker = 26,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthL = 27,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthR = 28,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_SMILE_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthSmileL = 29,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_SMILE_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthSmileR = 30,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_FROWN_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthFrownL = 31,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_FROWN_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthFrownR = 32,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_DIMPLE_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthDimpleL = 33,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_DIMPLE_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthDimpleR = 34,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_STRETCH_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthStretchL = 35,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_STRETCH_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthStretchR = 36,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_ROLL_LOWER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthRollLower = 37,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_ROLL_UPPER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthRollUpper = 38,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_SHRUG_LOWER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthShrugLower = 39,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_SHRUG_UPPER_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthShrugUpper = 40,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_PRESS_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthPressL = 41,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_PRESS_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthPressR = 42,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_LOWER_DROP_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthLowerDropL = 43,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_LOWER_DROP_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthLowerDropR = 44,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_UPPER_UPWARDS_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthUpperUpwardsL = 45,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_UPPER_UPWARDS_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    MouthUpperUpwardsR = 46,

    [NativeName("XR_FACE_EXPRESSION_JAW_FORWARD_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    JawForward = 47,

    [NativeName("XR_FACE_EXPRESSION_JAW_L_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    JawL = 48,

    [NativeName("XR_FACE_EXPRESSION_JAW_R_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    JawR = 49,

    [NativeName("XR_FACE_EXPRESSION_JAW_OPEN_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    JawOpen = 50,

    [NativeName("XR_FACE_EXPRESSION_TONGUE_OUT_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_facial_simulation"])]
    TongueOut = 51,
}
