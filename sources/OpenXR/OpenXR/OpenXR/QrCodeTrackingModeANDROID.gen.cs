// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrQrCodeTrackingModeANDROID")]
[SupportedApiProfile("openxr")]
public enum QrCodeTrackingModeANDROID : uint
{
    [NativeName("XR_QR_CODE_TRACKING_MODE_DYNAMIC_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_qr_code"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    Dynamic = 0,

    [NativeName("XR_QR_CODE_TRACKING_MODE_STATIC_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_qr_code"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    Static = 1,
}
