// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrMarkerDetectorCameraML")]
    public enum MarkerDetectorCameraML : int
    {
        [Obsolete("Deprecated in favour of \"RgbCameraML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_CAMERA_RGB_CAMERA_ML")]
        MarkerDetectorCameraRgbCameraML = 0,
        [Obsolete("Deprecated in favour of \"WorldCamerasML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_CAMERA_WORLD_CAMERAS_ML")]
        MarkerDetectorCameraWorldCamerasML = 1,
        [NativeName("Name", "XR_MARKER_DETECTOR_CAMERA_RGB_CAMERA_ML")]
        RgbCameraML = 0,
        [NativeName("Name", "XR_MARKER_DETECTOR_CAMERA_WORLD_CAMERAS_ML")]
        WorldCamerasML = 1,
    }
}
