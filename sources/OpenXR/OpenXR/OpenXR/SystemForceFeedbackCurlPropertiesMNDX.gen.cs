// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemForceFeedbackCurlPropertiesMNDX")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemForceFeedbackCurlPropertiesMNDX
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MNDX_force_feedback_curl"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.SystemForceFeedbackCurlPropertiesMNDX;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MNDX_force_feedback_curl"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("supportsForceFeedbackCurl")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MNDX_force_feedback_curl"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public MaybeBool<uint> SupportsForceFeedbackCurl;

    [SupportedApiProfile(
        "openxr",
        ["XR_MNDX_force_feedback_curl"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    public SystemForceFeedbackCurlPropertiesMNDX() { }
}
