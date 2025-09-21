// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialEntityTrackingStateEXT")]
    public enum SpatialEntityTrackingStateEXT : int
    {
        [Obsolete("Deprecated in favour of \"StoppedExt\"")]
        [NativeName("Name", "XR_SPATIAL_ENTITY_TRACKING_STATE_STOPPED_EXT")]
        SpatialEntityTrackingStateStoppedExt = 1,
        [Obsolete("Deprecated in favour of \"PausedExt\"")]
        [NativeName("Name", "XR_SPATIAL_ENTITY_TRACKING_STATE_PAUSED_EXT")]
        SpatialEntityTrackingStatePausedExt = 2,
        [Obsolete("Deprecated in favour of \"TrackingExt\"")]
        [NativeName("Name", "XR_SPATIAL_ENTITY_TRACKING_STATE_TRACKING_EXT")]
        SpatialEntityTrackingStateTrackingExt = 3,
        [NativeName("Name", "XR_SPATIAL_ENTITY_TRACKING_STATE_STOPPED_EXT")]
        StoppedExt = 1,
        [NativeName("Name", "XR_SPATIAL_ENTITY_TRACKING_STATE_PAUSED_EXT")]
        PausedExt = 2,
        [NativeName("Name", "XR_SPATIAL_ENTITY_TRACKING_STATE_TRACKING_EXT")]
        TrackingExt = 3,
    }
}
