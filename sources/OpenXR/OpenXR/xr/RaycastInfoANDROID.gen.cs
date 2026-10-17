// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrRaycastInfoANDROID")]
public unsafe partial struct RaycastInfoANDROID
{
    [NativeName("type")]
    public StructureType Type = StructureType.RaycastInfoANDROID;

    [NativeName("next")]
    public void* Next;

    [NativeName("maxResults")]
    public uint MaxResults;

    [NativeName("trackerCount")]
    public uint TrackerCount;

    [NativeName("trackers")]
    public TrackableTrackerHandleANDROID* Trackers;

    [NativeName("origin")]
    public Vector3F Origin;

    [NativeName("trajectory")]
    public Vector3F Trajectory;

    [NativeName("space")]
    public SpaceHandle Space;

    [NativeName("time")]
    public long Time;

    public RaycastInfoANDROID() { }
}
