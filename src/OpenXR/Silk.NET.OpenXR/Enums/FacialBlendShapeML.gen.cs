// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFacialBlendShapeML")]
    public enum FacialBlendShapeML : int
    {
        [Obsolete("Deprecated in favour of \"BrowLowererLML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_BROW_LOWERER_L_ML")]
        FacialBlendShapeBrowLowererLML = 0,
        [Obsolete("Deprecated in favour of \"BrowLowererRML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_BROW_LOWERER_R_ML")]
        FacialBlendShapeBrowLowererRML = 1,
        [Obsolete("Deprecated in favour of \"CheekRaiserLML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_CHEEK_RAISER_L_ML")]
        FacialBlendShapeCheekRaiserLML = 2,
        [Obsolete("Deprecated in favour of \"CheekRaiserRML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_CHEEK_RAISER_R_ML")]
        FacialBlendShapeCheekRaiserRML = 3,
        [Obsolete("Deprecated in favour of \"ChinRaiserML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_CHIN_RAISER_ML")]
        FacialBlendShapeChinRaiserML = 4,
        [Obsolete("Deprecated in favour of \"DimplerLML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_DIMPLER_L_ML")]
        FacialBlendShapeDimplerLML = 5,
        [Obsolete("Deprecated in favour of \"DimplerRML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_DIMPLER_R_ML")]
        FacialBlendShapeDimplerRML = 6,
        [Obsolete("Deprecated in favour of \"EyesClosedLML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_EYES_CLOSED_L_ML")]
        FacialBlendShapeEyesClosedLML = 7,
        [Obsolete("Deprecated in favour of \"EyesClosedRML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_EYES_CLOSED_R_ML")]
        FacialBlendShapeEyesClosedRML = 8,
        [Obsolete("Deprecated in favour of \"InnerBrowRaiserLML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_INNER_BROW_RAISER_L_ML")]
        FacialBlendShapeInnerBrowRaiserLML = 9,
        [Obsolete("Deprecated in favour of \"InnerBrowRaiserRML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_INNER_BROW_RAISER_R_ML")]
        FacialBlendShapeInnerBrowRaiserRML = 10,
        [Obsolete("Deprecated in favour of \"JawDropML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_JAW_DROP_ML")]
        FacialBlendShapeJawDropML = 11,
        [Obsolete("Deprecated in favour of \"LidTightenerLML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LID_TIGHTENER_L_ML")]
        FacialBlendShapeLidTightenerLML = 12,
        [Obsolete("Deprecated in favour of \"LidTightenerRML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LID_TIGHTENER_R_ML")]
        FacialBlendShapeLidTightenerRML = 13,
        [Obsolete("Deprecated in favour of \"LipCornerDepressorLML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_CORNER_DEPRESSOR_L_ML")]
        FacialBlendShapeLipCornerDepressorLML = 14,
        [Obsolete("Deprecated in favour of \"LipCornerDepressorRML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_CORNER_DEPRESSOR_R_ML")]
        FacialBlendShapeLipCornerDepressorRML = 15,
        [Obsolete("Deprecated in favour of \"LipCornerPullerLML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_CORNER_PULLER_L_ML")]
        FacialBlendShapeLipCornerPullerLML = 16,
        [Obsolete("Deprecated in favour of \"LipCornerPullerRML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_CORNER_PULLER_R_ML")]
        FacialBlendShapeLipCornerPullerRML = 17,
        [Obsolete("Deprecated in favour of \"LipFunnelerLBML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_FUNNELER_LB_ML")]
        FacialBlendShapeLipFunnelerLBML = 18,
        [Obsolete("Deprecated in favour of \"LipFunnelerLTML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_FUNNELER_LT_ML")]
        FacialBlendShapeLipFunnelerLTML = 19,
        [Obsolete("Deprecated in favour of \"LipFunnelerRBML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_FUNNELER_RB_ML")]
        FacialBlendShapeLipFunnelerRBML = 20,
        [Obsolete("Deprecated in favour of \"LipFunnelerRTML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_FUNNELER_RT_ML")]
        FacialBlendShapeLipFunnelerRTML = 21,
        [Obsolete("Deprecated in favour of \"LipPressorLML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_PRESSOR_L_ML")]
        FacialBlendShapeLipPressorLML = 22,
        [Obsolete("Deprecated in favour of \"LipPressorRML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_PRESSOR_R_ML")]
        FacialBlendShapeLipPressorRML = 23,
        [Obsolete("Deprecated in favour of \"LipPuckerLML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_PUCKER_L_ML")]
        FacialBlendShapeLipPuckerLML = 24,
        [Obsolete("Deprecated in favour of \"LipPuckerRML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_PUCKER_R_ML")]
        FacialBlendShapeLipPuckerRML = 25,
        [Obsolete("Deprecated in favour of \"LipStretcherLML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_STRETCHER_L_ML")]
        FacialBlendShapeLipStretcherLML = 26,
        [Obsolete("Deprecated in favour of \"LipStretcherRML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_STRETCHER_R_ML")]
        FacialBlendShapeLipStretcherRML = 27,
        [Obsolete("Deprecated in favour of \"LipSuckLBML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_SUCK_LB_ML")]
        FacialBlendShapeLipSuckLBML = 28,
        [Obsolete("Deprecated in favour of \"LipSuckLTML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_SUCK_LT_ML")]
        FacialBlendShapeLipSuckLTML = 29,
        [Obsolete("Deprecated in favour of \"LipSuckRBML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_SUCK_RB_ML")]
        FacialBlendShapeLipSuckRBML = 30,
        [Obsolete("Deprecated in favour of \"LipSuckRTML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_SUCK_RT_ML")]
        FacialBlendShapeLipSuckRTML = 31,
        [Obsolete("Deprecated in favour of \"LipTightenerLML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_TIGHTENER_L_ML")]
        FacialBlendShapeLipTightenerLML = 32,
        [Obsolete("Deprecated in favour of \"LipTightenerRML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_TIGHTENER_R_ML")]
        FacialBlendShapeLipTightenerRML = 33,
        [Obsolete("Deprecated in favour of \"LipsTowardML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIPS_TOWARD_ML")]
        FacialBlendShapeLipsTowardML = 34,
        [Obsolete("Deprecated in favour of \"LowerLipDepressorLML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LOWER_LIP_DEPRESSOR_L_ML")]
        FacialBlendShapeLowerLipDepressorLML = 35,
        [Obsolete("Deprecated in favour of \"LowerLipDepressorRML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LOWER_LIP_DEPRESSOR_R_ML")]
        FacialBlendShapeLowerLipDepressorRML = 36,
        [Obsolete("Deprecated in favour of \"NoseWrinklerLML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_NOSE_WRINKLER_L_ML")]
        FacialBlendShapeNoseWrinklerLML = 37,
        [Obsolete("Deprecated in favour of \"NoseWrinklerRML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_NOSE_WRINKLER_R_ML")]
        FacialBlendShapeNoseWrinklerRML = 38,
        [Obsolete("Deprecated in favour of \"OuterBrowRaiserLML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_OUTER_BROW_RAISER_L_ML")]
        FacialBlendShapeOuterBrowRaiserLML = 39,
        [Obsolete("Deprecated in favour of \"OuterBrowRaiserRML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_OUTER_BROW_RAISER_R_ML")]
        FacialBlendShapeOuterBrowRaiserRML = 40,
        [Obsolete("Deprecated in favour of \"UpperLidRaiserLML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_UPPER_LID_RAISER_L_ML")]
        FacialBlendShapeUpperLidRaiserLML = 41,
        [Obsolete("Deprecated in favour of \"UpperLidRaiserRML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_UPPER_LID_RAISER_R_ML")]
        FacialBlendShapeUpperLidRaiserRML = 42,
        [Obsolete("Deprecated in favour of \"UpperLipRaiserLML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_UPPER_LIP_RAISER_L_ML")]
        FacialBlendShapeUpperLipRaiserLML = 43,
        [Obsolete("Deprecated in favour of \"UpperLipRaiserRML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_UPPER_LIP_RAISER_R_ML")]
        FacialBlendShapeUpperLipRaiserRML = 44,
        [Obsolete("Deprecated in favour of \"TongueOutML\"")]
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_TONGUE_OUT_ML")]
        FacialBlendShapeTongueOutML = 45,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_BROW_LOWERER_L_ML")]
        BrowLowererLML = 0,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_BROW_LOWERER_R_ML")]
        BrowLowererRML = 1,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_CHEEK_RAISER_L_ML")]
        CheekRaiserLML = 2,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_CHEEK_RAISER_R_ML")]
        CheekRaiserRML = 3,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_CHIN_RAISER_ML")]
        ChinRaiserML = 4,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_DIMPLER_L_ML")]
        DimplerLML = 5,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_DIMPLER_R_ML")]
        DimplerRML = 6,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_EYES_CLOSED_L_ML")]
        EyesClosedLML = 7,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_EYES_CLOSED_R_ML")]
        EyesClosedRML = 8,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_INNER_BROW_RAISER_L_ML")]
        InnerBrowRaiserLML = 9,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_INNER_BROW_RAISER_R_ML")]
        InnerBrowRaiserRML = 10,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_JAW_DROP_ML")]
        JawDropML = 11,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LID_TIGHTENER_L_ML")]
        LidTightenerLML = 12,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LID_TIGHTENER_R_ML")]
        LidTightenerRML = 13,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_CORNER_DEPRESSOR_L_ML")]
        LipCornerDepressorLML = 14,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_CORNER_DEPRESSOR_R_ML")]
        LipCornerDepressorRML = 15,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_CORNER_PULLER_L_ML")]
        LipCornerPullerLML = 16,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_CORNER_PULLER_R_ML")]
        LipCornerPullerRML = 17,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_FUNNELER_LB_ML")]
        LipFunnelerLBML = 18,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_FUNNELER_LT_ML")]
        LipFunnelerLTML = 19,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_FUNNELER_RB_ML")]
        LipFunnelerRBML = 20,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_FUNNELER_RT_ML")]
        LipFunnelerRTML = 21,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_PRESSOR_L_ML")]
        LipPressorLML = 22,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_PRESSOR_R_ML")]
        LipPressorRML = 23,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_PUCKER_L_ML")]
        LipPuckerLML = 24,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_PUCKER_R_ML")]
        LipPuckerRML = 25,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_STRETCHER_L_ML")]
        LipStretcherLML = 26,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_STRETCHER_R_ML")]
        LipStretcherRML = 27,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_SUCK_LB_ML")]
        LipSuckLBML = 28,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_SUCK_LT_ML")]
        LipSuckLTML = 29,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_SUCK_RB_ML")]
        LipSuckRBML = 30,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_SUCK_RT_ML")]
        LipSuckRTML = 31,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_TIGHTENER_L_ML")]
        LipTightenerLML = 32,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIP_TIGHTENER_R_ML")]
        LipTightenerRML = 33,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LIPS_TOWARD_ML")]
        LipsTowardML = 34,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LOWER_LIP_DEPRESSOR_L_ML")]
        LowerLipDepressorLML = 35,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_LOWER_LIP_DEPRESSOR_R_ML")]
        LowerLipDepressorRML = 36,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_NOSE_WRINKLER_L_ML")]
        NoseWrinklerLML = 37,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_NOSE_WRINKLER_R_ML")]
        NoseWrinklerRML = 38,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_OUTER_BROW_RAISER_L_ML")]
        OuterBrowRaiserLML = 39,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_OUTER_BROW_RAISER_R_ML")]
        OuterBrowRaiserRML = 40,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_UPPER_LID_RAISER_L_ML")]
        UpperLidRaiserLML = 41,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_UPPER_LID_RAISER_R_ML")]
        UpperLidRaiserRML = 42,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_UPPER_LIP_RAISER_L_ML")]
        UpperLipRaiserLML = 43,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_UPPER_LIP_RAISER_R_ML")]
        UpperLipRaiserRML = 44,
        [NativeName("Name", "XR_FACIAL_BLEND_SHAPE_TONGUE_OUT_ML")]
        TongueOutML = 45,
    }
}
