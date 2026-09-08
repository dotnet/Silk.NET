// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrTrackableObjectANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct TrackableObjectANDROID
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_object"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public StructureType Type = StructureType.TrackableObjectANDROID;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_object"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public void* Next;

    [NativeName("trackingState")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_object"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public TrackingStateANDROID TrackingState;

    [NativeName("centerPose")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_object"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public Posef CenterPose;

    [NativeName("extents")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_object"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public Extent3Df Extents;

    [NativeName("objectLabel")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_object"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public ObjectLabelANDROID ObjectLabel;

    [NativeName("lastUpdatedTime")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_object"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public long LastUpdatedTime;

    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_trackables_object"],
        ImpliesSets = ["XR_ANDROID_trackables"]
    )]
    public TrackableObjectANDROID() { }
}
