// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrReprojectionModeMSFT")]
    public enum ReprojectionModeMSFT : int
    {
        [Obsolete("Deprecated in favour of \"DepthMsft\"")]
        [NativeName("Name", "XR_REPROJECTION_MODE_DEPTH_MSFT")]
        ReprojectionModeDepthMsft = 1,
        [Obsolete("Deprecated in favour of \"PlanarFromDepthMsft\"")]
        [NativeName("Name", "XR_REPROJECTION_MODE_PLANAR_FROM_DEPTH_MSFT")]
        ReprojectionModePlanarFromDepthMsft = 2,
        [Obsolete("Deprecated in favour of \"PlanarManualMsft\"")]
        [NativeName("Name", "XR_REPROJECTION_MODE_PLANAR_MANUAL_MSFT")]
        ReprojectionModePlanarManualMsft = 3,
        [Obsolete("Deprecated in favour of \"OrientationOnlyMsft\"")]
        [NativeName("Name", "XR_REPROJECTION_MODE_ORIENTATION_ONLY_MSFT")]
        ReprojectionModeOrientationOnlyMsft = 4,
        [NativeName("Name", "XR_REPROJECTION_MODE_DEPTH_MSFT")]
        DepthMsft = 1,
        [NativeName("Name", "XR_REPROJECTION_MODE_PLANAR_FROM_DEPTH_MSFT")]
        PlanarFromDepthMsft = 2,
        [NativeName("Name", "XR_REPROJECTION_MODE_PLANAR_MANUAL_MSFT")]
        PlanarManualMsft = 3,
        [NativeName("Name", "XR_REPROJECTION_MODE_ORIENTATION_ONLY_MSFT")]
        OrientationOnlyMsft = 4,
    }
}
