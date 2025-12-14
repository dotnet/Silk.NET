// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrTrackableMarkerTrackingModeANDROID")]
    public enum TrackableMarkerTrackingModeANDROID : int
    {
        [Obsolete("Deprecated in favour of \"DynamicAndroid\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_TRACKING_MODE_DYNAMIC_ANDROID")]
        TrackableMarkerTrackingModeDynamicAndroid = 0,
        [Obsolete("Deprecated in favour of \"StaticAndroid\"")]
        [NativeName("Name", "XR_TRACKABLE_MARKER_TRACKING_MODE_STATIC_ANDROID")]
        TrackableMarkerTrackingModeStaticAndroid = 1,
        [NativeName("Name", "XR_TRACKABLE_MARKER_TRACKING_MODE_DYNAMIC_ANDROID")]
        DynamicAndroid = 0,
        [NativeName("Name", "XR_TRACKABLE_MARKER_TRACKING_MODE_STATIC_ANDROID")]
        StaticAndroid = 1,
    }
}
