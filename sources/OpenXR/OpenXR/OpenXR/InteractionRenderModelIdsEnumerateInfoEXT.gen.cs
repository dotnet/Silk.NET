// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrInteractionRenderModelIdsEnumerateInfoEXT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct InteractionRenderModelIdsEnumerateInfoEXT
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_interaction_render_model"],
        ImpliesSets = ["XR_EXT_render_model"]
    )]
    public StructureType Type = StructureType.TypeInteractionRenderModelIdsEnumerateInfoEXT;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_interaction_render_model"],
        ImpliesSets = ["XR_EXT_render_model"]
    )]
    public void* Next;

    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_interaction_render_model"],
        ImpliesSets = ["XR_EXT_render_model"]
    )]
    public InteractionRenderModelIdsEnumerateInfoEXT() { }
}
