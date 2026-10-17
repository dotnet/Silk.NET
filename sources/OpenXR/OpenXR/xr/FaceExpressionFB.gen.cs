// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceExpressionFB")]
public enum FaceExpressionFB : uint
{
    [NativeName("XR_FACE_EXPRESSION_BROW_LOWERER_L_FB")]
    BrowLowererL = 0,

    [NativeName("XR_FACE_EXPRESSION_BROW_LOWERER_R_FB")]
    BrowLowererR = 1,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_PUFF_L_FB")]
    CheekPuffL = 2,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_PUFF_R_FB")]
    CheekPuffR = 3,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_RAISER_L_FB")]
    CheekRaiserL = 4,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_RAISER_R_FB")]
    CheekRaiserR = 5,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_SUCK_L_FB")]
    CheekSuckL = 6,

    [NativeName("XR_FACE_EXPRESSION_CHEEK_SUCK_R_FB")]
    CheekSuckR = 7,

    [NativeName("XR_FACE_EXPRESSION_CHIN_RAISER_B_FB")]
    ChinRaiserB = 8,

    [NativeName("XR_FACE_EXPRESSION_CHIN_RAISER_T_FB")]
    ChinRaiserT = 9,

    [NativeName("XR_FACE_EXPRESSION_DIMPLER_L_FB")]
    DimplerL = 10,

    [NativeName("XR_FACE_EXPRESSION_DIMPLER_R_FB")]
    DimplerR = 11,

    [NativeName("XR_FACE_EXPRESSION_EYES_CLOSED_L_FB")]
    EyesClosedL = 12,

    [NativeName("XR_FACE_EXPRESSION_EYES_CLOSED_R_FB")]
    EyesClosedR = 13,

    [NativeName("XR_FACE_EXPRESSION_EYES_LOOK_DOWN_L_FB")]
    EyesLookDownL = 14,

    [NativeName("XR_FACE_EXPRESSION_EYES_LOOK_DOWN_R_FB")]
    EyesLookDownR = 15,

    [NativeName("XR_FACE_EXPRESSION_EYES_LOOK_LEFT_L_FB")]
    EyesLookLeftL = 16,

    [NativeName("XR_FACE_EXPRESSION_EYES_LOOK_LEFT_R_FB")]
    EyesLookLeftR = 17,

    [NativeName("XR_FACE_EXPRESSION_EYES_LOOK_RIGHT_L_FB")]
    EyesLookRightL = 18,

    [NativeName("XR_FACE_EXPRESSION_EYES_LOOK_RIGHT_R_FB")]
    EyesLookRightR = 19,

    [NativeName("XR_FACE_EXPRESSION_EYES_LOOK_UP_L_FB")]
    EyesLookUpL = 20,

    [NativeName("XR_FACE_EXPRESSION_EYES_LOOK_UP_R_FB")]
    EyesLookUpR = 21,

    [NativeName("XR_FACE_EXPRESSION_INNER_BROW_RAISER_L_FB")]
    InnerBrowRaiserL = 22,

    [NativeName("XR_FACE_EXPRESSION_INNER_BROW_RAISER_R_FB")]
    InnerBrowRaiserR = 23,

    [NativeName("XR_FACE_EXPRESSION_JAW_DROP_FB")]
    JawDrop = 24,

    [NativeName("XR_FACE_EXPRESSION_JAW_SIDEWAYS_LEFT_FB")]
    JawSidewaysLeft = 25,

    [NativeName("XR_FACE_EXPRESSION_JAW_SIDEWAYS_RIGHT_FB")]
    JawSidewaysRight = 26,

    [NativeName("XR_FACE_EXPRESSION_JAW_THRUST_FB")]
    JawThrust = 27,

    [NativeName("XR_FACE_EXPRESSION_LID_TIGHTENER_L_FB")]
    LidTightenerL = 28,

    [NativeName("XR_FACE_EXPRESSION_LID_TIGHTENER_R_FB")]
    LidTightenerR = 29,

    [NativeName("XR_FACE_EXPRESSION_LIP_CORNER_DEPRESSOR_L_FB")]
    LipCornerDepressorL = 30,

    [NativeName("XR_FACE_EXPRESSION_LIP_CORNER_DEPRESSOR_R_FB")]
    LipCornerDepressorR = 31,

