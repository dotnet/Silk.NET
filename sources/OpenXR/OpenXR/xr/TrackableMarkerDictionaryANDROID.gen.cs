// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrTrackableMarkerDictionaryANDROID")]
public enum TrackableMarkerDictionaryANDROID : uint
{
    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_4X4_50_ANDROID")]
    Aruco4x4x50 = 0,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_4X4_100_ANDROID")]
    Aruco4x4x100 = 1,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_4X4_250_ANDROID")]
    Aruco4x4x250 = 2,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_4X4_1000_ANDROID")]
    Aruco4x4x1000 = 3,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_5X5_50_ANDROID")]
    Aruco5x5x50 = 4,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_5X5_100_ANDROID")]
    Aruco5x5x100 = 5,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_5X5_250_ANDROID")]
    Aruco5x5x250 = 6,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_5X5_1000_ANDROID")]
    Aruco5x5x1000 = 7,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_6X6_50_ANDROID")]
    Aruco6x6x50 = 8,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_6X6_100_ANDROID")]
    Aruco6x6x100 = 9,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_6X6_250_ANDROID")]
    Aruco6x6x250 = 10,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_6X6_1000_ANDROID")]
    Aruco6x6x1000 = 11,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_7X7_50_ANDROID")]
    Aruco7x7x50 = 12,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_7X7_100_ANDROID")]
    Aruco7x7x100 = 13,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_7X7_250_ANDROID")]
    Aruco7x7x250 = 14,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_ARUCO_7X7_1000_ANDROID")]
    Aruco7x7x1000 = 15,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_APRILTAG_16H5_ANDROID")]
    Apriltag16H5 = 16,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_APRILTAG_25H9_ANDROID")]
    Apriltag25H9 = 17,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_APRILTAG_36H10_ANDROID")]
    Apriltag36H10 = 18,

    [NativeName("XR_TRACKABLE_MARKER_DICTIONARY_APRILTAG_36H11_ANDROID")]
    Apriltag36H11 = 19,
}
