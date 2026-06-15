// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerImageLayoutFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct CompositionLayerImageLayoutFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_image_layout"])]
    public StructureType Type = StructureType.TypeCompositionLayerImageLayoutFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_image_layout"])]
    public void* Next;

    [NativeName("flags")]
    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_image_layout"])]
    public CompositionLayerImageLayoutFlagsFB Flags;

    [SupportedApiProfile("openxr", ["XR_FB_composition_layer_image_layout"])]
    public CompositionLayerImageLayoutFB() { }
}
