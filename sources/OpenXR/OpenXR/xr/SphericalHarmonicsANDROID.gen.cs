// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSphericalHarmonicsANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SphericalHarmonicsANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    public StructureType Type = StructureType.SphericalHarmonicsANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    public void* Next;

    [NativeName("state")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    public LightEstimateStateANDROID State;

    [NativeName("kind")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    public SphericalHarmonicsKindANDROID Kind;

    [NativeName("coefficients")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    public SphericalHarmonicsANDROIDCoefficients Coefficients;

    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    public SphericalHarmonicsANDROID() { }
}
