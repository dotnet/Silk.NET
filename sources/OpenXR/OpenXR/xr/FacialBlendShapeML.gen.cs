// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFacialBlendShapeML")]
public enum FacialBlendShapeML : uint
{
    [NativeName("XR_FACIAL_BLEND_SHAPE_BROW_LOWERER_L_ML")]
    BrowLowererL = 0,

    [NativeName("XR_FACIAL_BLEND_SHAPE_BROW_LOWERER_R_ML")]
    BrowLowererR = 1,

    [NativeName("XR_FACIAL_BLEND_SHAPE_CHEEK_RAISER_L_ML")]
    CheekRaiserL = 2,

    [NativeName("XR_FACIAL_BLEND_SHAPE_CHEEK_RAISER_R_ML")]
    CheekRaiserR = 3,

    [NativeName("XR_FACIAL_BLEND_SHAPE_CHIN_RAISER_ML")]
    ChinRaiser = 4,

    [NativeName("XR_FACIAL_BLEND_SHAPE_DIMPLER_L_ML")]
    DimplerL = 5,

    [NativeName("XR_FACIAL_BLEND_SHAPE_DIMPLER_R_ML")]
    DimplerR = 6,

    [NativeName("XR_FACIAL_BLEND_SHAPE_EYES_CLOSED_L_ML")]
    EyesClosedL = 7,

    [NativeName("XR_FACIAL_BLEND_SHAPE_EYES_CLOSED_R_ML")]
    EyesClosedR = 8,

    [NativeName("XR_FACIAL_BLEND_SHAPE_INNER_BROW_RAISER_L_ML")]
    InnerBrowRaiserL = 9,

    [NativeName("XR_FACIAL_BLEND_SHAPE_INNER_BROW_RAISER_R_ML")]
    InnerBrowRaiserR = 10,

    [NativeName("XR_FACIAL_BLEND_SHAPE_JAW_DROP_ML")]
    JawDrop = 11,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LID_TIGHTENER_L_ML")]
    LidTightenerL = 12,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LID_TIGHTENER_R_ML")]
    LidTightenerR = 13,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_CORNER_DEPRESSOR_L_ML")]
    LipCornerDepressorL = 14,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_CORNER_DEPRESSOR_R_ML")]
    LipCornerDepressorR = 15,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_CORNER_PULLER_L_ML")]
    LipCornerPullerL = 16,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_CORNER_PULLER_R_ML")]
    LipCornerPullerR = 17,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_FUNNELER_LB_ML")]
    LipFunnelerLb = 18,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_FUNNELER_LT_ML")]
    LipFunnelerLt = 19,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_FUNNELER_RB_ML")]
    LipFunnelerRb = 20,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_FUNNELER_RT_ML")]
    LipFunnelerRt = 21,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_PRESSOR_L_ML")]
    LipPressorL = 22,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_PRESSOR_R_ML")]
    LipPressorR = 23,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_PUCKER_L_ML")]
    LipPuckerL = 24,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_PUCKER_R_ML")]
    LipPuckerR = 25,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_STRETCHER_L_ML")]
    LipStretcherL = 26,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_STRETCHER_R_ML")]
    LipStretcherR = 27,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_SUCK_LB_ML")]
    LipSuckLb = 28,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_SUCK_LT_ML")]
    LipSuckLt = 29,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_SUCK_RB_ML")]
    LipSuckRb = 30,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_SUCK_RT_ML")]
    LipSuckRt = 31,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_TIGHTENER_L_ML")]
    LipTightenerL = 32,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_TIGHTENER_R_ML")]
    LipTightenerR = 33,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIPS_TOWARD_ML")]
    LipsToward = 34,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LOWER_LIP_DEPRESSOR_L_ML")]
    LowerLipDepressorL = 35,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LOWER_LIP_DEPRESSOR_R_ML")]
    LowerLipDepressorR = 36,

    [NativeName("XR_FACIAL_BLEND_SHAPE_NOSE_WRINKLER_L_ML")]
    NoseWrinklerL = 37,

    [NativeName("XR_FACIAL_BLEND_SHAPE_NOSE_WRINKLER_R_ML")]
    NoseWrinklerR = 38,

    [NativeName("XR_FACIAL_BLEND_SHAPE_OUTER_BROW_RAISER_L_ML")]
    OuterBrowRaiserL = 39,

    [NativeName("XR_FACIAL_BLEND_SHAPE_OUTER_BROW_RAISER_R_ML")]
    OuterBrowRaiserR = 40,

    [NativeName("XR_FACIAL_BLEND_SHAPE_UPPER_LID_RAISER_L_ML")]
    UpperLidRaiserL = 41,

    [NativeName("XR_FACIAL_BLEND_SHAPE_UPPER_LID_RAISER_R_ML")]
    UpperLidRaiserR = 42,

    [NativeName("XR_FACIAL_BLEND_SHAPE_UPPER_LIP_RAISER_L_ML")]
    UpperLipRaiserL = 43,

    [NativeName("XR_FACIAL_BLEND_SHAPE_UPPER_LIP_RAISER_R_ML")]
    UpperLipRaiserR = 44,

    [NativeName("XR_FACIAL_BLEND_SHAPE_TONGUE_OUT_ML")]
    TongueOut = 45,
}
