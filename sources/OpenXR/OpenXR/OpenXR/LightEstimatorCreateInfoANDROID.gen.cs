// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrLightEstimatorCreateInfoANDROID")]
[SupportedApiProfile("openxr")]
public unsafe partial struct LightEstimatorCreateInfoANDROID
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    public StructureType Type = StructureType.TypeLightEstimatorCreateInfoANDROID;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    public void* Next;

    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    public LightEstimatorCreateInfoANDROID() { }
}
