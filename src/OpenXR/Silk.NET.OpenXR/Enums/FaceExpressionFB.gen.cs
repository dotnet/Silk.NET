// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFaceExpressionFB")]
    public enum FaceExpressionFB : int
    {
        [Obsolete("Deprecated in favour of \"BrowLowererLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_BROW_LOWERER_L_FB")]
        FaceExpressionBrowLowererLFB = 0,
        [Obsolete("Deprecated in favour of \"BrowLowererRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_BROW_LOWERER_R_FB")]
        FaceExpressionBrowLowererRFB = 1,
        [Obsolete("Deprecated in favour of \"CheekPuffLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_PUFF_L_FB")]
        FaceExpressionCheekPuffLFB = 2,
        [Obsolete("Deprecated in favour of \"CheekPuffRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_PUFF_R_FB")]
        FaceExpressionCheekPuffRFB = 3,
        [Obsolete("Deprecated in favour of \"CheekRaiserLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_RAISER_L_FB")]
        FaceExpressionCheekRaiserLFB = 4,
        [Obsolete("Deprecated in favour of \"CheekRaiserRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_RAISER_R_FB")]
        FaceExpressionCheekRaiserRFB = 5,
        [Obsolete("Deprecated in favour of \"CheekSuckLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_SUCK_L_FB")]
        FaceExpressionCheekSuckLFB = 6,
        [Obsolete("Deprecated in favour of \"CheekSuckRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_SUCK_R_FB")]
        FaceExpressionCheekSuckRFB = 7,
        [Obsolete("Deprecated in favour of \"ChinRaiserBFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_CHIN_RAISER_B_FB")]
        FaceExpressionChinRaiserBFB = 8,
        [Obsolete("Deprecated in favour of \"ChinRaiserTFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_CHIN_RAISER_T_FB")]
        FaceExpressionChinRaiserTFB = 9,
        [Obsolete("Deprecated in favour of \"DimplerLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_DIMPLER_L_FB")]
        FaceExpressionDimplerLFB = 10,
        [Obsolete("Deprecated in favour of \"DimplerRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_DIMPLER_R_FB")]
        FaceExpressionDimplerRFB = 11,
        [Obsolete("Deprecated in favour of \"EyesClosedLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_CLOSED_L_FB")]
        FaceExpressionEyesClosedLFB = 12,
        [Obsolete("Deprecated in favour of \"EyesClosedRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_CLOSED_R_FB")]
        FaceExpressionEyesClosedRFB = 13,
        [Obsolete("Deprecated in favour of \"EyesLookDownLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_LOOK_DOWN_L_FB")]
        FaceExpressionEyesLookDownLFB = 14,
        [Obsolete("Deprecated in favour of \"EyesLookDownRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_LOOK_DOWN_R_FB")]
        FaceExpressionEyesLookDownRFB = 15,
        [Obsolete("Deprecated in favour of \"EyesLookLeftLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_LOOK_LEFT_L_FB")]
        FaceExpressionEyesLookLeftLFB = 16,
        [Obsolete("Deprecated in favour of \"EyesLookLeftRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_LOOK_LEFT_R_FB")]
        FaceExpressionEyesLookLeftRFB = 17,
        [Obsolete("Deprecated in favour of \"EyesLookRightLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_LOOK_RIGHT_L_FB")]
        FaceExpressionEyesLookRightLFB = 18,
        [Obsolete("Deprecated in favour of \"EyesLookRightRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_LOOK_RIGHT_R_FB")]
        FaceExpressionEyesLookRightRFB = 19,
        [Obsolete("Deprecated in favour of \"EyesLookUpLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_LOOK_UP_L_FB")]
        FaceExpressionEyesLookUpLFB = 20,
        [Obsolete("Deprecated in favour of \"EyesLookUpRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_LOOK_UP_R_FB")]
        FaceExpressionEyesLookUpRFB = 21,
        [Obsolete("Deprecated in favour of \"InnerBrowRaiserLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_INNER_BROW_RAISER_L_FB")]
        FaceExpressionInnerBrowRaiserLFB = 22,
        [Obsolete("Deprecated in favour of \"InnerBrowRaiserRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_INNER_BROW_RAISER_R_FB")]
        FaceExpressionInnerBrowRaiserRFB = 23,
        [Obsolete("Deprecated in favour of \"JawDropFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_JAW_DROP_FB")]
        FaceExpressionJawDropFB = 24,
        [Obsolete("Deprecated in favour of \"JawSidewaysLeftFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_JAW_SIDEWAYS_LEFT_FB")]
        FaceExpressionJawSidewaysLeftFB = 25,
        [Obsolete("Deprecated in favour of \"JawSidewaysRightFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_JAW_SIDEWAYS_RIGHT_FB")]
        FaceExpressionJawSidewaysRightFB = 26,
        [Obsolete("Deprecated in favour of \"JawThrustFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_JAW_THRUST_FB")]
        FaceExpressionJawThrustFB = 27,
        [Obsolete("Deprecated in favour of \"LidTightenerLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LID_TIGHTENER_L_FB")]
        FaceExpressionLidTightenerLFB = 28,
        [Obsolete("Deprecated in favour of \"LidTightenerRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LID_TIGHTENER_R_FB")]
        FaceExpressionLidTightenerRFB = 29,
        [Obsolete("Deprecated in favour of \"LipCornerDepressorLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_CORNER_DEPRESSOR_L_FB")]
        FaceExpressionLipCornerDepressorLFB = 30,
        [Obsolete("Deprecated in favour of \"LipCornerDepressorRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_CORNER_DEPRESSOR_R_FB")]
        FaceExpressionLipCornerDepressorRFB = 31,
        [Obsolete("Deprecated in favour of \"LipCornerPullerLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_CORNER_PULLER_L_FB")]
        FaceExpressionLipCornerPullerLFB = 32,
        [Obsolete("Deprecated in favour of \"LipCornerPullerRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_CORNER_PULLER_R_FB")]
        FaceExpressionLipCornerPullerRFB = 33,
        [Obsolete("Deprecated in favour of \"LipFunnelerLBFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_FUNNELER_LB_FB")]
        FaceExpressionLipFunnelerLBFB = 34,
        [Obsolete("Deprecated in favour of \"LipFunnelerLTFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_FUNNELER_LT_FB")]
        FaceExpressionLipFunnelerLTFB = 35,
        [Obsolete("Deprecated in favour of \"LipFunnelerRBFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_FUNNELER_RB_FB")]
        FaceExpressionLipFunnelerRBFB = 36,
        [Obsolete("Deprecated in favour of \"LipFunnelerRTFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_FUNNELER_RT_FB")]
        FaceExpressionLipFunnelerRTFB = 37,
        [Obsolete("Deprecated in favour of \"LipPressorLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_PRESSOR_L_FB")]
        FaceExpressionLipPressorLFB = 38,
        [Obsolete("Deprecated in favour of \"LipPressorRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_PRESSOR_R_FB")]
        FaceExpressionLipPressorRFB = 39,
        [Obsolete("Deprecated in favour of \"LipPuckerLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_PUCKER_L_FB")]
        FaceExpressionLipPuckerLFB = 40,
        [Obsolete("Deprecated in favour of \"LipPuckerRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_PUCKER_R_FB")]
        FaceExpressionLipPuckerRFB = 41,
        [Obsolete("Deprecated in favour of \"LipStretcherLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_STRETCHER_L_FB")]
        FaceExpressionLipStretcherLFB = 42,
        [Obsolete("Deprecated in favour of \"LipStretcherRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_STRETCHER_R_FB")]
        FaceExpressionLipStretcherRFB = 43,
        [Obsolete("Deprecated in favour of \"LipSuckLBFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_SUCK_LB_FB")]
        FaceExpressionLipSuckLBFB = 44,
        [Obsolete("Deprecated in favour of \"LipSuckLTFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_SUCK_LT_FB")]
        FaceExpressionLipSuckLTFB = 45,
        [Obsolete("Deprecated in favour of \"LipSuckRBFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_SUCK_RB_FB")]
        FaceExpressionLipSuckRBFB = 46,
        [Obsolete("Deprecated in favour of \"LipSuckRTFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_SUCK_RT_FB")]
        FaceExpressionLipSuckRTFB = 47,
        [Obsolete("Deprecated in favour of \"LipTightenerLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_TIGHTENER_L_FB")]
        FaceExpressionLipTightenerLFB = 48,
        [Obsolete("Deprecated in favour of \"LipTightenerRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_TIGHTENER_R_FB")]
        FaceExpressionLipTightenerRFB = 49,
        [Obsolete("Deprecated in favour of \"LipsTowardFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LIPS_TOWARD_FB")]
        FaceExpressionLipsTowardFB = 50,
        [Obsolete("Deprecated in favour of \"LowerLipDepressorLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LOWER_LIP_DEPRESSOR_L_FB")]
        FaceExpressionLowerLipDepressorLFB = 51,
        [Obsolete("Deprecated in favour of \"LowerLipDepressorRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_LOWER_LIP_DEPRESSOR_R_FB")]
        FaceExpressionLowerLipDepressorRFB = 52,
        [Obsolete("Deprecated in favour of \"MouthLeftFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_LEFT_FB")]
        FaceExpressionMouthLeftFB = 53,
        [Obsolete("Deprecated in favour of \"MouthRightFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_RIGHT_FB")]
        FaceExpressionMouthRightFB = 54,
        [Obsolete("Deprecated in favour of \"NoseWrinklerLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_NOSE_WRINKLER_L_FB")]
        FaceExpressionNoseWrinklerLFB = 55,
        [Obsolete("Deprecated in favour of \"NoseWrinklerRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_NOSE_WRINKLER_R_FB")]
        FaceExpressionNoseWrinklerRFB = 56,
        [Obsolete("Deprecated in favour of \"OuterBrowRaiserLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_OUTER_BROW_RAISER_L_FB")]
        FaceExpressionOuterBrowRaiserLFB = 57,
        [Obsolete("Deprecated in favour of \"OuterBrowRaiserRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_OUTER_BROW_RAISER_R_FB")]
        FaceExpressionOuterBrowRaiserRFB = 58,
        [Obsolete("Deprecated in favour of \"UpperLidRaiserLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_UPPER_LID_RAISER_L_FB")]
        FaceExpressionUpperLidRaiserLFB = 59,
        [Obsolete("Deprecated in favour of \"UpperLidRaiserRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_UPPER_LID_RAISER_R_FB")]
        FaceExpressionUpperLidRaiserRFB = 60,
        [Obsolete("Deprecated in favour of \"UpperLipRaiserLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_UPPER_LIP_RAISER_L_FB")]
        FaceExpressionUpperLipRaiserLFB = 61,
        [Obsolete("Deprecated in favour of \"UpperLipRaiserRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_UPPER_LIP_RAISER_R_FB")]
        FaceExpressionUpperLipRaiserRFB = 62,
        [Obsolete("Deprecated in favour of \"CountFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_COUNT_FB")]
        FaceExpressionCountFB = 63,
        [NativeName("Name", "XR_FACE_EXPRESSION_BROW_LOWERER_L_FB")]
        BrowLowererLFB = 0,
        [NativeName("Name", "XR_FACE_EXPRESSION_BROW_LOWERER_R_FB")]
        BrowLowererRFB = 1,
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_PUFF_L_FB")]
        CheekPuffLFB = 2,
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_PUFF_R_FB")]
        CheekPuffRFB = 3,
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_RAISER_L_FB")]
        CheekRaiserLFB = 4,
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_RAISER_R_FB")]
        CheekRaiserRFB = 5,
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_SUCK_L_FB")]
        CheekSuckLFB = 6,
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_SUCK_R_FB")]
        CheekSuckRFB = 7,
        [NativeName("Name", "XR_FACE_EXPRESSION_CHIN_RAISER_B_FB")]
        ChinRaiserBFB = 8,
        [NativeName("Name", "XR_FACE_EXPRESSION_CHIN_RAISER_T_FB")]
        ChinRaiserTFB = 9,
        [NativeName("Name", "XR_FACE_EXPRESSION_DIMPLER_L_FB")]
        DimplerLFB = 10,
        [NativeName("Name", "XR_FACE_EXPRESSION_DIMPLER_R_FB")]
        DimplerRFB = 11,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_CLOSED_L_FB")]
        EyesClosedLFB = 12,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_CLOSED_R_FB")]
        EyesClosedRFB = 13,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_LOOK_DOWN_L_FB")]
        EyesLookDownLFB = 14,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_LOOK_DOWN_R_FB")]
        EyesLookDownRFB = 15,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_LOOK_LEFT_L_FB")]
        EyesLookLeftLFB = 16,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_LOOK_LEFT_R_FB")]
        EyesLookLeftRFB = 17,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_LOOK_RIGHT_L_FB")]
        EyesLookRightLFB = 18,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_LOOK_RIGHT_R_FB")]
        EyesLookRightRFB = 19,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_LOOK_UP_L_FB")]
        EyesLookUpLFB = 20,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYES_LOOK_UP_R_FB")]
        EyesLookUpRFB = 21,
        [NativeName("Name", "XR_FACE_EXPRESSION_INNER_BROW_RAISER_L_FB")]
        InnerBrowRaiserLFB = 22,
        [NativeName("Name", "XR_FACE_EXPRESSION_INNER_BROW_RAISER_R_FB")]
        InnerBrowRaiserRFB = 23,
        [NativeName("Name", "XR_FACE_EXPRESSION_JAW_DROP_FB")]
        JawDropFB = 24,
        [NativeName("Name", "XR_FACE_EXPRESSION_JAW_SIDEWAYS_LEFT_FB")]
        JawSidewaysLeftFB = 25,
        [NativeName("Name", "XR_FACE_EXPRESSION_JAW_SIDEWAYS_RIGHT_FB")]
        JawSidewaysRightFB = 26,
        [NativeName("Name", "XR_FACE_EXPRESSION_JAW_THRUST_FB")]
        JawThrustFB = 27,
        [NativeName("Name", "XR_FACE_EXPRESSION_LID_TIGHTENER_L_FB")]
        LidTightenerLFB = 28,
        [NativeName("Name", "XR_FACE_EXPRESSION_LID_TIGHTENER_R_FB")]
        LidTightenerRFB = 29,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_CORNER_DEPRESSOR_L_FB")]
        LipCornerDepressorLFB = 30,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_CORNER_DEPRESSOR_R_FB")]
        LipCornerDepressorRFB = 31,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_CORNER_PULLER_L_FB")]
        LipCornerPullerLFB = 32,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_CORNER_PULLER_R_FB")]
        LipCornerPullerRFB = 33,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_FUNNELER_LB_FB")]
        LipFunnelerLBFB = 34,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_FUNNELER_LT_FB")]
        LipFunnelerLTFB = 35,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_FUNNELER_RB_FB")]
        LipFunnelerRBFB = 36,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_FUNNELER_RT_FB")]
        LipFunnelerRTFB = 37,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_PRESSOR_L_FB")]
        LipPressorLFB = 38,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_PRESSOR_R_FB")]
        LipPressorRFB = 39,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_PUCKER_L_FB")]
        LipPuckerLFB = 40,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_PUCKER_R_FB")]
        LipPuckerRFB = 41,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_STRETCHER_L_FB")]
        LipStretcherLFB = 42,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_STRETCHER_R_FB")]
        LipStretcherRFB = 43,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_SUCK_LB_FB")]
        LipSuckLBFB = 44,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_SUCK_LT_FB")]
        LipSuckLTFB = 45,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_SUCK_RB_FB")]
        LipSuckRBFB = 46,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_SUCK_RT_FB")]
        LipSuckRTFB = 47,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_TIGHTENER_L_FB")]
        LipTightenerLFB = 48,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIP_TIGHTENER_R_FB")]
        LipTightenerRFB = 49,
        [NativeName("Name", "XR_FACE_EXPRESSION_LIPS_TOWARD_FB")]
        LipsTowardFB = 50,
        [NativeName("Name", "XR_FACE_EXPRESSION_LOWER_LIP_DEPRESSOR_L_FB")]
        LowerLipDepressorLFB = 51,
        [NativeName("Name", "XR_FACE_EXPRESSION_LOWER_LIP_DEPRESSOR_R_FB")]
        LowerLipDepressorRFB = 52,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_LEFT_FB")]
        MouthLeftFB = 53,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_RIGHT_FB")]
        MouthRightFB = 54,
        [NativeName("Name", "XR_FACE_EXPRESSION_NOSE_WRINKLER_L_FB")]
        NoseWrinklerLFB = 55,
        [NativeName("Name", "XR_FACE_EXPRESSION_NOSE_WRINKLER_R_FB")]
        NoseWrinklerRFB = 56,
        [NativeName("Name", "XR_FACE_EXPRESSION_OUTER_BROW_RAISER_L_FB")]
        OuterBrowRaiserLFB = 57,
        [NativeName("Name", "XR_FACE_EXPRESSION_OUTER_BROW_RAISER_R_FB")]
        OuterBrowRaiserRFB = 58,
        [NativeName("Name", "XR_FACE_EXPRESSION_UPPER_LID_RAISER_L_FB")]
        UpperLidRaiserLFB = 59,
        [NativeName("Name", "XR_FACE_EXPRESSION_UPPER_LID_RAISER_R_FB")]
        UpperLidRaiserRFB = 60,
        [NativeName("Name", "XR_FACE_EXPRESSION_UPPER_LIP_RAISER_L_FB")]
        UpperLipRaiserLFB = 61,
        [NativeName("Name", "XR_FACE_EXPRESSION_UPPER_LIP_RAISER_R_FB")]
        UpperLipRaiserRFB = 62,
        [NativeName("Name", "XR_FACE_EXPRESSION_COUNT_FB")]
        CountFB = 63,
    }
}
