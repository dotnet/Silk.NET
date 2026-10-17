// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrTrackableMarkerANDROID")]
public unsafe partial struct TrackableMarkerANDROID
{
    [NativeName("type")]
    public StructureType Type = StructureType.TrackableMarkerANDROID;

    [NativeName("next")]
    public void* Next;

    [NativeName("trackingState")]
    public TrackingStateANDROID TrackingState;

    [NativeName("lastUpdatedTime")]
    public long LastUpdatedTime;

    [NativeName("dictionary")]
    public TrackableMarkerDictionaryANDROID Dictionary;

    [NativeName("markerId")]
    public int MarkerId;

    [NativeName("centerPose")]
    public Posef CenterPose;

    [NativeName("extents")]
    public Extent2Df Extents;

    public TrackableMarkerANDROID() { }
}
