// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrRaycastInfoANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct RaycastInfoANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    public StructureType Type = StructureType.TypeRaycastInfoANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    public void* Next;

    [NativeName("maxResults")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    public uint MaxResults;

    [NativeName("trackerCount")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    public uint TrackerCount;

    [NativeName("trackers")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    public TrackableTrackerHandleANDROID* Trackers;

    [NativeName("origin")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    public Vector3F Origin;

    [NativeName("trajectory")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    public Vector3F Trajectory;

    [NativeName("space")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    public SpaceHandle Space;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    public long Time;

    [SupportedApiProfile("openxr", ["XR_ANDROID_raycast"], ImpliesSets = ["XR_ANDROID_trackables"])]
    public RaycastInfoANDROID() { }
}
