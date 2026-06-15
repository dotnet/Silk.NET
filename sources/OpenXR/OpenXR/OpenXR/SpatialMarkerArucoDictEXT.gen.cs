// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialMarkerArucoDictEXT")]
[SupportedApiProfile("openxr")]
public enum SpatialMarkerArucoDictEXT : uint
{
    [NativeName("XR_SPATIAL_MARKER_ARUCO_DICT_4X4_50_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Dict4x4x50 = 1,

    [NativeName("XR_SPATIAL_MARKER_ARUCO_DICT_4X4_100_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Dict4x4x100 = 2,

    [NativeName("XR_SPATIAL_MARKER_ARUCO_DICT_4X4_250_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Dict4x4x250 = 3,

    [NativeName("XR_SPATIAL_MARKER_ARUCO_DICT_4X4_1000_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Dict4x4x1000 = 4,

    [NativeName("XR_SPATIAL_MARKER_ARUCO_DICT_5X5_50_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Dict5x5x50 = 5,

    [NativeName("XR_SPATIAL_MARKER_ARUCO_DICT_5X5_100_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Dict5x5x100 = 6,

    [NativeName("XR_SPATIAL_MARKER_ARUCO_DICT_5X5_250_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Dict5x5x250 = 7,

    [NativeName("XR_SPATIAL_MARKER_ARUCO_DICT_5X5_1000_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Dict5x5x1000 = 8,

    [NativeName("XR_SPATIAL_MARKER_ARUCO_DICT_6X6_50_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Dict6x6x50 = 9,

    [NativeName("XR_SPATIAL_MARKER_ARUCO_DICT_6X6_100_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Dict6x6x100 = 10,

    [NativeName("XR_SPATIAL_MARKER_ARUCO_DICT_6X6_250_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Dict6x6x250 = 11,

    [NativeName("XR_SPATIAL_MARKER_ARUCO_DICT_6X6_1000_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Dict6x6x1000 = 12,

    [NativeName("XR_SPATIAL_MARKER_ARUCO_DICT_7X7_50_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Dict7x7x50 = 13,

    [NativeName("XR_SPATIAL_MARKER_ARUCO_DICT_7X7_100_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Dict7x7x100 = 14,

    [NativeName("XR_SPATIAL_MARKER_ARUCO_DICT_7X7_250_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Dict7x7x250 = 15,

    [NativeName("XR_SPATIAL_MARKER_ARUCO_DICT_7X7_1000_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Dict7x7x1000 = 16,
}
