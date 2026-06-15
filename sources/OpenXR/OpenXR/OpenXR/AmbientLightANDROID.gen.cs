// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrAmbientLightANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct AmbientLightANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    public StructureType Type = StructureType.TypeAmbientLightANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    public void* Next;

    [NativeName("state")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    public LightEstimateStateANDROID State;

    [NativeName("intensity")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    public Vector3F Intensity;

    [NativeName("colorCorrection")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    public Vector3F ColorCorrection;

    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    public AmbientLightANDROID() { }
}
