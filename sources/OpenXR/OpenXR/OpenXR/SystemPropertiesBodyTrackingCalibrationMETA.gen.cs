// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemPropertiesBodyTrackingCalibrationMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemPropertiesBodyTrackingCalibrationMETA
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_calibration"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    public StructureType Type = StructureType.TypeSystemPropertiesBodyTrackingCalibrationMETA;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_calibration"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    public void* Next;

    [NativeName("supportsHeightOverride")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_calibration"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    public MaybeBool<uint> SupportsHeightOverride;

    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_calibration"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    public SystemPropertiesBodyTrackingCalibrationMETA() { }
}
