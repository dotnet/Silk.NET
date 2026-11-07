// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerAlphaBlendFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct CompositionLayerAlphaBlendFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_alpha_blend"])]
    public StructureType Type = StructureType.CompositionLayerAlphaBlendFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_alpha_blend"])]
    public void* Next;

    [NativeName("srcFactorColor")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_alpha_blend"])]
    public BlendFactorFB SrcFactorColor;

    [NativeName("dstFactorColor")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_alpha_blend"])]
    public BlendFactorFB DstFactorColor;

    [NativeName("srcFactorAlpha")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_alpha_blend"])]
    public BlendFactorFB SrcFactorAlpha;

    [NativeName("dstFactorAlpha")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_alpha_blend"])]
    public BlendFactorFB DstFactorAlpha;

    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_alpha_blend"])]
    public CompositionLayerAlphaBlendFB() { }
}
