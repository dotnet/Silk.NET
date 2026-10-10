// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrForceFeedbackCurlLocationMNDX")]
[SupportedApiProfile("openxr")]
public enum ForceFeedbackCurlLocationMNDX : uint
{
    [NativeName("XR_FORCE_FEEDBACK_CURL_LOCATION_THUMB_CURL_MNDX")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MNDX_force_feedback_curl"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    ThumbCurl = 0,

    [NativeName("XR_FORCE_FEEDBACK_CURL_LOCATION_INDEX_CURL_MNDX")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MNDX_force_feedback_curl"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    IndexCurl = 1,

    [NativeName("XR_FORCE_FEEDBACK_CURL_LOCATION_MIDDLE_CURL_MNDX")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MNDX_force_feedback_curl"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    MiddleCurl = 2,

    [NativeName("XR_FORCE_FEEDBACK_CURL_LOCATION_RING_CURL_MNDX")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MNDX_force_feedback_curl"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    RingCurl = 3,

    [NativeName("XR_FORCE_FEEDBACK_CURL_LOCATION_LITTLE_CURL_MNDX")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MNDX_force_feedback_curl"],
        ImpliesSets = ["XR_EXT_hand_tracking", "XR_VERSION_1_0"]
    )]
    LittleCurl = 4,
}
