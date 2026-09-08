// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrLightEstimateStateANDROID")]
[SupportedApiProfile("openxr")]
public enum LightEstimateStateANDROID : uint
{
    [NativeName("XR_LIGHT_ESTIMATE_STATE_VALID_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    Valid = 0,

    [NativeName("XR_LIGHT_ESTIMATE_STATE_INVALID_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    Invalid = 1,
}
