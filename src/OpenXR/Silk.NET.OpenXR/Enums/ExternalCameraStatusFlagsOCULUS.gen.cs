// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrExternalCameraStatusFlagsOCULUS")]
    public enum ExternalCameraStatusFlagsOCULUS : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ConnectedBitOculus\"")]
        [NativeName("Name", "XR_EXTERNAL_CAMERA_STATUS_CONNECTED_BIT_OCULUS")]
        ExternalCameraStatusConnectedBitOculus = 1,
        [Obsolete("Deprecated in favour of \"CalibratingBitOculus\"")]
        [NativeName("Name", "XR_EXTERNAL_CAMERA_STATUS_CALIBRATING_BIT_OCULUS")]
        ExternalCameraStatusCalibratingBitOculus = 2,
        [Obsolete("Deprecated in favour of \"CalibrationFailedBitOculus\"")]
        [NativeName("Name", "XR_EXTERNAL_CAMERA_STATUS_CALIBRATION_FAILED_BIT_OCULUS")]
        ExternalCameraStatusCalibrationFailedBitOculus = 4,
        [Obsolete("Deprecated in favour of \"CalibratedBitOculus\"")]
        [NativeName("Name", "XR_EXTERNAL_CAMERA_STATUS_CALIBRATED_BIT_OCULUS")]
        ExternalCameraStatusCalibratedBitOculus = 8,
        [Obsolete("Deprecated in favour of \"CapturingBitOculus\"")]
        [NativeName("Name", "XR_EXTERNAL_CAMERA_STATUS_CAPTURING_BIT_OCULUS")]
        ExternalCameraStatusCapturingBitOculus = 16,
        [NativeName("Name", "XR_EXTERNAL_CAMERA_STATUS_CONNECTED_BIT_OCULUS")]
        ConnectedBitOculus = 1,
        [NativeName("Name", "XR_EXTERNAL_CAMERA_STATUS_CALIBRATING_BIT_OCULUS")]
        CalibratingBitOculus = 2,
        [NativeName("Name", "XR_EXTERNAL_CAMERA_STATUS_CALIBRATION_FAILED_BIT_OCULUS")]
        CalibrationFailedBitOculus = 4,
        [NativeName("Name", "XR_EXTERNAL_CAMERA_STATUS_CALIBRATED_BIT_OCULUS")]
        CalibratedBitOculus = 8,
        [NativeName("Name", "XR_EXTERNAL_CAMERA_STATUS_CAPTURING_BIT_OCULUS")]
        CapturingBitOculus = 16,
    }
}
