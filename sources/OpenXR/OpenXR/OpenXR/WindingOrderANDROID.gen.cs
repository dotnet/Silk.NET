// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrWindingOrderANDROID")]
[SupportedApiProfile("openxr")]
public enum WindingOrderANDROID : uint
{
    [NativeName("XR_WINDING_ORDER_UNKNOWN_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    Unknown = 0,

    [NativeName("XR_WINDING_ORDER_CW_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    Cw = 1,

    [NativeName("XR_WINDING_ORDER_CCW_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_composition_layer_passthrough_mesh"])]
    Ccw = 2,
}
