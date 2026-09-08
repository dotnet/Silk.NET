// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrMarkerArucoDictML")]
[SupportedApiProfile("openxr")]
public enum MarkerArucoDictML : uint
{
    [NativeName("XR_MARKER_ARUCO_DICT_4X4_50_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict4x4x50 = 0,

    [NativeName("XR_MARKER_ARUCO_DICT_4X4_100_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict4x4x100 = 1,

    [NativeName("XR_MARKER_ARUCO_DICT_4X4_250_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict4x4x250 = 2,

    [NativeName("XR_MARKER_ARUCO_DICT_4X4_1000_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict4x4x1000 = 3,

    [NativeName("XR_MARKER_ARUCO_DICT_5X5_50_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict5x5x50 = 4,

    [NativeName("XR_MARKER_ARUCO_DICT_5X5_100_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict5x5x100 = 5,

    [NativeName("XR_MARKER_ARUCO_DICT_5X5_250_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict5x5x250 = 6,

    [NativeName("XR_MARKER_ARUCO_DICT_5X5_1000_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict5x5x1000 = 7,

    [NativeName("XR_MARKER_ARUCO_DICT_6X6_50_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict6x6x50 = 8,

    [NativeName("XR_MARKER_ARUCO_DICT_6X6_100_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict6x6x100 = 9,

    [NativeName("XR_MARKER_ARUCO_DICT_6X6_250_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict6x6x250 = 10,

    [NativeName("XR_MARKER_ARUCO_DICT_6X6_1000_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict6x6x1000 = 11,

    [NativeName("XR_MARKER_ARUCO_DICT_7X7_50_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict7x7x50 = 12,

    [NativeName("XR_MARKER_ARUCO_DICT_7X7_100_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict7x7x100 = 13,

    [NativeName("XR_MARKER_ARUCO_DICT_7X7_250_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict7x7x250 = 14,

    [NativeName("XR_MARKER_ARUCO_DICT_7X7_1000_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    Dict7x7x1000 = 15,
}
