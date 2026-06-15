// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrRect3DfFB")]
[SupportedApiProfile("openxr")]
public partial struct Rect3DfFB
{
    [NativeName("offset")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public Offset3DfFB Offset;

    [NativeName("extent")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_scene"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    public Extent3Df Extent;
}
