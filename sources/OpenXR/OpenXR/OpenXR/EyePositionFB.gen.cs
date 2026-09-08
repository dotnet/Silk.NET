// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEyePositionFB")]
[SupportedApiProfile("openxr")]
public enum EyePositionFB : uint
{
    [NativeName("XR_EYE_POSITION_LEFT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    Left = 0,

    [NativeName("XR_EYE_POSITION_RIGHT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    Right = 1,

    [NativeName("XR_EYE_POSITION_COUNT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_eye_tracking_social"])]
    Count = 2,
}
