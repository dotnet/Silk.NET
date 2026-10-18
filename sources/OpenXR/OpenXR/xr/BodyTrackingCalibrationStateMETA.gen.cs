// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyTrackingCalibrationStateMETA")]
[SupportedApiProfile("openxr")]
public enum BodyTrackingCalibrationStateMETA : uint
{
    [NativeName("XR_BODY_TRACKING_CALIBRATION_STATE_VALID_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_calibration"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    Valid = 1,

    [NativeName("XR_BODY_TRACKING_CALIBRATION_STATE_CALIBRATING_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_calibration"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    Calibrating = 2,

    [NativeName("XR_BODY_TRACKING_CALIBRATION_STATE_INVALID_META")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_calibration"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    Invalid = 3,
}
