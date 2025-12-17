// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFaceExpressionBD")]
    public enum FaceExpressionBD : int
    {
        [Obsolete("Deprecated in favour of \"BrowDropLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_BROW_DROP_L_BD")]
        FaceExpressionBrowDropLBD = 0,
        [Obsolete("Deprecated in favour of \"BrowDropRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_BROW_DROP_R_BD")]
        FaceExpressionBrowDropRBD = 1,
        [Obsolete("Deprecated in favour of \"BrowInnerUpwardsBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_BROW_INNER_UPWARDS_BD")]
        FaceExpressionBrowInnerUpwardsBD = 2,
        [Obsolete("Deprecated in favour of \"BrowOuterUpwardsLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_BROW_OUTER_UPWARDS_L_BD")]
        FaceExpressionBrowOuterUpwardsLBD = 3,
        [Obsolete("Deprecated in favour of \"BrowOuterUpwardsRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_BROW_OUTER_UPWARDS_R_BD")]
        FaceExpressionBrowOuterUpwardsRBD = 4,
        [Obsolete("Deprecated in favour of \"EyeBlinkLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_BLINK_L_BD")]
        FaceExpressionEyeBlinkLBD = 5,
        [Obsolete("Deprecated in favour of \"EyeLookDropLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_DROP_L_BD")]
        FaceExpressionEyeLookDropLBD = 6,
        [Obsolete("Deprecated in favour of \"EyeLookInLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_IN_L_BD")]
        FaceExpressionEyeLookInLBD = 7,
        [Obsolete("Deprecated in favour of \"EyeLookOutLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_OUT_L_BD")]
        FaceExpressionEyeLookOutLBD = 8,
        [Obsolete("Deprecated in favour of \"EyeLookUpwardsLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_UPWARDS_L_BD")]
        FaceExpressionEyeLookUpwardsLBD = 9,
        [Obsolete("Deprecated in favour of \"EyeLookSquintLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_SQUINT_L_BD")]
        FaceExpressionEyeLookSquintLBD = 10,
        [Obsolete("Deprecated in favour of \"EyeLookWideLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_WIDE_L_BD")]
        FaceExpressionEyeLookWideLBD = 11,
        [Obsolete("Deprecated in favour of \"EyeBlinkRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_BLINK_R_BD")]
        FaceExpressionEyeBlinkRBD = 12,
        [Obsolete("Deprecated in favour of \"EyeLookDropRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_DROP_R_BD")]
        FaceExpressionEyeLookDropRBD = 13,
        [Obsolete("Deprecated in favour of \"EyeLookInRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_IN_R_BD")]
        FaceExpressionEyeLookInRBD = 14,
        [Obsolete("Deprecated in favour of \"EyeLookOutRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_OUT_R_BD")]
        FaceExpressionEyeLookOutRBD = 15,
        [Obsolete("Deprecated in favour of \"EyeLookUpwardsRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_UPWARDS_R_BD")]
        FaceExpressionEyeLookUpwardsRBD = 16,
        [Obsolete("Deprecated in favour of \"EyeLookSquintRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_SQUINT_R_BD")]
        FaceExpressionEyeLookSquintRBD = 17,
        [Obsolete("Deprecated in favour of \"EyeLookWideRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_WIDE_R_BD")]
        FaceExpressionEyeLookWideRBD = 18,
        [Obsolete("Deprecated in favour of \"NoseSneerLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_NOSE_SNEER_L_BD")]
        FaceExpressionNoseSneerLBD = 19,
        [Obsolete("Deprecated in favour of \"NoseSneerRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_NOSE_SNEER_R_BD")]
        FaceExpressionNoseSneerRBD = 20,
        [Obsolete("Deprecated in favour of \"CheekPuffBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_PUFF_BD")]
        FaceExpressionCheekPuffBD = 21,
        [Obsolete("Deprecated in favour of \"CheekSquintLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_SQUINT_L_BD")]
        FaceExpressionCheekSquintLBD = 22,
        [Obsolete("Deprecated in favour of \"CheekSquintRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_SQUINT_R_BD")]
        FaceExpressionCheekSquintRBD = 23,
        [Obsolete("Deprecated in favour of \"MouthCloseBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_CLOSE_BD")]
        FaceExpressionMouthCloseBD = 24,
        [Obsolete("Deprecated in favour of \"MouthFunnelBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_FUNNEL_BD")]
        FaceExpressionMouthFunnelBD = 25,
        [Obsolete("Deprecated in favour of \"MouthPuckerBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_PUCKER_BD")]
        FaceExpressionMouthPuckerBD = 26,
        [Obsolete("Deprecated in favour of \"MouthLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_L_BD")]
        FaceExpressionMouthLBD = 27,
        [Obsolete("Deprecated in favour of \"MouthRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_R_BD")]
        FaceExpressionMouthRBD = 28,
        [Obsolete("Deprecated in favour of \"MouthSmileLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_SMILE_L_BD")]
        FaceExpressionMouthSmileLBD = 29,
        [Obsolete("Deprecated in favour of \"MouthSmileRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_SMILE_R_BD")]
        FaceExpressionMouthSmileRBD = 30,
        [Obsolete("Deprecated in favour of \"MouthFrownLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_FROWN_L_BD")]
        FaceExpressionMouthFrownLBD = 31,
        [Obsolete("Deprecated in favour of \"MouthFrownRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_FROWN_R_BD")]
        FaceExpressionMouthFrownRBD = 32,
        [Obsolete("Deprecated in favour of \"MouthDimpleLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_DIMPLE_L_BD")]
        FaceExpressionMouthDimpleLBD = 33,
        [Obsolete("Deprecated in favour of \"MouthDimpleRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_DIMPLE_R_BD")]
        FaceExpressionMouthDimpleRBD = 34,
        [Obsolete("Deprecated in favour of \"MouthStretchLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_STRETCH_L_BD")]
        FaceExpressionMouthStretchLBD = 35,
        [Obsolete("Deprecated in favour of \"MouthStretchRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_STRETCH_R_BD")]
        FaceExpressionMouthStretchRBD = 36,
        [Obsolete("Deprecated in favour of \"MouthRollLowerBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_ROLL_LOWER_BD")]
        FaceExpressionMouthRollLowerBD = 37,
        [Obsolete("Deprecated in favour of \"MouthRollUpperBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_ROLL_UPPER_BD")]
        FaceExpressionMouthRollUpperBD = 38,
        [Obsolete("Deprecated in favour of \"MouthShrugLowerBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_SHRUG_LOWER_BD")]
        FaceExpressionMouthShrugLowerBD = 39,
        [Obsolete("Deprecated in favour of \"MouthShrugUpperBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_SHRUG_UPPER_BD")]
        FaceExpressionMouthShrugUpperBD = 40,
        [Obsolete("Deprecated in favour of \"MouthPressLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_PRESS_L_BD")]
        FaceExpressionMouthPressLBD = 41,
        [Obsolete("Deprecated in favour of \"MouthPressRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_PRESS_R_BD")]
        FaceExpressionMouthPressRBD = 42,
        [Obsolete("Deprecated in favour of \"MouthLowerDropLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_LOWER_DROP_L_BD")]
        FaceExpressionMouthLowerDropLBD = 43,
        [Obsolete("Deprecated in favour of \"MouthLowerDropRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_LOWER_DROP_R_BD")]
        FaceExpressionMouthLowerDropRBD = 44,
        [Obsolete("Deprecated in favour of \"MouthUpperUpwardsLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_UPPER_UPWARDS_L_BD")]
        FaceExpressionMouthUpperUpwardsLBD = 45,
        [Obsolete("Deprecated in favour of \"MouthUpperUpwardsRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_UPPER_UPWARDS_R_BD")]
        FaceExpressionMouthUpperUpwardsRBD = 46,
        [Obsolete("Deprecated in favour of \"JawForwardBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_JAW_FORWARD_BD")]
        FaceExpressionJawForwardBD = 47,
        [Obsolete("Deprecated in favour of \"JawLBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_JAW_L_BD")]
        FaceExpressionJawLBD = 48,
        [Obsolete("Deprecated in favour of \"JawRBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_JAW_R_BD")]
        FaceExpressionJawRBD = 49,
        [Obsolete("Deprecated in favour of \"JawOpenBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_JAW_OPEN_BD")]
        FaceExpressionJawOpenBD = 50,
        [Obsolete("Deprecated in favour of \"TongueOutBD\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_TONGUE_OUT_BD")]
        FaceExpressionTongueOutBD = 51,
        [NativeName("Name", "XR_FACE_EXPRESSION_BROW_DROP_L_BD")]
        BrowDropLBD = 0,
        [NativeName("Name", "XR_FACE_EXPRESSION_BROW_DROP_R_BD")]
        BrowDropRBD = 1,
        [NativeName("Name", "XR_FACE_EXPRESSION_BROW_INNER_UPWARDS_BD")]
        BrowInnerUpwardsBD = 2,
        [NativeName("Name", "XR_FACE_EXPRESSION_BROW_OUTER_UPWARDS_L_BD")]
        BrowOuterUpwardsLBD = 3,
        [NativeName("Name", "XR_FACE_EXPRESSION_BROW_OUTER_UPWARDS_R_BD")]
        BrowOuterUpwardsRBD = 4,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_BLINK_L_BD")]
        EyeBlinkLBD = 5,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_DROP_L_BD")]
        EyeLookDropLBD = 6,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_IN_L_BD")]
        EyeLookInLBD = 7,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_OUT_L_BD")]
        EyeLookOutLBD = 8,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_UPWARDS_L_BD")]
        EyeLookUpwardsLBD = 9,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_SQUINT_L_BD")]
        EyeLookSquintLBD = 10,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_WIDE_L_BD")]
        EyeLookWideLBD = 11,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_BLINK_R_BD")]
        EyeBlinkRBD = 12,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_DROP_R_BD")]
        EyeLookDropRBD = 13,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_IN_R_BD")]
        EyeLookInRBD = 14,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_OUT_R_BD")]
        EyeLookOutRBD = 15,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_UPWARDS_R_BD")]
        EyeLookUpwardsRBD = 16,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_SQUINT_R_BD")]
        EyeLookSquintRBD = 17,
        [NativeName("Name", "XR_FACE_EXPRESSION_EYE_LOOK_WIDE_R_BD")]
        EyeLookWideRBD = 18,
        [NativeName("Name", "XR_FACE_EXPRESSION_NOSE_SNEER_L_BD")]
        NoseSneerLBD = 19,
        [NativeName("Name", "XR_FACE_EXPRESSION_NOSE_SNEER_R_BD")]
        NoseSneerRBD = 20,
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_PUFF_BD")]
        CheekPuffBD = 21,
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_SQUINT_L_BD")]
        CheekSquintLBD = 22,
        [NativeName("Name", "XR_FACE_EXPRESSION_CHEEK_SQUINT_R_BD")]
        CheekSquintRBD = 23,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_CLOSE_BD")]
        MouthCloseBD = 24,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_FUNNEL_BD")]
        MouthFunnelBD = 25,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_PUCKER_BD")]
        MouthPuckerBD = 26,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_L_BD")]
        MouthLBD = 27,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_R_BD")]
        MouthRBD = 28,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_SMILE_L_BD")]
        MouthSmileLBD = 29,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_SMILE_R_BD")]
        MouthSmileRBD = 30,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_FROWN_L_BD")]
        MouthFrownLBD = 31,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_FROWN_R_BD")]
        MouthFrownRBD = 32,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_DIMPLE_L_BD")]
        MouthDimpleLBD = 33,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_DIMPLE_R_BD")]
        MouthDimpleRBD = 34,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_STRETCH_L_BD")]
        MouthStretchLBD = 35,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_STRETCH_R_BD")]
        MouthStretchRBD = 36,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_ROLL_LOWER_BD")]
        MouthRollLowerBD = 37,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_ROLL_UPPER_BD")]
        MouthRollUpperBD = 38,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_SHRUG_LOWER_BD")]
        MouthShrugLowerBD = 39,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_SHRUG_UPPER_BD")]
        MouthShrugUpperBD = 40,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_PRESS_L_BD")]
        MouthPressLBD = 41,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_PRESS_R_BD")]
        MouthPressRBD = 42,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_LOWER_DROP_L_BD")]
        MouthLowerDropLBD = 43,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_LOWER_DROP_R_BD")]
        MouthLowerDropRBD = 44,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_UPPER_UPWARDS_L_BD")]
        MouthUpperUpwardsLBD = 45,
        [NativeName("Name", "XR_FACE_EXPRESSION_MOUTH_UPPER_UPWARDS_R_BD")]
        MouthUpperUpwardsRBD = 46,
        [NativeName("Name", "XR_FACE_EXPRESSION_JAW_FORWARD_BD")]
        JawForwardBD = 47,
        [NativeName("Name", "XR_FACE_EXPRESSION_JAW_L_BD")]
        JawLBD = 48,
        [NativeName("Name", "XR_FACE_EXPRESSION_JAW_R_BD")]
        JawRBD = 49,
        [NativeName("Name", "XR_FACE_EXPRESSION_JAW_OPEN_BD")]
        JawOpenBD = 50,
        [NativeName("Name", "XR_FACE_EXPRESSION_TONGUE_OUT_BD")]
        TongueOutBD = 51,
    }
}
