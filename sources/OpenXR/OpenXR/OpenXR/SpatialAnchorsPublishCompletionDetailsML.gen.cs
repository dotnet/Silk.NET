// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialAnchorsPublishCompletionDetailsML")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialAnchorsPublishCompletionDetailsML
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    public StructureType Type = StructureType.SpatialAnchorsPublishCompletionDetailsML;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    public void* Next;

    [NativeName("resultCount")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    public uint ResultCount;

    [NativeName("results")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    public SpatialAnchorCompletionResultML* Results;

    [SupportedApiProfile(
        "openxr",
        ["XR_ML_spatial_anchors_storage"],
        ImpliesSets = ["XR_EXT_future", "XR_ML_spatial_anchors"]
    )]
    public SpatialAnchorsPublishCompletionDetailsML() { }
}
