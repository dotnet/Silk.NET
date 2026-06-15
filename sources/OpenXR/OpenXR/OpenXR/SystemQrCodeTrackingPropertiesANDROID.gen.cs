// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemQrCodeTrackingPropertiesANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemQrCodeTrackingPropertiesANDROID
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_qr_code"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public StructureType Type = StructureType.TypeSystemQrCodeTrackingPropertiesANDROID;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_qr_code"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public void* Next;

    [NativeName("supportsQrCodeTracking")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_qr_code"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public MaybeBool<uint> SupportsQrCodeTracking;

    [NativeName("supportsQrCodeSizeEstimation")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_qr_code"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public MaybeBool<uint> SupportsQrCodeSizeEstimation;

    [NativeName("maxQrCodeCount")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_qr_code"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public ushort MaxQrCodeCount;

    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_qr_code"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public SystemQrCodeTrackingPropertiesANDROID() { }
}
