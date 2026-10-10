// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialCapabilityEXT")]
[SupportedApiProfile("openxr")]
public enum SpatialCapabilityEXT : uint
{
    [NativeName("XR_SPATIAL_CAPABILITY_PLANE_TRACKING_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_plane_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    PlaneTracking = 1000741000,

    [NativeName("XR_SPATIAL_CAPABILITY_MARKER_TRACKING_QR_CODE_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    MarkerTrackingQrCode = 1000743000,

    [NativeName("XR_SPATIAL_CAPABILITY_MARKER_TRACKING_MICRO_QR_CODE_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    MarkerTrackingMicroQrCode = 1000743001,

    [NativeName("XR_SPATIAL_CAPABILITY_MARKER_TRACKING_ARUCO_MARKER_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    MarkerTrackingArucoMarker = 1000743002,

    [NativeName("XR_SPATIAL_CAPABILITY_MARKER_TRACKING_APRIL_TAG_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_marker_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    MarkerTrackingAprilTag = 1000743003,

    [NativeName("XR_SPATIAL_CAPABILITY_ANCHOR_EXT")]
    [SupportedApiProfile(
        "openxr",
        ["XR_EXT_spatial_anchor"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    Anchor = 1000762000,

    [NativeName("XR_SPATIAL_CAPABILITY_OBJECT_TRACKING_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_object_tracking"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    ObjectTrackingANDROID = 1000785000,

    [NativeName("XR_SPATIAL_CAPABILITY_DEPTH_RAYCAST_ANDROID")]
    [SupportedApiProfile(
        "openxr",
        ["XR_ANDROID_spatial_discovery_raycast"],
        ImpliesSets = ["XR_EXT_spatial_entity"]
    )]
    DepthRaycastANDROID = 1000786000,
}
