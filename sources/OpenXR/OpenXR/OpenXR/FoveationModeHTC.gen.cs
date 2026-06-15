// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFoveationModeHTC")]
[SupportedApiProfile("openxr")]
public enum FoveationModeHTC : uint
{
    [NativeName("XR_FOVEATION_MODE_DISABLE_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    Disable = 0,

    [NativeName("XR_FOVEATION_MODE_FIXED_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    Fixed = 1,

    [NativeName("XR_FOVEATION_MODE_DYNAMIC_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    Dynamic = 2,

    [NativeName("XR_FOVEATION_MODE_CUSTOM_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    Custom = 3,
}
