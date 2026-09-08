// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEyeExpressionHTC")]
[SupportedApiProfile("openxr")]
public enum EyeExpressionHTC : uint
{
    [NativeName("XR_EYE_EXPRESSION_LEFT_BLINK_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    LeftBlink = 0,

    [NativeName("XR_EYE_EXPRESSION_LEFT_WIDE_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    LeftWide = 1,

    [NativeName("XR_EYE_EXPRESSION_RIGHT_BLINK_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    RightBlink = 2,

    [NativeName("XR_EYE_EXPRESSION_RIGHT_WIDE_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    RightWide = 3,

    [NativeName("XR_EYE_EXPRESSION_LEFT_SQUEEZE_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    LeftSqueeze = 4,

    [NativeName("XR_EYE_EXPRESSION_RIGHT_SQUEEZE_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    RightSqueeze = 5,

    [NativeName("XR_EYE_EXPRESSION_LEFT_DOWN_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    LeftDown = 6,

    [NativeName("XR_EYE_EXPRESSION_RIGHT_DOWN_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    RightDown = 7,

    [NativeName("XR_EYE_EXPRESSION_LEFT_OUT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    LeftOut = 8,

    [NativeName("XR_EYE_EXPRESSION_RIGHT_IN_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    RightIn = 9,

    [NativeName("XR_EYE_EXPRESSION_LEFT_IN_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    LeftIn = 10,

    [NativeName("XR_EYE_EXPRESSION_RIGHT_OUT_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    RightOut = 11,

    [NativeName("XR_EYE_EXPRESSION_LEFT_UP_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    LeftUp = 12,

    [NativeName("XR_EYE_EXPRESSION_RIGHT_UP_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_facial_tracking"])]
    RightUp = 13,
}
