// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrEyePositionFB")]
    public enum EyePositionFB : int
    {
        [Obsolete("Deprecated in favour of \"LeftFB\"")]
        [NativeName("Name", "XR_EYE_POSITION_LEFT_FB")]
        EyePositionLeftFB = 0,
        [Obsolete("Deprecated in favour of \"RightFB\"")]
        [NativeName("Name", "XR_EYE_POSITION_RIGHT_FB")]
        EyePositionRightFB = 1,
        [Obsolete("Deprecated in favour of \"CountFB\"")]
        [NativeName("Name", "XR_EYE_POSITION_COUNT_FB")]
        EyePositionCountFB = 2,
        [NativeName("Name", "XR_EYE_POSITION_LEFT_FB")]
        LeftFB = 0,
        [NativeName("Name", "XR_EYE_POSITION_RIGHT_FB")]
        RightFB = 1,
        [NativeName("Name", "XR_EYE_POSITION_COUNT_FB")]
        CountFB = 2,
    }
}
