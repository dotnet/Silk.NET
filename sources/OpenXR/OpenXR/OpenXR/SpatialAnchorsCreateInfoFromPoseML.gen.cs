// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialAnchorsCreateInfoFromPoseML")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialAnchorsCreateInfoFromPoseML
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    public StructureType Type = StructureType.SpatialAnchorsCreateInfoFromPoseML;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    public void* Next;

    [NativeName("baseSpace")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    public SpaceHandle BaseSpace;

    [NativeName("poseInBaseSpace")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    public Posef PoseInBaseSpace;

    [NativeName("time")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    public long Time;

    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    public SpatialAnchorsCreateInfoFromPoseML() { }
}
