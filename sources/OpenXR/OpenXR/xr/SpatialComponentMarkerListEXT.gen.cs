// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialComponentMarkerListEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialComponentMarkerListEXT
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public StructureType Type = StructureType.SpatialComponentMarkerListEXT;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public void* Next;

    [NativeName("markerCount")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public uint MarkerCount;

    [NativeName("markers")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public SpatialMarkerDataEXT* Markers;

    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    public SpatialComponentMarkerListEXT() { }
}
