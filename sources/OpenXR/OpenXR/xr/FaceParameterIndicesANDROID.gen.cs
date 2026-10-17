// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceParameterIndicesANDROID")]
public enum FaceParameterIndicesANDROID : uint
{
    [NativeName("XR_FACE_PARAMETER_INDICES_BROW_LOWERER_L_ANDROID")]
    BrowLowererL = 0,

    [NativeName("XR_FACE_PARAMETER_INDICES_BROW_LOWERER_R_ANDROID")]
    BrowLowererR = 1,

    [NativeName("XR_FACE_PARAMETER_INDICES_CHEEK_PUFF_L_ANDROID")]
    CheekPuffL = 2,

    [NativeName("XR_FACE_PARAMETER_INDICES_CHEEK_PUFF_R_ANDROID")]
    CheekPuffR = 3,

    [NativeName("XR_FACE_PARAMETER_INDICES_CHEEK_RAISER_L_ANDROID")]
    CheekRaiserL = 4,

    [NativeName("XR_FACE_PARAMETER_INDICES_CHEEK_RAISER_R_ANDROID")]
    CheekRaiserR = 5,

    [NativeName("XR_FACE_PARAMETER_INDICES_CHEEK_SUCK_L_ANDROID")]
    CheekSuckL = 6,

    [NativeName("XR_FACE_PARAMETER_INDICES_CHEEK_SUCK_R_ANDROID")]
    CheekSuckR = 7,

    [NativeName("XR_FACE_PARAMETER_INDICES_CHIN_RAISER_B_ANDROID")]
    ChinRaiserB = 8,

    [NativeName("XR_FACE_PARAMETER_INDICES_CHIN_RAISER_T_ANDROID")]
    ChinRaiserT = 9,

    [NativeName("XR_FACE_PARAMETER_INDICES_DIMPLER_L_ANDROID")]
    DimplerL = 10,

    [NativeName("XR_FACE_PARAMETER_INDICES_DIMPLER_R_ANDROID")]
    DimplerR = 11,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_CLOSED_L_ANDROID")]
    EyesClosedL = 12,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_CLOSED_R_ANDROID")]
    EyesClosedR = 13,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_LOOK_DOWN_L_ANDROID")]
    EyesLookDownL = 14,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_LOOK_DOWN_R_ANDROID")]
    EyesLookDownR = 15,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_LOOK_LEFT_L_ANDROID")]
    EyesLookLeftL = 16,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_LOOK_LEFT_R_ANDROID")]
    EyesLookLeftR = 17,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_LOOK_RIGHT_L_ANDROID")]
    EyesLookRightL = 18,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_LOOK_RIGHT_R_ANDROID")]
    EyesLookRightR = 19,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_LOOK_UP_L_ANDROID")]
    EyesLookUpL = 20,

    [NativeName("XR_FACE_PARAMETER_INDICES_EYES_LOOK_UP_R_ANDROID")]
    EyesLookUpR = 21,

    [NativeName("XR_FACE_PARAMETER_INDICES_INNER_BROW_RAISER_L_ANDROID")]
    InnerBrowRaiserL = 22,

    [NativeName("XR_FACE_PARAMETER_INDICES_INNER_BROW_RAISER_R_ANDROID")]
    InnerBrowRaiserR = 23,

    [NativeName("XR_FACE_PARAMETER_INDICES_JAW_DROP_ANDROID")]
    JawDrop = 24,

    [NativeName("XR_FACE_PARAMETER_INDICES_JAW_SIDEWAYS_LEFT_ANDROID")]
    JawSidewaysLeft = 25,

    [NativeName("XR_FACE_PARAMETER_INDICES_JAW_SIDEWAYS_RIGHT_ANDROID")]
    JawSidewaysRight = 26,

    [NativeName("XR_FACE_PARAMETER_INDICES_JAW_THRUST_ANDROID")]
    JawThrust = 27,

    [NativeName("XR_FACE_PARAMETER_INDICES_LID_TIGHTENER_L_ANDROID")]
    LidTightenerL = 28,

