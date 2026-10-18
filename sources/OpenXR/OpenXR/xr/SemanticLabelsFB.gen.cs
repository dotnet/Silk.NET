// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSemanticLabelsFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SemanticLabelsFB
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.SemanticLabelsFB;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("bufferCapacityInput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public uint BufferCapacityInput;

    [NativeName("bufferCountOutput")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public uint BufferCountOutput;

    [NativeName("buffer")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public sbyte* Buffer;

    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public SemanticLabelsFB() { }
}
