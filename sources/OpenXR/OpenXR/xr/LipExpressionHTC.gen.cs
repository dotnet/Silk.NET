// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrLipExpressionHTC")]
public enum LipExpressionHTC : uint
{
    [NativeName("XR_LIP_EXPRESSION_JAW_RIGHT_HTC")]
    JawRight = 0,

    [NativeName("XR_LIP_EXPRESSION_JAW_LEFT_HTC")]
    JawLeft = 1,

    [NativeName("XR_LIP_EXPRESSION_JAW_FORWARD_HTC")]
    JawForward = 2,

    [NativeName("XR_LIP_EXPRESSION_JAW_OPEN_HTC")]
    JawOpen = 3,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_APE_SHAPE_HTC")]
    MouthApeShape = 4,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_UPPER_RIGHT_HTC")]
    MouthUpperRight = 5,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_UPPER_LEFT_HTC")]
    MouthUpperLeft = 6,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_LOWER_RIGHT_HTC")]
    MouthLowerRight = 7,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_LOWER_LEFT_HTC")]
    MouthLowerLeft = 8,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_UPPER_OVERTURN_HTC")]
    MouthUpperOverturn = 9,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_LOWER_OVERTURN_HTC")]
    MouthLowerOverturn = 10,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_POUT_HTC")]
    MouthPout = 11,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_RAISER_RIGHT_HTC")]
    MouthRaiserRight = 12,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_RAISER_LEFT_HTC")]
    MouthRaiserLeft = 13,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_STRETCHER_RIGHT_HTC")]
    MouthStretcherRight = 14,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_STRETCHER_LEFT_HTC")]
    MouthStretcherLeft = 15,

    [NativeName("XR_LIP_EXPRESSION_CHEEK_PUFF_RIGHT_HTC")]
    CheekPuffRight = 16,

    [NativeName("XR_LIP_EXPRESSION_CHEEK_PUFF_LEFT_HTC")]
    CheekPuffLeft = 17,

    [NativeName("XR_LIP_EXPRESSION_CHEEK_SUCK_HTC")]
    CheekSuck = 18,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_UPPER_UPRIGHT_HTC")]
    MouthUpperUpright = 19,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_UPPER_UPLEFT_HTC")]
    MouthUpperUpleft = 20,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_LOWER_DOWNRIGHT_HTC")]
    MouthLowerDownright = 21,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_LOWER_DOWNLEFT_HTC")]
    MouthLowerDownleft = 22,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_UPPER_INSIDE_HTC")]
    MouthUpperInside = 23,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_LOWER_INSIDE_HTC")]
    MouthLowerInside = 24,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_LOWER_OVERLAY_HTC")]
    MouthLowerOverlay = 25,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_LONGSTEP1_HTC")]
    TongueLongstep1 = 26,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_LEFT_HTC")]
    TongueLeft = 27,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_RIGHT_HTC")]
    TongueRight = 28,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_UP_HTC")]
    TongueUp = 29,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_DOWN_HTC")]
    TongueDown = 30,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_ROLL_HTC")]
    TongueRoll = 31,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_LONGSTEP2_HTC")]
    TongueLongstep2 = 32,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_UPRIGHT_MORPH_HTC")]
    TongueUprightMorph = 33,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_UPLEFT_MORPH_HTC")]
    TongueUpleftMorph = 34,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_DOWNRIGHT_MORPH_HTC")]
    TongueDownrightMorph = 35,

    [NativeName("XR_LIP_EXPRESSION_TONGUE_DOWNLEFT_MORPH_HTC")]
    TongueDownleftMorph = 36,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_SMILE_RIGHT_HTC")]
    MouthSmileRight = MouthRaiserRight,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_SMILE_LEFT_HTC")]
    MouthSmileLeft = MouthRaiserLeft,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_SAD_RIGHT_HTC")]
    MouthSadRight = MouthStretcherRight,

    [NativeName("XR_LIP_EXPRESSION_MOUTH_SAD_LEFT_HTC")]
    MouthSadLeft = MouthStretcherLeft,
}
