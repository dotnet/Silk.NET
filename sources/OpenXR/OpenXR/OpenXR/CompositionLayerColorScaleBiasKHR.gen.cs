// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerColorScaleBiasKHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct CompositionLayerColorScaleBiasKHR
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_color_scale_bias"])]
    public StructureType Type = StructureType.TypeCompositionLayerColorScaleBiasKHR;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_color_scale_bias"])]
    public void* Next;

    [NativeName("colorScale")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_color_scale_bias"])]
    public Color4F ColorScale;

    [NativeName("colorBias")]
    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_color_scale_bias"])]
    public Color4F ColorBias;

    [SupportedApiProfile("openxr", ["XR_KHR_composition_layer_color_scale_bias"])]
    public CompositionLayerColorScaleBiasKHR() { }
}
