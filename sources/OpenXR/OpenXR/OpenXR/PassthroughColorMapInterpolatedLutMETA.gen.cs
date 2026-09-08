// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughColorMapInterpolatedLutMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct PassthroughColorMapInterpolatedLutMETA
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.PassthroughColorMapInterpolatedLutMETA;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("sourceColorLut")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public PassthroughColorLutHandleMETA SourceColorLut;

    [NativeName("targetColorLut")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public PassthroughColorLutHandleMETA TargetColorLut;

    [NativeName("weight")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public float Weight;

    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_color_lut"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public PassthroughColorMapInterpolatedLutMETA() { }
}
