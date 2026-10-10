// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrMarkerDetectorCameraML")]
[SupportedApiProfile("openxr")]
public enum MarkerDetectorCameraML : uint
{
    [NativeName("XR_MARKER_DETECTOR_CAMERA_RGB_CAMERA_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    RgbCamera = 0,

    [NativeName("XR_MARKER_DETECTOR_CAMERA_WORLD_CAMERAS_ML")]
    [SupportedApiProfile("openxr", ["XR_ML_marker_understanding"])]
    WorldCameras = 1,
}
