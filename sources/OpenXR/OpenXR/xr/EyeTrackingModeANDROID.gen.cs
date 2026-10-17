// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEyeTrackingModeANDROID")]
public enum EyeTrackingModeANDROID : uint
{
    [NativeName("XR_EYE_TRACKING_MODE_NOT_TRACKING_ANDROID")]
    NotTracking = 0,

    [NativeName("XR_EYE_TRACKING_MODE_RIGHT_ANDROID")]
    Right = 1,

    [NativeName("XR_EYE_TRACKING_MODE_LEFT_ANDROID")]
    Left = 2,

    [NativeName("XR_EYE_TRACKING_MODE_BOTH_ANDROID")]
    Both = 3,
}
