// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialAnchorCreateInfoFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialAnchorCreateInfoFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public StructureType Type = StructureType.SpatialAnchorCreateInfoFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public void* Next;

    [NativeName("space")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public SpaceHandle Space;

    [NativeName("poseInSpace")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public Posef PoseInSpace;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public long Time;

    [SupportedApiProfile("openxr", ["XR_FB_spatial_entity"])]
    public SpatialAnchorCreateInfoFB() { }
}
