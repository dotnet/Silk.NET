// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEventDataHeadsetFitChangedML")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EventDataHeadsetFitChangedML
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    public StructureType Type = StructureType.EventDataHeadsetFitChangedML;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    public void* Next;

    [NativeName("status")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    public HeadsetFitStatusML Status;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    public long Time;

    [SupportedApiProfile("openxr", ["XR_ML_user_calibration"])]
    public EventDataHeadsetFitChangedML() { }
}
