// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrEventDataPassthroughLayerResumedMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct EventDataPassthroughLayerResumedMETA
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_layer_resumed_event"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.TypeEventDataPassthroughLayerResumedMETA;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_layer_resumed_event"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("layer")]
    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_layer_resumed_event"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public PassthroughLayerHandleFB Layer;

    [SupportedApiProfile(
        "openxr",
        ["XR_META_passthrough_layer_resumed_event"],
        ImpliesSets = ["XR_FB_passthrough", "XR_VERSION_1_0"]
    )]
    public EventDataPassthroughLayerResumedMETA() { }
}
