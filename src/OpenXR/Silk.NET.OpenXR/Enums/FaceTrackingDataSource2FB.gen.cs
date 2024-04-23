// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFaceTrackingDataSource2FB")]
    public enum FaceTrackingDataSource2FB : int
    {
        [Obsolete("Deprecated in favour of \"VisualFB\"")]
        [NativeName("Name", "XR_FACE_TRACKING_DATA_SOURCE2_VISUAL_FB")]
        FaceTrackingDataSource2VisualFB = 0,
        [Obsolete("Deprecated in favour of \"AudioFB\"")]
        [NativeName("Name", "XR_FACE_TRACKING_DATA_SOURCE2_AUDIO_FB")]
        FaceTrackingDataSource2AudioFB = 1,
        [NativeName("Name", "XR_FACE_TRACKING_DATA_SOURCE2_VISUAL_FB")]
        VisualFB = 0,
        [NativeName("Name", "XR_FACE_TRACKING_DATA_SOURCE2_AUDIO_FB")]
        AudioFB = 1,
    }
}
