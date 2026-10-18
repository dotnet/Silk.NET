// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialAnchorConfidenceML")]
[SupportedApiProfile("openxr")]
public enum SpatialAnchorConfidenceML : uint
{
    [NativeName("XR_SPATIAL_ANCHOR_CONFIDENCE_LOW_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    Low = 0,

    [NativeName("XR_SPATIAL_ANCHOR_CONFIDENCE_MEDIUM_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    Medium = 1,

    [NativeName("XR_SPATIAL_ANCHOR_CONFIDENCE_HIGH_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_spatial_anchors"], ImpliesSets = ["XR_EXT_future"])]
    High = 2,
}
