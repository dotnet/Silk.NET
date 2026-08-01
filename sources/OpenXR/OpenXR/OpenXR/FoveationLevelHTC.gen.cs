// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFoveationLevelHTC")]
[SupportedApiProfile("openxr")]
public enum FoveationLevelHTC : uint
{
    [NativeName("XR_FOVEATION_LEVEL_NONE_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    None = 0,

    [NativeName("XR_FOVEATION_LEVEL_LOW_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    Low = 1,

    [NativeName("XR_FOVEATION_LEVEL_MEDIUM_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    Medium = 2,

    [NativeName("XR_FOVEATION_LEVEL_HIGH_HTC")]
    [SupportedApiProfile("openxr", ["XR_HTC_foveation"])]
    High = 3,
}
