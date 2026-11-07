// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughKeyboardHandsIntensityFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct PassthroughKeyboardHandsIntensityFB
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_passthrough_keyboard_hands"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.PassthroughKeyboardHandsIntensityFB;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_passthrough_keyboard_hands"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("leftHandIntensity")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_passthrough_keyboard_hands"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public float LeftHandIntensity;

    [NativeName("rightHandIntensity")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_passthrough_keyboard_hands"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public float RightHandIntensity;

    [SupportedApiProfile(
        "openxr",
        ["XR_FB_passthrough_keyboard_hands"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public PassthroughKeyboardHandsIntensityFB() { }
}
