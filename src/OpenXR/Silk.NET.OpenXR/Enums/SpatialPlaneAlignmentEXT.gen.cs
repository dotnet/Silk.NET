// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpatialPlaneAlignmentEXT")]
    public enum SpatialPlaneAlignmentEXT : int
    {
        [Obsolete("Deprecated in favour of \"HorizontalUpwardExt\"")]
        [NativeName("Name", "XR_SPATIAL_PLANE_ALIGNMENT_HORIZONTAL_UPWARD_EXT")]
        SpatialPlaneAlignmentHorizontalUpwardExt = 0,
        [Obsolete("Deprecated in favour of \"HorizontalDownwardExt\"")]
        [NativeName("Name", "XR_SPATIAL_PLANE_ALIGNMENT_HORIZONTAL_DOWNWARD_EXT")]
        SpatialPlaneAlignmentHorizontalDownwardExt = 1,
        [Obsolete("Deprecated in favour of \"VerticalExt\"")]
        [NativeName("Name", "XR_SPATIAL_PLANE_ALIGNMENT_VERTICAL_EXT")]
        SpatialPlaneAlignmentVerticalExt = 2,
        [Obsolete("Deprecated in favour of \"ArbitraryExt\"")]
        [NativeName("Name", "XR_SPATIAL_PLANE_ALIGNMENT_ARBITRARY_EXT")]
        SpatialPlaneAlignmentArbitraryExt = 3,
        [NativeName("Name", "XR_SPATIAL_PLANE_ALIGNMENT_HORIZONTAL_UPWARD_EXT")]
        HorizontalUpwardExt = 0,
        [NativeName("Name", "XR_SPATIAL_PLANE_ALIGNMENT_HORIZONTAL_DOWNWARD_EXT")]
        HorizontalDownwardExt = 1,
        [NativeName("Name", "XR_SPATIAL_PLANE_ALIGNMENT_VERTICAL_EXT")]
        VerticalExt = 2,
        [NativeName("Name", "XR_SPATIAL_PLANE_ALIGNMENT_ARBITRARY_EXT")]
        ArbitraryExt = 3,
    }
}
