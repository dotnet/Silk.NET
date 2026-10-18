// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSphericalHarmonicsKindANDROID")]
[SupportedApiProfile("openxr")]
public enum SphericalHarmonicsKindANDROID : uint
{
    [NativeName("XR_SPHERICAL_HARMONICS_KIND_TOTAL_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    Total = 0,

    [NativeName("XR_SPHERICAL_HARMONICS_KIND_AMBIENT_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_light_estimation"])]
    Ambient = 1,
}
