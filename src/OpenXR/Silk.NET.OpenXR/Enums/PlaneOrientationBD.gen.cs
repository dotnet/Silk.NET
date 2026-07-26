// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPlaneOrientationBD")]
    public enum PlaneOrientationBD : int
    {
        [Obsolete("Deprecated in favour of \"HorizontalUpwardBD\"")]
        [NativeName("Name", "XR_PLANE_ORIENTATION_HORIZONTAL_UPWARD_BD")]
        PlaneOrientationHorizontalUpwardBD = 0,
        [Obsolete("Deprecated in favour of \"HorizontalDownwardBD\"")]
        [NativeName("Name", "XR_PLANE_ORIENTATION_HORIZONTAL_DOWNWARD_BD")]
        PlaneOrientationHorizontalDownwardBD = 1,
        [Obsolete("Deprecated in favour of \"VerticalBD\"")]
        [NativeName("Name", "XR_PLANE_ORIENTATION_VERTICAL_BD")]
        PlaneOrientationVerticalBD = 2,
        [Obsolete("Deprecated in favour of \"ArbitraryBD\"")]
        [NativeName("Name", "XR_PLANE_ORIENTATION_ARBITRARY_BD")]
        PlaneOrientationArbitraryBD = 3,
        [NativeName("Name", "XR_PLANE_ORIENTATION_HORIZONTAL_UPWARD_BD")]
        HorizontalUpwardBD = 0,
        [NativeName("Name", "XR_PLANE_ORIENTATION_HORIZONTAL_DOWNWARD_BD")]
        HorizontalDownwardBD = 1,
        [NativeName("Name", "XR_PLANE_ORIENTATION_VERTICAL_BD")]
        VerticalBD = 2,
        [NativeName("Name", "XR_PLANE_ORIENTATION_ARBITRARY_BD")]
        ArbitraryBD = 3,
    }
}
