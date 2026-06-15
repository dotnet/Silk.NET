// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerReprojectionInfoMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct CompositionLayerReprojectionInfoMSFT
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    public StructureType Type = StructureType.TypeCompositionLayerReprojectionInfoMSFT;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    public void* Next;

    [NativeName("reprojectionMode")]
    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    public ReprojectionModeMSFT ReprojectionMode;

    [SupportedApiProfile("openxr", ["XR_MSFT_composition_layer_reprojection"])]
    public CompositionLayerReprojectionInfoMSFT() { }
}
