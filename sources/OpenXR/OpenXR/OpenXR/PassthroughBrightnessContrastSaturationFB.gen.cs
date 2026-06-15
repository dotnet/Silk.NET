// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughBrightnessContrastSaturationFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct PassthroughBrightnessContrastSaturationFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public StructureType Type = StructureType.TypePassthroughBrightnessContrastSaturationFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public void* Next;

    [NativeName("brightness")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public float Brightness;

    [NativeName("contrast")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public float Contrast;

    [NativeName("saturation")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public float Saturation;

    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public PassthroughBrightnessContrastSaturationFB() { }
}
