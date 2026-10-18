// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerEquirectKHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct CompositionLayerEquirectKHR
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect"])]
    public StructureType Type = StructureType.CompositionLayerEquirectKHR;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect"])]
    public void* Next;

    [NativeName("layerFlags")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect"])]
    public CompositionLayerFlags LayerFlags;

    [NativeName("space")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect"])]
    public SpaceHandle Space;

    [NativeName("eyeVisibility")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect"])]
    public EyeVisibility EyeVisibility;

    [NativeName("subImage")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect"])]
    public SwapchainSubImage SubImage;

    [NativeName("pose")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect"])]
    public Posef Pose;

    [NativeName("radius")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect"])]
    public float Radius;

    [NativeName("scale")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect"])]
    public Vector2F Scale;

    [NativeName("bias")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect"])]
    public Vector2F Bias;

    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect"])]
    public CompositionLayerEquirectKHR() { }
}
