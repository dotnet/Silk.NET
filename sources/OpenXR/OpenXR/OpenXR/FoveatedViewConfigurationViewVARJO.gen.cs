// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFoveatedViewConfigurationViewVARJO")]
[SupportedApiProfile("openxr")]
public unsafe partial struct FoveatedViewConfigurationViewVARJO
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_foveated_rendering"],
        ImpliesSets = ["XR_VARJO_quad_views", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.FoveatedViewConfigurationViewVARJO;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_foveated_rendering"],
        ImpliesSets = ["XR_VARJO_quad_views", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("foveatedRenderingActive")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_foveated_rendering"],
        ImpliesSets = ["XR_VARJO_quad_views", "XR_VERSION_1_0"]
    )]
    public MaybeBool<uint> FoveatedRenderingActive;

    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_foveated_rendering"],
        ImpliesSets = ["XR_VARJO_quad_views", "XR_VERSION_1_0"]
    )]
    public FoveatedViewConfigurationViewVARJO() { }
}
