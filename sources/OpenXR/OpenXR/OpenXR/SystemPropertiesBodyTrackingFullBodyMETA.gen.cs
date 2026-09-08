// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSystemPropertiesBodyTrackingFullBodyMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SystemPropertiesBodyTrackingFullBodyMETA
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_full_body"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    public StructureType Type = StructureType.SystemPropertiesBodyTrackingFullBodyMETA;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_full_body"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    public void* Next;

    [NativeName("supportsFullBodyTracking")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_full_body"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    public MaybeBool<uint> SupportsFullBodyTracking;

    [SupportedApiProfile(
        "openxr",
        ["XR_META_body_tracking_full_body"],
        ImpliesSets = ["XR_FB_body_tracking"]
    )]
    public SystemPropertiesBodyTrackingFullBodyMETA() { }
}
