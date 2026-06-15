// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrExternalCameraStatusFlagsOCULUS")]
[Flags]
public enum ExternalCameraStatusFlagsOCULUS : ulong
{
    None = 0x0,

    [NativeName("XR_EXTERNAL_CAMERA_STATUS_CONNECTED_BIT_OCULUS")]
    ConnectedBit = 0x1,

    [NativeName("XR_EXTERNAL_CAMERA_STATUS_CALIBRATING_BIT_OCULUS")]
    CalibratingBit = 0x2,

    [NativeName("XR_EXTERNAL_CAMERA_STATUS_CALIBRATION_FAILED_BIT_OCULUS")]
    CalibrationFailedBit = 0x4,

    [NativeName("XR_EXTERNAL_CAMERA_STATUS_CALIBRATED_BIT_OCULUS")]
    CalibratedBit = 0x8,

    [NativeName("XR_EXTERNAL_CAMERA_STATUS_CAPTURING_BIT_OCULUS")]
    CapturingBit = 0x10,
}
