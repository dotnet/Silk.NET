// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpaceStorageLocationFB")]
[SupportedApiProfile("openxr")]
public enum SpaceStorageLocationFB : uint
{
    [NativeName("XR_SPACE_STORAGE_LOCATION_INVALID_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    Invalid = 0,

    [NativeName("XR_SPACE_STORAGE_LOCATION_LOCAL_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    Local = 1,

    [NativeName("XR_SPACE_STORAGE_LOCATION_CLOUD_FB")]
    [SupportedApiProfile(
        "openxr",
        ["XR_FB_spatial_entity_storage"],
        ImpliesSets = ["XR_FB_spatial_entity", "XR_VERSION_1_0"]
    )]
    Cloud = 2,
}
