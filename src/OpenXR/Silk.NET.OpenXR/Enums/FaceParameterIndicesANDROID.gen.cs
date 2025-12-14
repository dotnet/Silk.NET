// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFaceParameterIndicesANDROID")]
    public enum FaceParameterIndicesANDROID : int
    {
        [Obsolete("Deprecated in favour of \"BrowLowererLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_BROW_LOWERER_L_ANDROID")]
        FaceParameterIndicesBrowLowererLAndroid = 0,
        [Obsolete("Deprecated in favour of \"BrowLowererRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_BROW_LOWERER_R_ANDROID")]
        FaceParameterIndicesBrowLowererRAndroid = 1,
        [Obsolete("Deprecated in favour of \"CheekPuffLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_CHEEK_PUFF_L_ANDROID")]
        FaceParameterIndicesCheekPuffLAndroid = 2,
        [Obsolete("Deprecated in favour of \"CheekPuffRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_CHEEK_PUFF_R_ANDROID")]
        FaceParameterIndicesCheekPuffRAndroid = 3,
        [Obsolete("Deprecated in favour of \"CheekRaiserLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_CHEEK_RAISER_L_ANDROID")]
        FaceParameterIndicesCheekRaiserLAndroid = 4,
        [Obsolete("Deprecated in favour of \"CheekRaiserRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_CHEEK_RAISER_R_ANDROID")]
        FaceParameterIndicesCheekRaiserRAndroid = 5,
        [Obsolete("Deprecated in favour of \"CheekSuckLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_CHEEK_SUCK_L_ANDROID")]
        FaceParameterIndicesCheekSuckLAndroid = 6,
        [Obsolete("Deprecated in favour of \"CheekSuckRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_CHEEK_SUCK_R_ANDROID")]
        FaceParameterIndicesCheekSuckRAndroid = 7,
        [Obsolete("Deprecated in favour of \"ChinRaiserBAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_CHIN_RAISER_B_ANDROID")]
        FaceParameterIndicesChinRaiserBAndroid = 8,
        [Obsolete("Deprecated in favour of \"ChinRaiserTAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_CHIN_RAISER_T_ANDROID")]
        FaceParameterIndicesChinRaiserTAndroid = 9,
        [Obsolete("Deprecated in favour of \"DimplerLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_DIMPLER_L_ANDROID")]
        FaceParameterIndicesDimplerLAndroid = 10,
        [Obsolete("Deprecated in favour of \"DimplerRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_DIMPLER_R_ANDROID")]
        FaceParameterIndicesDimplerRAndroid = 11,
        [Obsolete("Deprecated in favour of \"EyesClosedLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_CLOSED_L_ANDROID")]
        FaceParameterIndicesEyesClosedLAndroid = 12,
        [Obsolete("Deprecated in favour of \"EyesClosedRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_CLOSED_R_ANDROID")]
        FaceParameterIndicesEyesClosedRAndroid = 13,
        [Obsolete("Deprecated in favour of \"EyesLookDownLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_LOOK_DOWN_L_ANDROID")]
        FaceParameterIndicesEyesLookDownLAndroid = 14,
        [Obsolete("Deprecated in favour of \"EyesLookDownRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_LOOK_DOWN_R_ANDROID")]
        FaceParameterIndicesEyesLookDownRAndroid = 15,
        [Obsolete("Deprecated in favour of \"EyesLookLeftLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_LOOK_LEFT_L_ANDROID")]
        FaceParameterIndicesEyesLookLeftLAndroid = 16,
        [Obsolete("Deprecated in favour of \"EyesLookLeftRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_LOOK_LEFT_R_ANDROID")]
        FaceParameterIndicesEyesLookLeftRAndroid = 17,
        [Obsolete("Deprecated in favour of \"EyesLookRightLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_LOOK_RIGHT_L_ANDROID")]
        FaceParameterIndicesEyesLookRightLAndroid = 18,
        [Obsolete("Deprecated in favour of \"EyesLookRightRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_LOOK_RIGHT_R_ANDROID")]
        FaceParameterIndicesEyesLookRightRAndroid = 19,
        [Obsolete("Deprecated in favour of \"EyesLookUpLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_LOOK_UP_L_ANDROID")]
        FaceParameterIndicesEyesLookUpLAndroid = 20,
        [Obsolete("Deprecated in favour of \"EyesLookUpRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_LOOK_UP_R_ANDROID")]
        FaceParameterIndicesEyesLookUpRAndroid = 21,
        [Obsolete("Deprecated in favour of \"InnerBrowRaiserLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_INNER_BROW_RAISER_L_ANDROID")]
        FaceParameterIndicesInnerBrowRaiserLAndroid = 22,
        [Obsolete("Deprecated in favour of \"InnerBrowRaiserRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_INNER_BROW_RAISER_R_ANDROID")]
        FaceParameterIndicesInnerBrowRaiserRAndroid = 23,
        [Obsolete("Deprecated in favour of \"JawDropAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_JAW_DROP_ANDROID")]
        FaceParameterIndicesJawDropAndroid = 24,
        [Obsolete("Deprecated in favour of \"JawSidewaysLeftAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_JAW_SIDEWAYS_LEFT_ANDROID")]
        FaceParameterIndicesJawSidewaysLeftAndroid = 25,
        [Obsolete("Deprecated in favour of \"JawSidewaysRightAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_JAW_SIDEWAYS_RIGHT_ANDROID")]
        FaceParameterIndicesJawSidewaysRightAndroid = 26,
        [Obsolete("Deprecated in favour of \"JawThrustAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_JAW_THRUST_ANDROID")]
        FaceParameterIndicesJawThrustAndroid = 27,
        [Obsolete("Deprecated in favour of \"LidTightenerLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LID_TIGHTENER_L_ANDROID")]
        FaceParameterIndicesLidTightenerLAndroid = 28,
        [Obsolete("Deprecated in favour of \"LidTightenerRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LID_TIGHTENER_R_ANDROID")]
        FaceParameterIndicesLidTightenerRAndroid = 29,
        [Obsolete("Deprecated in favour of \"LipCornerDepressorLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_CORNER_DEPRESSOR_L_ANDROID")]
        FaceParameterIndicesLipCornerDepressorLAndroid = 30,
        [Obsolete("Deprecated in favour of \"LipCornerDepressorRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_CORNER_DEPRESSOR_R_ANDROID")]
        FaceParameterIndicesLipCornerDepressorRAndroid = 31,
        [Obsolete("Deprecated in favour of \"LipCornerPullerLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_CORNER_PULLER_L_ANDROID")]
        FaceParameterIndicesLipCornerPullerLAndroid = 32,
        [Obsolete("Deprecated in favour of \"LipCornerPullerRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_CORNER_PULLER_R_ANDROID")]
        FaceParameterIndicesLipCornerPullerRAndroid = 33,
        [Obsolete("Deprecated in favour of \"LipFunnelerLBAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_FUNNELER_LB_ANDROID")]
        FaceParameterIndicesLipFunnelerLBAndroid = 34,
        [Obsolete("Deprecated in favour of \"LipFunnelerLTAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_FUNNELER_LT_ANDROID")]
        FaceParameterIndicesLipFunnelerLTAndroid = 35,
        [Obsolete("Deprecated in favour of \"LipFunnelerRBAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_FUNNELER_RB_ANDROID")]
        FaceParameterIndicesLipFunnelerRBAndroid = 36,
        [Obsolete("Deprecated in favour of \"LipFunnelerRTAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_FUNNELER_RT_ANDROID")]
        FaceParameterIndicesLipFunnelerRTAndroid = 37,
        [Obsolete("Deprecated in favour of \"LipPressorLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_PRESSOR_L_ANDROID")]
        FaceParameterIndicesLipPressorLAndroid = 38,
        [Obsolete("Deprecated in favour of \"LipPressorRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_PRESSOR_R_ANDROID")]
        FaceParameterIndicesLipPressorRAndroid = 39,
        [Obsolete("Deprecated in favour of \"LipPuckerLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_PUCKER_L_ANDROID")]
        FaceParameterIndicesLipPuckerLAndroid = 40,
        [Obsolete("Deprecated in favour of \"LipPuckerRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_PUCKER_R_ANDROID")]
        FaceParameterIndicesLipPuckerRAndroid = 41,
        [Obsolete("Deprecated in favour of \"LipStretcherLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_STRETCHER_L_ANDROID")]
        FaceParameterIndicesLipStretcherLAndroid = 42,
        [Obsolete("Deprecated in favour of \"LipStretcherRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_STRETCHER_R_ANDROID")]
        FaceParameterIndicesLipStretcherRAndroid = 43,
        [Obsolete("Deprecated in favour of \"LipSuckLBAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_SUCK_LB_ANDROID")]
        FaceParameterIndicesLipSuckLBAndroid = 44,
        [Obsolete("Deprecated in favour of \"LipSuckLTAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_SUCK_LT_ANDROID")]
        FaceParameterIndicesLipSuckLTAndroid = 45,
        [Obsolete("Deprecated in favour of \"LipSuckRBAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_SUCK_RB_ANDROID")]
        FaceParameterIndicesLipSuckRBAndroid = 46,
        [Obsolete("Deprecated in favour of \"LipSuckRTAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_SUCK_RT_ANDROID")]
        FaceParameterIndicesLipSuckRTAndroid = 47,
        [Obsolete("Deprecated in favour of \"LipTightenerLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_TIGHTENER_L_ANDROID")]
        FaceParameterIndicesLipTightenerLAndroid = 48,
        [Obsolete("Deprecated in favour of \"LipTightenerRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_TIGHTENER_R_ANDROID")]
        FaceParameterIndicesLipTightenerRAndroid = 49,
        [Obsolete("Deprecated in favour of \"LipsTowardAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIPS_TOWARD_ANDROID")]
        FaceParameterIndicesLipsTowardAndroid = 50,
        [Obsolete("Deprecated in favour of \"LowerLipDepressorLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LOWER_LIP_DEPRESSOR_L_ANDROID")]
        FaceParameterIndicesLowerLipDepressorLAndroid = 51,
        [Obsolete("Deprecated in favour of \"LowerLipDepressorRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LOWER_LIP_DEPRESSOR_R_ANDROID")]
        FaceParameterIndicesLowerLipDepressorRAndroid = 52,
        [Obsolete("Deprecated in favour of \"MouthLeftAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_MOUTH_LEFT_ANDROID")]
        FaceParameterIndicesMouthLeftAndroid = 53,
        [Obsolete("Deprecated in favour of \"MouthRightAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_MOUTH_RIGHT_ANDROID")]
        FaceParameterIndicesMouthRightAndroid = 54,
        [Obsolete("Deprecated in favour of \"NoseWrinklerLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_NOSE_WRINKLER_L_ANDROID")]
        FaceParameterIndicesNoseWrinklerLAndroid = 55,
        [Obsolete("Deprecated in favour of \"NoseWrinklerRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_NOSE_WRINKLER_R_ANDROID")]
        FaceParameterIndicesNoseWrinklerRAndroid = 56,
        [Obsolete("Deprecated in favour of \"OuterBrowRaiserLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_OUTER_BROW_RAISER_L_ANDROID")]
        FaceParameterIndicesOuterBrowRaiserLAndroid = 57,
        [Obsolete("Deprecated in favour of \"OuterBrowRaiserRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_OUTER_BROW_RAISER_R_ANDROID")]
        FaceParameterIndicesOuterBrowRaiserRAndroid = 58,
        [Obsolete("Deprecated in favour of \"UpperLidRaiserLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_UPPER_LID_RAISER_L_ANDROID")]
        FaceParameterIndicesUpperLidRaiserLAndroid = 59,
        [Obsolete("Deprecated in favour of \"UpperLidRaiserRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_UPPER_LID_RAISER_R_ANDROID")]
        FaceParameterIndicesUpperLidRaiserRAndroid = 60,
        [Obsolete("Deprecated in favour of \"UpperLipRaiserLAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_UPPER_LIP_RAISER_L_ANDROID")]
        FaceParameterIndicesUpperLipRaiserLAndroid = 61,
        [Obsolete("Deprecated in favour of \"UpperLipRaiserRAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_UPPER_LIP_RAISER_R_ANDROID")]
        FaceParameterIndicesUpperLipRaiserRAndroid = 62,
        [Obsolete("Deprecated in favour of \"TongueOutAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_TONGUE_OUT_ANDROID")]
        FaceParameterIndicesTongueOutAndroid = 63,
        [Obsolete("Deprecated in favour of \"TongueLeftAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_TONGUE_LEFT_ANDROID")]
        FaceParameterIndicesTongueLeftAndroid = 64,
        [Obsolete("Deprecated in favour of \"TongueRightAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_TONGUE_RIGHT_ANDROID")]
        FaceParameterIndicesTongueRightAndroid = 65,
        [Obsolete("Deprecated in favour of \"TongueUpAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_TONGUE_UP_ANDROID")]
        FaceParameterIndicesTongueUpAndroid = 66,
        [Obsolete("Deprecated in favour of \"TongueDownAndroid\"")]
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_TONGUE_DOWN_ANDROID")]
        FaceParameterIndicesTongueDownAndroid = 67,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_BROW_LOWERER_L_ANDROID")]
        BrowLowererLAndroid = 0,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_BROW_LOWERER_R_ANDROID")]
        BrowLowererRAndroid = 1,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_CHEEK_PUFF_L_ANDROID")]
        CheekPuffLAndroid = 2,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_CHEEK_PUFF_R_ANDROID")]
        CheekPuffRAndroid = 3,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_CHEEK_RAISER_L_ANDROID")]
        CheekRaiserLAndroid = 4,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_CHEEK_RAISER_R_ANDROID")]
        CheekRaiserRAndroid = 5,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_CHEEK_SUCK_L_ANDROID")]
        CheekSuckLAndroid = 6,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_CHEEK_SUCK_R_ANDROID")]
        CheekSuckRAndroid = 7,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_CHIN_RAISER_B_ANDROID")]
        ChinRaiserBAndroid = 8,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_CHIN_RAISER_T_ANDROID")]
        ChinRaiserTAndroid = 9,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_DIMPLER_L_ANDROID")]
        DimplerLAndroid = 10,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_DIMPLER_R_ANDROID")]
        DimplerRAndroid = 11,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_CLOSED_L_ANDROID")]
        EyesClosedLAndroid = 12,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_CLOSED_R_ANDROID")]
        EyesClosedRAndroid = 13,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_LOOK_DOWN_L_ANDROID")]
        EyesLookDownLAndroid = 14,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_LOOK_DOWN_R_ANDROID")]
        EyesLookDownRAndroid = 15,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_LOOK_LEFT_L_ANDROID")]
        EyesLookLeftLAndroid = 16,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_LOOK_LEFT_R_ANDROID")]
        EyesLookLeftRAndroid = 17,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_LOOK_RIGHT_L_ANDROID")]
        EyesLookRightLAndroid = 18,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_LOOK_RIGHT_R_ANDROID")]
        EyesLookRightRAndroid = 19,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_LOOK_UP_L_ANDROID")]
        EyesLookUpLAndroid = 20,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_EYES_LOOK_UP_R_ANDROID")]
        EyesLookUpRAndroid = 21,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_INNER_BROW_RAISER_L_ANDROID")]
        InnerBrowRaiserLAndroid = 22,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_INNER_BROW_RAISER_R_ANDROID")]
        InnerBrowRaiserRAndroid = 23,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_JAW_DROP_ANDROID")]
        JawDropAndroid = 24,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_JAW_SIDEWAYS_LEFT_ANDROID")]
        JawSidewaysLeftAndroid = 25,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_JAW_SIDEWAYS_RIGHT_ANDROID")]
        JawSidewaysRightAndroid = 26,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_JAW_THRUST_ANDROID")]
        JawThrustAndroid = 27,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LID_TIGHTENER_L_ANDROID")]
        LidTightenerLAndroid = 28,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LID_TIGHTENER_R_ANDROID")]
        LidTightenerRAndroid = 29,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_CORNER_DEPRESSOR_L_ANDROID")]
        LipCornerDepressorLAndroid = 30,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_CORNER_DEPRESSOR_R_ANDROID")]
        LipCornerDepressorRAndroid = 31,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_CORNER_PULLER_L_ANDROID")]
        LipCornerPullerLAndroid = 32,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_CORNER_PULLER_R_ANDROID")]
        LipCornerPullerRAndroid = 33,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_FUNNELER_LB_ANDROID")]
        LipFunnelerLBAndroid = 34,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_FUNNELER_LT_ANDROID")]
        LipFunnelerLTAndroid = 35,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_FUNNELER_RB_ANDROID")]
        LipFunnelerRBAndroid = 36,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_FUNNELER_RT_ANDROID")]
        LipFunnelerRTAndroid = 37,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_PRESSOR_L_ANDROID")]
        LipPressorLAndroid = 38,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_PRESSOR_R_ANDROID")]
        LipPressorRAndroid = 39,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_PUCKER_L_ANDROID")]
        LipPuckerLAndroid = 40,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_PUCKER_R_ANDROID")]
        LipPuckerRAndroid = 41,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_STRETCHER_L_ANDROID")]
        LipStretcherLAndroid = 42,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_STRETCHER_R_ANDROID")]
        LipStretcherRAndroid = 43,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_SUCK_LB_ANDROID")]
        LipSuckLBAndroid = 44,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_SUCK_LT_ANDROID")]
        LipSuckLTAndroid = 45,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_SUCK_RB_ANDROID")]
        LipSuckRBAndroid = 46,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_SUCK_RT_ANDROID")]
        LipSuckRTAndroid = 47,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_TIGHTENER_L_ANDROID")]
        LipTightenerLAndroid = 48,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIP_TIGHTENER_R_ANDROID")]
        LipTightenerRAndroid = 49,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LIPS_TOWARD_ANDROID")]
        LipsTowardAndroid = 50,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LOWER_LIP_DEPRESSOR_L_ANDROID")]
        LowerLipDepressorLAndroid = 51,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_LOWER_LIP_DEPRESSOR_R_ANDROID")]
        LowerLipDepressorRAndroid = 52,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_MOUTH_LEFT_ANDROID")]
        MouthLeftAndroid = 53,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_MOUTH_RIGHT_ANDROID")]
        MouthRightAndroid = 54,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_NOSE_WRINKLER_L_ANDROID")]
        NoseWrinklerLAndroid = 55,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_NOSE_WRINKLER_R_ANDROID")]
        NoseWrinklerRAndroid = 56,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_OUTER_BROW_RAISER_L_ANDROID")]
        OuterBrowRaiserLAndroid = 57,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_OUTER_BROW_RAISER_R_ANDROID")]
        OuterBrowRaiserRAndroid = 58,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_UPPER_LID_RAISER_L_ANDROID")]
        UpperLidRaiserLAndroid = 59,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_UPPER_LID_RAISER_R_ANDROID")]
        UpperLidRaiserRAndroid = 60,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_UPPER_LIP_RAISER_L_ANDROID")]
        UpperLipRaiserLAndroid = 61,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_UPPER_LIP_RAISER_R_ANDROID")]
        UpperLipRaiserRAndroid = 62,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_TONGUE_OUT_ANDROID")]
        TongueOutAndroid = 63,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_TONGUE_LEFT_ANDROID")]
        TongueLeftAndroid = 64,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_TONGUE_RIGHT_ANDROID")]
        TongueRightAndroid = 65,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_TONGUE_UP_ANDROID")]
        TongueUpAndroid = 66,
        [NativeName("Name", "XR_FACE_PARAMETER_INDICES_TONGUE_DOWN_ANDROID")]
        TongueDownAndroid = 67,
    }
}
