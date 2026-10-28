// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceParameterIndicesANDROID")]
[SupportedApiProfile("openxr")]
public enum FaceParameterIndicesANDROID : uint
{
    [NativeName("XR_FACE_PARAMETER_INDICES_BROW_LOWERER_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    BrowLowererL = 0,

    [NativeName("XR_FACE_PARAMETER_INDICES_BROW_LOWERER_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    BrowLowererR = 1,

    [NativeName("XR_FACE_PARAMETER_INDICES_CHEEK_PUFF_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    CheekPuffL = 2,

    [NativeName("XR_FACE_PARAMETER_INDICES_CHEEK_PUFF_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    CheekPuffR = 3,

    [NativeName("XR_FACE_PARAMETER_INDICES_CHEEK_RAISER_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    CheekRaiserL = 4,

    [NativeName("XR_FACE_PARAMETER_INDICES_CHEEK_RAISER_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    CheekRaiserR = 5,

    [NativeName("XR_FACE_PARAMETER_INDICES_CHEEK_SUCK_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    CheekSuckL = 6,

    [NativeName("XR_FACE_PARAMETER_INDICES_CHEEK_SUCK_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    CheekSuckR = 7,

    [NativeName("XR_FACE_PARAMETER_INDICES_CHIN_RAISER_B_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    ChinRaiserB = 8,

    [NativeName("XR_FACE_PARAMETER_INDICES_CHIN_RAISER_T_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    ChinRaiserT = 9,

    [NativeName("XR_FACE_PARAMETER_INDICES_DIMPLER_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    DimplerL = 10,

    [NativeName("XR_FACE_PARAMETER_INDICES_DIMPLER_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    DimplerR = 11,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_CLOSED_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    EyesClosedL = 12,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_CLOSED_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    EyesClosedR = 13,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_LOOK_DOWN_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    EyesLookDownL = 14,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_LOOK_DOWN_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    EyesLookDownR = 15,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_LOOK_LEFT_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    EyesLookLeftL = 16,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_LOOK_LEFT_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    EyesLookLeftR = 17,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_LOOK_RIGHT_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    EyesLookRightL = 18,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_LOOK_RIGHT_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    EyesLookRightR = 19,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_LOOK_UP_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    EyesLookUpL = 20,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_LOOK_UP_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    EyesLookUpR = 21,

    [NativeName("XR_FACE_PARAMETER_INDICES_INNER_BROW_RAISER_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    InnerBrowRaiserL = 22,

    [NativeName("XR_FACE_PARAMETER_INDICES_INNER_BROW_RAISER_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    InnerBrowRaiserR = 23,

    [NativeName("XR_FACE_PARAMETER_INDICES_JAW_DROP_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    JawDrop = 24,

    [NativeName("XR_FACE_PARAMETER_INDICES_JAW_SIDEWAYS_LEFT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    JawSidewaysLeft = 25,

    [NativeName("XR_FACE_PARAMETER_INDICES_JAW_SIDEWAYS_RIGHT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    JawSidewaysRight = 26,

    [NativeName("XR_FACE_PARAMETER_INDICES_JAW_THRUST_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    JawThrust = 27,

    [NativeName("XR_FACE_PARAMETER_INDICES_LID_TIGHTENER_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LidTightenerL = 28,

    [NativeName("XR_FACE_PARAMETER_INDICES_LID_TIGHTENER_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LidTightenerR = 29,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_CORNER_DEPRESSOR_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipCornerDepressorL = 30,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_CORNER_DEPRESSOR_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipCornerDepressorR = 31,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_CORNER_PULLER_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipCornerPullerL = 32,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_CORNER_PULLER_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipCornerPullerR = 33,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_FUNNELER_LB_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipFunnelerLb = 34,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_FUNNELER_LT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipFunnelerLt = 35,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_FUNNELER_RB_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipFunnelerRb = 36,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_FUNNELER_RT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipFunnelerRt = 37,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_PRESSOR_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipPressorL = 38,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_PRESSOR_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipPressorR = 39,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_PUCKER_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipPuckerL = 40,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_PUCKER_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipPuckerR = 41,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_STRETCHER_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipStretcherL = 42,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_STRETCHER_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipStretcherR = 43,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_SUCK_LB_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipSuckLb = 44,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_SUCK_LT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipSuckLt = 45,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_SUCK_RB_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipSuckRb = 46,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_SUCK_RT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipSuckRt = 47,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_TIGHTENER_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipTightenerL = 48,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_TIGHTENER_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipTightenerR = 49,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIPS_TOWARD_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LipsToward = 50,

    [NativeName("XR_FACE_PARAMETER_INDICES_LOWER_LIP_DEPRESSOR_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LowerLipDepressorL = 51,

    [NativeName("XR_FACE_PARAMETER_INDICES_LOWER_LIP_DEPRESSOR_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    LowerLipDepressorR = 52,

    [NativeName("XR_FACE_PARAMETER_INDICES_MOUTH_LEFT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    MouthLeft = 53,

    [NativeName("XR_FACE_PARAMETER_INDICES_MOUTH_RIGHT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    MouthRight = 54,

    [NativeName("XR_FACE_PARAMETER_INDICES_NOSE_WRINKLER_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    NoseWrinklerL = 55,

    [NativeName("XR_FACE_PARAMETER_INDICES_NOSE_WRINKLER_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    NoseWrinklerR = 56,

    [NativeName("XR_FACE_PARAMETER_INDICES_OUTER_BROW_RAISER_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    OuterBrowRaiserL = 57,

    [NativeName("XR_FACE_PARAMETER_INDICES_OUTER_BROW_RAISER_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    OuterBrowRaiserR = 58,

    [NativeName("XR_FACE_PARAMETER_INDICES_UPPER_LID_RAISER_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    UpperLidRaiserL = 59,

    [NativeName("XR_FACE_PARAMETER_INDICES_UPPER_LID_RAISER_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    UpperLidRaiserR = 60,

    [NativeName("XR_FACE_PARAMETER_INDICES_UPPER_LIP_RAISER_L_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    UpperLipRaiserL = 61,

    [NativeName("XR_FACE_PARAMETER_INDICES_UPPER_LIP_RAISER_R_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    UpperLipRaiserR = 62,

    [NativeName("XR_FACE_PARAMETER_INDICES_TONGUE_OUT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    TongueOut = 63,

    [NativeName("XR_FACE_PARAMETER_INDICES_TONGUE_LEFT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    TongueLeft = 64,

    [NativeName("XR_FACE_PARAMETER_INDICES_TONGUE_RIGHT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    TongueRight = 65,

    [NativeName("XR_FACE_PARAMETER_INDICES_TONGUE_UP_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    TongueUp = 66,

    [NativeName("XR_FACE_PARAMETER_INDICES_TONGUE_DOWN_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_face_tracking"])]
    TongueDown = 67,
}
