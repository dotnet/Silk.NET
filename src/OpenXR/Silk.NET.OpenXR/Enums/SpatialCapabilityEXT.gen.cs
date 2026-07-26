// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialCapabilityEXT")]
    public enum SpatialCapabilityEXT : int
    {
        [Obsolete("Deprecated in favour of \"PlaneTrackingExt\"")]
        [NativeName("Name", "XR_SPATIAL_CAPABILITY_PLANE_TRACKING_EXT")]
        SpatialCapabilityPlaneTrackingExt = 1000741000,
        [Obsolete("Deprecated in favour of \"MarkerTrackingQRCodeExt\"")]
        [NativeName("Name", "XR_SPATIAL_CAPABILITY_MARKER_TRACKING_QR_CODE_EXT")]
        SpatialCapabilityMarkerTrackingQRCodeExt = 1000743000,
        [Obsolete("Deprecated in favour of \"MarkerTrackingMicroQRCodeExt\"")]
        [NativeName("Name", "XR_SPATIAL_CAPABILITY_MARKER_TRACKING_MICRO_QR_CODE_EXT")]
        SpatialCapabilityMarkerTrackingMicroQRCodeExt = 1000743001,
        [Obsolete("Deprecated in favour of \"MarkerTrackingArucoMarkerExt\"")]
        [NativeName("Name", "XR_SPATIAL_CAPABILITY_MARKER_TRACKING_ARUCO_MARKER_EXT")]
        SpatialCapabilityMarkerTrackingArucoMarkerExt = 1000743002,
        [Obsolete("Deprecated in favour of \"MarkerTrackingAprilTagExt\"")]
        [NativeName("Name", "XR_SPATIAL_CAPABILITY_MARKER_TRACKING_APRIL_TAG_EXT")]
        SpatialCapabilityMarkerTrackingAprilTagExt = 1000743003,
        [Obsolete("Deprecated in favour of \"AnchorExt\"")]
        [NativeName("Name", "XR_SPATIAL_CAPABILITY_ANCHOR_EXT")]
        SpatialCapabilityAnchorExt = 1000762000,
        [NativeName("Name", "XR_SPATIAL_CAPABILITY_PLANE_TRACKING_EXT")]
        PlaneTrackingExt = 1000741000,
        [NativeName("Name", "XR_SPATIAL_CAPABILITY_MARKER_TRACKING_QR_CODE_EXT")]
        MarkerTrackingQRCodeExt = 1000743000,
        [NativeName("Name", "XR_SPATIAL_CAPABILITY_MARKER_TRACKING_MICRO_QR_CODE_EXT")]
        MarkerTrackingMicroQRCodeExt = 1000743001,
        [NativeName("Name", "XR_SPATIAL_CAPABILITY_MARKER_TRACKING_ARUCO_MARKER_EXT")]
        MarkerTrackingArucoMarkerExt = 1000743002,
        [NativeName("Name", "XR_SPATIAL_CAPABILITY_MARKER_TRACKING_APRIL_TAG_EXT")]
        MarkerTrackingAprilTagExt = 1000743003,
        [NativeName("Name", "XR_SPATIAL_CAPABILITY_ANCHOR_EXT")]
        AnchorExt = 1000762000,
    }
}
