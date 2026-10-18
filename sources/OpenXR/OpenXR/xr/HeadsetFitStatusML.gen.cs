// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrHeadsetFitStatusML")]
[SupportedApiProfile("openxr")]
public enum HeadsetFitStatusML : uint
{
    [NativeName("XR_HEADSET_FIT_STATUS_UNKNOWN_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    Unknown = 0,

    [NativeName("XR_HEADSET_FIT_STATUS_NOT_WORN_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    NotWorn = 1,

    [NativeName("XR_HEADSET_FIT_STATUS_GOOD_FIT_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    GoodFit = 2,

    [NativeName("XR_HEADSET_FIT_STATUS_BAD_FIT_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    BadFit = 3,
}
