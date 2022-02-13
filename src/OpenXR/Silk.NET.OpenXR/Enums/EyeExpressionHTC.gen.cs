// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrEyeExpressionHTC")]
    public enum EyeExpressionHTC : int
    {
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_BLINK_HTC")]
        EyeExpressionLeftBlinkHtc = 0,
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_WIDE_HTC")]
        EyeExpressionLeftWideHtc = 1,
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_BLINK_HTC")]
        EyeExpressionRightBlinkHtc = 2,
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_WIDE_HTC")]
        EyeExpressionRightWideHtc = 3,
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_SQUEEZE_HTC")]
        EyeExpressionLeftSqueezeHtc = 4,
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_SQUEEZE_HTC")]
        EyeExpressionRightSqueezeHtc = 5,
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_DOWN_HTC")]
        EyeExpressionLeftDownHtc = 6,
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_DOWN_HTC")]
        EyeExpressionRightDownHtc = 7,
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_OUT_HTC")]
        EyeExpressionLeftOutHtc = 8,
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_IN_HTC")]
        EyeExpressionRightInHtc = 9,
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_IN_HTC")]
        EyeExpressionLeftInHtc = 10,
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_OUT_HTC")]
        EyeExpressionRightOutHtc = 11,
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_UP_HTC")]
        EyeExpressionLeftUpHtc = 12,
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_UP_HTC")]
        EyeExpressionRightUpHtc = 13,
    }
}