    [NativeName("XR_FACE_EXPRESSION_LIP_CORNER_PULLER_L_FB")]
    LipCornerPullerL = 32,

    [NativeName("XR_FACE_EXPRESSION_LIP_CORNER_PULLER_R_FB")]
    LipCornerPullerR = 33,

    [NativeName("XR_FACE_EXPRESSION_LIP_FUNNELER_LB_FB")]
    LipFunnelerLb = 34,

    [NativeName("XR_FACE_EXPRESSION_LIP_FUNNELER_LT_FB")]
    LipFunnelerLt = 35,

    [NativeName("XR_FACE_EXPRESSION_LIP_FUNNELER_RB_FB")]
    LipFunnelerRb = 36,

    [NativeName("XR_FACE_EXPRESSION_LIP_FUNNELER_RT_FB")]
    LipFunnelerRt = 37,

    [NativeName("XR_FACE_EXPRESSION_LIP_PRESSOR_L_FB")]
    LipPressorL = 38,

    [NativeName("XR_FACE_EXPRESSION_LIP_PRESSOR_R_FB")]
    LipPressorR = 39,

    [NativeName("XR_FACE_EXPRESSION_LIP_PUCKER_L_FB")]
    LipPuckerL = 40,

    [NativeName("XR_FACE_EXPRESSION_LIP_PUCKER_R_FB")]
    LipPuckerR = 41,

    [NativeName("XR_FACE_EXPRESSION_LIP_STRETCHER_L_FB")]
    LipStretcherL = 42,

    [NativeName("XR_FACE_EXPRESSION_LIP_STRETCHER_R_FB")]
    LipStretcherR = 43,

    [NativeName("XR_FACE_EXPRESSION_LIP_SUCK_LB_FB")]
    LipSuckLb = 44,

    [NativeName("XR_FACE_EXPRESSION_LIP_SUCK_LT_FB")]
    LipSuckLt = 45,

    [NativeName("XR_FACE_EXPRESSION_LIP_SUCK_RB_FB")]
    LipSuckRb = 46,

    [NativeName("XR_FACE_EXPRESSION_LIP_SUCK_RT_FB")]
    LipSuckRt = 47,

    [NativeName("XR_FACE_EXPRESSION_LIP_TIGHTENER_L_FB")]
    LipTightenerL = 48,

    [NativeName("XR_FACE_EXPRESSION_LIP_TIGHTENER_R_FB")]
    LipTightenerR = 49,

    [NativeName("XR_FACE_EXPRESSION_LIPS_TOWARD_FB")]
    LipsToward = 50,

    [NativeName("XR_FACE_EXPRESSION_LOWER_LIP_DEPRESSOR_L_FB")]
    LowerLipDepressorL = 51,

    [NativeName("XR_FACE_EXPRESSION_LOWER_LIP_DEPRESSOR_R_FB")]
    LowerLipDepressorR = 52,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_LEFT_FB")]
    MouthLeft = 53,

    [NativeName("XR_FACE_EXPRESSION_MOUTH_RIGHT_FB")]
    MouthRight = 54,

    [NativeName("XR_FACE_EXPRESSION_NOSE_WRINKLER_L_FB")]
    NoseWrinklerL = 55,

    [NativeName("XR_FACE_EXPRESSION_NOSE_WRINKLER_R_FB")]
    NoseWrinklerR = 56,

    [NativeName("XR_FACE_EXPRESSION_OUTER_BROW_RAISER_L_FB")]
    OuterBrowRaiserL = 57,

    [NativeName("XR_FACE_EXPRESSION_OUTER_BROW_RAISER_R_FB")]
    OuterBrowRaiserR = 58,

    [NativeName("XR_FACE_EXPRESSION_UPPER_LID_RAISER_L_FB")]
    UpperLidRaiserL = 59,

    [NativeName("XR_FACE_EXPRESSION_UPPER_LID_RAISER_R_FB")]
    UpperLidRaiserR = 60,

    [NativeName("XR_FACE_EXPRESSION_UPPER_LIP_RAISER_L_FB")]
    UpperLipRaiserL = 61,

    [NativeName("XR_FACE_EXPRESSION_UPPER_LIP_RAISER_R_FB")]
    UpperLipRaiserR = 62,

    [NativeName("XR_FACE_EXPRESSION_COUNT_FB")]
    Count = 63,
}
