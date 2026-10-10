// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrLipExpressionHTC")]
[SupportedApiProfile("openxr")]
public enum LipExpressionHTC : uint
{
    [NativeName("XR_LIP_EXPRESSION_JAW_RIGHT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    JawRight = 0,

    [NativeName("XR_LIP_EXPRESSION_JAW_LEFT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    JawLeft = 1,

    [NativeName("XR_LIP_EXPRESSION_JAW_FORWARD_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    JawForward = 2,

    [NativeName("XR_LIP_EXPRESSION_JAW_OPEN_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    JawOpen = 3,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_APE_SHAPE_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthApeShape = 4,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_UPPER_RIGHT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthUpperRight = 5,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_UPPER_LEFT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthUpperLeft = 6,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_LOWER_RIGHT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthLowerRight = 7,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_LOWER_LEFT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthLowerLeft = 8,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_UPPER_OVERTURN_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthUpperOverturn = 9,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_LOWER_OVERTURN_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthLowerOverturn = 10,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_POUT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthPout = 11,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_RAISER_RIGHT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthRaiserRight = 12,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_RAISER_LEFT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthRaiserLeft = 13,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_STRETCHER_RIGHT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthStretcherRight = 14,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_STRETCHER_LEFT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthStretcherLeft = 15,

    [NativeName("XR_LIP_EXPRESSION_CHEEK_PUFF_RIGHT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    CheekPuffRight = 16,

    [NativeName("XR_LIP_EXPRESSION_CHEEK_PUFF_LEFT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    CheekPuffLeft = 17,

    [NativeName("XR_LIP_EXPRESSION_CHEEK_SUCK_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    CheekSuck = 18,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_UPPER_UPRIGHT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthUpperUpright = 19,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_UPPER_UPLEFT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthUpperUpleft = 20,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_LOWER_DOWNRIGHT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthLowerDownright = 21,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_LOWER_DOWNLEFT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthLowerDownleft = 22,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_UPPER_INSIDE_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthUpperInside = 23,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_LOWER_INSIDE_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthLowerInside = 24,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_LOWER_OVERLAY_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthLowerOverlay = 25,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_LONGSTEP1_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    TongueLongstep1 = 26,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_LEFT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    TongueLeft = 27,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_RIGHT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    TongueRight = 28,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_UP_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    TongueUp = 29,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_DOWN_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    TongueDown = 30,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_ROLL_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    TongueRoll = 31,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_LONGSTEP2_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    TongueLongstep2 = 32,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_UPRIGHT_MORPH_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    TongueUprightMorph = 33,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_UPLEFT_MORPH_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    TongueUpleftMorph = 34,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_DOWNRIGHT_MORPH_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    TongueDownrightMorph = 35,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_DOWNLEFT_MORPH_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    TongueDownleftMorph = 36,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_SMILE_RIGHT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthSmileRight = MouthRaiserRight,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_SMILE_LEFT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthSmileLeft = MouthRaiserLeft,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_SAD_RIGHT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthSadRight = MouthStretcherRight,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_SAD_LEFT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    MouthSadLeft = MouthStretcherLeft,
}
