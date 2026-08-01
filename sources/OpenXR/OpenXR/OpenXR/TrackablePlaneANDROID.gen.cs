// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrTrackablePlaneANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct TrackablePlaneANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public StructureType Type = StructureType.TrackablePlaneANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public void* Next;

    [NativeName("trackingState")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public TrackingStateANDROID TrackingState;

    [NativeName("centerPose")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public Posef CenterPose;

    [NativeName("extents")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public Extent2Df Extents;

    [NativeName("planeType")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public PlaneTypeANDROID PlaneType;

    [NativeName("planeLabel")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public PlaneLabelANDROID PlaneLabel;

    [NativeName("subsumedByPlane")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public ulong SubsumedByPlane;

    [NativeName("lastUpdatedTime")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public long LastUpdatedTime;

    [NativeName("vertexCapacityInput")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public uint VertexCapacityInput;

    [NativeName("vertexCountOutput")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public uint* VertexCountOutput;

    [NativeName("vertices")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public Vector2F* Vertices;

    [SupportedApiProfile("openxr", ["XR_ANDROID_trackables"])]
    public TrackablePlaneANDROID() { }
}
