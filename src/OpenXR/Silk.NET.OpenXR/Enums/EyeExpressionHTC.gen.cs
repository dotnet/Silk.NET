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
        [Obsolete("Deprecated in favour of \"LeftBlinkHtc\"")]
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_BLINK_HTC")]
        EyeExpressionLeftBlinkHtc = 0,
        [Obsolete("Deprecated in favour of \"LeftWideHtc\"")]
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_WIDE_HTC")]
        EyeExpressionLeftWideHtc = 1,
        [Obsolete("Deprecated in favour of \"RightBlinkHtc\"")]
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_BLINK_HTC")]
        EyeExpressionRightBlinkHtc = 2,
        [Obsolete("Deprecated in favour of \"RightWideHtc\"")]
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_WIDE_HTC")]
        EyeExpressionRightWideHtc = 3,
        [Obsolete("Deprecated in favour of \"LeftSqueezeHtc\"")]
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_SQUEEZE_HTC")]
        EyeExpressionLeftSqueezeHtc = 4,
        [Obsolete("Deprecated in favour of \"RightSqueezeHtc\"")]
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_SQUEEZE_HTC")]
        EyeExpressionRightSqueezeHtc = 5,
        [Obsolete("Deprecated in favour of \"LeftDownHtc\"")]
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_DOWN_HTC")]
        EyeExpressionLeftDownHtc = 6,
        [Obsolete("Deprecated in favour of \"RightDownHtc\"")]
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_DOWN_HTC")]
        EyeExpressionRightDownHtc = 7,
        [Obsolete("Deprecated in favour of \"LeftOutHtc\"")]
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_OUT_HTC")]
        EyeExpressionLeftOutHtc = 8,
        [Obsolete("Deprecated in favour of \"RightInHtc\"")]
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_IN_HTC")]
        EyeExpressionRightInHtc = 9,
        [Obsolete("Deprecated in favour of \"LeftInHtc\"")]
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_IN_HTC")]
        EyeExpressionLeftInHtc = 10,
        [Obsolete("Deprecated in favour of \"RightOutHtc\"")]
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_OUT_HTC")]
        EyeExpressionRightOutHtc = 11,
        [Obsolete("Deprecated in favour of \"LeftUpHtc\"")]
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_UP_HTC")]
        EyeExpressionLeftUpHtc = 12,
        [Obsolete("Deprecated in favour of \"RightUpHtc\"")]
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_UP_HTC")]
        EyeExpressionRightUpHtc = 13,
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_BLINK_HTC")]
        LeftBlinkHtc = 0,
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_WIDE_HTC")]
        LeftWideHtc = 1,
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_BLINK_HTC")]
        RightBlinkHtc = 2,
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_WIDE_HTC")]
        RightWideHtc = 3,
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_SQUEEZE_HTC")]
        LeftSqueezeHtc = 4,
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_SQUEEZE_HTC")]
        RightSqueezeHtc = 5,
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_DOWN_HTC")]
        LeftDownHtc = 6,
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_DOWN_HTC")]
        RightDownHtc = 7,
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_OUT_HTC")]
        LeftOutHtc = 8,
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_IN_HTC")]
        RightInHtc = 9,
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_IN_HTC")]
        LeftInHtc = 10,
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_OUT_HTC")]
        RightOutHtc = 11,
        [NativeName("Name", "XR_EYE_EXPRESSION_LEFT_UP_HTC")]
        LeftUpHtc = 12,
        [NativeName("Name", "XR_EYE_EXPRESSION_RIGHT_UP_HTC")]
        RightUpHtc = 13,
    }
}
