// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrTrackablePlaneANDROID")]
public unsafe partial struct TrackablePlaneANDROID
{
    [NativeName("type")]
    public StructureType Type = StructureType.TrackablePlaneANDROID;

    [NativeName("next")]
    public void* Next;

    [NativeName("trackingState")]
    public TrackingStateANDROID TrackingState;

    [NativeName("centerPose")]
    public Posef CenterPose;

    [NativeName("extents")]
    public Extent2Df Extents;

    [NativeName("planeType")]
    public PlaneTypeANDROID PlaneType;

    [NativeName("planeLabel")]
    public PlaneLabelANDROID PlaneLabel;

    [NativeName("subsumedByPlane")]
    public ulong SubsumedByPlane;

    [NativeName("lastUpdatedTime")]
    public long LastUpdatedTime;

    [NativeName("vertexCapacityInput")]
    public uint VertexCapacityInput;

    [NativeName("vertexCountOutput")]
    public uint* VertexCountOutput;

    [NativeName("vertices")]
    public Vector2F* Vertices;

    public TrackablePlaneANDROID() { }
}
