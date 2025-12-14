// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFaceTrackingStateANDROID")]
    public enum FaceTrackingStateANDROID : int
    {
        [Obsolete("Deprecated in favour of \"PausedAndroid\"")]
        [NativeName("Name", "XR_FACE_TRACKING_STATE_PAUSED_ANDROID")]
        FaceTrackingStatePausedAndroid = 0,
        [Obsolete("Deprecated in favour of \"StoppedAndroid\"")]
        [NativeName("Name", "XR_FACE_TRACKING_STATE_STOPPED_ANDROID")]
        FaceTrackingStateStoppedAndroid = 1,
        [Obsolete("Deprecated in favour of \"TrackingAndroid\"")]
        [NativeName("Name", "XR_FACE_TRACKING_STATE_TRACKING_ANDROID")]
        FaceTrackingStateTrackingAndroid = 2,
        [NativeName("Name", "XR_FACE_TRACKING_STATE_PAUSED_ANDROID")]
        PausedAndroid = 0,
        [NativeName("Name", "XR_FACE_TRACKING_STATE_STOPPED_ANDROID")]
        StoppedAndroid = 1,
        [NativeName("Name", "XR_FACE_TRACKING_STATE_TRACKING_ANDROID")]
        TrackingAndroid = 2,
    }
}
