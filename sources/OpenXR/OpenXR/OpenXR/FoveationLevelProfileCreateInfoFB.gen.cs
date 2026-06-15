// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFoveationLevelProfileCreateInfoFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FoveationLevelProfileCreateInfoFB
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_configuration"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.TypeFoveationLevelProfileCreateInfoFB;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_configuration"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("level")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_configuration"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    public FoveationLevelFB Level;

    [NativeName("verticalOffset")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_configuration"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    public float VerticalOffset;

    [NativeName("dynamic")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_configuration"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    public FoveationDynamicFB Dynamic;

    [SupportedApiProfile(
        "openxr",
        ["XR_FB_foveation_configuration"],
        ImpliesSets = ["XR_FB_foveation", "XR_VERSION_1_0"]
    )]
    public FoveationLevelProfileCreateInfoFB() { }
}
