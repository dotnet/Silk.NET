// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrEyeCalibrationStatusML")]
    public enum EyeCalibrationStatusML : int
    {
        [Obsolete("Deprecated in favour of \"UnknownML\"")]
        [NativeName("Name", "XR_EYE_CALIBRATION_STATUS_UNKNOWN_ML")]
        EyeCalibrationStatusUnknownML = 0,
        [Obsolete("Deprecated in favour of \"NoneML\"")]
        [NativeName("Name", "XR_EYE_CALIBRATION_STATUS_NONE_ML")]
        EyeCalibrationStatusNoneML = 1,
        [Obsolete("Deprecated in favour of \"CoarseML\"")]
        [NativeName("Name", "XR_EYE_CALIBRATION_STATUS_COARSE_ML")]
        EyeCalibrationStatusCoarseML = 2,
        [Obsolete("Deprecated in favour of \"FineML\"")]
        [NativeName("Name", "XR_EYE_CALIBRATION_STATUS_FINE_ML")]
        EyeCalibrationStatusFineML = 3,
        [NativeName("Name", "XR_EYE_CALIBRATION_STATUS_UNKNOWN_ML")]
        UnknownML = 0,
        [NativeName("Name", "XR_EYE_CALIBRATION_STATUS_NONE_ML")]
        NoneML = 1,
        [NativeName("Name", "XR_EYE_CALIBRATION_STATUS_COARSE_ML")]
        CoarseML = 2,
        [NativeName("Name", "XR_EYE_CALIBRATION_STATUS_FINE_ML")]
        FineML = 3,
    }
}
