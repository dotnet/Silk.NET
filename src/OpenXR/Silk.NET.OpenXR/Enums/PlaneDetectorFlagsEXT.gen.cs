// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrPlaneDetectorFlagsEXT")]
    public enum PlaneDetectorFlagsEXT : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"EnableContourBitExt\"")]
        [NativeName("Name", "XR_PLANE_DETECTOR_ENABLE_CONTOUR_BIT_EXT")]
        PlaneDetectorEnableContourBitExt = 1,
        [NativeName("Name", "XR_PLANE_DETECTOR_ENABLE_CONTOUR_BIT_EXT")]
        EnableContourBitExt = 1,
    }
}
