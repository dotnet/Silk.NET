// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEyeCalibrationStatusML")]
[SupportedApiProfile("openxr")]
public enum EyeCalibrationStatusML : uint
{
    [NativeName("XR_EYE_CALIBRATION_STATUS_UNKNOWN_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    Unknown = 0,

    [NativeName("XR_EYE_CALIBRATION_STATUS_NONE_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    None = 1,

    [NativeName("XR_EYE_CALIBRATION_STATUS_COARSE_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    Coarse = 2,

    [NativeName("XR_EYE_CALIBRATION_STATUS_FINE_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    Fine = 3,
}
