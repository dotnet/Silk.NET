// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerCubeKHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct CompositionLayerCubeKHR
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cube"])]
    public StructureType Type = StructureType.CompositionLayerCubeKHR;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cube"])]
    public void* Next;

    [NativeName("layerFlags")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cube"])]
    public CompositionLayerFlags LayerFlags;

    [NativeName("space")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cube"])]
    public SpaceHandle Space;

    [NativeName("eyeVisibility")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cube"])]
    public EyeVisibility EyeVisibility;

    [NativeName("swapchain")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cube"])]
    public SwapchainHandle Swapchain;

    [NativeName("imageArrayIndex")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cube"])]
    public uint ImageArrayIndex;

    [NativeName("orientation")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cube"])]
    public Quaternionf Orientation;

    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_cube"])]
    public CompositionLayerCubeKHR() { }
}
