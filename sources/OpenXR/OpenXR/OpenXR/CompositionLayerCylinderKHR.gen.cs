// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerCylinderKHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct CompositionLayerCylinderKHR
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cylinder"])]
    public StructureType Type = StructureType.TypeCompositionLayerCylinderKHR;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cylinder"])]
    public void* Next;

    [NativeName("layerFlags")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cylinder"])]
    public CompositionLayerFlags LayerFlags;

    [NativeName("space")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cylinder"])]
    public SpaceHandle Space;

    [NativeName("eyeVisibility")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cylinder"])]
    public EyeVisibility EyeVisibility;

    [NativeName("subImage")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cylinder"])]
    public SwapchainSubImage SubImage;

    [NativeName("pose")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cylinder"])]
    public Posef Pose;

    [NativeName("radius")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cylinder"])]
    public float Radius;

    [NativeName("centralAngle")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cylinder"])]
    public float CentralAngle;

    [NativeName("aspectRatio")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cylinder"])]
    public float AspectRatio;

    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cylinder"])]
    public CompositionLayerCylinderKHR() { }
}
