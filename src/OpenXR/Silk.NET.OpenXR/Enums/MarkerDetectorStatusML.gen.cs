// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrMarkerDetectorStatusML")]
    public enum MarkerDetectorStatusML : int
    {
        [Obsolete("Deprecated in favour of \"PendingML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_STATUS_PENDING_ML")]
        MarkerDetectorStatusPendingML = 0,
        [Obsolete("Deprecated in favour of \"ReadyML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_STATUS_READY_ML")]
        MarkerDetectorStatusReadyML = 1,
        [Obsolete("Deprecated in favour of \"ErrorML\"")]
        [NativeName("Name", "XR_MARKER_DETECTOR_STATUS_ERROR_ML")]
        MarkerDetectorStatusErrorML = 2,
        [NativeName("Name", "XR_MARKER_DETECTOR_STATUS_PENDING_ML")]
        PendingML = 0,
        [NativeName("Name", "XR_MARKER_DETECTOR_STATUS_READY_ML")]
        ReadyML = 1,
        [NativeName("Name", "XR_MARKER_DETECTOR_STATUS_ERROR_ML")]
        ErrorML = 2,
    }
}
