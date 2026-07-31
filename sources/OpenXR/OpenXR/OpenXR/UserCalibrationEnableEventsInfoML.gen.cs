// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrUserCalibrationEnableEventsInfoML")]
[SupportedApiProfile("openxr")]
public unsafe partial struct UserCalibrationEnableEventsInfoML
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    public StructureType Type = StructureType.UserCalibrationEnableEventsInfoML;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    public void* Next;

    [NativeName("enabled")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    public MaybeBool<uint> Enabled;

    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    public UserCalibrationEnableEventsInfoML() { }
}
