// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialPersistenceScopeEXT")]
[SupportedApiProfile("openxr")]
public enum SpatialPersistenceScopeEXT : uint
{
    [NativeName("XR_SPATIAL_PERSISTENCE_SCOPE_SYSTEM_MANAGED_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_entity"]
    )]
    SystemManaged = 1,

    [NativeName("XR_SPATIAL_PERSISTENCE_SCOPE_LOCAL_ANCHORS_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_persistence_operations"],
        ImpliesSets = ["XR_EXT_future", "XR_EXT_spatial_persistence"]
    )]
    LocalAnchors = 1000781000,
}
