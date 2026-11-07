// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialAnchorCreateInfoBD")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialAnchorCreateInfoBD
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    public StructureType Type = StructureType.SpatialAnchorCreateInfoBD;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    public void* Next;

    [NativeName("space")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    public SpaceHandle Space;

    [NativeName("pose")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    public Posef Pose;

    [NativeName("time")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    public long Time;

    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    public SpatialAnchorCreateInfoBD() { }
}
