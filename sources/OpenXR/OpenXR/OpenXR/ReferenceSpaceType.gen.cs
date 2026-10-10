// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrReferenceSpaceType")]
[SupportedApiProfile("openxr")]
public enum ReferenceSpaceType : uint
{
    [NativeName("XR_REFERENCE_SPACE_TYPE_VIEW")]
    [SupportedApiProfile("openxr")]
    View = 1,

    [NativeName("XR_REFERENCE_SPACE_TYPE_LOCAL")]
    [SupportedApiProfile("openxr")]
    Local = 2,

    [NativeName("XR_REFERENCE_SPACE_TYPE_STAGE")]
    [SupportedApiProfile("openxr")]
    Stage = 3,

    [NativeName("XR_REFERENCE_SPACE_TYPE_LOCAL_FLOOR")]
    [SupportedApiProfile("openxr", ["XR_VERSION_1_1"], MinVersion = "1.1")]
    LocalFloor = 1000426000,

    [NativeName("XR_REFERENCE_SPACE_TYPE_UNBOUNDED_MSFT")]
    [SupportedApiProfile("openxr", ["XR_MSFT_unbounded_reference_space"])]
    UnboundedMSFT = 1000038000,

    [NativeName("XR_REFERENCE_SPACE_TYPE_COMBINED_EYE_VARJO")]
    [SupportedApiProfile(
        "openxr",
        ["XR_VARJO_foveated_rendering"],
        ImpliesSets = ["XR_VARJO_quad_views", "XR_VERSION_1_0"]
    )]
    CombinedEyeVARJO = 1000121000,

    [NativeName("XR_REFERENCE_SPACE_TYPE_LOCALIZATION_MAP_ML")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ML_localization_map"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    LocalizationMapML = 1000139000,

    [NativeName("XR_REFERENCE_SPACE_TYPE_UNBOUNDED_ANDROID")]
    [SupportedApiProfile("openxr", ["XR_ANDROID_unbounded_reference_space"])]
    UnboundedANDROID = 1000467000,

    [NativeName("XR_REFERENCE_SPACE_TYPE_STATIONARY_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_stationary_reference_space"],
        ImpliesSets = ["XR_EXT_uuid", "XR_VERSION_1_0"]
    )]
    StationaryEXT = 1000742000,

    [NativeName("XR_REFERENCE_SPACE_TYPE_LOCAL_FLOOR_EXT")]
    [SupportedApiProfile("openxr", ["XR_EXT_local_floor"])]
    LocalFloorEXT = LocalFloor,
}
