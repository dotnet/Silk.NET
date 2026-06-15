// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrBodyTrackingFidelityStatusMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct BodyTrackingFidelityStatusMETA
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_fidelity"],
        ImpliesSets = ["XR_FB_body_tracking", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.TypeBodyTrackingFidelityStatusMETA;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_fidelity"],
        ImpliesSets = ["XR_FB_body_tracking", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("fidelity")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_fidelity"],
        ImpliesSets = ["XR_FB_body_tracking", "XR_VERSION_1_0"]
    )]
    public BodyTrackingFidelityMETA Fidelity;

    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_fidelity"],
        ImpliesSets = ["XR_FB_body_tracking", "XR_VERSION_1_0"]
    )]
    public BodyTrackingFidelityStatusMETA() { }
}
