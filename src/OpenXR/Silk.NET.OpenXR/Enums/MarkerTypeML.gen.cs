// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrMarkerTypeML")]
    public enum MarkerTypeML : int
    {
        [Obsolete("Deprecated in favour of \"ArucoML\"")]
        [NativeName("Name", "XR_MARKER_TYPE_ARUCO_ML")]
        MarkerTypeArucoML = 0,
        [Obsolete("Deprecated in favour of \"AprilTagML\"")]
        [NativeName("Name", "XR_MARKER_TYPE_APRIL_TAG_ML")]
        MarkerTypeAprilTagML = 1,
        [Obsolete("Deprecated in favour of \"QRML\"")]
        [NativeName("Name", "XR_MARKER_TYPE_QR_ML")]
        MarkerTypeQRML = 2,
        [Obsolete("Deprecated in favour of \"Ean13ML\"")]
        [NativeName("Name", "XR_MARKER_TYPE_EAN_13_ML")]
        MarkerTypeEan13ML = 3,
        [Obsolete("Deprecated in favour of \"UpcAML\"")]
        [NativeName("Name", "XR_MARKER_TYPE_UPC_A_ML")]
        MarkerTypeUpcAML = 4,
        [Obsolete("Deprecated in favour of \"Code128ML\"")]
        [NativeName("Name", "XR_MARKER_TYPE_CODE_128_ML")]
        MarkerTypeCode128ML = 5,
        [NativeName("Name", "XR_MARKER_TYPE_ARUCO_ML")]
        ArucoML = 0,
        [NativeName("Name", "XR_MARKER_TYPE_APRIL_TAG_ML")]
        AprilTagML = 1,
        [NativeName("Name", "XR_MARKER_TYPE_QR_ML")]
        QRML = 2,
        [NativeName("Name", "XR_MARKER_TYPE_EAN_13_ML")]
        Ean13ML = 3,
        [NativeName("Name", "XR_MARKER_TYPE_UPC_A_ML")]
        UpcAML = 4,
        [NativeName("Name", "XR_MARKER_TYPE_CODE_128_ML")]
        Code128ML = 5,
    }
}
