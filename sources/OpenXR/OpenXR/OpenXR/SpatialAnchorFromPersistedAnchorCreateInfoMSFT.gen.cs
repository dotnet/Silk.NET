// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialAnchorFromPersistedAnchorCreateInfoMSFT")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SpatialAnchorFromPersistedAnchorCreateInfoMSFT
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_spatial_anchor_persistence"],
        ImpliesSets = ["XR_MSFT_spatial_anchor", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.SpatialAnchorFromPersistedAnchorCreateInfoMSFT;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_spatial_anchor_persistence"],
        ImpliesSets = ["XR_MSFT_spatial_anchor", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("spatialAnchorStore")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_spatial_anchor_persistence"],
        ImpliesSets = ["XR_MSFT_spatial_anchor", "XR_VERSION_1_0"]
    )]
    public SpatialAnchorStoreConnectionHandleMSFT SpatialAnchorStore;

    [NativeName("spatialAnchorPersistenceName")]
    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_spatial_anchor_persistence"],
        ImpliesSets = ["XR_MSFT_spatial_anchor", "XR_VERSION_1_0"]
    )]
    public SpatialAnchorPersistenceNameMSFT SpatialAnchorPersistenceName;

    [SupportedApiProfile(
        "openxr",
        ["XR_MSFT_spatial_anchor_persistence"],
        ImpliesSets = ["XR_MSFT_spatial_anchor", "XR_VERSION_1_0"]
    )]
    public SpatialAnchorFromPersistedAnchorCreateInfoMSFT() { }
}
