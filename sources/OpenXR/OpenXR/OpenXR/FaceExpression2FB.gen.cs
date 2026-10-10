// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceExpression2FB")]
[SupportedApiProfile("openxr")]
public enum FaceExpression2FB : uint
{
    [NativeName("XR_FACE_EXPRESSION2_BROW_LOWERER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    BrowLowererL = 0,

    [NativeName("XR_FACE_EXPRESSION2_BROW_LOWERER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    BrowLowererR = 1,

    [NativeName("XR_FACE_EXPRESSION2_CHEEK_PUFF_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    CheekPuffL = 2,

    [NativeName("XR_FACE_EXPRESSION2_CHEEK_PUFF_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    CheekPuffR = 3,

    [NativeName("XR_FACE_EXPRESSION2_CHEEK_RAISER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    CheekRaiserL = 4,

    [NativeName("XR_FACE_EXPRESSION2_CHEEK_RAISER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    CheekRaiserR = 5,

    [NativeName("XR_FACE_EXPRESSION2_CHEEK_SUCK_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    CheekSuckL = 6,

    [NativeName("XR_FACE_EXPRESSION2_CHEEK_SUCK_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    CheekSuckR = 7,

    [NativeName("XR_FACE_EXPRESSION2_CHIN_RAISER_B_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    ChinRaiserB = 8,

    [NativeName("XR_FACE_EXPRESSION2_CHIN_RAISER_T_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    ChinRaiserT = 9,

    [NativeName("XR_FACE_EXPRESSION2_DIMPLER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    DimplerL = 10,

    [NativeName("XR_FACE_EXPRESSION2_DIMPLER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    DimplerR = 11,

    [NativeName("XR_FACE_EXPRESSION2_EYES_CLOSED_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    EyesClosedL = 12,

    [NativeName("XR_FACE_EXPRESSION2_EYES_CLOSED_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    EyesClosedR = 13,

    [NativeName("XR_FACE_EXPRESSION2_EYES_LOOK_DOWN_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    EyesLookDownL = 14,

    [NativeName("XR_FACE_EXPRESSION2_EYES_LOOK_DOWN_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    EyesLookDownR = 15,

    [NativeName("XR_FACE_EXPRESSION2_EYES_LOOK_LEFT_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    EyesLookLeftL = 16,

    [NativeName("XR_FACE_EXPRESSION2_EYES_LOOK_LEFT_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    EyesLookLeftR = 17,

    [NativeName("XR_FACE_EXPRESSION2_EYES_LOOK_RIGHT_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    EyesLookRightL = 18,

    [NativeName("XR_FACE_EXPRESSION2_EYES_LOOK_RIGHT_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    EyesLookRightR = 19,

    [NativeName("XR_FACE_EXPRESSION2_EYES_LOOK_UP_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    EyesLookUpL = 20,

    [NativeName("XR_FACE_EXPRESSION2_EYES_LOOK_UP_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    EyesLookUpR = 21,

    [NativeName("XR_FACE_EXPRESSION2_INNER_BROW_RAISER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    InnerBrowRaiserL = 22,

    [NativeName("XR_FACE_EXPRESSION2_INNER_BROW_RAISER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    InnerBrowRaiserR = 23,

    [NativeName("XR_FACE_EXPRESSION2_JAW_DROP_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    JawDrop = 24,

    [NativeName("XR_FACE_EXPRESSION2_JAW_SIDEWAYS_LEFT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    JawSidewaysLeft = 25,

    [NativeName("XR_FACE_EXPRESSION2_JAW_SIDEWAYS_RIGHT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    JawSidewaysRight = 26,

    [NativeName("XR_FACE_EXPRESSION2_JAW_THRUST_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    JawThrust = 27,

    [NativeName("XR_FACE_EXPRESSION2_LID_TIGHTENER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LidTightenerL = 28,

    [NativeName("XR_FACE_EXPRESSION2_LID_TIGHTENER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LidTightenerR = 29,

    [NativeName("XR_FACE_EXPRESSION2_LIP_CORNER_DEPRESSOR_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipCornerDepressorL = 30,

    [NativeName("XR_FACE_EXPRESSION2_LIP_CORNER_DEPRESSOR_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipCornerDepressorR = 31,

    [NativeName("XR_FACE_EXPRESSION2_LIP_CORNER_PULLER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipCornerPullerL = 32,

    [NativeName("XR_FACE_EXPRESSION2_LIP_CORNER_PULLER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipCornerPullerR = 33,

    [NativeName("XR_FACE_EXPRESSION2_LIP_FUNNELER_LB_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipFunnelerLb = 34,

    [NativeName("XR_FACE_EXPRESSION2_LIP_FUNNELER_LT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipFunnelerLt = 35,

    [NativeName("XR_FACE_EXPRESSION2_LIP_FUNNELER_RB_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipFunnelerRb = 36,

    [NativeName("XR_FACE_EXPRESSION2_LIP_FUNNELER_RT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipFunnelerRt = 37,

    [NativeName("XR_FACE_EXPRESSION2_LIP_PRESSOR_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipPressorL = 38,

    [NativeName("XR_FACE_EXPRESSION2_LIP_PRESSOR_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipPressorR = 39,

    [NativeName("XR_FACE_EXPRESSION2_LIP_PUCKER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipPuckerL = 40,

    [NativeName("XR_FACE_EXPRESSION2_LIP_PUCKER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipPuckerR = 41,

    [NativeName("XR_FACE_EXPRESSION2_LIP_STRETCHER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipStretcherL = 42,

    [NativeName("XR_FACE_EXPRESSION2_LIP_STRETCHER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipStretcherR = 43,

    [NativeName("XR_FACE_EXPRESSION2_LIP_SUCK_LB_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipSuckLb = 44,

    [NativeName("XR_FACE_EXPRESSION2_LIP_SUCK_LT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipSuckLt = 45,

    [NativeName("XR_FACE_EXPRESSION2_LIP_SUCK_RB_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipSuckRb = 46,

    [NativeName("XR_FACE_EXPRESSION2_LIP_SUCK_RT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipSuckRt = 47,

    [NativeName("XR_FACE_EXPRESSION2_LIP_TIGHTENER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipTightenerL = 48,

    [NativeName("XR_FACE_EXPRESSION2_LIP_TIGHTENER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipTightenerR = 49,

    [NativeName("XR_FACE_EXPRESSION2_LIPS_TOWARD_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LipsToward = 50,

    [NativeName("XR_FACE_EXPRESSION2_LOWER_LIP_DEPRESSOR_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LowerLipDepressorL = 51,

    [NativeName("XR_FACE_EXPRESSION2_LOWER_LIP_DEPRESSOR_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    LowerLipDepressorR = 52,

    [NativeName("XR_FACE_EXPRESSION2_MOUTH_LEFT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    MouthLeft = 53,

    [NativeName("XR_FACE_EXPRESSION2_MOUTH_RIGHT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    MouthRight = 54,

    [NativeName("XR_FACE_EXPRESSION2_NOSE_WRINKLER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    NoseWrinklerL = 55,

    [NativeName("XR_FACE_EXPRESSION2_NOSE_WRINKLER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    NoseWrinklerR = 56,

    [NativeName("XR_FACE_EXPRESSION2_OUTER_BROW_RAISER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    OuterBrowRaiserL = 57,

    [NativeName("XR_FACE_EXPRESSION2_OUTER_BROW_RAISER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    OuterBrowRaiserR = 58,

    [NativeName("XR_FACE_EXPRESSION2_UPPER_LID_RAISER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    UpperLidRaiserL = 59,

    [NativeName("XR_FACE_EXPRESSION2_UPPER_LID_RAISER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    UpperLidRaiserR = 60,

    [NativeName("XR_FACE_EXPRESSION2_UPPER_LIP_RAISER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    UpperLipRaiserL = 61,

    [NativeName("XR_FACE_EXPRESSION2_UPPER_LIP_RAISER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    UpperLipRaiserR = 62,

    [NativeName("XR_FACE_EXPRESSION2_TONGUE_TIP_INTERDENTAL_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    TongueTipInterdental = 63,

    [NativeName("XR_FACE_EXPRESSION2_TONGUE_TIP_ALVEOLAR_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    TongueTipAlveolar = 64,

    [NativeName("XR_FACE_EXPRESSION2_TONGUE_FRONT_DORSAL_PALATE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    TongueFrontDorsalPalate = 65,

    [NativeName("XR_FACE_EXPRESSION2_TONGUE_MID_DORSAL_PALATE_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    TongueMidDorsalPalate = 66,

    [NativeName("XR_FACE_EXPRESSION2_TONGUE_BACK_DORSAL_VELAR_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    TongueBackDorsalVelar = 67,

    [NativeName("XR_FACE_EXPRESSION2_TONGUE_OUT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    TongueOut = 68,

    [NativeName("XR_FACE_EXPRESSION2_TONGUE_RETREAT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    TongueRetreat = 69,

    [NativeName("XR_FACE_EXPRESSION2_COUNT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking2"])]
    Count = 70,
}
