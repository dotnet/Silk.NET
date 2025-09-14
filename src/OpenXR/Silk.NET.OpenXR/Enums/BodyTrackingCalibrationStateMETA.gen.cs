// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrBodyTrackingCalibrationStateMETA")]
    public enum BodyTrackingCalibrationStateMETA : int
    {
        [Obsolete("Deprecated in favour of \"ValidMeta\"")]
        [NativeName("Name", "XR_BODY_TRACKING_CALIBRATION_STATE_VALID_META")]
        BodyTrackingCalibrationStateValidMeta = 1,
        [Obsolete("Deprecated in favour of \"CalibratingMeta\"")]
        [NativeName("Name", "XR_BODY_TRACKING_CALIBRATION_STATE_CALIBRATING_META")]
        BodyTrackingCalibrationStateCalibratingMeta = 2,
        [Obsolete("Deprecated in favour of \"InvalidMeta\"")]
        [NativeName("Name", "XR_BODY_TRACKING_CALIBRATION_STATE_INVALID_META")]
        BodyTrackingCalibrationStateInvalidMeta = 3,
        [NativeName("Name", "XR_BODY_TRACKING_CALIBRATION_STATE_VALID_META")]
        ValidMeta = 1,
        [NativeName("Name", "XR_BODY_TRACKING_CALIBRATION_STATE_CALIBRATING_META")]
        CalibratingMeta = 2,
        [NativeName("Name", "XR_BODY_TRACKING_CALIBRATION_STATE_INVALID_META")]
        InvalidMeta = 3,
    }
}
