// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPlaneDetectionStateEXT")]
    public enum PlaneDetectionStateEXT : int
    {
        [Obsolete("Deprecated in favour of \"NoneExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTION_STATE_NONE_EXT")]
        PlaneDetectionStateNoneExt = 0,
        [Obsolete("Deprecated in favour of \"PendingExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTION_STATE_PENDING_EXT")]
        PlaneDetectionStatePendingExt = 1,
        [Obsolete("Deprecated in favour of \"DoneExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTION_STATE_DONE_EXT")]
        PlaneDetectionStateDoneExt = 2,
        [Obsolete("Deprecated in favour of \"ErrorExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTION_STATE_ERROR_EXT")]
        PlaneDetectionStateErrorExt = 3,
        [Obsolete("Deprecated in favour of \"FatalExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTION_STATE_FATAL_EXT")]
        PlaneDetectionStateFatalExt = 4,
        [NativeName("Name", "XR_PLANE_DETECTION_STATE_NONE_EXT")]
        NoneExt = 0,
        [NativeName("Name", "XR_PLANE_DETECTION_STATE_PENDING_EXT")]
        PendingExt = 1,
        [NativeName("Name", "XR_PLANE_DETECTION_STATE_DONE_EXT")]
        DoneExt = 2,
        [NativeName("Name", "XR_PLANE_DETECTION_STATE_ERROR_EXT")]
        ErrorExt = 3,
        [NativeName("Name", "XR_PLANE_DETECTION_STATE_FATAL_EXT")]
        FatalExt = 4,
    }
}
