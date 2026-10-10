// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceExpressionFB")]
[SupportedApiProfile("openxr")]
public enum FaceExpressionFB : uint
{
    [NativeName("XR_FACE_EXPRESSION_BROW_LOWERER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    BrowLowererL = 0,

    [NativeName("XR_FACE_EXPRESSION_BROW_LOWERER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    BrowLowererR = 1,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_PUFF_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    CheekPuffL = 2,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_PUFF_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    CheekPuffR = 3,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_RAISER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    CheekRaiserL = 4,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_RAISER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    CheekRaiserR = 5,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_SUCK_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    CheekSuckL = 6,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_SUCK_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    CheekSuckR = 7,

    [NativeName("XR_FACE_EXPRESSION_CHIN_RAISER_B_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    ChinRaiserB = 8,

    [NativeName("XR_FACE_EXPRESSION_CHIN_RAISER_T_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    ChinRaiserT = 9,

    [NativeName("XR_FACE_EXPRESSION_DIMPLER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    DimplerL = 10,

    [NativeName("XR_FACE_EXPRESSION_DIMPLER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    DimplerR = 11,

    [NativeName("XR_FACE_EXPRESSION_EYES_CLOSED_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    EyesClosedL = 12,

    [NativeName("XR_FACE_EXPRESSION_EYES_CLOSED_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    EyesClosedR = 13,

    [NativeName("XR_FACE_EXPRESSION_EYES_LOOK_DOWN_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    EyesLookDownL = 14,

    [NativeName("XR_FACE_EXPRESSION_EYES_LOOK_DOWN_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    EyesLookDownR = 15,

    [NativeName("XR_FACE_EXPRESSION_EYES_LOOK_LEFT_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    EyesLookLeftL = 16,

    [NativeName("XR_FACE_EXPRESSION_EYES_LOOK_LEFT_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    EyesLookLeftR = 17,

    [NativeName("XR_FACE_EXPRESSION_EYES_LOOK_RIGHT_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    EyesLookRightL = 18,

    [NativeName("XR_FACE_EXPRESSION_EYES_LOOK_RIGHT_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    EyesLookRightR = 19,

    [NativeName("XR_FACE_EXPRESSION_EYES_LOOK_UP_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    EyesLookUpL = 20,

    [NativeName("XR_FACE_EXPRESSION_EYES_LOOK_UP_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    EyesLookUpR = 21,

    [NativeName("XR_FACE_EXPRESSION_INNER_BROW_RAISER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    InnerBrowRaiserL = 22,

    [NativeName("XR_FACE_EXPRESSION_INNER_BROW_RAISER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    InnerBrowRaiserR = 23,

    [NativeName("XR_FACE_EXPRESSION_JAW_DROP_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    JawDrop = 24,

    [NativeName("XR_FACE_EXPRESSION_JAW_SIDEWAYS_LEFT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    JawSidewaysLeft = 25,

    [NativeName("XR_FACE_EXPRESSION_JAW_SIDEWAYS_RIGHT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    JawSidewaysRight = 26,

    [NativeName("XR_FACE_EXPRESSION_JAW_THRUST_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    JawThrust = 27,

    [NativeName("XR_FACE_EXPRESSION_LID_TIGHTENER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LidTightenerL = 28,

    [NativeName("XR_FACE_EXPRESSION_LID_TIGHTENER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LidTightenerR = 29,

    [NativeName("XR_FACE_EXPRESSION_LIP_CORNER_DEPRESSOR_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipCornerDepressorL = 30,

    [NativeName("XR_FACE_EXPRESSION_LIP_CORNER_DEPRESSOR_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipCornerDepressorR = 31,

    [NativeName("XR_FACE_EXPRESSION_LIP_CORNER_PULLER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipCornerPullerL = 32,

    [NativeName("XR_FACE_EXPRESSION_LIP_CORNER_PULLER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipCornerPullerR = 33,

    [NativeName("XR_FACE_EXPRESSION_LIP_FUNNELER_LB_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipFunnelerLb = 34,

    [NativeName("XR_FACE_EXPRESSION_LIP_FUNNELER_LT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipFunnelerLt = 35,

    [NativeName("XR_FACE_EXPRESSION_LIP_FUNNELER_RB_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipFunnelerRb = 36,

    [NativeName("XR_FACE_EXPRESSION_LIP_FUNNELER_RT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipFunnelerRt = 37,

    [NativeName("XR_FACE_EXPRESSION_LIP_PRESSOR_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipPressorL = 38,

    [NativeName("XR_FACE_EXPRESSION_LIP_PRESSOR_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipPressorR = 39,

    [NativeName("XR_FACE_EXPRESSION_LIP_PUCKER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipPuckerL = 40,

    [NativeName("XR_FACE_EXPRESSION_LIP_PUCKER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipPuckerR = 41,

    [NativeName("XR_FACE_EXPRESSION_LIP_STRETCHER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipStretcherL = 42,

    [NativeName("XR_FACE_EXPRESSION_LIP_STRETCHER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipStretcherR = 43,

    [NativeName("XR_FACE_EXPRESSION_LIP_SUCK_LB_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipSuckLb = 44,

    [NativeName("XR_FACE_EXPRESSION_LIP_SUCK_LT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipSuckLt = 45,

    [NativeName("XR_FACE_EXPRESSION_LIP_SUCK_RB_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipSuckRb = 46,

    [NativeName("XR_FACE_EXPRESSION_LIP_SUCK_RT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipSuckRt = 47,

    [NativeName("XR_FACE_EXPRESSION_LIP_TIGHTENER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipTightenerL = 48,

    [NativeName("XR_FACE_EXPRESSION_LIP_TIGHTENER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipTightenerR = 49,

    [NativeName("XR_FACE_EXPRESSION_LIPS_TOWARD_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LipsToward = 50,

    [NativeName("XR_FACE_EXPRESSION_LOWER_LIP_DEPRESSOR_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LowerLipDepressorL = 51,

    [NativeName("XR_FACE_EXPRESSION_LOWER_LIP_DEPRESSOR_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    LowerLipDepressorR = 52,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_LEFT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    MouthLeft = 53,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_RIGHT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    MouthRight = 54,

    [NativeName("XR_FACE_EXPRESSION_NOSE_WRINKLER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    NoseWrinklerL = 55,

    [NativeName("XR_FACE_EXPRESSION_NOSE_WRINKLER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    NoseWrinklerR = 56,

    [NativeName("XR_FACE_EXPRESSION_OUTER_BROW_RAISER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    OuterBrowRaiserL = 57,

    [NativeName("XR_FACE_EXPRESSION_OUTER_BROW_RAISER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    OuterBrowRaiserR = 58,

    [NativeName("XR_FACE_EXPRESSION_UPPER_LID_RAISER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    UpperLidRaiserL = 59,

    [NativeName("XR_FACE_EXPRESSION_UPPER_LID_RAISER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    UpperLidRaiserR = 60,

    [NativeName("XR_FACE_EXPRESSION_UPPER_LIP_RAISER_L_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    UpperLipRaiserL = 61,

    [NativeName("XR_FACE_EXPRESSION_UPPER_LIP_RAISER_R_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    UpperLipRaiserR = 62,

    [NativeName("XR_FACE_EXPRESSION_COUNT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    Count = 63,
}
