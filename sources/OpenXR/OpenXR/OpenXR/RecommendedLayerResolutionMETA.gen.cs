// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrRecommendedLayerResolutionMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct RecommendedLayerResolutionMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_recommended_layer_resolution"])]
    public StructureType Type = StructureType.RecommendedLayerResolutionMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_recommended_layer_resolution"])]
    public void* Next;

    [NativeName("recommendedImageDimensions")]
    [SupportedApiProfile("openxr", ["XR_META_recommended_layer_resolution"])]
    public Extent2Di RecommendedImageDimensions;

    [NativeName("isValid")]
    [SupportedApiProfile("openxr", ["XR_META_recommended_layer_resolution"])]
    public MaybeBool<uint> IsValid;

    [SupportedApiProfile("openxr", ["XR_META_recommended_layer_resolution"])]
    public RecommendedLayerResolutionMETA() { }
}
