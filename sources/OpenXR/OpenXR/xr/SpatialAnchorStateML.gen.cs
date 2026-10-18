// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialAnchorStateML")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialAnchorStateML
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    public StructureType Type = StructureType.SpatialAnchorStateML;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    public void* Next;

    [NativeName("confidence")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    public SpatialAnchorConfidenceML Confidence;

    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    public SpatialAnchorStateML() { }
}
