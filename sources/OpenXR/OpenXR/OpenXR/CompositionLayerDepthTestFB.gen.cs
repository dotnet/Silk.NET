// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerDepthTestFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct CompositionLayerDepthTestFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_depth_test"])]
    public StructureType Type = StructureType.TypeCompositionLayerDepthTestFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_depth_test"])]
    public void* Next;

    [NativeName("depthMask")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_depth_test"])]
    public MaybeBool<uint> DepthMask;

    [NativeName("compareOp")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_depth_test"])]
    public CompareOpFB CompareOp;

    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_depth_test"])]
    public CompositionLayerDepthTestFB() { }
}
