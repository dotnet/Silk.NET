// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFoveationDynamicFB")]
[SupportedApiProfile("openxr")]
public enum FoveationDynamicFB : uint
{
    [NativeName("XR_FOVEATION_DYNAMIC_DISABLED_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_configuration"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    Disabled = 0,

    [NativeName("XR_FOVEATION_DYNAMIC_LEVEL_ENABLED_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_configuration"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    LevelEnabled = 1,
}
