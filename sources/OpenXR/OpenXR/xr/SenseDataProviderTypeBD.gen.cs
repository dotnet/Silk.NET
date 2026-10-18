// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSenseDataProviderTypeBD")]
[SupportedApiProfile("openxr")]
public enum SenseDataProviderTypeBD : uint
{
    [NativeName("XR_SENSE_DATA_PROVIDER_TYPE_ANCHOR_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_anchor"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    Anchor = 1000390000,

    [NativeName("XR_SENSE_DATA_PROVIDER_TYPE_SCENE_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_scene"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    Scene = 1000392000,

    [NativeName("XR_SENSE_DATA_PROVIDER_TYPE_MESH_BD")]
    [SupportedApiProfile("openxr", ["XR_BD_spatial_mesh"], ImpliesSets = ["XR_BD_spatial_sensing"])]
    Mesh = 1000393000,

    [NativeName("XR_SENSE_DATA_PROVIDER_TYPE_PLANE_BD")]
    [SupportedApiProfile(
        "openxr",
        ["XR_BD_spatial_plane"],
        ImpliesSets = ["XR_BD_spatial_sensing"]
    )]
    Plane = 1000396000,
}
