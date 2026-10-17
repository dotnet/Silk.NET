// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEyeExpressionHTC")]
public enum EyeExpressionHTC : uint
{
    [NativeName("XR_EYE_EXPRESSION_LEFT_BLINK_HTC")]
    LeftBlink = 0,

    [NativeName("XR_EYE_EXPRESSION_LEFT_WIDE_HTC")]
    LeftWide = 1,

    [NativeName("XR_EYE_EXPRESSION_RIGHT_BLINK_HTC")]
    RightBlink = 2,

    [NativeName("XR_EYE_EXPRESSION_RIGHT_WIDE_HTC")]
    RightWide = 3,

    [NativeName("XR_EYE_EXPRESSION_LEFT_SQUEEZE_HTC")]
    LeftSqueeze = 4,

    [NativeName("XR_EYE_EXPRESSION_RIGHT_SQUEEZE_HTC")]
    RightSqueeze = 5,

    [NativeName("XR_EYE_EXPRESSION_LEFT_DOWN_HTC")]
    LeftDown = 6,

    [NativeName("XR_EYE_EXPRESSION_RIGHT_DOWN_HTC")]
    RightDown = 7,

    [NativeName("XR_EYE_EXPRESSION_LEFT_OUT_HTC")]
    LeftOut = 8,

    [NativeName("XR_EYE_EXPRESSION_RIGHT_IN_HTC")]
    RightIn = 9,

    [NativeName("XR_EYE_EXPRESSION_LEFT_IN_HTC")]
    LeftIn = 10,

    [NativeName("XR_EYE_EXPRESSION_RIGHT_OUT_HTC")]
    RightOut = 11,

    [NativeName("XR_EYE_EXPRESSION_LEFT_UP_HTC")]
    LeftUp = 12,

    [NativeName("XR_EYE_EXPRESSION_RIGHT_UP_HTC")]
    RightUp = 13,
}
