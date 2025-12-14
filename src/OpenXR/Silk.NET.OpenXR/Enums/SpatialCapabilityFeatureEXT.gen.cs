// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialCapabilityFeatureEXT")]
    public enum SpatialCapabilityFeatureEXT : int
    {
        [Obsolete("Deprecated in favour of \"FixedSizeMarkersExt\"")]
        [NativeName("Name", "XR_SPATIAL_CAPABILITY_FEATURE_MARKER_TRACKING_FIXED_SIZE_MARKERS_EXT")]
        SpatialCapabilityFeatureMarkerTrackingFixedSizeMarkersExt = 1000743000,
        [Obsolete("Deprecated in favour of \"StaticMarkersExt\"")]
        [NativeName("Name", "XR_SPATIAL_CAPABILITY_FEATURE_MARKER_TRACKING_STATIC_MARKERS_EXT")]
        SpatialCapabilityFeatureMarkerTrackingStaticMarkersExt = 1000743001,
        [NativeName("Name", "XR_SPATIAL_CAPABILITY_FEATURE_MARKER_TRACKING_FIXED_SIZE_MARKERS_EXT")]
        FixedSizeMarkersExt = 1000743000,
        [NativeName("Name", "XR_SPATIAL_CAPABILITY_FEATURE_MARKER_TRACKING_STATIC_MARKERS_EXT")]
        StaticMarkersExt = 1000743001,
    }
}
