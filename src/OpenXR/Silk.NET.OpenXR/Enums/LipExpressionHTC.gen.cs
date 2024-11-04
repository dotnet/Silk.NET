// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrLipExpressionHTC")]
    public enum LipExpressionHTC : int
    {
        [Obsolete("Deprecated in favour of \"JawRightHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_JAW_RIGHT_HTC")]
        LipExpressionJawRightHtc = 0,
        [Obsolete("Deprecated in favour of \"JawLeftHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_JAW_LEFT_HTC")]
        LipExpressionJawLeftHtc = 1,
        [Obsolete("Deprecated in favour of \"JawForwardHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_JAW_FORWARD_HTC")]
        LipExpressionJawForwardHtc = 2,
        [Obsolete("Deprecated in favour of \"JawOpenHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_JAW_OPEN_HTC")]
        LipExpressionJawOpenHtc = 3,
        [Obsolete("Deprecated in favour of \"MouthApeShapeHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_APE_SHAPE_HTC")]
        LipExpressionMouthApeShapeHtc = 4,
        [Obsolete("Deprecated in favour of \"MouthUpperRightHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_UPPER_RIGHT_HTC")]
        LipExpressionMouthUpperRightHtc = 5,
        [Obsolete("Deprecated in favour of \"MouthUpperLeftHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_UPPER_LEFT_HTC")]
        LipExpressionMouthUpperLeftHtc = 6,
        [Obsolete("Deprecated in favour of \"MouthLowerRightHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_LOWER_RIGHT_HTC")]
        LipExpressionMouthLowerRightHtc = 7,
        [Obsolete("Deprecated in favour of \"MouthLowerLeftHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_LOWER_LEFT_HTC")]
        LipExpressionMouthLowerLeftHtc = 8,
        [Obsolete("Deprecated in favour of \"MouthUpperOverturnHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_UPPER_OVERTURN_HTC")]
        LipExpressionMouthUpperOverturnHtc = 9,
        [Obsolete("Deprecated in favour of \"MouthLowerOverturnHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_LOWER_OVERTURN_HTC")]
        LipExpressionMouthLowerOverturnHtc = 10,
        [Obsolete("Deprecated in favour of \"MouthPoutHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_POUT_HTC")]
        LipExpressionMouthPoutHtc = 11,
        [Obsolete("Deprecated in favour of \"MouthRaiserRightHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_RAISER_RIGHT_HTC")]
        LipExpressionMouthRaiserRightHtc = 12,
        [Obsolete("Deprecated in favour of \"MouthRaiserLeftHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_RAISER_LEFT_HTC")]
        LipExpressionMouthRaiserLeftHtc = 13,
        [Obsolete("Deprecated in favour of \"MouthStretcherRightHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_STRETCHER_RIGHT_HTC")]
        LipExpressionMouthStretcherRightHtc = 14,
        [Obsolete("Deprecated in favour of \"MouthStretcherLeftHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_STRETCHER_LEFT_HTC")]
        LipExpressionMouthStretcherLeftHtc = 15,
        [Obsolete("Deprecated in favour of \"CheekPuffRightHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_CHEEK_PUFF_RIGHT_HTC")]
        LipExpressionCheekPuffRightHtc = 16,
        [Obsolete("Deprecated in favour of \"CheekPuffLeftHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_CHEEK_PUFF_LEFT_HTC")]
        LipExpressionCheekPuffLeftHtc = 17,
        [Obsolete("Deprecated in favour of \"CheekSuckHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_CHEEK_SUCK_HTC")]
        LipExpressionCheekSuckHtc = 18,
        [Obsolete("Deprecated in favour of \"MouthUpperUprightHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_UPPER_UPRIGHT_HTC")]
        LipExpressionMouthUpperUprightHtc = 19,
        [Obsolete("Deprecated in favour of \"MouthUpperUpleftHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_UPPER_UPLEFT_HTC")]
        LipExpressionMouthUpperUpleftHtc = 20,
        [Obsolete("Deprecated in favour of \"MouthLowerDownrightHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_LOWER_DOWNRIGHT_HTC")]
        LipExpressionMouthLowerDownrightHtc = 21,
        [Obsolete("Deprecated in favour of \"MouthLowerDownleftHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_LOWER_DOWNLEFT_HTC")]
        LipExpressionMouthLowerDownleftHtc = 22,
        [Obsolete("Deprecated in favour of \"MouthUpperInsideHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_UPPER_INSIDE_HTC")]
        LipExpressionMouthUpperInsideHtc = 23,
        [Obsolete("Deprecated in favour of \"MouthLowerInsideHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_LOWER_INSIDE_HTC")]
        LipExpressionMouthLowerInsideHtc = 24,
        [Obsolete("Deprecated in favour of \"MouthLowerOverlayHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_LOWER_OVERLAY_HTC")]
        LipExpressionMouthLowerOverlayHtc = 25,
        [Obsolete("Deprecated in favour of \"TongueLongstep1Htc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_LONGSTEP1_HTC")]
        LipExpressionTongueLongstep1Htc = 26,
        [Obsolete("Deprecated in favour of \"TongueLeftHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_LEFT_HTC")]
        LipExpressionTongueLeftHtc = 27,
        [Obsolete("Deprecated in favour of \"TongueRightHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_RIGHT_HTC")]
        LipExpressionTongueRightHtc = 28,
        [Obsolete("Deprecated in favour of \"TongueUpHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_UP_HTC")]
        LipExpressionTongueUpHtc = 29,
        [Obsolete("Deprecated in favour of \"TongueDownHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_DOWN_HTC")]
        LipExpressionTongueDownHtc = 30,
        [Obsolete("Deprecated in favour of \"TongueRollHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_ROLL_HTC")]
        LipExpressionTongueRollHtc = 31,
        [Obsolete("Deprecated in favour of \"TongueLongstep2Htc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_LONGSTEP2_HTC")]
        LipExpressionTongueLongstep2Htc = 32,
        [Obsolete("Deprecated in favour of \"TongueUprightMorphHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_UPRIGHT_MORPH_HTC")]
        LipExpressionTongueUprightMorphHtc = 33,
        [Obsolete("Deprecated in favour of \"TongueUpleftMorphHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_UPLEFT_MORPH_HTC")]
        LipExpressionTongueUpleftMorphHtc = 34,
        [Obsolete("Deprecated in favour of \"TongueDownrightMorphHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_DOWNRIGHT_MORPH_HTC")]
        LipExpressionTongueDownrightMorphHtc = 35,
        [Obsolete("Deprecated in favour of \"TongueDownleftMorphHtc\"")]
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_DOWNLEFT_MORPH_HTC")]
        LipExpressionTongueDownleftMorphHtc = 36,
        [NativeName("Name", "XR_LIP_EXPRESSION_JAW_RIGHT_HTC")]
        JawRightHtc = 0,
        [NativeName("Name", "XR_LIP_EXPRESSION_JAW_LEFT_HTC")]
        JawLeftHtc = 1,
        [NativeName("Name", "XR_LIP_EXPRESSION_JAW_FORWARD_HTC")]
        JawForwardHtc = 2,
        [NativeName("Name", "XR_LIP_EXPRESSION_JAW_OPEN_HTC")]
        JawOpenHtc = 3,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_APE_SHAPE_HTC")]
        MouthApeShapeHtc = 4,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_UPPER_RIGHT_HTC")]
        MouthUpperRightHtc = 5,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_UPPER_LEFT_HTC")]
        MouthUpperLeftHtc = 6,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_LOWER_RIGHT_HTC")]
        MouthLowerRightHtc = 7,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_LOWER_LEFT_HTC")]
        MouthLowerLeftHtc = 8,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_UPPER_OVERTURN_HTC")]
        MouthUpperOverturnHtc = 9,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_LOWER_OVERTURN_HTC")]
        MouthLowerOverturnHtc = 10,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_POUT_HTC")]
        MouthPoutHtc = 11,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_RAISER_RIGHT_HTC")]
        MouthRaiserRightHtc = 12,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_RAISER_LEFT_HTC")]
        MouthRaiserLeftHtc = 13,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_STRETCHER_RIGHT_HTC")]
        MouthStretcherRightHtc = 14,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_STRETCHER_LEFT_HTC")]
        MouthStretcherLeftHtc = 15,
        [NativeName("Name", "XR_LIP_EXPRESSION_CHEEK_PUFF_RIGHT_HTC")]
        CheekPuffRightHtc = 16,
        [NativeName("Name", "XR_LIP_EXPRESSION_CHEEK_PUFF_LEFT_HTC")]
        CheekPuffLeftHtc = 17,
        [NativeName("Name", "XR_LIP_EXPRESSION_CHEEK_SUCK_HTC")]
        CheekSuckHtc = 18,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_UPPER_UPRIGHT_HTC")]
        MouthUpperUprightHtc = 19,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_UPPER_UPLEFT_HTC")]
        MouthUpperUpleftHtc = 20,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_LOWER_DOWNRIGHT_HTC")]
        MouthLowerDownrightHtc = 21,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_LOWER_DOWNLEFT_HTC")]
        MouthLowerDownleftHtc = 22,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_UPPER_INSIDE_HTC")]
        MouthUpperInsideHtc = 23,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_LOWER_INSIDE_HTC")]
        MouthLowerInsideHtc = 24,
        [NativeName("Name", "XR_LIP_EXPRESSION_MOUTH_LOWER_OVERLAY_HTC")]
        MouthLowerOverlayHtc = 25,
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_LONGSTEP1_HTC")]
        TongueLongstep1Htc = 26,
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_LEFT_HTC")]
        TongueLeftHtc = 27,
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_RIGHT_HTC")]
        TongueRightHtc = 28,
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_UP_HTC")]
        TongueUpHtc = 29,
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_DOWN_HTC")]
        TongueDownHtc = 30,
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_ROLL_HTC")]
        TongueRollHtc = 31,
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_LONGSTEP2_HTC")]
        TongueLongstep2Htc = 32,
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_UPRIGHT_MORPH_HTC")]
        TongueUprightMorphHtc = 33,
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_UPLEFT_MORPH_HTC")]
        TongueUpleftMorphHtc = 34,
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_DOWNRIGHT_MORPH_HTC")]
        TongueDownrightMorphHtc = 35,
        [NativeName("Name", "XR_LIP_EXPRESSION_TONGUE_DOWNLEFT_MORPH_HTC")]
        TongueDownleftMorphHtc = 36,
    }
}
