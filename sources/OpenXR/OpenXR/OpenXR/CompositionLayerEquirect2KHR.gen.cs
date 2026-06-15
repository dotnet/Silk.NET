// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerEquirect2KHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct CompositionLayerEquirect2KHR
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect2"])]
    public StructureType Type = StructureType.TypeCompositionLayerEquirect2KHR;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect2"])]
    public void* Next;

    [NativeName("layerFlags")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect2"])]
    public CompositionLayerFlags LayerFlags;

    [NativeName("space")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect2"])]
    public SpaceHandle Space;

    [NativeName("eyeVisibility")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect2"])]
    public EyeVisibility EyeVisibility;

    [NativeName("subImage")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect2"])]
    public SwapchainSubImage SubImage;

    [NativeName("pose")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect2"])]
    public Posef Pose;

    [NativeName("radius")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect2"])]
    public float Radius;

    [NativeName("centralHorizontalAngle")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect2"])]
    public float CentralHorizontalAngle;

    [NativeName("upperVerticalAngle")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect2"])]
    public float UpperVerticalAngle;

    [NativeName("lowerVerticalAngle")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect2"])]
    public float LowerVerticalAngle;

    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_equirect2"])]
    public CompositionLayerEquirect2KHR() { }
}
