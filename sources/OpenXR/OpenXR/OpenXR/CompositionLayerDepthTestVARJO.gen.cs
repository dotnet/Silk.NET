// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerDepthTestVARJO")]
[SupportedApiProfile("openxr")]
public unsafe partial struct CompositionLayerDepthTestVARJO
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_composition_layer_depth_test"],
        ImpliesSets = ["XR_KHR_composition_layer_depth", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.TypeCompositionLayerDepthTestVARJO;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_composition_layer_depth_test"],
        ImpliesSets = ["XR_KHR_composition_layer_depth", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("depthTestRangeNearZ")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_composition_layer_depth_test"],
        ImpliesSets = ["XR_KHR_composition_layer_depth", "XR_VERSION_1_0"]
    )]
    public float DepthTestRangeNearZ;

    [NativeName("depthTestRangeFarZ")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_composition_layer_depth_test"],
        ImpliesSets = ["XR_KHR_composition_layer_depth", "XR_VERSION_1_0"]
    )]
    public float DepthTestRangeFarZ;

    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_composition_layer_depth_test"],
        ImpliesSets = ["XR_KHR_composition_layer_depth", "XR_VERSION_1_0"]
    )]
    public CompositionLayerDepthTestVARJO() { }
}
