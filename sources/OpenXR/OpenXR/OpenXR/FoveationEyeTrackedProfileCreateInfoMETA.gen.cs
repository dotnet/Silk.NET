// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFoveationEyeTrackedProfileCreateInfoMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FoveationEyeTrackedProfileCreateInfoMETA
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_foveation_eye_tracked"],
        ImpliesSets = ["XR_FB_foveation", "XR_FB_foveation_configuration", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.TypeFoveationEyeTrackedProfileCreateInfoMETA;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_foveation_eye_tracked"],
        ImpliesSets = ["XR_FB_foveation", "XR_FB_foveation_configuration", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("flags")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_foveation_eye_tracked"],
        ImpliesSets = ["XR_FB_foveation", "XR_FB_foveation_configuration", "XR_VERSION_1_0"]
    )]
    public FoveationEyeTrackedProfileCreateFlagsMETA Flags;

    [SupportedApiProfile(
        "openxr",
        ["XR_META_foveation_eye_tracked"],
        ImpliesSets = ["XR_FB_foveation", "XR_FB_foveation_configuration", "XR_VERSION_1_0"]
    )]
    public FoveationEyeTrackedProfileCreateInfoMETA() { }
}