    [NativeName("XR_FACE_PARAMETER_INDICES_LID_TIGHTENER_R_ANDROID")]
    LidTightenerR = 29,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_CORNER_DEPRESSOR_L_ANDROID")]
    LipCornerDepressorL = 30,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_CORNER_DEPRESSOR_R_ANDROID")]
    LipCornerDepressorR = 31,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_CORNER_PULLER_L_ANDROID")]
    LipCornerPullerL = 32,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_CORNER_PULLER_R_ANDROID")]
    LipCornerPullerR = 33,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_FUNNELER_LB_ANDROID")]
    LipFunnelerLb = 34,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_FUNNELER_LT_ANDROID")]
    LipFunnelerLt = 35,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_FUNNELER_RB_ANDROID")]
    LipFunnelerRb = 36,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_FUNNELER_RT_ANDROID")]
    LipFunnelerRt = 37,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_PRESSOR_L_ANDROID")]
    LipPressorL = 38,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_PRESSOR_R_ANDROID")]
    LipPressorR = 39,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_PUCKER_L_ANDROID")]
    LipPuckerL = 40,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_PUCKER_R_ANDROID")]
    LipPuckerR = 41,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_STRETCHER_L_ANDROID")]
    LipStretcherL = 42,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_STRETCHER_R_ANDROID")]
    LipStretcherR = 43,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_SUCK_LB_ANDROID")]
    LipSuckLb = 44,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_SUCK_LT_ANDROID")]
    LipSuckLt = 45,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_SUCK_RB_ANDROID")]
    LipSuckRb = 46,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_SUCK_RT_ANDROID")]
    LipSuckRt = 47,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_TIGHTENER_L_ANDROID")]
    LipTightenerL = 48,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIP_TIGHTENER_R_ANDROID")]
    LipTightenerR = 49,

    [NativeName("XR_FACE_PARAMETER_INDICES_LIPS_TOWARD_ANDROID")]
    LipsToward = 50,

    [NativeName("XR_FACE_PARAMETER_INDICES_LOWER_LIP_DEPRESSOR_L_ANDROID")]
    LowerLipDepressorL = 51,

    [NativeName("XR_FACE_PARAMETER_INDICES_LOWER_LIP_DEPRESSOR_R_ANDROID")]
    LowerLipDepressorR = 52,

    [NativeName("XR_FACE_PARAMETER_INDICES_MOUTH_LEFT_ANDROID")]
    MouthLeft = 53,

    [NativeName("XR_FACE_PARAMETER_INDICES_MOUTH_RIGHT_ANDROID")]
    MouthRight = 54,

    [NativeName("XR_FACE_PARAMETER_INDICES_NOSE_WRINKLER_L_ANDROID")]
    NoseWrinklerL = 55,

    [NativeName("XR_FACE_PARAMETER_INDICES_NOSE_WRINKLER_R_ANDROID")]
    NoseWrinklerR = 56,

    [NativeName("XR_FACE_PARAMETER_INDICES_OUTER_BROW_RAISER_L_ANDROID")]
    OuterBrowRaiserL = 57,

    [NativeName("XR_FACE_PARAMETER_INDICES_OUTER_BROW_RAISER_R_ANDROID")]
    OuterBrowRaiserR = 58,

    [NativeName("XR_FACE_PARAMETER_INDICES_UPPER_LID_RAISER_L_ANDROID")]
    UpperLidRaiserL = 59,

    [NativeName("XR_FACE_PARAMETER_INDICES_UPPER_LID_RAISER_R_ANDROID")]
    UpperLidRaiserR = 60,

    [NativeName("XR_FACE_PARAMETER_INDICES_UPPER_LIP_RAISER_L_ANDROID")]
    UpperLipRaiserL = 61,

    [NativeName("XR_FACE_PARAMETER_INDICES_UPPER_LIP_RAISER_R_ANDROID")]
    UpperLipRaiserR = 62,

    [NativeName("XR_FACE_PARAMETER_INDICES_TONGUE_OUT_ANDROID")]
    TongueOut = 63,

    [NativeName("XR_FACE_PARAMETER_INDICES_TONGUE_LEFT_ANDROID")]
    TongueLeft = 64,

    [NativeName("XR_FACE_PARAMETER_INDICES_TONGUE_RIGHT_ANDROID")]
    TongueRight = 65,

    [NativeName("XR_FACE_PARAMETER_INDICES_TONGUE_UP_ANDROID")]
    TongueUp = 66,

    [NativeName("XR_FACE_PARAMETER_INDICES_TONGUE_DOWN_ANDROID")]
    TongueDown = 67,
}
