// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSpatialCapabilityEXT")]
public enum SpatialCapabilityEXT : uint
{
    [NativeName("XR_SPATIAL_CAPABILITY_PLANE_TRACKING_EXT")]
    PlaneTracking = 1000741000,

    [NativeName("XR_SPATIAL_CAPABILITY_MARKER_TRACKING_QR_CODE_EXT")]
    MarkerTrackingQrCode = 1000743000,

    [NativeName("XR_SPATIAL_CAPABILITY_MARKER_TRACKING_MICRO_QR_CODE_EXT")]
    MarkerTrackingMicroQrCode = 1000743001,

    [NativeName("XR_SPATIAL_CAPABILITY_MARKER_TRACKING_ARUCO_MARKER_EXT")]
    MarkerTrackingArucoMarker = 1000743002,

    [NativeName("XR_SPATIAL_CAPABILITY_MARKER_TRACKING_APRIL_TAG_EXT")]
    MarkerTrackingAprilTag = 1000743003,

    [NativeName("XR_SPATIAL_CAPABILITY_ANCHOR_EXT")]
    Anchor = 1000762000,

    [NativeName("XR_SPATIAL_CAPABILITY_OBJECT_TRACKING_ANDROID")]
    ObjectTrackingANDROID = 1000785000,

    [NativeName("XR_SPATIAL_CAPABILITY_DEPTH_RAYCAST_ANDROID")]
    DepthRaycastANDROID = 1000786000,
}
