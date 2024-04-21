// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFaceExpression2FB")]
    public enum FaceExpression2FB : int
    {
        [Obsolete("Deprecated in favour of \"BrowLowererLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_BROW_LOWERER_L_FB")]
        FaceExpression2BrowLowererLFB = 0,
        [Obsolete("Deprecated in favour of \"BrowLowererRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_BROW_LOWERER_R_FB")]
        FaceExpression2BrowLowererRFB = 1,
        [Obsolete("Deprecated in favour of \"CheekPuffLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_CHEEK_PUFF_L_FB")]
        FaceExpression2CheekPuffLFB = 2,
        [Obsolete("Deprecated in favour of \"CheekPuffRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_CHEEK_PUFF_R_FB")]
        FaceExpression2CheekPuffRFB = 3,
        [Obsolete("Deprecated in favour of \"CheekRaiserLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_CHEEK_RAISER_L_FB")]
        FaceExpression2CheekRaiserLFB = 4,
        [Obsolete("Deprecated in favour of \"CheekRaiserRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_CHEEK_RAISER_R_FB")]
        FaceExpression2CheekRaiserRFB = 5,
        [Obsolete("Deprecated in favour of \"CheekSuckLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_CHEEK_SUCK_L_FB")]
        FaceExpression2CheekSuckLFB = 6,
        [Obsolete("Deprecated in favour of \"CheekSuckRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_CHEEK_SUCK_R_FB")]
        FaceExpression2CheekSuckRFB = 7,
        [Obsolete("Deprecated in favour of \"ChinRaiserBFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_CHIN_RAISER_B_FB")]
        FaceExpression2ChinRaiserBFB = 8,
        [Obsolete("Deprecated in favour of \"ChinRaiserTFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_CHIN_RAISER_T_FB")]
        FaceExpression2ChinRaiserTFB = 9,
        [Obsolete("Deprecated in favour of \"DimplerLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_DIMPLER_L_FB")]
        FaceExpression2DimplerLFB = 10,
        [Obsolete("Deprecated in favour of \"DimplerRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_DIMPLER_R_FB")]
        FaceExpression2DimplerRFB = 11,
        [Obsolete("Deprecated in favour of \"EyesClosedLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_CLOSED_L_FB")]
        FaceExpression2EyesClosedLFB = 12,
        [Obsolete("Deprecated in favour of \"EyesClosedRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_CLOSED_R_FB")]
        FaceExpression2EyesClosedRFB = 13,
        [Obsolete("Deprecated in favour of \"EyesLookDownLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_LOOK_DOWN_L_FB")]
        FaceExpression2EyesLookDownLFB = 14,
        [Obsolete("Deprecated in favour of \"EyesLookDownRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_LOOK_DOWN_R_FB")]
        FaceExpression2EyesLookDownRFB = 15,
        [Obsolete("Deprecated in favour of \"EyesLookLeftLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_LOOK_LEFT_L_FB")]
        FaceExpression2EyesLookLeftLFB = 16,
        [Obsolete("Deprecated in favour of \"EyesLookLeftRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_LOOK_LEFT_R_FB")]
        FaceExpression2EyesLookLeftRFB = 17,
        [Obsolete("Deprecated in favour of \"EyesLookRightLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_LOOK_RIGHT_L_FB")]
        FaceExpression2EyesLookRightLFB = 18,
        [Obsolete("Deprecated in favour of \"EyesLookRightRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_LOOK_RIGHT_R_FB")]
        FaceExpression2EyesLookRightRFB = 19,
        [Obsolete("Deprecated in favour of \"EyesLookUpLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_LOOK_UP_L_FB")]
        FaceExpression2EyesLookUpLFB = 20,
        [Obsolete("Deprecated in favour of \"EyesLookUpRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_LOOK_UP_R_FB")]
        FaceExpression2EyesLookUpRFB = 21,
        [Obsolete("Deprecated in favour of \"InnerBrowRaiserLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_INNER_BROW_RAISER_L_FB")]
        FaceExpression2InnerBrowRaiserLFB = 22,
        [Obsolete("Deprecated in favour of \"InnerBrowRaiserRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_INNER_BROW_RAISER_R_FB")]
        FaceExpression2InnerBrowRaiserRFB = 23,
        [Obsolete("Deprecated in favour of \"JawDropFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_JAW_DROP_FB")]
        FaceExpression2JawDropFB = 24,
        [Obsolete("Deprecated in favour of \"JawSidewaysLeftFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_JAW_SIDEWAYS_LEFT_FB")]
        FaceExpression2JawSidewaysLeftFB = 25,
        [Obsolete("Deprecated in favour of \"JawSidewaysRightFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_JAW_SIDEWAYS_RIGHT_FB")]
        FaceExpression2JawSidewaysRightFB = 26,
        [Obsolete("Deprecated in favour of \"JawThrustFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_JAW_THRUST_FB")]
        FaceExpression2JawThrustFB = 27,
        [Obsolete("Deprecated in favour of \"LidTightenerLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LID_TIGHTENER_L_FB")]
        FaceExpression2LidTightenerLFB = 28,
        [Obsolete("Deprecated in favour of \"LidTightenerRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LID_TIGHTENER_R_FB")]
        FaceExpression2LidTightenerRFB = 29,
        [Obsolete("Deprecated in favour of \"LipCornerDepressorLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_CORNER_DEPRESSOR_L_FB")]
        FaceExpression2LipCornerDepressorLFB = 30,
        [Obsolete("Deprecated in favour of \"LipCornerDepressorRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_CORNER_DEPRESSOR_R_FB")]
        FaceExpression2LipCornerDepressorRFB = 31,
        [Obsolete("Deprecated in favour of \"LipCornerPullerLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_CORNER_PULLER_L_FB")]
        FaceExpression2LipCornerPullerLFB = 32,
        [Obsolete("Deprecated in favour of \"LipCornerPullerRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_CORNER_PULLER_R_FB")]
        FaceExpression2LipCornerPullerRFB = 33,
        [Obsolete("Deprecated in favour of \"LipFunnelerLBFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_FUNNELER_LB_FB")]
        FaceExpression2LipFunnelerLBFB = 34,
        [Obsolete("Deprecated in favour of \"LipFunnelerLTFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_FUNNELER_LT_FB")]
        FaceExpression2LipFunnelerLTFB = 35,
        [Obsolete("Deprecated in favour of \"LipFunnelerRBFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_FUNNELER_RB_FB")]
        FaceExpression2LipFunnelerRBFB = 36,
        [Obsolete("Deprecated in favour of \"LipFunnelerRTFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_FUNNELER_RT_FB")]
        FaceExpression2LipFunnelerRTFB = 37,
        [Obsolete("Deprecated in favour of \"LipPressorLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_PRESSOR_L_FB")]
        FaceExpression2LipPressorLFB = 38,
        [Obsolete("Deprecated in favour of \"LipPressorRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_PRESSOR_R_FB")]
        FaceExpression2LipPressorRFB = 39,
        [Obsolete("Deprecated in favour of \"LipPuckerLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_PUCKER_L_FB")]
        FaceExpression2LipPuckerLFB = 40,
        [Obsolete("Deprecated in favour of \"LipPuckerRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_PUCKER_R_FB")]
        FaceExpression2LipPuckerRFB = 41,
        [Obsolete("Deprecated in favour of \"LipStretcherLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_STRETCHER_L_FB")]
        FaceExpression2LipStretcherLFB = 42,
        [Obsolete("Deprecated in favour of \"LipStretcherRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_STRETCHER_R_FB")]
        FaceExpression2LipStretcherRFB = 43,
        [Obsolete("Deprecated in favour of \"LipSuckLBFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_SUCK_LB_FB")]
        FaceExpression2LipSuckLBFB = 44,
        [Obsolete("Deprecated in favour of \"LipSuckLTFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_SUCK_LT_FB")]
        FaceExpression2LipSuckLTFB = 45,
        [Obsolete("Deprecated in favour of \"LipSuckRBFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_SUCK_RB_FB")]
        FaceExpression2LipSuckRBFB = 46,
        [Obsolete("Deprecated in favour of \"LipSuckRTFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_SUCK_RT_FB")]
        FaceExpression2LipSuckRTFB = 47,
        [Obsolete("Deprecated in favour of \"LipTightenerLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_TIGHTENER_L_FB")]
        FaceExpression2LipTightenerLFB = 48,
        [Obsolete("Deprecated in favour of \"LipTightenerRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_TIGHTENER_R_FB")]
        FaceExpression2LipTightenerRFB = 49,
        [Obsolete("Deprecated in favour of \"LipsTowardFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIPS_TOWARD_FB")]
        FaceExpression2LipsTowardFB = 50,
        [Obsolete("Deprecated in favour of \"LowerLipDepressorLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LOWER_LIP_DEPRESSOR_L_FB")]
        FaceExpression2LowerLipDepressorLFB = 51,
        [Obsolete("Deprecated in favour of \"LowerLipDepressorRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_LOWER_LIP_DEPRESSOR_R_FB")]
        FaceExpression2LowerLipDepressorRFB = 52,
        [Obsolete("Deprecated in favour of \"MouthLeftFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_MOUTH_LEFT_FB")]
        FaceExpression2MouthLeftFB = 53,
        [Obsolete("Deprecated in favour of \"MouthRightFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_MOUTH_RIGHT_FB")]
        FaceExpression2MouthRightFB = 54,
        [Obsolete("Deprecated in favour of \"NoseWrinklerLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_NOSE_WRINKLER_L_FB")]
        FaceExpression2NoseWrinklerLFB = 55,
        [Obsolete("Deprecated in favour of \"NoseWrinklerRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_NOSE_WRINKLER_R_FB")]
        FaceExpression2NoseWrinklerRFB = 56,
        [Obsolete("Deprecated in favour of \"OuterBrowRaiserLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_OUTER_BROW_RAISER_L_FB")]
        FaceExpression2OuterBrowRaiserLFB = 57,
        [Obsolete("Deprecated in favour of \"OuterBrowRaiserRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_OUTER_BROW_RAISER_R_FB")]
        FaceExpression2OuterBrowRaiserRFB = 58,
        [Obsolete("Deprecated in favour of \"UpperLidRaiserLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_UPPER_LID_RAISER_L_FB")]
        FaceExpression2UpperLidRaiserLFB = 59,
        [Obsolete("Deprecated in favour of \"UpperLidRaiserRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_UPPER_LID_RAISER_R_FB")]
        FaceExpression2UpperLidRaiserRFB = 60,
        [Obsolete("Deprecated in favour of \"UpperLipRaiserLFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_UPPER_LIP_RAISER_L_FB")]
        FaceExpression2UpperLipRaiserLFB = 61,
        [Obsolete("Deprecated in favour of \"UpperLipRaiserRFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_UPPER_LIP_RAISER_R_FB")]
        FaceExpression2UpperLipRaiserRFB = 62,
        [Obsolete("Deprecated in favour of \"TongueTipInterdentalFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_TONGUE_TIP_INTERDENTAL_FB")]
        FaceExpression2TongueTipInterdentalFB = 63,
        [Obsolete("Deprecated in favour of \"TongueTipAlveolarFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_TONGUE_TIP_ALVEOLAR_FB")]
        FaceExpression2TongueTipAlveolarFB = 64,
        [Obsolete("Deprecated in favour of \"TongueFrontDorsalPalateFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_TONGUE_FRONT_DORSAL_PALATE_FB")]
        FaceExpression2TongueFrontDorsalPalateFB = 65,
        [Obsolete("Deprecated in favour of \"TongueMidDorsalPalateFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_TONGUE_MID_DORSAL_PALATE_FB")]
        FaceExpression2TongueMidDorsalPalateFB = 66,
        [Obsolete("Deprecated in favour of \"TongueBackDorsalVelarFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_TONGUE_BACK_DORSAL_VELAR_FB")]
        FaceExpression2TongueBackDorsalVelarFB = 67,
        [Obsolete("Deprecated in favour of \"TongueOutFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_TONGUE_OUT_FB")]
        FaceExpression2TongueOutFB = 68,
        [Obsolete("Deprecated in favour of \"TongueRetreatFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_TONGUE_RETREAT_FB")]
        FaceExpression2TongueRetreatFB = 69,
        [Obsolete("Deprecated in favour of \"CountFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION2_COUNT_FB")]
        FaceExpression2CountFB = 70,
        [NativeName("Name", "XR_FACE_EXPRESSION2_BROW_LOWERER_L_FB")]
        BrowLowererLFB = 0,
        [NativeName("Name", "XR_FACE_EXPRESSION2_BROW_LOWERER_R_FB")]
        BrowLowererRFB = 1,
        [NativeName("Name", "XR_FACE_EXPRESSION2_CHEEK_PUFF_L_FB")]
        CheekPuffLFB = 2,
        [NativeName("Name", "XR_FACE_EXPRESSION2_CHEEK_PUFF_R_FB")]
        CheekPuffRFB = 3,
        [NativeName("Name", "XR_FACE_EXPRESSION2_CHEEK_RAISER_L_FB")]
        CheekRaiserLFB = 4,
        [NativeName("Name", "XR_FACE_EXPRESSION2_CHEEK_RAISER_R_FB")]
        CheekRaiserRFB = 5,
        [NativeName("Name", "XR_FACE_EXPRESSION2_CHEEK_SUCK_L_FB")]
        CheekSuckLFB = 6,
        [NativeName("Name", "XR_FACE_EXPRESSION2_CHEEK_SUCK_R_FB")]
        CheekSuckRFB = 7,
        [NativeName("Name", "XR_FACE_EXPRESSION2_CHIN_RAISER_B_FB")]
        ChinRaiserBFB = 8,
        [NativeName("Name", "XR_FACE_EXPRESSION2_CHIN_RAISER_T_FB")]
        ChinRaiserTFB = 9,
        [NativeName("Name", "XR_FACE_EXPRESSION2_DIMPLER_L_FB")]
        DimplerLFB = 10,
        [NativeName("Name", "XR_FACE_EXPRESSION2_DIMPLER_R_FB")]
        DimplerRFB = 11,
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_CLOSED_L_FB")]
        EyesClosedLFB = 12,
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_CLOSED_R_FB")]
        EyesClosedRFB = 13,
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_LOOK_DOWN_L_FB")]
        EyesLookDownLFB = 14,
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_LOOK_DOWN_R_FB")]
        EyesLookDownRFB = 15,
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_LOOK_LEFT_L_FB")]
        EyesLookLeftLFB = 16,
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_LOOK_LEFT_R_FB")]
        EyesLookLeftRFB = 17,
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_LOOK_RIGHT_L_FB")]
        EyesLookRightLFB = 18,
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_LOOK_RIGHT_R_FB")]
        EyesLookRightRFB = 19,
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_LOOK_UP_L_FB")]
        EyesLookUpLFB = 20,
        [NativeName("Name", "XR_FACE_EXPRESSION2_EYES_LOOK_UP_R_FB")]
        EyesLookUpRFB = 21,
        [NativeName("Name", "XR_FACE_EXPRESSION2_INNER_BROW_RAISER_L_FB")]
        InnerBrowRaiserLFB = 22,
        [NativeName("Name", "XR_FACE_EXPRESSION2_INNER_BROW_RAISER_R_FB")]
        InnerBrowRaiserRFB = 23,
        [NativeName("Name", "XR_FACE_EXPRESSION2_JAW_DROP_FB")]
        JawDropFB = 24,
        [NativeName("Name", "XR_FACE_EXPRESSION2_JAW_SIDEWAYS_LEFT_FB")]
        JawSidewaysLeftFB = 25,
        [NativeName("Name", "XR_FACE_EXPRESSION2_JAW_SIDEWAYS_RIGHT_FB")]
        JawSidewaysRightFB = 26,
        [NativeName("Name", "XR_FACE_EXPRESSION2_JAW_THRUST_FB")]
        JawThrustFB = 27,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LID_TIGHTENER_L_FB")]
        LidTightenerLFB = 28,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LID_TIGHTENER_R_FB")]
        LidTightenerRFB = 29,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_CORNER_DEPRESSOR_L_FB")]
        LipCornerDepressorLFB = 30,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_CORNER_DEPRESSOR_R_FB")]
        LipCornerDepressorRFB = 31,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_CORNER_PULLER_L_FB")]
        LipCornerPullerLFB = 32,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_CORNER_PULLER_R_FB")]
        LipCornerPullerRFB = 33,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_FUNNELER_LB_FB")]
        LipFunnelerLBFB = 34,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_FUNNELER_LT_FB")]
        LipFunnelerLTFB = 35,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_FUNNELER_RB_FB")]
        LipFunnelerRBFB = 36,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_FUNNELER_RT_FB")]
        LipFunnelerRTFB = 37,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_PRESSOR_L_FB")]
        LipPressorLFB = 38,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_PRESSOR_R_FB")]
        LipPressorRFB = 39,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_PUCKER_L_FB")]
        LipPuckerLFB = 40,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_PUCKER_R_FB")]
        LipPuckerRFB = 41,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_STRETCHER_L_FB")]
        LipStretcherLFB = 42,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_STRETCHER_R_FB")]
        LipStretcherRFB = 43,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_SUCK_LB_FB")]
        LipSuckLBFB = 44,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_SUCK_LT_FB")]
        LipSuckLTFB = 45,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_SUCK_RB_FB")]
        LipSuckRBFB = 46,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_SUCK_RT_FB")]
        LipSuckRTFB = 47,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_TIGHTENER_L_FB")]
        LipTightenerLFB = 48,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIP_TIGHTENER_R_FB")]
        LipTightenerRFB = 49,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LIPS_TOWARD_FB")]
        LipsTowardFB = 50,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LOWER_LIP_DEPRESSOR_L_FB")]
        LowerLipDepressorLFB = 51,
        [NativeName("Name", "XR_FACE_EXPRESSION2_LOWER_LIP_DEPRESSOR_R_FB")]
        LowerLipDepressorRFB = 52,
        [NativeName("Name", "XR_FACE_EXPRESSION2_MOUTH_LEFT_FB")]
        MouthLeftFB = 53,
        [NativeName("Name", "XR_FACE_EXPRESSION2_MOUTH_RIGHT_FB")]
        MouthRightFB = 54,
        [NativeName("Name", "XR_FACE_EXPRESSION2_NOSE_WRINKLER_L_FB")]
        NoseWrinklerLFB = 55,
        [NativeName("Name", "XR_FACE_EXPRESSION2_NOSE_WRINKLER_R_FB")]
        NoseWrinklerRFB = 56,
        [NativeName("Name", "XR_FACE_EXPRESSION2_OUTER_BROW_RAISER_L_FB")]
        OuterBrowRaiserLFB = 57,
        [NativeName("Name", "XR_FACE_EXPRESSION2_OUTER_BROW_RAISER_R_FB")]
        OuterBrowRaiserRFB = 58,
        [NativeName("Name", "XR_FACE_EXPRESSION2_UPPER_LID_RAISER_L_FB")]
        UpperLidRaiserLFB = 59,
        [NativeName("Name", "XR_FACE_EXPRESSION2_UPPER_LID_RAISER_R_FB")]
        UpperLidRaiserRFB = 60,
        [NativeName("Name", "XR_FACE_EXPRESSION2_UPPER_LIP_RAISER_L_FB")]
        UpperLipRaiserLFB = 61,
        [NativeName("Name", "XR_FACE_EXPRESSION2_UPPER_LIP_RAISER_R_FB")]
        UpperLipRaiserRFB = 62,
        [NativeName("Name", "XR_FACE_EXPRESSION2_TONGUE_TIP_INTERDENTAL_FB")]
        TongueTipInterdentalFB = 63,
        [NativeName("Name", "XR_FACE_EXPRESSION2_TONGUE_TIP_ALVEOLAR_FB")]
        TongueTipAlveolarFB = 64,
        [NativeName("Name", "XR_FACE_EXPRESSION2_TONGUE_FRONT_DORSAL_PALATE_FB")]
        TongueFrontDorsalPalateFB = 65,
        [NativeName("Name", "XR_FACE_EXPRESSION2_TONGUE_MID_DORSAL_PALATE_FB")]
        TongueMidDorsalPalateFB = 66,
        [NativeName("Name", "XR_FACE_EXPRESSION2_TONGUE_BACK_DORSAL_VELAR_FB")]
        TongueBackDorsalVelarFB = 67,
        [NativeName("Name", "XR_FACE_EXPRESSION2_TONGUE_OUT_FB")]
        TongueOutFB = 68,
        [NativeName("Name", "XR_FACE_EXPRESSION2_TONGUE_RETREAT_FB")]
        TongueRetreatFB = 69,
        [NativeName("Name", "XR_FACE_EXPRESSION2_COUNT_FB")]
        CountFB = 70,
    }
}
