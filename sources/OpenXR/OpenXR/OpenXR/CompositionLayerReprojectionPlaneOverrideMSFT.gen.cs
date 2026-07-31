// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerReprojectionPlaneOverrideMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct CompositionLayerReprojectionPlaneOverrideMSFT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    public StructureType Type = StructureType.CompositionLayerReprojectionPlaneOverrideMSFT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    public void* Next;

    [NativeName("position")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    public Vector3F Position;

    [NativeName("normal")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    public Vector3F Normal;

    [NativeName("velocity")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    public Vector3F Velocity;

    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    public CompositionLayerReprojectionPlaneOverrideMSFT() { }
}
