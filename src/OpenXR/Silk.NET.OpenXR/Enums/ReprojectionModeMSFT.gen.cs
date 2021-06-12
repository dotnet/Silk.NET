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
        [NativeName("Name", "XR_REPROJECTION_MODE_DEPTH_MSFT")]
        ReprojectionModeDepthMsft = 1,
        [NativeName("Name", "XR_REPROJECTION_MODE_PLANAR_FROM_DEPTH_MSFT")]
        ReprojectionModePlanarFromDepthMsft = 2,
        [NativeName("Name", "XR_REPROJECTION_MODE_PLANAR_MANUAL_MSFT")]
        ReprojectionModePlanarManualMsft = 3,
        [NativeName("Name", "XR_REPROJECTION_MODE_ORIENTATION_ONLY_MSFT")]
        ReprojectionModeOrientationOnlyMsft = 4,
    }
}
