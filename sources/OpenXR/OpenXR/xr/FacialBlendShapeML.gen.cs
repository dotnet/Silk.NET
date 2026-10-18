// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFacialBlendShapeML")]
[SupportedApiProfile("openxr")]
public enum FacialBlendShapeML : uint
{
    [NativeName("XR_FACIAL_BLEND_SHAPE_BROW_LOWERER_L_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    BrowLowererL = 0,

    [NativeName("XR_FACIAL_BLEND_SHAPE_BROW_LOWERER_R_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    BrowLowererR = 1,

    [NativeName("XR_FACIAL_BLEND_SHAPE_CHEEK_RAISER_L_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    CheekRaiserL = 2,

    [NativeName("XR_FACIAL_BLEND_SHAPE_CHEEK_RAISER_R_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    CheekRaiserR = 3,

    [NativeName("XR_FACIAL_BLEND_SHAPE_CHIN_RAISER_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    ChinRaiser = 4,

    [NativeName("XR_FACIAL_BLEND_SHAPE_DIMPLER_L_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    DimplerL = 5,

    [NativeName("XR_FACIAL_BLEND_SHAPE_DIMPLER_R_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    DimplerR = 6,

    [NativeName("XR_FACIAL_BLEND_SHAPE_EYES_CLOSED_L_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    EyesClosedL = 7,

    [NativeName("XR_FACIAL_BLEND_SHAPE_EYES_CLOSED_R_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    EyesClosedR = 8,

    [NativeName("XR_FACIAL_BLEND_SHAPE_INNER_BROW_RAISER_L_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    InnerBrowRaiserL = 9,

    [NativeName("XR_FACIAL_BLEND_SHAPE_INNER_BROW_RAISER_R_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    InnerBrowRaiserR = 10,

    [NativeName("XR_FACIAL_BLEND_SHAPE_JAW_DROP_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    JawDrop = 11,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LID_TIGHTENER_L_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LidTightenerL = 12,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LID_TIGHTENER_R_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LidTightenerR = 13,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_CORNER_DEPRESSOR_L_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipCornerDepressorL = 14,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_CORNER_DEPRESSOR_R_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipCornerDepressorR = 15,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_CORNER_PULLER_L_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipCornerPullerL = 16,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_CORNER_PULLER_R_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipCornerPullerR = 17,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_FUNNELER_LB_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipFunnelerLb = 18,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_FUNNELER_LT_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipFunnelerLt = 19,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_FUNNELER_RB_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipFunnelerRb = 20,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_FUNNELER_RT_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipFunnelerRt = 21,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_PRESSOR_L_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipPressorL = 22,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_PRESSOR_R_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipPressorR = 23,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_PUCKER_L_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipPuckerL = 24,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_PUCKER_R_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipPuckerR = 25,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_STRETCHER_L_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipStretcherL = 26,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_STRETCHER_R_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipStretcherR = 27,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_SUCK_LB_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipSuckLb = 28,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_SUCK_LT_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipSuckLt = 29,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_SUCK_RB_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipSuckRb = 30,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_SUCK_RT_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipSuckRt = 31,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_TIGHTENER_L_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipTightenerL = 32,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIP_TIGHTENER_R_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipTightenerR = 33,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LIPS_TOWARD_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LipsToward = 34,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LOWER_LIP_DEPRESSOR_L_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LowerLipDepressorL = 35,

    [NativeName("XR_FACIAL_BLEND_SHAPE_LOWER_LIP_DEPRESSOR_R_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    LowerLipDepressorR = 36,

    [NativeName("XR_FACIAL_BLEND_SHAPE_NOSE_WRINKLER_L_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    NoseWrinklerL = 37,

    [NativeName("XR_FACIAL_BLEND_SHAPE_NOSE_WRINKLER_R_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    NoseWrinklerR = 38,

    [NativeName("XR_FACIAL_BLEND_SHAPE_OUTER_BROW_RAISER_L_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    OuterBrowRaiserL = 39,

    [NativeName("XR_FACIAL_BLEND_SHAPE_OUTER_BROW_RAISER_R_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    OuterBrowRaiserR = 40,

    [NativeName("XR_FACIAL_BLEND_SHAPE_UPPER_LID_RAISER_L_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    UpperLidRaiserL = 41,

    [NativeName("XR_FACIAL_BLEND_SHAPE_UPPER_LID_RAISER_R_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    UpperLidRaiserR = 42,

    [NativeName("XR_FACIAL_BLEND_SHAPE_UPPER_LIP_RAISER_L_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    UpperLipRaiserL = 43,

    [NativeName("XR_FACIAL_BLEND_SHAPE_UPPER_LIP_RAISER_R_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    UpperLipRaiserR = 44,

    [NativeName("XR_FACIAL_BLEND_SHAPE_TONGUE_OUT_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_facial_expression"])]
    TongueOut = 45,
}
